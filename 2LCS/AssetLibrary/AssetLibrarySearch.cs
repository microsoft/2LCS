using AutoMapper;
using CsvHelper;
using LCS.JsonObjects;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LCS.AssetLibrary;

public partial class AssetLibrarySearch : Form
{
    private HttpClientHelper _httpClientHelper;

    internal AssetLibrarySearch(HttpClientHelper httpClientHelper)
    {
        InitializeComponent();
        _httpClientHelper = httpClientHelper;
    }

    private void AssetLibrarySearch_Load(object sender, EventArgs e)
    {
        assetsCreatedAfter.Value = DateTime.Now.AddMonths(-6);
        assetsCreatedBefore.Value = DateTime.Now;
    }

    private void search_Click(object sender, EventArgs e)
    {
        Cursor.Current = Cursors.WaitCursor;

        var assets = _httpClientHelper.GetSharedAssetList(AssetFileType.NuGetPackage);

        var assetVersionsForExportList = new List<AssetVersionForExport>();

        var config = new MapperConfiguration(
            cfg => cfg.CreateMap<AssetVersion, AssetVersionForExport>());
        var mapper = config.CreateMapper();

        // linear with progress, only assets in date range
        assetExportProgress.Maximum = assets.Count;
        assetExportProgress.Value = 0;
        foreach (var asset in assets)
        {
            assetExportProgress.Value++;
            assetExportProgressNumberOfMax.Text = $"{assetExportProgress.Value} of {assetExportProgress.Maximum}";
            assetExportProgressAssetName.Text = asset.Name;
            var assetVersions = _httpClientHelper.GetSharedAssetVersionList(asset.ParentAssetId)
                .Where(assetVersion => assetVersion.CreatedDate >= assetsCreatedAfter.Value
                                    && assetVersion.CreatedDate <= assetsCreatedBefore.Value);
            if (assetVersions.Any() == false)
            {
                break;
            }
            assetVersionsForExportList.AddRange(assetVersions
                .Select(assetVersion =>
                {
                    var fileDescription = assetVersion.FileDescription.Split('\n').Last();
                    assetVersion.ApplicationOrPlatformVersion = fileDescription;
                    return mapper.Map<AssetVersionForExport>(assetVersion);
                }));
;       }

        Cursor.Current = Cursors.Default;
        assetExportProgress.Value = 0;
        assetExportProgressNumberOfMax.Text = string.Empty;
        assetExportProgressAssetName.Text = string.Empty;

        SaveFileDialog saveFile = new()
        {
            FileName = "D365FO NuGet Packages.csv",
            Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*"
        };

        if (saveFile.ShowDialog() == DialogResult.OK)
        {
            try
            {
                using StreamWriter sw = new(saveFile.FileName, false, Encoding.Unicode);
                var csv = new CsvWriter(sw, CultureInfo.CurrentCulture);
                csv.WriteRecords(assetVersionsForExportList);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

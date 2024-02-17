using System;

namespace LCS.AssetLibrary;

public class AssetVersionForExport
{
    public string ApplicationOrPlatformVersion { get; set; }

    public string Name { get; set; }
    public string Id { get; set; }
    public string FileName { get; set; }
    public string DisplayVersion { get; set; }
    public int FileType { get; set; }
    public string CreatedByName { get; set; }
    public string ModifiedByName { get; set; }
    public string ReleaseDetailsAssetId { get; set; }
    public string ReleaseDetailsLink { get; set; }
    public string ParentAssetId { get; set; }
    public bool IsInvalid { get; set; }
    public string Description { get; set; }
    public string Location { get; set; }
    public int CreatedBy { get; set; }
    public DateTime CreatedDate { get; set; }
    public int ModifiedBy { get; set; }
    public DateTime ModifiedDate { get; set; }
}

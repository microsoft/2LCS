using LCS.JsonObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace LCS.AssetLibrary;

internal static class HttpClientHelperAssetLibraryExtension
{
    internal static string GetGetSharedAssetsUrl(
        this HttpClientHelper httpClientHelper,
        AssetFileType assetFileType)
    {
        return $"{httpClientHelper.LcsUrl}/FileAsset/GetSharedAssets/?assetKind={((int)assetFileType)}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}";
    }

    internal static string GetGetFileAssetVersionsUrl(
        this HttpClientHelper httpClientHelper)
    {
        return $"{httpClientHelper.LcsUrl}/FileAsset/GetFileAssetVersions";
    }

    internal static List<Asset> GetSharedAssetList(
        this HttpClientHelper httpClientHelper,
        AssetFileType assetFileType)
    {
        var assetList = new List<Asset>();

        var url = httpClientHelper.GetGetSharedAssetsUrl(assetFileType);
        var result = httpClientHelper.GetHttpClient().GetAsync(url).Result;
        result.EnsureSuccessStatusCode();

        var responseBody = result.Content.ReadAsStringAsync().Result;
        var response = JsonConvert.DeserializeObject<Response>(responseBody);
        if (response.Success 
            && response.Data != null
            && response.Data is JToken responseData)
        {
            var assetData = responseData[0].ToObject<AssetData>();
            assetList = assetData.Assets;
        }

        return assetList;
    }

    internal static List<AssetVersion> GetSharedAssetVersionList(
        this HttpClientHelper httpClientHelper,
        string parentFileAssetId)
    {
        var assetVersionList = new List<AssetVersion>();

        var url = httpClientHelper.GetGetFileAssetVersionsUrl();
        var stringContent = new StringContent(
            $"parentFileAssetId={parentFileAssetId}",
            Encoding.UTF8,
            "application/x-www-form-urlencoded");
        httpClientHelper.SetRequestVerificationToken($"{httpClientHelper.LcsUrl}/V2");
        var result = httpClientHelper.GetHttpClient().PostAsync(url, stringContent).Result;
        result.EnsureSuccessStatusCode();
    
        var responseBody = result.Content.ReadAsStringAsync().Result;
        var response = JsonConvert.DeserializeObject<Response>(responseBody);
        if (response.Success 
            && response.Data != null
            && response.Data is JToken responseData)
        {
            assetVersionList = responseData.ToObject<List<AssetVersion>>();
        }

        return assetVersionList;
    }
}

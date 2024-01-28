using LCS.JsonObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;

namespace LCS.AssetLibrary;

internal static class HttpClientHelperAssetLibraryExtension
{
    internal static string GetGetSharedAssetsUrl(this HttpClientHelper httpClientHelper,
        AssetFileType assetFileType)
    {
        return $"{httpClientHelper.LcsUrl}/FileAsset/GetSharedAssets/?assetKind={((int)assetFileType)}&_={DateTimeOffset.Now.ToUnixTimeSeconds()}";
    }

    internal static List<Asset> GetSharedAssetList(this HttpClientHelper httpClientHelper,
        AssetFileType assetFileType)
    {
        var assetList = new List<Asset>();

        var url = httpClientHelper.GetGetSharedAssetsUrl(assetFileType);
        var result = httpClientHelper.GetHttpClient().GetAsync(url).Result;
        result.EnsureSuccessStatusCode();

        var responseBody = result.Content.ReadAsStringAsync().Result;
        var response = JsonConvert.DeserializeObject<Response>(responseBody);
        if (response.Success && response.Data != null)
        {
            var responseData = response.Data as JToken;
            if (responseData != null)
            {
                var assetData = responseData[0].ToObject<AssetData>();
                assetList = assetData.Assets;
            }
        }

        return assetList;
    }
}

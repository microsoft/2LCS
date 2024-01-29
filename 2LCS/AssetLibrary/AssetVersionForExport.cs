namespace LCS.AssetLibrary;

public class AssetVersionForExport
{
    public string Id { get; set; }
    public string AssetName { get; set; }
    public string FileName { get; set; }
    public string FileDescription { get; set; }
    public string DisplaySize { get; set; }
    public int CommitStatus { get; set; }
    public int State { get; set; }
    public int Scope { get; set; }
    public string FileLocation { get; set; }
    public int Version { get; set; }
    public int FileType { get; set; }
    public string CreatedByName { get; set; }
    public string ModifiedByName { get; set; }
    public bool IsGoldBuild { get; set; }
    public string DataPackageApplicationDetails { get; set; }
    public int ValidationStatus { get; set; }
    public string AadTenantId { get; set; }
    public string ValidationStatusText { get; set; }
    public string NextValidationDate { get; set; }
    public int NumValidationAttempts { get; set; }
    public int NumTenantTaggingAttempts { get; set; }
    public string ReleaseDetailsAssetId { get; set; }
    public bool IsMockData { get; set; }
    public string ReleaseDetailsLink { get; set; }
    public string ParentAssetId { get; set; }
    public bool IsInvalid { get; set; }
    public string DisplayValidationSymbol { get; set; }
    public string DisplayModifiedDate { get; set; }
    public string DisplayCreatedDate { get; set; }
    public string DisplayId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string DisplayScope { get; set; }
    public string DisplayState { get; set; }
    public string Location { get; set; }
    public bool IsAbsoluteLocation { get; set; }
    public bool CanDelete { get; set; }
    public bool CanUpdate { get; set; }
    public bool CanPublish { get; set; }
    public bool CanNavigate { get; set; }
    public string DisplayVersion { get; set; }
    public int OriginalScope { get; set; }
    public string TelemetryId { get; set; }
    public int CreatedBy { get; set; }
    public string CreatedDate { get; set; }
    public int ModifiedBy { get; set; }
    public string ModifiedDate { get; set; }
    public string LocalCreatedDate { get; set; }
    public string LocalModifiedDate { get; set; }
}

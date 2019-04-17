using System;
using System.Collections.Generic;

namespace LCS.JsonObjects
{
    public class ProjectInstance
    {
        public int LcsProjectId { get; set; }
        public List<CloudHostedInstance> CheInstances { get; set; }
        public List<CloudHostedInstance> SaasInstances { get; set; }
    }

    public class CustomLink
    {
        public string LinkLabel { get; set; }
        public string Link { get; set; }
    }

    public class CloudHostedInstance
    {
        public object[] JITOptions { get; set; }
        public bool JITRequestAccessEnabledState { get; set; }
        public object JITRequestActivityId { get; set; }
        public bool JITRequestShowError { get; set; }
        public object JITWorkItemDetails { get; set; }
        public object JITExpireTimeRemaining { get; set; }
        public string AzureSubscriptionId { get; set; }
        public string TopologyId { get; set; }
        public string InstanceId { get; set; }
        public bool HasStagingEnvironment { get; set; }
        public object StagingEnvironmentId { get; set; }
        public string EnvironmentId { get; set; }
        public string CatalogName { get; set; }
        public string ConnectorName { get; set; }
        public string DisplayName { get; set; }
        public string TopologyName { get; set; }
        public string TopologyType { get; set; }
        public string[] CloudServiceNames { get; set; }
        public string CloudStorageLocation { get; set; }
        public string TopologyDescription { get; set; }
        public string ProductName { get; set; }
        public string TopologyDisplayName { get; set; }
        public string CurrentPlatformVersion { get; set; }
        public string CurrentPlatformReleaseName { get; set; }
        public string CurrentApplicationReleaseName { get; set; }
        public string ProductRegisteredName { get; set; }
        public string TopologyVersion { get; set; }
        public string DeploymentStatus { get; set; }
        public int InternalDeploymentStatus { get; set; }
        public int DeploymentState { get; set; }
        public int InternalDeploymentAction { get; set; }
        public string DeploymentAction { get; set; }
        public string DeploymentId { get; set; }
        public string ActivityId { get; set; }
        public int VirtualMachineCount { get; set; }
        public string DeployedBy { get; set; }
        public string EnvironmentAdmin { get; set; }
        public string BuildNumber { get; set; }
        public string BuildInfo { get; set; }
        public DateTime DeployedOn { get; set; }
        public string LicenseLink { get; set; }
        public bool CanStart { get; set; }
        public bool IsMaintainVisible { get; set; }
        public bool IsHistoryVisible { get; set; }
        public bool IsNotificationListVisible { get; set; }
        public bool CanStop { get; set; }
        public bool CanShowRdp { get; set; }
        public bool CanShowNavigationLinks { get; set; }
        public bool CanShowLoginButton { get; set; }
        public bool CanShowTrialLink { get; set; }
        public bool CanEdit { get; set; }
        public bool CanDeallocate { get; set; }
        public bool CanDelete { get; set; }
        public bool CanRestart { get; set; }
        public bool CanShowAzureConnector { get; set; }
        public bool IsInitialDeploymentState { get; set; }
        public object RdsWebAccessCertificate { get; set; }
        public object RdsWebAccessLink { get; set; }
        public bool IsDiagnosticsEnabledEnvironment { get; set; }
        public object RdsFarmAccessRdp { get; set; }
        public bool CanEnableDR { get; set; }
        public bool CanFailover { get; set; }
        public bool CanFailback { get; set; }
        public bool CanCleanup { get; set; }
        public object Location { get; set; }
        public int SaasEnvironmentType { get; set; }
        public int RefinedEnvironmentType { get; set; }
        public bool IsPublishedToD365 { get; set; }
        public Instance[] Instances { get; set; }
        public object ClientInstances { get; set; }
        public Credentials[] LocalCredentials { get; set; }
        public Credentials[] SqlAzureCredentials { get; set; }
        public Credentials[] ContosoCredentials { get; set; }
        public object Errors { get; set; }
        public object Warnings { get; set; }
        public object LogOnDetails { get; set; }
        public Navigationlink[] NavigationLinks { get; set; }
        public object ServiceIds { get; set; }
        public bool IsPinToD365Enabled { get; set; }
        public bool IsPinToD365Visible { get; set; }
        public string DisasterRecoveryLocation { get; set; }
        public string CloudStorageLocationLabel { get; set; }
        public string DisasterRecoveryLocationLabel { get; set; }
        public bool IsGuidelinesLinkVisible { get; set; }
        public bool IsARMTopology { get; set; }
        public bool ShowSslCertRotateWarning { get; set; }
    }

    public class Instance
    {
        public string ItemName { get; set; }
        public string DisplayName { get; set; }
        public string DeploymentStatus { get; set; }
        public string MachineName { get; set; }
        public string Location { get; set; }
        public string RDPConnectionDetails { get; set; }
        public Dictionary<string, string> Credentials { get; set; }
    }

    public class Credentials
    {
        public string DeploymentItemName { get; set; }
        public string InstanceName { get; set; }
        public string SymbolicName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string PasswordExpiryTime { get; set; }
        public bool IsCredentialKeyVaultUri { get; set; }
        public string CredentialInfoKey { get; set; }
    }

    public class Navigationlink
    {
        public string DisplayName { get; set; }
        public string NavigationUri { get; set; }
    }

    public class Response
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public string MessageTitle { get; set; }
        public object Data { get; set; }
        public object ErrorList { get; set; }
        public int ErrorCode { get; set; }
    }

    public class SaasDeploymentInstance
    {
        public string AzureSubscriptionId { get; set; }
        public string InstanceId { get; set; }
        public object CatalogName { get; set; }
        public bool IsTopologySignedOff { get; set; }
        public bool IsDiagnosticsEnabled { get; set; }
        public int ConnectorId { get; set; }
        public int DeploymentSkuId { get; set; }
        public string DeploymentSkuType { get; set; }
        public object TopologyId { get; set; }
        public string EnvironmentId { get; set; }
        public object TopologyName { get; set; }
        public object TopologyType { get; set; }
        public bool IsDeployed { get; set; }
        public object TopologyDisplayName { get; set; }
        public object BuildNumber { get; set; }
        public int TopologyVersion { get; set; }
        public bool IsHealthy { get; set; }
        public bool IsNotConfigured { get; set; }
        public bool IsAvailableForConfiguration { get; set; }
        public string DeploymentHealthSummary { get; set; }
        public bool ShowFullDetailsLink { get; set; }
        public bool EnableDeleteEnvironmentDashboardButton { get; set; }
        public bool EnableRefreshEnvironmentHealthStateButton { get; set; }
        public bool ShowLastUpdateReceivedDate { get; set; }
        public bool ShowReconfigureOption { get; set; }
        public bool IsTopologyLoadError { get; set; }
        public string DeploymentSkuName { get; set; }
        public int DisplayOrder { get; set; }
}

    public class SaasInstance
    {
        public string DeploymentSkuName { get; set; }
        public object TopologyName { get; set; }
        public int DisplayOrder { get; set; }
        public List<SaasDeploymentInstance> DeploymentInstances { get; set; }
    }

    public class RDPConnectionDetails
    {
        public string Address { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public string Machine { get; set; }
    }

    public class LcsProject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string OrganizationName { get; set; }
        public bool RequestPending { get; set; }
        public int SolutionRequestStatus { get; set; }
        public string CreatedByUserName { get; set; }
        public int ProjectTypeId { get; set; }
        public int ProductVersionId { get; set; }
        public int ProductId { get; set; }
        public bool RequestSentToAlternativeEmail { get; set; }
        public string RequestEmailInvited { get; set; }
        public bool Favorite { get; set; }
    }

    public class Hotfix
    {
        public int KBNumber { get; set; }
        public int BugNumber { get; set; }
        public string Title { get; set; }
        public string Problem { get; set; }
        public DateTime ReleasedDate { get; set; }
        public string Type { get; set; }
        public string Substatus { get; set; }
        public string Solution { get; set; }
        public object Area { get; set; }
        public string AXVersion { get; set; }
        public object HtmlAttributes { get; set; }
        public string SearchContext { get; set; }
        public string Countries { get; set; }
        public string Industries { get; set; }
        public string Modules { get; set; }
        public string ConfigKeys { get; set; }
        public string DeliverableType { get; set; }
        public string CUInfo { get; set; }
        public string DB { get; set; }
        public string FeatureReference { get; set; }
        public string PageType { get; set; }
        public string Url { get; set; }
    }

    public class ProjectsData
    {
        public int StartIndex { get; set; }
        public int PagingType { get; set; }
        public int TotalCount { get; set; }
        public List<LcsProject> Results { get; set; }
    }

    public class DynamicPaging
    {
        public int StartPosition { get; set; }
        public int ItemsRequested { get; set; }
    }

    public class ProjectsPaging
    {
        public DynamicPaging DynamicPaging { get; set; }
        public object Filtering { get; set; }
    }

    public class ExportedInstance
    {
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string Organization { get; set; }
        public string InstanceName { get; set; }
        public string EnvironmentId { get; set; }
        public string CurrentPlatformVersion { get; set; }
        public string CurrentPlatformReleaseName { get; set; }
        public string CurrentApplicationReleaseName { get; set; }
        public string BuildInfo { get; set; }
        public string TopologyType { get; set; }
        public string TopologyVersion { get; set; }
        public string TopologyName { get; set; }
        public string DeploymentStatus { get; set; }
        public string HostingType { get; set; }
    }
    public class BuildInfoTreeView
    {
        public string Id { get; set; }
        public string ParentId { get; set; }
        public string ModelName { get; set; }
        public DateTime InstalledDate { get; set; }
        public string Version { get; set; }
        public string ModuleName { get; set; }
        public string Layer { get; set; }
        public string InstallationInfoType { get; set; }
        public string Description { get; set; }
    }

    public class BuildInfoDetails
    {
        public List<BuildInfoTreeView> BuildInfoTreeView { get; set; }
        public string InstalledPlatformBuild { get; set; }
        public string BuildVersion { get; set; }
    }

    public class BuildInfoEnvironment
    {
        public string Label { get; set; }
        public int Value { get; set; }
    }

    public class PackagesData
    {
        public int StartIndex { get; set; }
        public int PagingType { get; set; }
        public int TotalCount { get; set; }
        public List<DeployablePackage> Results { get; set; }
    }

    public class DeployablePackage
    {
        public string Description { get; set; }
        public int FileAssetDisplayVersion { get; set; }
        public int LcsEnvironmentActionId { get; set; }
        public string LcsEnvironmentId { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string Name { get; set; }
        public string PackageId { get; set; }
        public string PackageType { get; set; }
        public string PlatformVersion { get; set; }
        public string Publisher { get; set; }
    }

    public class NSGRule
    {
        public DateTime Expiration { get; set; }
        public string IpOrCidr { get; set; }
        public string Name { get; set; }
        public string Service { get; set; }
    }

    public class NetworkSecurityGroup
    {
        public string Name { get; set; }
        public List<NSGRule> Rules { get; set; }
    }
}

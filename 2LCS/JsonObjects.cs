using System.Collections.Generic;

namespace LCS.JsonObjects
{
    public class BuildInfoDetails
    {
        public List<BuildInfoTreeView> BuildInfoTreeView { get; set; }
        public string BuildVersion { get; set; }
        public string InstalledPlatformBuild { get; set; }
    }

    public class BuildInfoEnvironment
    {
        public string Label { get; set; }
        public int Value { get; set; }
    }

    public class BuildInfoTreeView
    {
        public string Description { get; set; }
        public string Id { get; set; }
        public string InstallationInfoType { get; set; }
        public string InstalledDate { get; set; }//Todo
        public string Layer { get; set; }
        public string ModelName { get; set; }
        public string ModuleName { get; set; }
        public string ParentId { get; set; }
        public string Version { get; set; }
    }

    public class CloudHostedInstance
    {
        public string ActivityId { get; set; }
        public string AzureSubscriptionId { get; set; }
        public string BuildInfo { get; set; }
        public string BuildNumber { get; set; }
        public bool CanApplyUpdatesToUpgradeEnvironment { get; set; }
        public bool CanCleanup { get; set; }
        public bool CanDeallocate { get; set; }
        public bool CanDelete { get; set; }
        public bool CanDseCreateStaging { get; set; }
        public bool CanEdit { get; set; }
        public bool CanEnableDR { get; set; }
        public bool CanFailback { get; set; }
        public bool CanFailover { get; set; }
        public bool CanMarkUpgradeComplete { get; set; }
        public bool CanRestart { get; set; }
        public bool CanRollbackUpgradeEnvironment { get; set; }
        public bool CanShowAzureConnector { get; set; }
        public bool CanShowLoginButton { get; set; }
        public bool CanShowNavigationLinks { get; set; }
        public bool CanShowRdp { get; set; }
        public bool CanShowTrialLink { get; set; }
        public bool CanStart { get; set; }
        public bool CanStop { get; set; }
        public bool CanUpgradeEnvironmentDatabase { get; set; }
        public string CatalogName { get; set; }
        public object ClientInstances { get; set; }
        public string[] CloudServiceNames { get; set; }
        public string CloudStorageLocation { get; set; }
        public string CloudStorageLocationLabel { get; set; }
        public string ConnectorId { get; set; }
        public string ConnectorName { get; set; }
        public Credentials[] ContosoCredentials { get; set; }
        public string CurrentApplicationBuildVersion { get; set; }
        public string CurrentApplicationReleaseName { get; set; }
        public string CurrentPlatformReleaseName { get; set; }
        public string CurrentPlatformVersion { get; set; }
        public string DeployedBy { get; set; }
        public string DeployedOn { get; set; }//Todo
        public string DeploymentAction { get; set; }
        public int DeploymentErrorCode { get; set; }
        public string DeploymentId { get; set; }
        public DeploymentState DeploymentState { get; set; }
        public string DeploymentStatus { get; set; }
        public string DevTestEnvironmentType { get; set; }
        public string DisasterRecoveryLocation { get; set; }
        public string DisasterRecoveryLocationLabel { get; set; }
        public string DisplayName { get; set; }
        public string EnvironmentAdmin { get; set; }
        public object EnvironmentCDSDetails { get; set; }
        public string EnvironmentId { get; set; }
        public string EnvironmentName { get; set; }
        public object Errors { get; set; }
        public bool HasStagingEnvironment { get; set; }
        public string InstanceId { get; set; }
        public Instance[] Instances { get; set; }
        public DeploymentAction InternalDeploymentAction { get; set; }
        public DeploymentStatus InternalDeploymentStatus { get; set; }
        public bool IsARMTopology { get; set; }
        public bool IsDiagnosticsEnabledEnvironment { get; set; }
        public bool IsEnableMaintenanceMode { get; set; }
        public bool IsGuidelinesLinkVisible { get; set; }
        public bool IsHistoryVisible { get; set; }
        public bool IsInitialDeploymentState { get; set; }
        public bool IsMaintainVisible { get; set; }
        public bool IsManualUpgradeInProgress { get; set; }
        public bool IsNotificationListVisible { get; set; }
        public bool IsPinToD365Enabled { get; set; }
        public bool IsPinToD365Visible { get; set; }
        public bool IsPreparationFailed { get; set; }
        public bool IsPublishedToD365 { get; set; }
        public bool IsStagingDeploymentFailed { get; set; }
        public bool IsStagingDeploymentSucceeded { get; set; }
        public bool IsUpgradeSelfServeCancelledOrCompleted { get; set; }
        public bool IsUpgradeSelfServeInProgress { get; set; }
        public bool IsUpgradeTimeExpired { get; set; }
        public object JITExpireTimeRemaining { get; set; }
        public JITOptions[] JITOptions { get; set; }
        public bool JITRequestAccessEnabledState { get; set; }
        public object JITRequestActivityId { get; set; }
        public bool JITRequestShowError { get; set; }
        public object JITWorkItemDetails { get; set; }
        public string LicenseLink { get; set; }
        public Credentials[] LocalCredentials { get; set; }
        public object Location { get; set; }
        public object LogOnDetails { get; set; }
        public Navigationlink[] NavigationLinks { get; set; }
        public string ProductName { get; set; }
        public string ProductRegisteredName { get; set; }
        public object RdsFarmAccessRdp { get; set; }
        public object RdsWebAccessCertificate { get; set; }
        public object RdsWebAccessLink { get; set; }
        public RefinedEnvironmentType RefinedEnvironmentType { get; set; }
        public string ResourceGroupName { get; set; }
        public SaasEnvironmentType SaasEnvironmentType { get; set; }
        public object ServiceIds { get; set; }
        public bool ShowRetailComponents { get; set; }
        public bool ShowSslCertRotateWarning { get; set; }
        public bool ShowUpgradeEnvironmentDetails { get; set; }
        public Credentials[] SqlAzureCredentials { get; set; }
        public string StagingActivityId { get; set; }
        public string StagingDeployedBy { get; set; }
        public string StagingDeployedOn { get; set; }//Todo
        public string StagingEnvironmentAdministrator { get; set; }
        public string StagingEnvironmentId { get; set; }
        public string StagingPrimaryRegion { get; set; }
        public string StagingSecondaryRegion { get; set; }
        public string StagingTargetVersion { get; set; }
        public string TimeForUpgradeText { get; set; }
        public string TopologyDescription { get; set; }
        public string TopologyDisplayName { get; set; }
        public string TopologyId { get; set; }
        public string TopologyName { get; set; }
        public string TopologyType { get; set; }
        public string TopologyVersion { get; set; }
        public UpgradeEnvironmentStatus UpgradeEnvironmentStatus { get; set; }
        public int VirtualMachineCount { get; set; }
        public object Warnings { get; set; }
    }

    public class Credentials
    {
        public string CredentialInfoKey { get; set; }
        public string DeploymentItemName { get; set; }
        public string InstanceName { get; set; }
        public bool IsCredentialKeyVaultUri { get; set; }
        public string Password { get; set; }
        public string PasswordExpiryTime { get; set; }
        public string SymbolicName { get; set; }
        public string UserName { get; set; }
    }

    public class CustomLink
    {
        public string Link { get; set; }
        public string LinkLabel { get; set; }
    }

    public class DeployablePackage
    {
        public string AppVersion { get; set; }
        public string Description { get; set; }
        public int FileAssetDisplayVersion { get; set; }
        public int LcsEnvironmentActionId { get; set; }
        public string LcsEnvironmentId { get; set; }
        public string ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }//Todo
        public string Name { get; set; }
        public string PackageId { get; set; }
        public string PackageType { get; set; }
        public string PlatformVersion { get; set; }
        public string Publisher { get; set; }
    }

    public class DynamicPaging
    {
        public int ItemsRequested { get; set; }
        public int StartPosition { get; set; }
    }

    public class ExportedInstance
    {
        public string BuildInfo { get; set; }
        public string CurrentApplicationBuildVersion { get; set; }
        public string CurrentApplicationReleaseName { get; set; }
        public string CurrentPlatformReleaseName { get; set; }
        public string CurrentPlatformVersion { get; set; }
        public string DeploymentStatus { get; set; }
        public string EnvironmentId { get; set; }
        public string HostingType { get; set; }
        public string InstanceName { get; set; }
        public string Organization { get; set; }
        public string ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string TopologyName { get; set; }
        public string TopologyType { get; set; }
        public string TopologyVersion { get; set; }
    }

    public class Hotfix
    {
        public object Area { get; set; }
        public string AXVersion { get; set; }
        public int BugNumber { get; set; }
        public string ConfigKeys { get; set; }
        public string Countries { get; set; }
        public string CUInfo { get; set; }
        public string DB { get; set; }
        public string DeliverableType { get; set; }
        public string FeatureReference { get; set; }
        public object HtmlAttributes { get; set; }
        public string Industries { get; set; }
        public int KBNumber { get; set; }
        public string Modules { get; set; }
        public string PageType { get; set; }
        public string Problem { get; set; }
        public string ReleasedDate { get; set; }//Todo
        public string SearchContext { get; set; }
        public string Solution { get; set; }
        public string Substatus { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }
    }

    public class Instance
    {
        public Dictionary<string, string> Credentials { get; set; }
        public string DeploymentStatus { get; set; }
        public string DisplayName { get; set; }
        public string ItemName { get; set; }
        public string Location { get; set; }
        public string MachineName { get; set; }
        public string RDPConnectionDetails { get; set; }
    }

    public class InvitedBy
    {
        public object ADOauthCode { get; set; }
        public string ADUserId { get; set; }
        public List<string> AllEmails { get; set; }
        public string AlternateEmails { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedDate { get; set; }//Todo
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public bool HasPscs { get; set; }
        public bool IsDefaultProfile { get; set; }
        public int LanguagePreference { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Organization Organization { get; set; }
        public string Puid { get; set; }
        public int Role { get; set; }
        public object RoleDisplayText { get; set; }
        public int UserId { get; set; }
        public int UserProfileId { get; set; }
    }

    public class LcsProject
    {
        public string CreatedByUserName { get; set; }
        public string Description { get; set; }
        public bool Favorite { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string OrganizationName { get; set; }
        public int ProductId { get; set; }
        public int ProductVersionId { get; set; }
        public ProjectType ProjectTypeId { get; set; }
        public string RequestEmailInvited { get; set; }
        public bool RequestPending { get; set; }
        public bool RequestSentToAlternativeEmail { get; set; }
        public string SharepointSite { get; set; }
        public int SolutionRequestStatus { get; set; }
        public string TfsProjectName { get; set; }
        public string TfsServerSite { get; set; }
    }

    public class Navigationlink
    {
        public string DisplayName { get; set; }
        public string NavigationUri { get; set; }
    }

    public class NetworkSecurityGroup
    {
        public string Name { get; set; }
        public List<NSGRule> Rules { get; set; }
    }

    public class NSGRule
    {
        public string Expiration { get; set; }//Todo
        public string IpOrCidr { get; set; }
        public string Name { get; set; }
        public string Service { get; set; }
    }

    public class Organization
    {
        public string ADTenantId { get; set; }
        public int ExternalId { get; set; }
        public bool IsTemporary { get; set; }
        public object LicenseSerialNumber { get; set; }
        public string Name { get; set; }
        public int OrgId { get; set; }
        public string TelemetryId { get; set; }
        public OrganizationType Type { get; set; }
    }

    public class PackagesData
    {
        public int PagingType { get; set; }
        public List<DeployablePackage> Results { get; set; }
        public int StartIndex { get; set; }
        public int TotalCount { get; set; }
    }

    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductVersion { get; set; }
        public string ProductVersionName { get; set; }
    }

    public class ProjectData
    {
        public UserCapabilities Capabilities { get; set; }
        public string CreatedDate { get; set; }//Todo
        public object CurrentPhase { get; set; }
        public int CurrentPhaseId { get; set; }
        public string Description { get; set; }
        public int Id { get; set; }
        public int IndustryId { get; set; }
        public string IndustryName { get; set; }
        public int MethodologyId { get; set; }
        public object MethodologyName { get; set; }
        public int MethodologyStatus { get; set; }
        public string Name { get; set; }
        public string OrganizationName { get; set; }
        public OrganizationType OrgType { get; set; }
        public Product Product { get; set; }
        public ProjectType ProjectTypeId { get; set; }
        public bool RequestPending { get; set; }
        public ProjectSettings Settings { get; set; }
    }

    public class ProjectInstance
    {
        public List<CloudHostedInstance> CheInstances { get; set; }
        public int LcsProjectId { get; set; }
        public List<CloudHostedInstance> SaasInstances { get; set; }
    }

    public class ProjectsData
    {
        public int PagingType { get; set; }
        public List<LcsProject> Results { get; set; }
        public int StartIndex { get; set; }
        public int TotalCount { get; set; }
    }

    public class ProjectSettings
    {
        public bool IsOnPremTfsEnabled { get; set; }
        public IssueStorage IssueStorageType { get; set; }
        public string SharepointSite { get; set; }
        public string TfsProjectId { get; set; }
        public string TfsProjectName { get; set; }
        public string TfsServerSite { get; set; }
    }

    public class PagingParameters
    {
        public DynamicPaging DynamicPaging { get; set; }
        public object Filtering { get; set; }
    }

    public class ProjectUser
    {
        public bool? AllowContactByMicrosoft { get; set; }
        public int? CreatedBy { get; set; }
        public string CreatedDate { get; set; }//Todo
        public int? FunctionalRole { get; set; }
        public string FunctionalRoleDisplayText { get; set; }
        public string InvitationEmail { get; set; }
        public int InvitationStatus { get; set; }
        public string InvitationStatusDisplayText { get; set; }
        public InvitedBy InvitedBy { get; set; }
        public bool IsOwner { get; set; }
        public string LocalCreatedDate { get; set; }
        public string LocalModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string ModifiedDate { get; set; }//Todo
        public int ProjectId { get; set; }
        public int ProjectUserId { get; set; }
        public string UserLastAccess { get; set; }//Todo
        public UserProfile UserProfile { get; set; }
        public int UserProfileId { get; set; }
        public int UserRole { get; set; }
        public string UserRoleDisplayText { get; set; }
        public object UserRoleTypeDisplayText { get; set; }
    }

    public class ProjectUsersData
    {
        public int PagingType { get; set; }
        public List<ProjectUser> Results { get; set; }
        public int StartIndex { get; set; }
        public int TotalCount { get; set; }
    }

    public class RDPConnectionDetails
    {
        public string Address { get; set; }
        public string Domain { get; set; }
        public string Machine { get; set; }
        public string Password { get; set; }
        public string Port { get; set; }
        public string Username { get; set; }
    }

    public class Response
    {
        public object Data { get; set; }
        public int ErrorCode { get; set; }
        public object ErrorList { get; set; }
        public string Message { get; set; }
        public string MessageTitle { get; set; }
        public bool Success { get; set; }
    }

    public class HostedDeploymentInstance
    {
        public string AzureSubscriptionId { get; set; }
        public object BuildNumber { get; set; }
        public object CatalogName { get; set; }
        public int ConnectorId { get; set; }
        public DeploymentEnvironmentType DeploymentEnvironmentType { get; set; }
        public string DeploymentHealthSummary { get; set; }
        public int DeploymentSkuId { get; set; }
        public string DeploymentSkuType { get; set; }
        public bool EnableDeleteEnvironmentDashboardButton { get; set; }
        public bool EnableRefreshEnvironmentHealthStateButton { get; set; }
        public string EnvironmentId { get; set; }
        public string InstanceId { get; set; }
        public bool IsAvailableForConfiguration { get; set; }
        public bool IsDeployed { get; set; }
        public bool IsDiagnosticsEnabled { get; set; }
        public bool IsFreeTier1Suppressed { get; set; }
        public bool IsHealthy { get; set; }
        public bool IsNotConfigured { get; set; }
        public bool IsTopologyLoadError { get; set; }
        public bool IsTopologySignedOff { get; set; }
        public bool ShowFullDetailsLink { get; set; }
        public bool ShowLastUpdateReceivedDate { get; set; }
        public bool ShowReconfigureOption { get; set; }
        public object TopologyDisplayName { get; set; }
        public object TopologyId { get; set; }
        public object TopologyName { get; set; }
        public object TopologyType { get; set; }
        public int TopologyVersion { get; set; }
    }

    public class HostedInstance
    {
        public List<HostedDeploymentInstance> DeploymentInstances { get; set; }
        public string DeploymentSkuName { get; set; }
        public int DisplayOrder { get; set; }
        public object TopologyName { get; set; }
    }

    public class UserCapabilities
    {
        public bool IsDriRole { get; set; }
        public bool IsDseRole { get; set; }
        public bool IsEnvironmentAdmin { get; set; }
        public bool IsNonMaintainUserRole { get; set; }
        public bool IsNonPrivilegedDseRole { get; set; }
        public bool IsPrivilegedDseRole { get; set; }
        public bool IsProjectOwner { get; set; }
        public int UserRole { get; set; }
        public string UserRoleDisplayText { get; set; }
    }

    public class UserProfile
    {
        public object ADOauthCode { get; set; }
        public string ADUserId { get; set; }
        public List<string> AllEmails { get; set; }
        public string AlternateEmails { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedDate { get; set; }//Todo
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public bool HasPscs { get; set; }
        public bool IsDefaultProfile { get; set; }
        public int LanguagePreference { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public Organization Organization { get; set; }
        public string Puid { get; set; }
        public int Role { get; set; }
        public object RoleDisplayText { get; set; }
        public int UserId { get; set; }
        public int UserProfileId { get; set; }
    }

    public class Plan
    {
        public string ServicePlanName { get; set; }
        public string ServicePlanId { get; set; }
        public string DisplayAssignedDate { get; set; }
        public string AssignedDateTime { get; set; }
        public int PrepaidUnitsEnabled { get; set; }
        public string PlanStatus { get; set; }
    }

    public class PlanData
    {
        public string TenantName { get; set; }
        public string TenantId { get; set; }
        public List<Plan> Plans { get; set; }
    }

    public class Datum
    {
        public string EnvironmentName { get; set; }
        public int StatusEnum { get; set; }
        public int EventNameEnum { get; set; }
        public int CalendarId { get; set; }
        public string UtcStartDateTime { get; set; }
        public string EnvironmentId { get; set; }
        public string Month { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int DownTime { get; set; }
        public string EventName { get; set; }
        public string Status { get; set; }
        public bool IsModified { get; set; }
        public int WorkflowInstanceId { get; set; }
    }

    public class JITOptions
    {
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class ServiceToRestart
    {
        public string Label { get; set; }
        public string Value { get; set; }
    }

    public class ServiceRestartResponseData
    {
        public string ActivityId { get; set; }
        public string ErrorCode { get; set; }
        public object errorList { get; set; }
        public bool isSuccessful { get; set; }
        public string Message { get; set; }
        public string MessageTitle { get; set; }
    }

    public class ActionDetails
    {
        public string ActionStatusText { get; set; }
        public string ActionType { get; set; }
        public int ActionTypeId { get; set; }
        public string CompletionDate { get; set; }
        public int Id { get; set; }
        public string Name { get; set; }
        public string PackageAssetId { get; set; }
        public string PackageType { get; set; }
        public int ServicingAction { get; set; }
        public string StartDate { get; set; }
        public LcsEnvironmentActionStatus Status { get; set; }
    }

    public class EnvironmentHistoryDetailsData
    {
        public int PagingType { get; set; }
        public List<ActionDetails> Results { get; set; }
        public int StartIndex { get; set; }
        public int TotalCount { get; set; }
    }

    public class ValidateSandboxServicingData
    {
        public string PlatformRelease { get; set; }
        public string ApplicationRelease { get; set; }
    }

}
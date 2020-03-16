namespace LCS
{

    public enum HotfixesType
    {
        Metadata = 8,
        PlatformBinary = 11,
        ApplicationBinary = 9,
        CriticalMetadata = 16
    }

    public enum LCSEnvironments
    {
        ALL = 0,
        CHE = 1,
        SAAS = 2
    }

    #region LCS enums
    public enum ProjectDocScope { Methodology = 0, Artifact = 1 }

    public enum WorkItemStatus { Inactive = 0, Active = 1, Closed = 2, Unknown = 3 }

    public enum WorkItemTaskStatus { Inactive = 0, Active = 1, Closed = 2, Locked = 3, Blocked = 4 }

    public enum WorkItemPhaseStatus { Inactive = 0, Active = 1, Closed = 2, Locked = 3 }

    public enum MethodologyScope { Global = 0, Organization = 1, Private = 2, Project = 3, Prospect = 4, Package = 5 }

    public enum TemplateState { Draft = 0, Published = 1, Deprecated = 2, Deleted = 3 }

    public enum SeverityEnum { Information = 0, Warning = 1, Error = 2 }

    public enum MethodologyResourceType { Link = 0, DocumentTemplate = 1 }

    public enum MilestoneStatus { Unfinished = 0, UnfinishedLate = 1, Finished = 2, FinishedEarly = 3 }

    public enum StatusMetadataType { None = 0, Dependency = 1, RuleEngine = 2 }

    public enum StatusLinkType { Internal = 0, Dialog = 1, External = 2 }

    public enum ConnectorSettingStatus { NotStarted = 0, InProgress = 1, Completed = 2 }

    public enum LcsEnvironmentServicingActionCategory { Servicing = 1, DataManagement = 2, SecretRotation = 3, EnvironmentUpgrade = 4, RollbackPackage = 5, OnPremServicing = 6, SqlCommand = 7 }

    public enum EnvironmentActionCategoryType { None = 0, PureCategory = 1, ActionableCategory = 2 }

    public struct LcsRegion { public const string None = "None"; public const string UnitedStates = "UnitedStates"; public const string Europe = "Europe"; public const string Canada = "Canada"; public const string UnitedKingdom = "UnitedKingdom"; public const string China = "China"; public const string USGov = "USGov"; public const string Germany = "Germany"; public const string France = "France"; }

    public enum MethodologyPinScopes { None = 0, GettingStarted = 1, Task = 2, Phase = 4 }

    public enum PinInputType { External = 0, Parameters = 1 }

    public enum PinOutputType { Display = 0, External = 1 }

    public enum PinDisplayType { Tile = 0, TextOnly = 1, Link = 2, Custom = 3, Card = 4 }

    public enum ChecklistFileType { Model = 1, Configuration = 4, DeploymentFile = 5, ModelStore = 6, ModelDB = 7, BusinessDB = 8, DeployablePackage = 10, BrandingLogo = 14 }

    public enum ProjectSystemRoleType { None = 0, ProjectOwner = 1, Contributor = 2, ReadOnly = 3, ProjectContributor = 5, OperationsAdmin = 6, EnvironmentAdmin = 7, InternalSreUser = 8, InternalSupportUser = 9, InternalDriUser = 10, InternalSreTier1User = 11 }

    public enum ProjectUserStatus { Pending = 0, Declined = 1, Accepted = 2 }

    public enum OrgUserRoleType { None = 0, SystemAdmin = 1, Admin = 2, Contributor = 3, Prospect = 4, DelegatedAdmin = 5, SupportAdmin = 6, OpsAdmin = 7, DriAdmin = 8, SreTier1Admin = 9 }

    public enum OrganizationType { None = 0, Partner = 1, Customer = 2, Prospect = 3, Employee = 4 }

    public enum IssueStorage { None = 0, Legacy = 1, Tfs = 2 }

    public enum ProductVersionId { None = 0, AX2012Rtm = 4, AX2012R2 = 5, AX2012FP = 6, AX2012R3 = 7, Nav2009 = 8, Nav2009R2 = 9, Nav2013 = 10, Nav2013R2 = 11, AX7 = 12, Crm2015 = 13, Nav2015 = 14, Nav2016 = 15, Dynamics365ForRetail = 18, Dynamics365Talent = 19, Crm2016 = 20, Nav2018 = 21, NavSaaS = 22, CRM = 23 }

    public enum Industry { None = 0, Other = 1, Retail = 2, Manufacturing = 3, Distribution = 4, Services = 5, PublicSector = 6 }

    public enum Product { None = 0, AX2012 = 2, Nav = 3, AX7 = 4, Crm = 5, Dynamics365ForRetail = 6, Dynamics365Talent = 7 }

    public enum TileEnum { None = 0, AllProjects = 4, NewProject = 5, ProjectRequests = 6, UserRequests = 7, Users = 8, Messages = 9, Announcements = 10, ProjectTeam = 13, IssuesTracking = 15, Documents = 17, ProjectMessages = 19, CodeAnalysisTool = 20, DiagnosticFramework = 21, ProjectRole = 23, Entitlement = 24, BusinessProcessModeler = 26, License = 27, UsageProfiler = 28, IssueSearch = 29, UpgradeService = 30, ProjectSettings = 31, ProjectHealth = 34, KeyWins = 37, Checkpoints = 38, RisksAndMitigations = 39, ApplicationModules = 40, CompletedCheckpoints = 41, MediumRisk = 42, LowRisk = 43, AllRisk = 44, Metering = 45, SupportIncident = 46, IsComService = 47, MSSupportIncident = 48, LcsBlog = 50, DeploymentPortal = 51, UpdateDownload = 52, ConfigurationManager = 53, InfraSizing = 54, DumpAnalysis = 55, OperationalInsight = 56, AX7CodeUpgrade = 57, TranslationService = 58, CRMInfraSizing = 59, ConfigurationAndDataManager = 60, AX7InfraSizing = 61, TotalEconomicImpactEstimatorForAX7 = 62, SubscriptionEstimator = 63, Dynamics365Talent = 64, AlertService = 65, MigrationAdminTemplate = 66, PerfbotAnalysis = 69, ImpactAnalysisReport = 71 }

    public enum ProjectType { None = 0, NotUsed1 = 1, NotUsed2 = 2, NotUsed3 = 3, NotUsed4 = 4, NotUsed5 = 5, Learn = 6, PreSales = 7, Implementation = 8, Partner = 9, OnPremImplementation = 10, ServiceFabricImplementation = 11 }

    public enum ProjectSettingsTab { None = 0, ProjectOverview = 1, ProjectOwnership = 2, LegacySharePoint = 3, VSOnline = 4, AzureConnectors = 5, OneDriveSettings = 6, OnPremiseConnector = 7, UpdateSettings = 8, UpdateSettingsForRing3 = 9, OnPremTFS = 10 }

    public enum SolutionRequestStatus { None = 0, Pending = 1, Approved = 2, Rejected = 3, InReview = 4 }

    public enum SolutionProvisioningState { None = 0, Blocked = 1, ProvisioningPending = 2, ProvisioningReady = 3, ProvisionComplete = 4 }

    public enum DeploymentConnectorCategory { None = 0, Default = 1, Microsoft = 2 }

    public enum SolutionAccess { None = 0, Reference = 1 }

    public enum SolutionLicenseType { None = 0, LicenseLink = 1, LicenseDocument = 2, PrivacyPolicy = 3 }

    public enum CustomizationGroupCategory { Default = 0, Summary = 1, CustomerSignoff = 2, DseSignoff = 3, CommonDataService = 4 }

    public enum AX7PartnerOption { None = 0, PartnerProject = 1, CustomerPresalesExperience = 2, Implementation = 3, OnPremImplementation = 4 }

    public enum DeploymentStatus { Undefined = 0, Succeeded = 1, Failed = 2, Canceled = 3, StateTransitionIncomplete = 4 }

    public enum DeploymentState { Undefined = 0, Active = 1, Paused = 2, Finished = 3, Starting = 4, Stopping = 5, Stopped = 6, Deleting = 7, Deallocating = 8, Deallocated = 9, Deleted = 10, Servicing = 11, Recovering = 12, SafeMode = 13, Restoring = 14, Swapping = 15, SwapRollingBack = 16, RotatingSecrets = 17, CommitingSwap = 18, Swapped = 19, ServicingRollback = 20, DatabaseRestoreRollback = 21, Migrating = 22, RestartingServices = 23, DatabaseNeedsUpgrade = 24, ValidatingDataUpgrade = 25, ExecutingSQLCommand = 26, ExecutingGenevaAction = 27, MigratingToSF = 28, MigratedToSF = 29, CDSConfiguring = 30, ScalingOut = 31, InfrastructureMaintenance = 32, PreparingForMigration = 33, PreppedForMigration = 34, ConfiguringFirewallRules = 35 }

    public enum LocalAgentEnums_DeploymentStatus { None = 0, Warning = 1, Failed = 2, StateTransitionIncomplete = 3 }

    public enum LocalAgentEnums_DeploymentState { Undefined = 0, Active = 1, Deploying = 2, Deleting = 3, Inactive = 5, Preparing = 6, Downloading = 7, Prepared = 8 }

    public enum DeploymentAction { Undefined = 0, Deploy = 1, Start = 2, Stop = 3, Update = 4, ScaleOut = 5, Configure = 6, Delete = 7, Restart = 8, Service = 9, PreService = 10, PostService = 11, MoveVMToMaintenancePool = 12, MoveVMToLivePool = 13, MarkStepComplete = 14, Rollback = 15, Abort = 16, Failover = 17, DeployDisasterRecovery = 18, RestoreDatabaseFromSourceToTargetServer = 19, Failback = 20, CleanupFailoverResources = 21, Resume = 22, SwapStaging = 23, SwapRollback = 24, SwapCommit = 25, ExecutePowershellScript = 26, RotateSecrets = 27, CreateJITAccount = 28, UpdateNetworkSecurityGroup = 29, ImportDatabase = 30, DataUpgrade = 31, RestartService = 32, ValidateDataUpgrade = 33, ExecuteSQLCommand = 34, Redeploy = 35, DataMovement = 36, ExecuteGenevaAction = 37, DataUpgradeRollback = 38 }

    public enum EnvironmentGroup { Primary = 0, DisasterRecovery = 1, Staging = 2 }

    public enum SaasEnvironmentType { none = 0, prod = 1, sandbox = 2, devtest = 3 }

    public enum RefinedEnvironmentType { Unknown = 0, Production = 1, Sandbox = 2, Demo = 3, DevTestDev = 4, DevTestBuild = 5, DevTestDevAndBuild = 6, OnPremSandbox = 7, OnPremProduction = 8, HighAvailability = 9 }

    public enum LcsEnvironmentServiceRequestStatus { None = 0, Requested = 1, RequestDenied = 2, RequestCancelled = 3, RequestAccepted = 4, InProgress = 5, Failed = 6, Succeeded = 7, SignedOff = 8, Aborted = 9, SignedOffWithIssues = 10, Preparation = 11, PostFailureCleanup = 12, PostCompletionCleanup = 13, PostCancellationCleanup = 14, Reserved = 15, RollbackSignedOff = 16, RollbackSignedOffWithIssues = 17, RollbackSucceeded = 18, RollbackFailed = 19, ValidationFailed = 20, ValidationSuccessful = 21, ReadyForValidation = 22 }

    public enum ServicingWorkItemRequestType { None = 0, NewDeployment = 1, UpdateDeployment = 2, DbBackup = 3, DbUpgrade = 4, DbRefresh = 5, ProdPointInTimeDBRestore = 6, OtherType = 7, SandboxPointInTimeDBRestore = 8, EnvironmentUpgrade = 9, DbRefreshSandboxToProd = 10 }

    public enum Types { None = 0, VMPasswords = 1, SQLPasswords = 2, StorageAccountKey = 4, Certificates = 8, AADCertificate = 16, SSLCertificates = 32 }

    public enum DatabaseType { AX = 0, MR = 1 }

    public enum StepStatus { NotStarted = 1, InProgress = 2, Completed = 3, ManuallyCompleted = 4, Failed = 5, EnvironmentIssue = 6, MarkingStepAsComplete = 7, RerunningStep = 8, NotApplicable = 9 }

    public enum StepDetailsType { Servicing = 0, Rollback = 1, DataMovement = 2 }

    public enum LcsEnvironmentActionStatus { NotStarted = 0, InProgress = 1, Completed = 2, Failed = 3, Unknown = 4, SignedOff = 5, Aborted = 6, SignedOffWithIssues = 7, InProgressManually = 8, CompletedManually = 9, PreparationFailed = 10, PreparationSucceeded = 11, PreparingEnvironment = 12, RollbackInProgress = 13, RollbackCompleted = 14, RollbackFailed = 15, RollbackSignedOff = 16, RollbackAborted = 17, RollbackSignedOffWithIssues = 18, ValidationFailed = 19, ValidationSuccessful = 20, ReadyForValidation = 22, PostCompletionCleanup = 23, PostFailureCleanup = 24, PostCancellationCleanup = 25 }

    public enum DeploymentEnvironmentType { MicrosoftManagedIaas = 0, CustomerManagedIaas = 1, CustomerOnPrem = 2, MicrosoftManagedServiceFabric = 3 }

    public enum UpgradeEnvironmentStatus { None = 0, EnvironmentDeploymentStarted = 1, EnvironmentDeploymentSucceeded = 2, EnvironmentDeploymentFailed = 3, DeployablePackageInstallationStarted = 4, DeployablePackageInstallationSucceeded = 5, DeployablePackageInstallationFailed = 6, DeployablePackageRollbackStarted = 7, DeployablePackageRollbackSucceeded = 8, DeployablePackageRollbackFailed = 9, SwapInStarted = 10, SwapInSucceeded = 11, SwapInFailed = 12, DataUpgradeStarted = 13, DataUpgradeSucceeded = 14, DataUpgradeFailed = 15, DataUpgradeValidationStarted = 16, DataUpgradeValidationSucceeded = 17, DataUpgradeValidationFailed = 18, CustomerValidationStarted = 19, CustomerValidationSucceeded = 20, CustomerValidationFailed = 21, SwapOutStarted = 22, SwapOutSucceeded = 23, SwapOutFailed = 24, EnvironmentDeallocationStarted = 25, EnvironmentDeallocationSucceeded = 26, EnvironmentDeallocationFailed = 27, EnvironmentDeleteStarted = 28, EnvironmentDeleteSucceeded = 29, EnvironmentDeleteFailed = 30, PointInTimeRestoreStarted = 31, PointInTimeRestoreSucceeded = 32, PointInTimeRestoreFailed = 33, DataUpgradePackageRollbackStarted = 34, DataUpgradePackageRollbackSucceeded = 35, DataUpgradePackageRollbackFailed = 36 }

    public enum JITRequestAccessEnabledState { DisabledNoAccess = 0, Enabled = 1, DisabledAnotherOperationProcessing = 2, DisabledEnvironmentSwapState = 3, DisabledUnknown = 4 }

    public enum CrmOptoOlProvisionEnvironmentEleven { ProvisionCrm2011 = 0, RunValidationService = 1, BackUpCrm2011 = 2, ProvisionCrm2013 = 3, BackUpCrm2013 = 4, ProvisionCrm2015 = 5, BackUpCrm2015 = 6 }

    public enum CrmOptoOlProvisionEnvironmentThirteen { ProvisionCrm2013 = 0, RunValidationService = 1, BackUpCrm2013 = 2, ProvisionCrm2015 = 3, BackUpCrm2015 = 4 }

    public enum CrmOptoOlProvisionEnvironmentFifteen { ProvisionCrm2015 = 0, RunValidationService = 1, BackUpCrm2015 = 2 }

    public enum CRMOpToOlValidationRunStatus { Scheduled = 1, Running = 2, Completed = 3, PendingUpload = 4, Errored = 9 }

    public enum CrmOptoOlProvisionEnvironment { CRM2011 = 0, CRM2013 = 1, CRM2015 = 2, CRM2016 = 3, CRMV09 = 4 }

    public enum CrmDeploymentStatus { Undefined = 0, Succeded = 1, Failed = 2, Canceled = 3 }

    public enum CRMOpToOlValidationRunType { None = 0, UpgradeAssessment = 1, CodeConversion = 2, OrgHealthCheck = 3, FinalValidationCheck = 4, OnlineMigration = 5 }

    public enum CrmGetIdStatus { CrmVersion = 1, CrmStatus = 2 }

    public struct PauseReasons { public const string Other = "Other"; public const string Holidays = "Holidays"; public const string UpComingGoLive = "UpComingGoLive"; public const string PendingUpgrade = "PendingUpgrade"; public const string IssueDuringValidation = "IssueDuringValidation"; public const string PendingValidation = "PendingValidation"; public const string CustomizationConflict = "CustomizationConflict"; public const string IsvReadiness = "IsvReadiness"; }
    #endregion
}
namespace LCS
{
    public enum ProjectType
    {
        None = 0,
        Deprecated1 = 1,
        Deprecated2 = 2,
        Deprecated3 = 3,
        Deprecated4 = 4,
        Deprecated5 = 5,
        Learn = 6,
        Presales = 7,
        Implementation = 8,
        Partner = 9,
        OnPremImplementation = 10,
        ServiceFabricImplementation = 11
    }

    public enum HotfixesType
    {
        Metadata = 8,
        PlatformBinary = 11,
        ApplicationBinary = 9,
        CriticalMetadata = 16
    }

    public enum ProjectSystemRoleType
    {
        None = 0,
        ProjectOwner = 1,
        Contributor = 2,
        ReadOnly = 3,
        ProjectContributor = 5,
        OperationsAdmin = 6,
        EnvironmentAdmin = 7,
        InternalSreUser = 8,
        InternalSupportUser = 9,
        InternalDriUser = 10,
        InternalSreTier1User = 11
    }

    public enum ProjectUserStatus
    {
        Pending = 0,
        Declined = 1,
        Accepted = 2
    }

    public enum OrgUserRoleType
    {
        None = 0,
        SystemAdmin = 1,
        Admin = 2,
        Contributor = 3,
        Prospect = 4,
        DelegatedAdmin = 5,
        SupportAdmin = 6,
        OpsAdmin = 7,
        DriAdmin = 8,
        SreTier1Admin = 9
    }

    public enum OrganizationType
    {
        None = 0,
        Partner = 1,
        Customer = 2,
        Prospect = 3,
        Employee = 4
    }

    public enum DeploymentStatus 
    {
        Undefined = 0,
        Succeeded = 1,
        Failed = 2,
        Canceled = 3,
        StateTransitionIncomplete = 4
    }

    public enum DeploymentState
    {
        Undefined = 0,
        Active = 1,
        Paused = 2,
        Finished = 3,
        Starting = 4,
        Stopping = 5,
        Stopped = 6,
        Deleting = 7,
        Deallocating = 8,
        Deallocated = 9,
        Deleted = 10,
        Servicing = 11,
        Recovering = 12,
        SafeMode = 13,
        Restoring = 14,
        Swapping = 15,
        SwapRollingBack = 16,
        RotatingSecrets = 17,
        CommitingSwap = 18,
        Swapped = 19,
        ServicingRollback = 20,
        DatabaseRestoreRollback = 21,
        Migrating = 22,
        RestartingServices = 23,
        DatabaseNeedsUpgrade = 24,
        ValidatingDataUpgrade = 25,
        ExecutingSQLCommand = 26,
        ExecutingGenevaAction = 27,
        MigratingToSF = 28,
        MigratedToSF = 29,
        CDSConfiguring = 30,
        ScalingOut = 31,
        InfrastructureMaintenance = 32,
        PreparingForMigration = 33,
        PreppedForMigration = 34,
        ConfiguringFirewallRules = 35
    }

    public enum DeploymentAction
    {
        Undefined = 0,
        Deploy = 1,
        Start = 2,
        Stop = 3,
        Update = 4,
        ScaleOut = 5,
        Configure = 6,
        Delete = 7,
        Restart = 8,
        Service = 9,
        PreService = 10,
        PostService = 11,
        MoveVMToMaintenancePool = 12,
        MoveVMToLivePool = 13,
        MarkStepComplete = 14,
        Rollback = 15,
        Abort = 16,
        Failover = 17,
        DeployDisasterRecovery = 18,
        RestoreDatabaseFromSourceToTargetServer = 19,
        Failback = 20,
        CleanupFailoverResources = 21,
        Resume = 22,
        SwapStaging = 23,
        SwapRollback = 24,
        SwapCommit = 25,
        ExecutePowershellScript = 26,
        RotateSecrets = 27,
        CreateJITAccount = 28,
        UpdateNetworkSecurityGroup = 29,
        ImportDatabase = 30,
        DataUpgrade = 31,
        RestartService = 32,
        ValidateDataUpgrade = 33,
        ExecuteSQLCommand = 34,
        Redeploy = 35,
        DataMovement = 36,
        ExecuteGenevaAction = 37,
        DataUpgradeRollback = 38
    }

    public enum IssueStorage
    {
        None = 0,
        Legacy = 1,
        Tfs = 2
    }
    
    public enum SaasEnvironmentType
    {
        none = 0,
        prod = 1,
        sandbox = 2,
        devtest = 3
    }

    public enum RefinedEnvironmentType 
    {
        Unknown = 0,
        Production = 1,
        Sandbox = 2,
        Demo = 3,
        DevTestDev = 4,
        DevTestBuild = 5,
        DevTestDevAndBuild = 6,
        OnPremSandbox = 7,
        OnPremProduction = 8,
        HighAvailability = 9
    }

    public enum UpgradeEnvironmentStatus
    {
        None = 0,
        EnvironmentDeploymentStarted = 1,
        EnvironmentDeploymentSucceeded = 2,
        EnvironmentDeploymentFailed = 3,
        DeployablePackageInstallationStarted = 4,
        DeployablePackageInstallationSucceeded = 5,
        DeployablePackageInstallationFailed = 6,
        DeployablePackageRollbackStarted = 7,
        DeployablePackageRollbackSucceeded = 8,
        DeployablePackageRollbackFailed = 9,
        SwapInStarted = 10,
        SwapInSucceeded = 11,
        SwapInFailed = 12,
        DataUpgradeStarted = 13,
        DataUpgradeSucceeded = 14,
        DataUpgradeFailed = 15,
        DataUpgradeValidationStarted = 16,
        DataUpgradeValidationSucceeded = 17,
        DataUpgradeValidationFailed = 18,
        CustomerValidationStarted = 19,
        CustomerValidationSucceeded = 20,
        CustomerValidationFailed = 21,
        SwapOutStarted = 22,
        SwapOutSucceeded = 23,
        SwapOutFailed = 24,
        EnvironmentDeallocationStarted = 25,
        EnvironmentDeallocationSucceeded = 26,
        EnvironmentDeallocationFailed = 27,
        EnvironmentDeleteStarted = 28,
        EnvironmentDeleteSucceeded = 29,
        EnvironmentDeleteFailed = 30,
        PointInTimeRestoreStarted = 31,
        PointInTimeRestoreSucceeded = 32,
        PointInTimeRestoreFailed = 33,
        DataUpgradePackageRollbackStarted = 34,
        DataUpgradePackageRollbackSucceeded = 35,
        DataUpgradePackageRollbackFailed = 36
    }
}
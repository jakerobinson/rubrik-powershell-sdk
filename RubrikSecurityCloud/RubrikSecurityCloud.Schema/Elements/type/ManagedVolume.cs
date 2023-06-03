// ManagedVolume.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region ManagedVolume
 
    public class ManagedVolume: BaseType, CdmHierarchyObject, CdmHierarchySnappableNew, HierarchyObject
    {
        #region members

        //      C# -> ManagedVolumeApplicationTag? ApplicationTag
        // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
        [JsonProperty("applicationTag")]
        public ManagedVolumeApplicationTag? ApplicationTag { get; set; }

        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        [JsonProperty("authorizedOperations")]
        public List<Operation>? AuthorizedOperations { get; set; }

        //      C# -> ManagedVolumeType? ManagedVolumeType
        // GraphQL -> managedVolumeType: ManagedVolumeType! (enum)
        [JsonProperty("managedVolumeType")]
        public ManagedVolumeType? ManagedVolumeType { get; set; }

        //      C# -> MountState? MountState
        // GraphQL -> mountState: MountState (enum)
        [JsonProperty("mountState")]
        public MountState? MountState { get; set; }

        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        [JsonProperty("objectType")]
        public HierarchyObjectTypeEnum? ObjectType { get; set; }

        //      C# -> ManagedVolumeShareType? Protocol
        // GraphQL -> protocol: ManagedVolumeShareType! (enum)
        [JsonProperty("protocol")]
        public ManagedVolumeShareType? Protocol { get; set; }

        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        [JsonProperty("slaAssignment")]
        public SlaAssignmentTypeEnum? SlaAssignment { get; set; }

        //      C# -> ManagedVolumeState? State
        // GraphQL -> state: ManagedVolumeState! (enum)
        [JsonProperty("state")]
        public ManagedVolumeState? State { get; set; }

        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        [JsonProperty("configuredSlaDomain")]
        public SlaDomain? ConfiguredSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        [JsonProperty("effectiveRetentionSlaDomain")]
        public SlaDomain? EffectiveRetentionSlaDomain { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public SlaDomain? EffectiveSlaDomain { get; set; }

        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        [JsonProperty("pendingSla")]
        public SlaDomain? PendingSla { get; set; }

        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        [JsonProperty("replicatedObjects")]
        public List<CdmHierarchyObject>? ReplicatedObjects { get; set; }

        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        [JsonProperty("cdmId")]
        public System.String? CdmId { get; set; }

        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        [JsonProperty("cdmLink")]
        public System.String? CdmLink { get; set; }

        //      C# -> List<System.String>? ClientNamePatterns
        // GraphQL -> clientNamePatterns: [String!]! (scalar)
        [JsonProperty("clientNamePatterns")]
        public List<System.String>? ClientNamePatterns { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        [JsonProperty("isRelic")]
        public System.Boolean? IsRelic { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }

        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        [JsonProperty("numWorkloadDescendants")]
        public System.Int32? NumWorkloadDescendants { get; set; }

        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        [JsonProperty("onDemandSnapshotCount")]
        public System.Int32? OnDemandSnapshotCount { get; set; }

        //      C# -> System.Int64? PhysicalUsedSize
        // GraphQL -> physicalUsedSize: Long! (scalar)
        [JsonProperty("physicalUsedSize")]
        public System.Int64? PhysicalUsedSize { get; set; }

        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        [JsonProperty("protectionDate")]
        public DateTime? ProtectionDate { get; set; }

        //      C# -> System.Int64? ProvisionedSize
        // GraphQL -> provisionedSize: Long! (scalar)
        [JsonProperty("provisionedSize")]
        public System.Int64? ProvisionedSize { get; set; }

        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        [JsonProperty("replicatedObjectCount")]
        public System.Int32? ReplicatedObjectCount { get; set; }

        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        [JsonProperty("slaPauseStatus")]
        public System.Boolean? SlaPauseStatus { get; set; }

        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        [JsonProperty("subnet")]
        public System.String? Subnet { get; set; }

        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        [JsonProperty("allOrgs")]
        public List<Org>? AllOrgs { get; set; }

        //      C# -> ManagedVolumeSlaClientConfig? ClientConfig
        // GraphQL -> clientConfig: ManagedVolumeSlaClientConfig (type)
        [JsonProperty("clientConfig")]
        public ManagedVolumeSlaClientConfig? ClientConfig { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> ManagedVolumeDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: ManagedVolumeDescendantTypeConnection! (type)
        [JsonProperty("descendantConnection")]
        public ManagedVolumeDescendantTypeConnection? DescendantConnection { get; set; }

        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        [JsonProperty("effectiveSlaSourceObject")]
        public PathNode? EffectiveSlaSourceObject { get; set; }

        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost (type)
        [JsonProperty("host")]
        public PhysicalHost? Host { get; set; }

        //      C# -> ManagedVolumeHostDetail? HostDetail
        // GraphQL -> hostDetail: ManagedVolumeHostDetail (type)
        [JsonProperty("hostDetail")]
        public ManagedVolumeHostDetail? HostDetail { get; set; }

        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        [JsonProperty("latestUserNote")]
        public LatestUserNote? LatestUserNote { get; set; }

        //      C# -> ManagedVolumeMountConnection? LiveMounts
        // GraphQL -> liveMounts: ManagedVolumeMountConnection! (type)
        [JsonProperty("liveMounts")]
        public ManagedVolumeMountConnection? LiveMounts { get; set; }

        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        [JsonProperty("logicalPath")]
        public List<PathNode>? LogicalPath { get; set; }

        //      C# -> ManagedVolumeMount? MainMount
        // GraphQL -> mainMount: ManagedVolumeMount (type)
        [JsonProperty("mainMount")]
        public ManagedVolumeMount? MainMount { get; set; }

        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        [JsonProperty("missedSnapshotConnection")]
        public MissedSnapshotCommonConnection? MissedSnapshotConnection { get; set; }

        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        [JsonProperty("missedSnapshotGroupByConnection")]
        public MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection { get; set; }

        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        [JsonProperty("newestArchivedSnapshot")]
        public CdmSnapshot? NewestArchivedSnapshot { get; set; }

        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        [JsonProperty("newestReplicatedSnapshot")]
        public CdmSnapshot? NewestReplicatedSnapshot { get; set; }

        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        [JsonProperty("newestSnapshot")]
        public CdmSnapshot? NewestSnapshot { get; set; }

        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        [JsonProperty("oldestSnapshot")]
        public CdmSnapshot? OldestSnapshot { get; set; }

        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        [JsonProperty("pendingObjectDeletionStatus")]
        public PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus { get; set; }

        //      C# -> ManagedVolumePhysicalChildTypeConnection? PhysicalChildConnection
        // GraphQL -> physicalChildConnection: ManagedVolumePhysicalChildTypeConnection! (type)
        [JsonProperty("physicalChildConnection")]
        public ManagedVolumePhysicalChildTypeConnection? PhysicalChildConnection { get; set; }

        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        [JsonProperty("physicalPath")]
        public List<PathNode>? PhysicalPath { get; set; }

        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        [JsonProperty("primaryClusterLocation")]
        public DataLocation? PrimaryClusterLocation { get; set; }

        //      C# -> ManagedVolumeQueuedSnapshotGroupByConnection? QueuedSnapshotGroupBys
        // GraphQL -> queuedSnapshotGroupBys: ManagedVolumeQueuedSnapshotGroupByConnection (type)
        [JsonProperty("queuedSnapshotGroupBys")]
        public ManagedVolumeQueuedSnapshotGroupByConnection? QueuedSnapshotGroupBys { get; set; }

        //      C# -> ManagedVolumeQueuedSnapshotConnection? QueuedSnapshots
        // GraphQL -> queuedSnapshots: ManagedVolumeQueuedSnapshotConnection (type)
        [JsonProperty("queuedSnapshots")]
        public ManagedVolumeQueuedSnapshotConnection? QueuedSnapshots { get; set; }

        //      C# -> Snappable? ReportWorkload
        // GraphQL -> reportWorkload: Snappable (type)
        [JsonProperty("reportWorkload")]
        public Snappable? ReportWorkload { get; set; }

        //      C# -> ManagedVolumeSmbShare? SmbShare
        // GraphQL -> smbShare: ManagedVolumeSmbShare (type)
        [JsonProperty("smbShare")]
        public ManagedVolumeSmbShare? SmbShare { get; set; }

        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        [JsonProperty("snapshotConnection")]
        public CdmSnapshotConnection? SnapshotConnection { get; set; }

        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        [JsonProperty("snapshotDistribution")]
        public SnapshotDistribution? SnapshotDistribution { get; set; }

        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        [JsonProperty("snapshotGroupByConnection")]
        public CdmSnapshotGroupByConnection? SnapshotGroupByConnection { get; set; }

        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        [JsonProperty("snapshotGroupBySummary")]
        public CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary { get; set; }


        #endregion

    #region methods

    public ManagedVolume Set(
        ManagedVolumeApplicationTag? ApplicationTag = null,
        List<Operation>? AuthorizedOperations = null,
        ManagedVolumeType? ManagedVolumeType = null,
        MountState? MountState = null,
        HierarchyObjectTypeEnum? ObjectType = null,
        ManagedVolumeShareType? Protocol = null,
        SlaAssignmentTypeEnum? SlaAssignment = null,
        ManagedVolumeState? State = null,
        SlaDomain? ConfiguredSlaDomain = null,
        SlaDomain? EffectiveRetentionSlaDomain = null,
        SlaDomain? EffectiveSlaDomain = null,
        SlaDomain? PendingSla = null,
        List<CdmHierarchyObject>? ReplicatedObjects = null,
        System.String? CdmId = null,
        System.String? CdmLink = null,
        List<System.String>? ClientNamePatterns = null,
        System.String? Id = null,
        System.Boolean? IsRelic = null,
        System.String? Name = null,
        System.Int32? NumChannels = null,
        System.Int32? NumWorkloadDescendants = null,
        System.Int32? OnDemandSnapshotCount = null,
        System.Int64? PhysicalUsedSize = null,
        DateTime? ProtectionDate = null,
        System.Int64? ProvisionedSize = null,
        System.Int32? ReplicatedObjectCount = null,
        System.Boolean? SlaPauseStatus = null,
        System.String? Subnet = null,
        List<Org>? AllOrgs = null,
        ManagedVolumeSlaClientConfig? ClientConfig = null,
        Cluster? Cluster = null,
        ManagedVolumeDescendantTypeConnection? DescendantConnection = null,
        PathNode? EffectiveSlaSourceObject = null,
        PhysicalHost? Host = null,
        ManagedVolumeHostDetail? HostDetail = null,
        LatestUserNote? LatestUserNote = null,
        ManagedVolumeMountConnection? LiveMounts = null,
        List<PathNode>? LogicalPath = null,
        ManagedVolumeMount? MainMount = null,
        MissedSnapshotCommonConnection? MissedSnapshotConnection = null,
        MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection = null,
        CdmSnapshot? NewestArchivedSnapshot = null,
        CdmSnapshot? NewestReplicatedSnapshot = null,
        CdmSnapshot? NewestSnapshot = null,
        CdmSnapshot? OldestSnapshot = null,
        PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus = null,
        ManagedVolumePhysicalChildTypeConnection? PhysicalChildConnection = null,
        List<PathNode>? PhysicalPath = null,
        DataLocation? PrimaryClusterLocation = null,
        ManagedVolumeQueuedSnapshotGroupByConnection? QueuedSnapshotGroupBys = null,
        ManagedVolumeQueuedSnapshotConnection? QueuedSnapshots = null,
        Snappable? ReportWorkload = null,
        ManagedVolumeSmbShare? SmbShare = null,
        CdmSnapshotConnection? SnapshotConnection = null,
        SnapshotDistribution? SnapshotDistribution = null,
        CdmSnapshotGroupByConnection? SnapshotGroupByConnection = null,
        CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary = null
    ) 
    {
        if ( ApplicationTag != null ) {
            this.ApplicationTag = ApplicationTag;
        }
        if ( AuthorizedOperations != null ) {
            this.AuthorizedOperations = AuthorizedOperations;
        }
        if ( ManagedVolumeType != null ) {
            this.ManagedVolumeType = ManagedVolumeType;
        }
        if ( MountState != null ) {
            this.MountState = MountState;
        }
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( Protocol != null ) {
            this.Protocol = Protocol;
        }
        if ( SlaAssignment != null ) {
            this.SlaAssignment = SlaAssignment;
        }
        if ( State != null ) {
            this.State = State;
        }
        if ( ConfiguredSlaDomain != null ) {
            this.ConfiguredSlaDomain = ConfiguredSlaDomain;
        }
        if ( EffectiveRetentionSlaDomain != null ) {
            this.EffectiveRetentionSlaDomain = EffectiveRetentionSlaDomain;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( PendingSla != null ) {
            this.PendingSla = PendingSla;
        }
        if ( ReplicatedObjects != null ) {
            this.ReplicatedObjects = ReplicatedObjects;
        }
        if ( CdmId != null ) {
            this.CdmId = CdmId;
        }
        if ( CdmLink != null ) {
            this.CdmLink = CdmLink;
        }
        if ( ClientNamePatterns != null ) {
            this.ClientNamePatterns = ClientNamePatterns;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRelic != null ) {
            this.IsRelic = IsRelic;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( NumChannels != null ) {
            this.NumChannels = NumChannels;
        }
        if ( NumWorkloadDescendants != null ) {
            this.NumWorkloadDescendants = NumWorkloadDescendants;
        }
        if ( OnDemandSnapshotCount != null ) {
            this.OnDemandSnapshotCount = OnDemandSnapshotCount;
        }
        if ( PhysicalUsedSize != null ) {
            this.PhysicalUsedSize = PhysicalUsedSize;
        }
        if ( ProtectionDate != null ) {
            this.ProtectionDate = ProtectionDate;
        }
        if ( ProvisionedSize != null ) {
            this.ProvisionedSize = ProvisionedSize;
        }
        if ( ReplicatedObjectCount != null ) {
            this.ReplicatedObjectCount = ReplicatedObjectCount;
        }
        if ( SlaPauseStatus != null ) {
            this.SlaPauseStatus = SlaPauseStatus;
        }
        if ( Subnet != null ) {
            this.Subnet = Subnet;
        }
        if ( AllOrgs != null ) {
            this.AllOrgs = AllOrgs;
        }
        if ( ClientConfig != null ) {
            this.ClientConfig = ClientConfig;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( DescendantConnection != null ) {
            this.DescendantConnection = DescendantConnection;
        }
        if ( EffectiveSlaSourceObject != null ) {
            this.EffectiveSlaSourceObject = EffectiveSlaSourceObject;
        }
        if ( Host != null ) {
            this.Host = Host;
        }
        if ( HostDetail != null ) {
            this.HostDetail = HostDetail;
        }
        if ( LatestUserNote != null ) {
            this.LatestUserNote = LatestUserNote;
        }
        if ( LiveMounts != null ) {
            this.LiveMounts = LiveMounts;
        }
        if ( LogicalPath != null ) {
            this.LogicalPath = LogicalPath;
        }
        if ( MainMount != null ) {
            this.MainMount = MainMount;
        }
        if ( MissedSnapshotConnection != null ) {
            this.MissedSnapshotConnection = MissedSnapshotConnection;
        }
        if ( MissedSnapshotGroupByConnection != null ) {
            this.MissedSnapshotGroupByConnection = MissedSnapshotGroupByConnection;
        }
        if ( NewestArchivedSnapshot != null ) {
            this.NewestArchivedSnapshot = NewestArchivedSnapshot;
        }
        if ( NewestReplicatedSnapshot != null ) {
            this.NewestReplicatedSnapshot = NewestReplicatedSnapshot;
        }
        if ( NewestSnapshot != null ) {
            this.NewestSnapshot = NewestSnapshot;
        }
        if ( OldestSnapshot != null ) {
            this.OldestSnapshot = OldestSnapshot;
        }
        if ( PendingObjectDeletionStatus != null ) {
            this.PendingObjectDeletionStatus = PendingObjectDeletionStatus;
        }
        if ( PhysicalChildConnection != null ) {
            this.PhysicalChildConnection = PhysicalChildConnection;
        }
        if ( PhysicalPath != null ) {
            this.PhysicalPath = PhysicalPath;
        }
        if ( PrimaryClusterLocation != null ) {
            this.PrimaryClusterLocation = PrimaryClusterLocation;
        }
        if ( QueuedSnapshotGroupBys != null ) {
            this.QueuedSnapshotGroupBys = QueuedSnapshotGroupBys;
        }
        if ( QueuedSnapshots != null ) {
            this.QueuedSnapshots = QueuedSnapshots;
        }
        if ( ReportWorkload != null ) {
            this.ReportWorkload = ReportWorkload;
        }
        if ( SmbShare != null ) {
            this.SmbShare = SmbShare;
        }
        if ( SnapshotConnection != null ) {
            this.SnapshotConnection = SnapshotConnection;
        }
        if ( SnapshotDistribution != null ) {
            this.SnapshotDistribution = SnapshotDistribution;
        }
        if ( SnapshotGroupByConnection != null ) {
            this.SnapshotGroupByConnection = SnapshotGroupByConnection;
        }
        if ( SnapshotGroupBySummary != null ) {
            this.SnapshotGroupBySummary = SnapshotGroupBySummary;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> ManagedVolumeApplicationTag? ApplicationTag
        // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
        if (this.ApplicationTag != null) {
            s += ind + "applicationTag\n" ;
        }
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations != null) {
            s += ind + "authorizedOperations\n" ;
        }
        //      C# -> ManagedVolumeType? ManagedVolumeType
        // GraphQL -> managedVolumeType: ManagedVolumeType! (enum)
        if (this.ManagedVolumeType != null) {
            s += ind + "managedVolumeType\n" ;
        }
        //      C# -> MountState? MountState
        // GraphQL -> mountState: MountState (enum)
        if (this.MountState != null) {
            s += ind + "mountState\n" ;
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType != null) {
            s += ind + "objectType\n" ;
        }
        //      C# -> ManagedVolumeShareType? Protocol
        // GraphQL -> protocol: ManagedVolumeShareType! (enum)
        if (this.Protocol != null) {
            s += ind + "protocol\n" ;
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment != null) {
            s += ind + "slaAssignment\n" ;
        }
        //      C# -> ManagedVolumeState? State
        // GraphQL -> state: ManagedVolumeState! (enum)
        if (this.State != null) {
            s += ind + "state\n" ;
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain != null) {
            s += ind + "configuredSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.ConfiguredSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain != null) {
            s += ind + "effectiveRetentionSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveRetentionSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
            s += ind + "effectiveSlaDomain {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
            s += ind + "pendingSla {\n" +
                InterfaceHelper.MakeListFromComposite((BaseType)this.PendingSla).AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (this.ReplicatedObjects != null) {
            s += ind + "replicatedObjects {\n" +
                this.ReplicatedObjects.AsFieldSpec(indent+1) + ind + "}\n";
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId != null) {
            s += ind + "cdmId\n" ;
        }
        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        if (this.CdmLink != null) {
            s += ind + "cdmLink\n" ;
        }
        //      C# -> List<System.String>? ClientNamePatterns
        // GraphQL -> clientNamePatterns: [String!]! (scalar)
        if (this.ClientNamePatterns != null) {
            s += ind + "clientNamePatterns\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic != null) {
            s += ind + "isRelic\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (this.NumChannels != null) {
            s += ind + "numChannels\n" ;
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants != null) {
            s += ind + "numWorkloadDescendants\n" ;
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount != null) {
            s += ind + "onDemandSnapshotCount\n" ;
        }
        //      C# -> System.Int64? PhysicalUsedSize
        // GraphQL -> physicalUsedSize: Long! (scalar)
        if (this.PhysicalUsedSize != null) {
            s += ind + "physicalUsedSize\n" ;
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate != null) {
            s += ind + "protectionDate\n" ;
        }
        //      C# -> System.Int64? ProvisionedSize
        // GraphQL -> provisionedSize: Long! (scalar)
        if (this.ProvisionedSize != null) {
            s += ind + "provisionedSize\n" ;
        }
        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        if (this.ReplicatedObjectCount != null) {
            s += ind + "replicatedObjectCount\n" ;
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus != null) {
            s += ind + "slaPauseStatus\n" ;
        }
        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        if (this.Subnet != null) {
            s += ind + "subnet\n" ;
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs != null) {
            s += ind + "allOrgs {\n" + this.AllOrgs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeSlaClientConfig? ClientConfig
        // GraphQL -> clientConfig: ManagedVolumeSlaClientConfig (type)
        if (this.ClientConfig != null) {
            s += ind + "clientConfig {\n" + this.ClientConfig.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            s += ind + "cluster {\n" + this.Cluster.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: ManagedVolumeDescendantTypeConnection! (type)
        if (this.DescendantConnection != null) {
            s += ind + "descendantConnection {\n" + this.DescendantConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject != null) {
            s += ind + "effectiveSlaSourceObject {\n" + this.EffectiveSlaSourceObject.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost (type)
        if (this.Host != null) {
            s += ind + "host {\n" + this.Host.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeHostDetail? HostDetail
        // GraphQL -> hostDetail: ManagedVolumeHostDetail (type)
        if (this.HostDetail != null) {
            s += ind + "hostDetail {\n" + this.HostDetail.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote != null) {
            s += ind + "latestUserNote {\n" + this.LatestUserNote.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeMountConnection? LiveMounts
        // GraphQL -> liveMounts: ManagedVolumeMountConnection! (type)
        if (this.LiveMounts != null) {
            s += ind + "liveMounts {\n" + this.LiveMounts.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath != null) {
            s += ind + "logicalPath {\n" + this.LogicalPath.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeMount? MainMount
        // GraphQL -> mainMount: ManagedVolumeMount (type)
        if (this.MainMount != null) {
            s += ind + "mainMount {\n" + this.MainMount.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (this.MissedSnapshotConnection != null) {
            s += ind + "missedSnapshotConnection {\n" + this.MissedSnapshotConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (this.MissedSnapshotGroupByConnection != null) {
            s += ind + "missedSnapshotGroupByConnection {\n" + this.MissedSnapshotGroupByConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (this.NewestArchivedSnapshot != null) {
            s += ind + "newestArchivedSnapshot {\n" + this.NewestArchivedSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (this.NewestReplicatedSnapshot != null) {
            s += ind + "newestReplicatedSnapshot {\n" + this.NewestReplicatedSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (this.NewestSnapshot != null) {
            s += ind + "newestSnapshot {\n" + this.NewestSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (this.OldestSnapshot != null) {
            s += ind + "oldestSnapshot {\n" + this.OldestSnapshot.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (this.PendingObjectDeletionStatus != null) {
            s += ind + "pendingObjectDeletionStatus {\n" + this.PendingObjectDeletionStatus.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumePhysicalChildTypeConnection? PhysicalChildConnection
        // GraphQL -> physicalChildConnection: ManagedVolumePhysicalChildTypeConnection! (type)
        if (this.PhysicalChildConnection != null) {
            s += ind + "physicalChildConnection {\n" + this.PhysicalChildConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath != null) {
            s += ind + "physicalPath {\n" + this.PhysicalPath.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (this.PrimaryClusterLocation != null) {
            s += ind + "primaryClusterLocation {\n" + this.PrimaryClusterLocation.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeQueuedSnapshotGroupByConnection? QueuedSnapshotGroupBys
        // GraphQL -> queuedSnapshotGroupBys: ManagedVolumeQueuedSnapshotGroupByConnection (type)
        if (this.QueuedSnapshotGroupBys != null) {
            s += ind + "queuedSnapshotGroupBys {\n" + this.QueuedSnapshotGroupBys.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeQueuedSnapshotConnection? QueuedSnapshots
        // GraphQL -> queuedSnapshots: ManagedVolumeQueuedSnapshotConnection (type)
        if (this.QueuedSnapshots != null) {
            s += ind + "queuedSnapshots {\n" + this.QueuedSnapshots.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> Snappable? ReportWorkload
        // GraphQL -> reportWorkload: Snappable (type)
        if (this.ReportWorkload != null) {
            s += ind + "reportWorkload {\n" + this.ReportWorkload.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ManagedVolumeSmbShare? SmbShare
        // GraphQL -> smbShare: ManagedVolumeSmbShare (type)
        if (this.SmbShare != null) {
            s += ind + "smbShare {\n" + this.SmbShare.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (this.SnapshotConnection != null) {
            s += ind + "snapshotConnection {\n" + this.SnapshotConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution != null) {
            s += ind + "snapshotDistribution {\n" + this.SnapshotDistribution.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection != null) {
            s += ind + "snapshotGroupByConnection {\n" + this.SnapshotGroupByConnection.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (this.SnapshotGroupBySummary != null) {
            s += ind + "snapshotGroupBySummary {\n" + this.SnapshotGroupBySummary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> ManagedVolumeApplicationTag? ApplicationTag
        // GraphQL -> applicationTag: ManagedVolumeApplicationTag (enum)
        if (this.ApplicationTag == null && Exploration.Includes(parent + ".applicationTag", true))
        {
            this.ApplicationTag = new ManagedVolumeApplicationTag();
        }
        //      C# -> List<Operation>? AuthorizedOperations
        // GraphQL -> authorizedOperations: [Operation!]! (enum)
        if (this.AuthorizedOperations == null && Exploration.Includes(parent + ".authorizedOperations", true))
        {
            this.AuthorizedOperations = new List<Operation>();
        }
        //      C# -> ManagedVolumeType? ManagedVolumeType
        // GraphQL -> managedVolumeType: ManagedVolumeType! (enum)
        if (this.ManagedVolumeType == null && Exploration.Includes(parent + ".managedVolumeType", true))
        {
            this.ManagedVolumeType = new ManagedVolumeType();
        }
        //      C# -> MountState? MountState
        // GraphQL -> mountState: MountState (enum)
        if (this.MountState == null && Exploration.Includes(parent + ".mountState", true))
        {
            this.MountState = new MountState();
        }
        //      C# -> HierarchyObjectTypeEnum? ObjectType
        // GraphQL -> objectType: HierarchyObjectTypeEnum! (enum)
        if (this.ObjectType == null && Exploration.Includes(parent + ".objectType", true))
        {
            this.ObjectType = new HierarchyObjectTypeEnum();
        }
        //      C# -> ManagedVolumeShareType? Protocol
        // GraphQL -> protocol: ManagedVolumeShareType! (enum)
        if (this.Protocol == null && Exploration.Includes(parent + ".protocol", true))
        {
            this.Protocol = new ManagedVolumeShareType();
        }
        //      C# -> SlaAssignmentTypeEnum? SlaAssignment
        // GraphQL -> slaAssignment: SlaAssignmentTypeEnum! (enum)
        if (this.SlaAssignment == null && Exploration.Includes(parent + ".slaAssignment", true))
        {
            this.SlaAssignment = new SlaAssignmentTypeEnum();
        }
        //      C# -> ManagedVolumeState? State
        // GraphQL -> state: ManagedVolumeState! (enum)
        if (this.State == null && Exploration.Includes(parent + ".state", true))
        {
            this.State = new ManagedVolumeState();
        }
        //      C# -> SlaDomain? ConfiguredSlaDomain
        // GraphQL -> configuredSlaDomain: SlaDomain! (interface)
        if (this.ConfiguredSlaDomain == null && Exploration.Includes(parent + ".configuredSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".configuredSlaDomain");
            this.ConfiguredSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveRetentionSlaDomain
        // GraphQL -> effectiveRetentionSlaDomain: SlaDomain (interface)
        if (this.EffectiveRetentionSlaDomain == null && Exploration.Includes(parent + ".effectiveRetentionSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".effectiveRetentionSlaDomain");
            this.EffectiveRetentionSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain == null && Exploration.Includes(parent + ".effectiveSlaDomain"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".effectiveSlaDomain");
            this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla == null && Exploration.Includes(parent + ".pendingSla"))
        {
            var impls = new List<SlaDomain>();
            impls.ApplyExploratoryFieldSpec(parent + ".pendingSla");
            this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);
        }
        //      C# -> List<CdmHierarchyObject>? ReplicatedObjects
        // GraphQL -> replicatedObjects: [CdmHierarchyObject!]! (interface)
        if (this.ReplicatedObjects == null && Exploration.Includes(parent + ".replicatedObjects"))
        {
            this.ReplicatedObjects = new List<CdmHierarchyObject>();
            this.ReplicatedObjects.ApplyExploratoryFieldSpec(parent + ".replicatedObjects");
        }
        //      C# -> System.String? CdmId
        // GraphQL -> cdmId: String! (scalar)
        if (this.CdmId == null && Exploration.Includes(parent + ".cdmId", true))
        {
            this.CdmId = new System.String("FETCH");
        }
        //      C# -> System.String? CdmLink
        // GraphQL -> cdmLink: String! (scalar)
        if (this.CdmLink == null && Exploration.Includes(parent + ".cdmLink", true))
        {
            this.CdmLink = new System.String("FETCH");
        }
        //      C# -> List<System.String>? ClientNamePatterns
        // GraphQL -> clientNamePatterns: [String!]! (scalar)
        if (this.ClientNamePatterns == null && Exploration.Includes(parent + ".clientNamePatterns", true))
        {
            this.ClientNamePatterns = new List<System.String>();
        }
        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.Boolean? IsRelic
        // GraphQL -> isRelic: Boolean! (scalar)
        if (this.IsRelic == null && Exploration.Includes(parent + ".isRelic", true))
        {
            this.IsRelic = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int! (scalar)
        if (this.NumChannels == null && Exploration.Includes(parent + ".numChannels", true))
        {
            this.NumChannels = new System.Int32();
        }
        //      C# -> System.Int32? NumWorkloadDescendants
        // GraphQL -> numWorkloadDescendants: Int! (scalar)
        if (this.NumWorkloadDescendants == null && Exploration.Includes(parent + ".numWorkloadDescendants", true))
        {
            this.NumWorkloadDescendants = new System.Int32();
        }
        //      C# -> System.Int32? OnDemandSnapshotCount
        // GraphQL -> onDemandSnapshotCount: Int! (scalar)
        if (this.OnDemandSnapshotCount == null && Exploration.Includes(parent + ".onDemandSnapshotCount", true))
        {
            this.OnDemandSnapshotCount = new System.Int32();
        }
        //      C# -> System.Int64? PhysicalUsedSize
        // GraphQL -> physicalUsedSize: Long! (scalar)
        if (this.PhysicalUsedSize == null && Exploration.Includes(parent + ".physicalUsedSize", true))
        {
            this.PhysicalUsedSize = new System.Int64();
        }
        //      C# -> DateTime? ProtectionDate
        // GraphQL -> protectionDate: DateTime (scalar)
        if (this.ProtectionDate == null && Exploration.Includes(parent + ".protectionDate", true))
        {
            this.ProtectionDate = new DateTime();
        }
        //      C# -> System.Int64? ProvisionedSize
        // GraphQL -> provisionedSize: Long! (scalar)
        if (this.ProvisionedSize == null && Exploration.Includes(parent + ".provisionedSize", true))
        {
            this.ProvisionedSize = new System.Int64();
        }
        //      C# -> System.Int32? ReplicatedObjectCount
        // GraphQL -> replicatedObjectCount: Int! (scalar)
        if (this.ReplicatedObjectCount == null && Exploration.Includes(parent + ".replicatedObjectCount", true))
        {
            this.ReplicatedObjectCount = new System.Int32();
        }
        //      C# -> System.Boolean? SlaPauseStatus
        // GraphQL -> slaPauseStatus: Boolean! (scalar)
        if (this.SlaPauseStatus == null && Exploration.Includes(parent + ".slaPauseStatus", true))
        {
            this.SlaPauseStatus = true;
        }
        //      C# -> System.String? Subnet
        // GraphQL -> subnet: String (scalar)
        if (this.Subnet == null && Exploration.Includes(parent + ".subnet", true))
        {
            this.Subnet = new System.String("FETCH");
        }
        //      C# -> List<Org>? AllOrgs
        // GraphQL -> allOrgs: [Org!]! (type)
        if (this.AllOrgs == null && Exploration.Includes(parent + ".allOrgs"))
        {
            this.AllOrgs = new List<Org>();
            this.AllOrgs.ApplyExploratoryFieldSpec(parent + ".allOrgs");
        }
        //      C# -> ManagedVolumeSlaClientConfig? ClientConfig
        // GraphQL -> clientConfig: ManagedVolumeSlaClientConfig (type)
        if (this.ClientConfig == null && Exploration.Includes(parent + ".clientConfig"))
        {
            this.ClientConfig = new ManagedVolumeSlaClientConfig();
            this.ClientConfig.ApplyExploratoryFieldSpec(parent + ".clientConfig");
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> ManagedVolumeDescendantTypeConnection? DescendantConnection
        // GraphQL -> descendantConnection: ManagedVolumeDescendantTypeConnection! (type)
        if (this.DescendantConnection == null && Exploration.Includes(parent + ".descendantConnection"))
        {
            this.DescendantConnection = new ManagedVolumeDescendantTypeConnection();
            this.DescendantConnection.ApplyExploratoryFieldSpec(parent + ".descendantConnection");
        }
        //      C# -> PathNode? EffectiveSlaSourceObject
        // GraphQL -> effectiveSlaSourceObject: PathNode (type)
        if (this.EffectiveSlaSourceObject == null && Exploration.Includes(parent + ".effectiveSlaSourceObject"))
        {
            this.EffectiveSlaSourceObject = new PathNode();
            this.EffectiveSlaSourceObject.ApplyExploratoryFieldSpec(parent + ".effectiveSlaSourceObject");
        }
        //      C# -> PhysicalHost? Host
        // GraphQL -> host: PhysicalHost (type)
        if (this.Host == null && Exploration.Includes(parent + ".host"))
        {
            this.Host = new PhysicalHost();
            this.Host.ApplyExploratoryFieldSpec(parent + ".host");
        }
        //      C# -> ManagedVolumeHostDetail? HostDetail
        // GraphQL -> hostDetail: ManagedVolumeHostDetail (type)
        if (this.HostDetail == null && Exploration.Includes(parent + ".hostDetail"))
        {
            this.HostDetail = new ManagedVolumeHostDetail();
            this.HostDetail.ApplyExploratoryFieldSpec(parent + ".hostDetail");
        }
        //      C# -> LatestUserNote? LatestUserNote
        // GraphQL -> latestUserNote: LatestUserNote (type)
        if (this.LatestUserNote == null && Exploration.Includes(parent + ".latestUserNote"))
        {
            this.LatestUserNote = new LatestUserNote();
            this.LatestUserNote.ApplyExploratoryFieldSpec(parent + ".latestUserNote");
        }
        //      C# -> ManagedVolumeMountConnection? LiveMounts
        // GraphQL -> liveMounts: ManagedVolumeMountConnection! (type)
        if (this.LiveMounts == null && Exploration.Includes(parent + ".liveMounts"))
        {
            this.LiveMounts = new ManagedVolumeMountConnection();
            this.LiveMounts.ApplyExploratoryFieldSpec(parent + ".liveMounts");
        }
        //      C# -> List<PathNode>? LogicalPath
        // GraphQL -> logicalPath: [PathNode!]! (type)
        if (this.LogicalPath == null && Exploration.Includes(parent + ".logicalPath"))
        {
            this.LogicalPath = new List<PathNode>();
            this.LogicalPath.ApplyExploratoryFieldSpec(parent + ".logicalPath");
        }
        //      C# -> ManagedVolumeMount? MainMount
        // GraphQL -> mainMount: ManagedVolumeMount (type)
        if (this.MainMount == null && Exploration.Includes(parent + ".mainMount"))
        {
            this.MainMount = new ManagedVolumeMount();
            this.MainMount.ApplyExploratoryFieldSpec(parent + ".mainMount");
        }
        //      C# -> MissedSnapshotCommonConnection? MissedSnapshotConnection
        // GraphQL -> missedSnapshotConnection: MissedSnapshotCommonConnection (type)
        if (this.MissedSnapshotConnection == null && Exploration.Includes(parent + ".missedSnapshotConnection"))
        {
            this.MissedSnapshotConnection = new MissedSnapshotCommonConnection();
            this.MissedSnapshotConnection.ApplyExploratoryFieldSpec(parent + ".missedSnapshotConnection");
        }
        //      C# -> MissedSnapshotGroupByConnection? MissedSnapshotGroupByConnection
        // GraphQL -> missedSnapshotGroupByConnection: MissedSnapshotGroupByConnection (type)
        if (this.MissedSnapshotGroupByConnection == null && Exploration.Includes(parent + ".missedSnapshotGroupByConnection"))
        {
            this.MissedSnapshotGroupByConnection = new MissedSnapshotGroupByConnection();
            this.MissedSnapshotGroupByConnection.ApplyExploratoryFieldSpec(parent + ".missedSnapshotGroupByConnection");
        }
        //      C# -> CdmSnapshot? NewestArchivedSnapshot
        // GraphQL -> newestArchivedSnapshot: CdmSnapshot (type)
        if (this.NewestArchivedSnapshot == null && Exploration.Includes(parent + ".newestArchivedSnapshot"))
        {
            this.NewestArchivedSnapshot = new CdmSnapshot();
            this.NewestArchivedSnapshot.ApplyExploratoryFieldSpec(parent + ".newestArchivedSnapshot");
        }
        //      C# -> CdmSnapshot? NewestReplicatedSnapshot
        // GraphQL -> newestReplicatedSnapshot: CdmSnapshot (type)
        if (this.NewestReplicatedSnapshot == null && Exploration.Includes(parent + ".newestReplicatedSnapshot"))
        {
            this.NewestReplicatedSnapshot = new CdmSnapshot();
            this.NewestReplicatedSnapshot.ApplyExploratoryFieldSpec(parent + ".newestReplicatedSnapshot");
        }
        //      C# -> CdmSnapshot? NewestSnapshot
        // GraphQL -> newestSnapshot: CdmSnapshot (type)
        if (this.NewestSnapshot == null && Exploration.Includes(parent + ".newestSnapshot"))
        {
            this.NewestSnapshot = new CdmSnapshot();
            this.NewestSnapshot.ApplyExploratoryFieldSpec(parent + ".newestSnapshot");
        }
        //      C# -> CdmSnapshot? OldestSnapshot
        // GraphQL -> oldestSnapshot: CdmSnapshot (type)
        if (this.OldestSnapshot == null && Exploration.Includes(parent + ".oldestSnapshot"))
        {
            this.OldestSnapshot = new CdmSnapshot();
            this.OldestSnapshot.ApplyExploratoryFieldSpec(parent + ".oldestSnapshot");
        }
        //      C# -> PendingSnapshotsOfObjectDeletion? PendingObjectDeletionStatus
        // GraphQL -> pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion (type)
        if (this.PendingObjectDeletionStatus == null && Exploration.Includes(parent + ".pendingObjectDeletionStatus"))
        {
            this.PendingObjectDeletionStatus = new PendingSnapshotsOfObjectDeletion();
            this.PendingObjectDeletionStatus.ApplyExploratoryFieldSpec(parent + ".pendingObjectDeletionStatus");
        }
        //      C# -> ManagedVolumePhysicalChildTypeConnection? PhysicalChildConnection
        // GraphQL -> physicalChildConnection: ManagedVolumePhysicalChildTypeConnection! (type)
        if (this.PhysicalChildConnection == null && Exploration.Includes(parent + ".physicalChildConnection"))
        {
            this.PhysicalChildConnection = new ManagedVolumePhysicalChildTypeConnection();
            this.PhysicalChildConnection.ApplyExploratoryFieldSpec(parent + ".physicalChildConnection");
        }
        //      C# -> List<PathNode>? PhysicalPath
        // GraphQL -> physicalPath: [PathNode!]! (type)
        if (this.PhysicalPath == null && Exploration.Includes(parent + ".physicalPath"))
        {
            this.PhysicalPath = new List<PathNode>();
            this.PhysicalPath.ApplyExploratoryFieldSpec(parent + ".physicalPath");
        }
        //      C# -> DataLocation? PrimaryClusterLocation
        // GraphQL -> primaryClusterLocation: DataLocation! (type)
        if (this.PrimaryClusterLocation == null && Exploration.Includes(parent + ".primaryClusterLocation"))
        {
            this.PrimaryClusterLocation = new DataLocation();
            this.PrimaryClusterLocation.ApplyExploratoryFieldSpec(parent + ".primaryClusterLocation");
        }
        //      C# -> ManagedVolumeQueuedSnapshotGroupByConnection? QueuedSnapshotGroupBys
        // GraphQL -> queuedSnapshotGroupBys: ManagedVolumeQueuedSnapshotGroupByConnection (type)
        if (this.QueuedSnapshotGroupBys == null && Exploration.Includes(parent + ".queuedSnapshotGroupBys"))
        {
            this.QueuedSnapshotGroupBys = new ManagedVolumeQueuedSnapshotGroupByConnection();
            this.QueuedSnapshotGroupBys.ApplyExploratoryFieldSpec(parent + ".queuedSnapshotGroupBys");
        }
        //      C# -> ManagedVolumeQueuedSnapshotConnection? QueuedSnapshots
        // GraphQL -> queuedSnapshots: ManagedVolumeQueuedSnapshotConnection (type)
        if (this.QueuedSnapshots == null && Exploration.Includes(parent + ".queuedSnapshots"))
        {
            this.QueuedSnapshots = new ManagedVolumeQueuedSnapshotConnection();
            this.QueuedSnapshots.ApplyExploratoryFieldSpec(parent + ".queuedSnapshots");
        }
        //      C# -> Snappable? ReportWorkload
        // GraphQL -> reportWorkload: Snappable (type)
        if (this.ReportWorkload == null && Exploration.Includes(parent + ".reportWorkload"))
        {
            this.ReportWorkload = new Snappable();
            this.ReportWorkload.ApplyExploratoryFieldSpec(parent + ".reportWorkload");
        }
        //      C# -> ManagedVolumeSmbShare? SmbShare
        // GraphQL -> smbShare: ManagedVolumeSmbShare (type)
        if (this.SmbShare == null && Exploration.Includes(parent + ".smbShare"))
        {
            this.SmbShare = new ManagedVolumeSmbShare();
            this.SmbShare.ApplyExploratoryFieldSpec(parent + ".smbShare");
        }
        //      C# -> CdmSnapshotConnection? SnapshotConnection
        // GraphQL -> snapshotConnection: CdmSnapshotConnection (type)
        if (this.SnapshotConnection == null && Exploration.Includes(parent + ".snapshotConnection"))
        {
            this.SnapshotConnection = new CdmSnapshotConnection();
            this.SnapshotConnection.ApplyExploratoryFieldSpec(parent + ".snapshotConnection");
        }
        //      C# -> SnapshotDistribution? SnapshotDistribution
        // GraphQL -> snapshotDistribution: SnapshotDistribution! (type)
        if (this.SnapshotDistribution == null && Exploration.Includes(parent + ".snapshotDistribution"))
        {
            this.SnapshotDistribution = new SnapshotDistribution();
            this.SnapshotDistribution.ApplyExploratoryFieldSpec(parent + ".snapshotDistribution");
        }
        //      C# -> CdmSnapshotGroupByConnection? SnapshotGroupByConnection
        // GraphQL -> snapshotGroupByConnection: CdmSnapshotGroupByConnection (type)
        if (this.SnapshotGroupByConnection == null && Exploration.Includes(parent + ".snapshotGroupByConnection"))
        {
            this.SnapshotGroupByConnection = new CdmSnapshotGroupByConnection();
            this.SnapshotGroupByConnection.ApplyExploratoryFieldSpec(parent + ".snapshotGroupByConnection");
        }
        //      C# -> CdmSnapshotGroupBySummaryConnection? SnapshotGroupBySummary
        // GraphQL -> snapshotGroupBySummary: CdmSnapshotGroupBySummaryConnection (type)
        if (this.SnapshotGroupBySummary == null && Exploration.Includes(parent + ".snapshotGroupBySummary"))
        {
            this.SnapshotGroupBySummary = new CdmSnapshotGroupBySummaryConnection();
            this.SnapshotGroupBySummary.ApplyExploratoryFieldSpec(parent + ".snapshotGroupBySummary");
        }
    }


    #endregion

    } // class ManagedVolume
    
    #endregion

    public static class ListManagedVolumeExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<ManagedVolume> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ManagedVolume> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ManagedVolume());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
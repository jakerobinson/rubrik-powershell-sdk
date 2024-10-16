// UnmanagedObjectDetail.cs
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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region UnmanagedObjectDetail
    public class UnmanagedObjectDetail: BaseType
    {
        #region members

        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        [JsonProperty("objectType")]
        public ManagedObjectType? ObjectType { get; set; }

        //      C# -> UnmanagedObjectAvailabilityFilter? UnmanagedStatus
        // GraphQL -> unmanagedStatus: UnmanagedObjectAvailabilityFilter! (enum)
        [JsonProperty("unmanagedStatus")]
        public UnmanagedObjectAvailabilityFilter? UnmanagedStatus { get; set; }

        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        [JsonProperty("effectiveSlaDomain")]
        public SlaDomain? EffectiveSlaDomain { get; set; }

        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        [JsonProperty("pendingSla")]
        public SlaDomain? PendingSla { get; set; }

        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        [JsonProperty("archiveStorage")]
        public System.Int64? ArchiveStorage { get; set; }

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.Boolean? HasSnapshotsWithPolicy
        // GraphQL -> hasSnapshotsWithPolicy: Boolean! (scalar)
        [JsonProperty("hasSnapshotsWithPolicy")]
        public System.Boolean? HasSnapshotsWithPolicy { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.Boolean? IsRemote
        // GraphQL -> isRemote: Boolean (scalar)
        [JsonProperty("isRemote")]
        public System.Boolean? IsRemote { get; set; }

        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long! (scalar)
        [JsonProperty("localStorage")]
        public System.Int64? LocalStorage { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        [JsonProperty("retentionSlaDomainId")]
        public System.String? RetentionSlaDomainId { get; set; }

        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        [JsonProperty("retentionSlaDomainName")]
        public System.String? RetentionSlaDomainName { get; set; }

        //      C# -> System.String? RetentionSlaDomainRscManagedId
        // GraphQL -> retentionSlaDomainRscManagedId: String (scalar)
        [JsonProperty("retentionSlaDomainRscManagedId")]
        public System.String? RetentionSlaDomainRscManagedId { get; set; }

        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        [JsonProperty("snapshotCount")]
        public System.Int64? SnapshotCount { get; set; }

        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        [JsonProperty("workloadId")]
        public System.String? WorkloadId { get; set; }

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        [JsonProperty("physicalLocation")]
        public List<LocationPathPoint>? PhysicalLocation { get; set; }

        //      C# -> WorkloadRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: WorkloadRecoveryInfo (type)
        [JsonProperty("recoveryInfo")]
        public WorkloadRecoveryInfo? RecoveryInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "UnmanagedObjectDetail";
    }

    public UnmanagedObjectDetail Set(
        ManagedObjectType? ObjectType = null,
        UnmanagedObjectAvailabilityFilter? UnmanagedStatus = null,
        SlaDomain? EffectiveSlaDomain = null,
        SlaDomain? PendingSla = null,
        System.Int64? ArchiveStorage = null,
        System.String? ClusterUuid = null,
        System.Boolean? HasSnapshotsWithPolicy = null,
        System.String? Id = null,
        System.Boolean? IsRemote = null,
        System.Int64? LocalStorage = null,
        System.String? Name = null,
        System.String? RetentionSlaDomainId = null,
        System.String? RetentionSlaDomainName = null,
        System.String? RetentionSlaDomainRscManagedId = null,
        System.Int64? SnapshotCount = null,
        System.String? WorkloadId = null,
        Cluster? Cluster = null,
        List<LocationPathPoint>? PhysicalLocation = null,
        WorkloadRecoveryInfo? RecoveryInfo = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( UnmanagedStatus != null ) {
            this.UnmanagedStatus = UnmanagedStatus;
        }
        if ( EffectiveSlaDomain != null ) {
            this.EffectiveSlaDomain = EffectiveSlaDomain;
        }
        if ( PendingSla != null ) {
            this.PendingSla = PendingSla;
        }
        if ( ArchiveStorage != null ) {
            this.ArchiveStorage = ArchiveStorage;
        }
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( HasSnapshotsWithPolicy != null ) {
            this.HasSnapshotsWithPolicy = HasSnapshotsWithPolicy;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( IsRemote != null ) {
            this.IsRemote = IsRemote;
        }
        if ( LocalStorage != null ) {
            this.LocalStorage = LocalStorage;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( RetentionSlaDomainId != null ) {
            this.RetentionSlaDomainId = RetentionSlaDomainId;
        }
        if ( RetentionSlaDomainName != null ) {
            this.RetentionSlaDomainName = RetentionSlaDomainName;
        }
        if ( RetentionSlaDomainRscManagedId != null ) {
            this.RetentionSlaDomainRscManagedId = RetentionSlaDomainRscManagedId;
        }
        if ( SnapshotCount != null ) {
            this.SnapshotCount = SnapshotCount;
        }
        if ( WorkloadId != null ) {
            this.WorkloadId = WorkloadId;
        }
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( PhysicalLocation != null ) {
            this.PhysicalLocation = PhysicalLocation;
        }
        if ( RecoveryInfo != null ) {
            this.RecoveryInfo = RecoveryInfo;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> UnmanagedObjectAvailabilityFilter? UnmanagedStatus
        // GraphQL -> unmanagedStatus: UnmanagedObjectAvailabilityFilter! (enum)
        if (this.UnmanagedStatus != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unmanagedStatus\n" ;
            } else {
                s += ind + "unmanagedStatus\n" ;
            }
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (this.EffectiveSlaDomain != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.EffectiveSlaDomain).AsFieldSpec(conf.Child("effectiveSlaDomain"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "effectiveSlaDomain {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (this.PendingSla != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.PendingSla).AsFieldSpec(conf.Child("pendingSla"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "pendingSla {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        if (this.ArchiveStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "archiveStorage\n" ;
            } else {
                s += ind + "archiveStorage\n" ;
            }
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "clusterUuid\n" ;
            } else {
                s += ind + "clusterUuid\n" ;
            }
        }
        //      C# -> System.Boolean? HasSnapshotsWithPolicy
        // GraphQL -> hasSnapshotsWithPolicy: Boolean! (scalar)
        if (this.HasSnapshotsWithPolicy != null) {
            if (conf.Flat) {
                s += conf.Prefix + "hasSnapshotsWithPolicy\n" ;
            } else {
                s += ind + "hasSnapshotsWithPolicy\n" ;
            }
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            if (conf.Flat) {
                s += conf.Prefix + "id\n" ;
            } else {
                s += ind + "id\n" ;
            }
        }
        //      C# -> System.Boolean? IsRemote
        // GraphQL -> isRemote: Boolean (scalar)
        if (this.IsRemote != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isRemote\n" ;
            } else {
                s += ind + "isRemote\n" ;
            }
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long! (scalar)
        if (this.LocalStorage != null) {
            if (conf.Flat) {
                s += conf.Prefix + "localStorage\n" ;
            } else {
                s += ind + "localStorage\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        if (this.RetentionSlaDomainId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retentionSlaDomainId\n" ;
            } else {
                s += ind + "retentionSlaDomainId\n" ;
            }
        }
        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        if (this.RetentionSlaDomainName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retentionSlaDomainName\n" ;
            } else {
                s += ind + "retentionSlaDomainName\n" ;
            }
        }
        //      C# -> System.String? RetentionSlaDomainRscManagedId
        // GraphQL -> retentionSlaDomainRscManagedId: String (scalar)
        if (this.RetentionSlaDomainRscManagedId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "retentionSlaDomainRscManagedId\n" ;
            } else {
                s += ind + "retentionSlaDomainRscManagedId\n" ;
            }
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (this.SnapshotCount != null) {
            if (conf.Flat) {
                s += conf.Prefix + "snapshotCount\n" ;
            } else {
                s += ind + "snapshotCount\n" ;
            }
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (this.WorkloadId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "workloadId\n" ;
            } else {
                s += ind + "workloadId\n" ;
            }
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        if (this.PhysicalLocation != null) {
            var fspec = this.PhysicalLocation.AsFieldSpec(conf.Child("physicalLocation"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "physicalLocation {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> WorkloadRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: WorkloadRecoveryInfo (type)
        if (this.RecoveryInfo != null) {
            var fspec = this.RecoveryInfo.AsFieldSpec(conf.Child("recoveryInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "recoveryInfo {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ManagedObjectType? ObjectType
        // GraphQL -> objectType: ManagedObjectType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new ManagedObjectType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> UnmanagedObjectAvailabilityFilter? UnmanagedStatus
        // GraphQL -> unmanagedStatus: UnmanagedObjectAvailabilityFilter! (enum)
        if (ec.Includes("unmanagedStatus",true))
        {
            if(this.UnmanagedStatus == null) {

                this.UnmanagedStatus = new UnmanagedObjectAvailabilityFilter();

            } else {


            }
        }
        else if (this.UnmanagedStatus != null && ec.Excludes("unmanagedStatus",true))
        {
            this.UnmanagedStatus = null;
        }
        //      C# -> SlaDomain? EffectiveSlaDomain
        // GraphQL -> effectiveSlaDomain: SlaDomain! (interface)
        if (ec.Includes("effectiveSlaDomain",false))
        {
            if(this.EffectiveSlaDomain == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("effectiveSlaDomain"));
                this.EffectiveSlaDomain = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.EffectiveSlaDomain != null && ec.Excludes("effectiveSlaDomain",false))
        {
            this.EffectiveSlaDomain = null;
        }
        //      C# -> SlaDomain? PendingSla
        // GraphQL -> pendingSla: SlaDomain (interface)
        if (ec.Includes("pendingSla",false))
        {
            if(this.PendingSla == null) {

                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));
                this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<SlaDomain>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("pendingSla"));
                this.PendingSla = (SlaDomain)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.PendingSla != null && ec.Excludes("pendingSla",false))
        {
            this.PendingSla = null;
        }
        //      C# -> System.Int64? ArchiveStorage
        // GraphQL -> archiveStorage: Long! (scalar)
        if (ec.Includes("archiveStorage",true))
        {
            if(this.ArchiveStorage == null) {

                this.ArchiveStorage = new System.Int64();

            } else {


            }
        }
        else if (this.ArchiveStorage != null && ec.Excludes("archiveStorage",true))
        {
            this.ArchiveStorage = null;
        }
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (ec.Includes("clusterUuid",true))
        {
            if(this.ClusterUuid == null) {

                this.ClusterUuid = "FETCH";

            } else {


            }
        }
        else if (this.ClusterUuid != null && ec.Excludes("clusterUuid",true))
        {
            this.ClusterUuid = null;
        }
        //      C# -> System.Boolean? HasSnapshotsWithPolicy
        // GraphQL -> hasSnapshotsWithPolicy: Boolean! (scalar)
        if (ec.Includes("hasSnapshotsWithPolicy",true))
        {
            if(this.HasSnapshotsWithPolicy == null) {

                this.HasSnapshotsWithPolicy = true;

            } else {


            }
        }
        else if (this.HasSnapshotsWithPolicy != null && ec.Excludes("hasSnapshotsWithPolicy",true))
        {
            this.HasSnapshotsWithPolicy = null;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (ec.Includes("id",true))
        {
            if(this.Id == null) {

                this.Id = "FETCH";

            } else {


            }
        }
        else if (this.Id != null && ec.Excludes("id",true))
        {
            this.Id = null;
        }
        //      C# -> System.Boolean? IsRemote
        // GraphQL -> isRemote: Boolean (scalar)
        if (ec.Includes("isRemote",true))
        {
            if(this.IsRemote == null) {

                this.IsRemote = true;

            } else {


            }
        }
        else if (this.IsRemote != null && ec.Excludes("isRemote",true))
        {
            this.IsRemote = null;
        }
        //      C# -> System.Int64? LocalStorage
        // GraphQL -> localStorage: Long! (scalar)
        if (ec.Includes("localStorage",true))
        {
            if(this.LocalStorage == null) {

                this.LocalStorage = new System.Int64();

            } else {


            }
        }
        else if (this.LocalStorage != null && ec.Excludes("localStorage",true))
        {
            this.LocalStorage = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
        //      C# -> System.String? RetentionSlaDomainId
        // GraphQL -> retentionSlaDomainId: String! (scalar)
        if (ec.Includes("retentionSlaDomainId",true))
        {
            if(this.RetentionSlaDomainId == null) {

                this.RetentionSlaDomainId = "FETCH";

            } else {


            }
        }
        else if (this.RetentionSlaDomainId != null && ec.Excludes("retentionSlaDomainId",true))
        {
            this.RetentionSlaDomainId = null;
        }
        //      C# -> System.String? RetentionSlaDomainName
        // GraphQL -> retentionSlaDomainName: String! (scalar)
        if (ec.Includes("retentionSlaDomainName",true))
        {
            if(this.RetentionSlaDomainName == null) {

                this.RetentionSlaDomainName = "FETCH";

            } else {


            }
        }
        else if (this.RetentionSlaDomainName != null && ec.Excludes("retentionSlaDomainName",true))
        {
            this.RetentionSlaDomainName = null;
        }
        //      C# -> System.String? RetentionSlaDomainRscManagedId
        // GraphQL -> retentionSlaDomainRscManagedId: String (scalar)
        if (ec.Includes("retentionSlaDomainRscManagedId",true))
        {
            if(this.RetentionSlaDomainRscManagedId == null) {

                this.RetentionSlaDomainRscManagedId = "FETCH";

            } else {


            }
        }
        else if (this.RetentionSlaDomainRscManagedId != null && ec.Excludes("retentionSlaDomainRscManagedId",true))
        {
            this.RetentionSlaDomainRscManagedId = null;
        }
        //      C# -> System.Int64? SnapshotCount
        // GraphQL -> snapshotCount: Long! (scalar)
        if (ec.Includes("snapshotCount",true))
        {
            if(this.SnapshotCount == null) {

                this.SnapshotCount = new System.Int64();

            } else {


            }
        }
        else if (this.SnapshotCount != null && ec.Excludes("snapshotCount",true))
        {
            this.SnapshotCount = null;
        }
        //      C# -> System.String? WorkloadId
        // GraphQL -> workloadId: String! (scalar)
        if (ec.Includes("workloadId",true))
        {
            if(this.WorkloadId == null) {

                this.WorkloadId = "FETCH";

            } else {


            }
        }
        else if (this.WorkloadId != null && ec.Excludes("workloadId",true))
        {
            this.WorkloadId = null;
        }
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> List<LocationPathPoint>? PhysicalLocation
        // GraphQL -> physicalLocation: [LocationPathPoint!]! (type)
        if (ec.Includes("physicalLocation",false))
        {
            if(this.PhysicalLocation == null) {

                this.PhysicalLocation = new List<LocationPathPoint>();
                this.PhysicalLocation.ApplyExploratoryFieldSpec(ec.NewChild("physicalLocation"));

            } else {

                this.PhysicalLocation.ApplyExploratoryFieldSpec(ec.NewChild("physicalLocation"));

            }
        }
        else if (this.PhysicalLocation != null && ec.Excludes("physicalLocation",false))
        {
            this.PhysicalLocation = null;
        }
        //      C# -> WorkloadRecoveryInfo? RecoveryInfo
        // GraphQL -> recoveryInfo: WorkloadRecoveryInfo (type)
        if (ec.Includes("recoveryInfo",false))
        {
            if(this.RecoveryInfo == null) {

                this.RecoveryInfo = new WorkloadRecoveryInfo();
                this.RecoveryInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfo"));

            } else {

                this.RecoveryInfo.ApplyExploratoryFieldSpec(ec.NewChild("recoveryInfo"));

            }
        }
        else if (this.RecoveryInfo != null && ec.Excludes("recoveryInfo",false))
        {
            this.RecoveryInfo = null;
        }
    }


    #endregion

    } // class UnmanagedObjectDetail
    
    #endregion

    public static class ListUnmanagedObjectDetailExtensions
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
            this List<UnmanagedObjectDetail> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<UnmanagedObjectDetail> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<UnmanagedObjectDetail> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new UnmanagedObjectDetail());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<UnmanagedObjectDetail> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
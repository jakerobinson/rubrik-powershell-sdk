// Invoke-RscQueryOracle.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using Rubrik.SecurityCloud.Types;
using Rubrik.SecurityCloud.NetSDK.Client;
using Rubrik.SecurityCloud.PowerShell.Private;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Threading.Tasks;
using RubrikSecurityCloud.Schema.Utils;
using GraphQL;

namespace Rubrik.SecurityCloud.PowerShell.Cmdlets
{
    [Cmdlet(
        "Invoke",
        "RscQueryOracle",
        DefaultParameterSetName = "Host")
    ]
    public class Invoke_RscQueryOracle : RscPSCmdlet
    {
        
        // -------------------------------------------------------------------
        // TopLevelDescendant parameter set
        //
        // GraphQL operation: oracleTopLevelDescendants(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):OracleTopLevelDescendantTypeConnection!
        //
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of the highest-level Oracle Objects accessible by the current user.
                GraphQL operation: oracleTopLevelDescendants(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   typeFilter: [HierarchyObjectTypeEnum!],   filter: [Filter!], ):OracleTopLevelDescendantTypeConnection!
                ",
            Position = 0
        )]
        public SwitchParameter TopLevelDescendant { get; set; }

        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the first n elements from the list.
                GraphQL argument first: Int
                "
        )]
        public System.Int32? First { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Returns the elements in the list that come after the specified cursor.
                GraphQL argument after: String
                "
        )]
        public System.String? After { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sort hierarchy objects by hierarchy field.
                GraphQL argument sortBy: HierarchySortByField
                "
        )]
        public HierarchySortByField? SortBy { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Sorting order for the results.
                GraphQL argument sortOrder: SortOrder
                "
        )]
        public SortOrder? SortOrder { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Types of objects to include.
                GraphQL argument typeFilter: [HierarchyObjectTypeEnum!]
                "
        )]
        public List<HierarchyObjectTypeEnum>? TypeFilter { get; set; }
        [Parameter(
            ParameterSetName = "TopLevelDescendant",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The hierarchy object filter.
                GraphQL argument filter: [Filter!]
                "
        )]
        public List<Filter>? Filter { get; set; }
        
        // -------------------------------------------------------------------
        // Database parameter set
        //
        // GraphQL operation: oracleDatabases(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):OracleDatabaseConnection!
        //
        [Parameter(
            ParameterSetName = "Database",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of Oracle Databases.
                GraphQL operation: oracleDatabases(,   first: Int,   after: String,   sortBy: HierarchySortByField,   sortOrder: SortOrder,   filter: [Filter!], ):OracleDatabaseConnection!
                ",
            Position = 0
        )]
        public SwitchParameter Database { get; set; }

        
        // -------------------------------------------------------------------
        // Host parameter set
        //
        // GraphQL operation: oracleHost(fid: UUID!):OracleHost!
        //
        [Parameter(
            ParameterSetName = "Host",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                An Oracle Host.
                GraphQL operation: oracleHost(fid: UUID!):OracleHost!
                ",
            Position = 0
        )]
        public new SwitchParameter Host { get; set; }

        [Parameter(
            ParameterSetName = "Host",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                The Rubrik UUID for the object.
                GraphQL argument fid: UUID!
                "
        )]
        public System.String? Fid { get; set; }
        
        // -------------------------------------------------------------------
        // Rac parameter set
        //
        // GraphQL operation: oracleRac(fid: UUID!):OracleRac!
        //
        [Parameter(
            ParameterSetName = "Rac",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                An Oracle Real Application Cluster.
                GraphQL operation: oracleRac(fid: UUID!):OracleRac!
                ",
            Position = 0
        )]
        public SwitchParameter Rac { get; set; }

        
        // -------------------------------------------------------------------
        // DataGuardGroup parameter set
        //
        // GraphQL operation: oracleDataGuardGroup(fid: UUID!):OracleDataGuardGroup!
        //
        [Parameter(
            ParameterSetName = "DataGuardGroup",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                An Oracle Data Guard Group.
                GraphQL operation: oracleDataGuardGroup(fid: UUID!):OracleDataGuardGroup!
                ",
            Position = 0
        )]
        public SwitchParameter DataGuardGroup { get; set; }

        
        // -------------------------------------------------------------------
        // LiveMount parameter set
        //
        // GraphQL operation: oracleLiveMounts(,   first: Int,   after: String,   filters: [OracleLiveMountFilterInput!],   sortBy: OracleLiveMountSortBy, ):OracleLiveMountConnection!
        //
        [Parameter(
            ParameterSetName = "LiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Paginated list of Oracle Live Mounts.
                GraphQL operation: oracleLiveMounts(,   first: Int,   after: String,   filters: [OracleLiveMountFilterInput!],   sortBy: OracleLiveMountSortBy, ):OracleLiveMountConnection!
                ",
            Position = 0
        )]
        public SwitchParameter LiveMount { get; set; }

        [Parameter(
            ParameterSetName = "LiveMount",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Filter for Oracle live mounts.
                GraphQL argument filters: [OracleLiveMountFilterInput!]
                "
        )]
        public List<OracleLiveMountFilterInput>? Filters { get; set; }
        
        // -------------------------------------------------------------------
        // AcoParameter parameter set
        //
        // GraphQL operation: oracleAcoParameters(input: ClusterUuidWithDbIdInput!):OracleAcoParameterList!
        //
        [Parameter(
            ParameterSetName = "AcoParameter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                List of supported Advanced Cloning Options

Supported in v6.0+
Get the list of supported Advanced Cloning Options (ACO) parameters.
                GraphQL operation: oracleAcoParameters(input: ClusterUuidWithDbIdInput!):OracleAcoParameterList!
                ",
            Position = 0
        )]
        public SwitchParameter AcoParameter { get; set; }

        [Parameter(
            ParameterSetName = "AcoParameter",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Specifies input for V1GetAcoParameterList including the Oracle database ID.
                GraphQL argument input: ClusterUuidWithDbIdInput!
                "
        )]
        public ClusterUuidWithDbIdInput? Input { get; set; }
        
        // -------------------------------------------------------------------
        // RecoverableRange parameter set
        //
        // GraphQL operation: oracleRecoverableRanges(input: GetOracleDbRecoverableRangesInput!):OracleRecoverableRangeListResponse!
        //
        [Parameter(
            ParameterSetName = "RecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve the recoverable ranges for a specified Oracle database. A begin and/or end timestamp can be provided to retrieve only the ranges that fall within the window.
                GraphQL operation: oracleRecoverableRanges(input: GetOracleDbRecoverableRangesInput!):OracleRecoverableRangeListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter RecoverableRange { get; set; }

        
        // -------------------------------------------------------------------
        // MissedRecoverableRange parameter set
        //
        // GraphQL operation: oracleMissedRecoverableRanges(input: GetOracleDbMissedRecoverableRangesInput!):OracleMissedRecoverableRangeListResponse!
        //
        [Parameter(
            ParameterSetName = "MissedRecoverableRange",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get missed recoverable ranges of a Oracle database

Supported in v5.0+
Retrieve a list of missed recoverable ranges for a Oracle database. For each run of one type of error, the first and last occurrence of the error are given.
                GraphQL operation: oracleMissedRecoverableRanges(input: GetOracleDbMissedRecoverableRangesInput!):OracleMissedRecoverableRangeListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter MissedRecoverableRange { get; set; }

        
        // -------------------------------------------------------------------
        // MissedSnapshot parameter set
        //
        // GraphQL operation: oracleMissedSnapshots(input: GetMissedOracleDbSnapshotsInput!):MissedSnapshotListResponse!
        //
        [Parameter(
            ParameterSetName = "MissedSnapshot",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get missed snapshots for an Oracle database

Supported in v5.0+
Retrieve summary information about the missed snapshots of an Oracle database.
                GraphQL operation: oracleMissedSnapshots(input: GetMissedOracleDbSnapshotsInput!):MissedSnapshotListResponse!
                ",
            Position = 0
        )]
        public SwitchParameter MissedSnapshot { get; set; }

        
        // -------------------------------------------------------------------
        // AcoExampleDownloadLink parameter set
        //
        // GraphQL operation: oracleAcoExampleDownloadLink(input: ClusterUuidWithDbIdInput!):OracleFileDownloadLink!
        //
        [Parameter(
            ParameterSetName = "AcoExampleDownloadLink",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Link to download the Advanced Recovery Options example file

Supported in v5.3+
Link to download the Advanced Recovery Options example file which can be used to customize Oracle recoveries.
                GraphQL operation: oracleAcoExampleDownloadLink(input: ClusterUuidWithDbIdInput!):OracleFileDownloadLink!
                ",
            Position = 0
        )]
        public SwitchParameter AcoExampleDownloadLink { get; set; }

        
        // -------------------------------------------------------------------
        // PdbDetail parameter set
        //
        // GraphQL operation: oraclePdbDetails(input: OraclePdbDetailsInput!):OraclePdbDetails!
        //
        [Parameter(
            ParameterSetName = "PdbDetail",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Get PDB details

Supported in v8.0+
Retrieves information about available pluggable databases (PDBs) for a given recovery point.
                GraphQL operation: oraclePdbDetails(input: OraclePdbDetailsInput!):OraclePdbDetails!
                ",
            Position = 0
        )]
        public SwitchParameter PdbDetail { get; set; }

        
        // -------------------------------------------------------------------
        // HostLogBackupConfig parameter set
        //
        // GraphQL operation: oracleHostLogBackupConfig(input: OracleHostInput!):OracleLogBackupConfig!
        //
        [Parameter(
            ParameterSetName = "HostLogBackupConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Oracle Log backup configuration for Oracle Host.
                GraphQL operation: oracleHostLogBackupConfig(input: OracleHostInput!):OracleLogBackupConfig!
                ",
            Position = 0
        )]
        public SwitchParameter HostLogBackupConfig { get; set; }

        
        // -------------------------------------------------------------------
        // DatabaseLogBackupConfig parameter set
        //
        // GraphQL operation: oracleDatabaseLogBackupConfig(input: OracleDbInput!):OracleLogBackupConfig!
        //
        [Parameter(
            ParameterSetName = "DatabaseLogBackupConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Oracle log backup configuration for an Oracle Database.
                GraphQL operation: oracleDatabaseLogBackupConfig(input: OracleDbInput!):OracleLogBackupConfig!
                ",
            Position = 0
        )]
        public SwitchParameter DatabaseLogBackupConfig { get; set; }

        
        // -------------------------------------------------------------------
        // RacLogBackupConfig parameter set
        //
        // GraphQL operation: oracleRacLogBackupConfig(input: OracleRacInput!):OracleLogBackupConfig!
        //
        [Parameter(
            ParameterSetName = "RacLogBackupConfig",
            Mandatory = false,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = false,
            HelpMessage =
                @"
                Oracle log backup configuration for an Oracle RAC.
                GraphQL operation: oracleRacLogBackupConfig(input: OracleRacInput!):OracleLogBackupConfig!
                ",
            Position = 0
        )]
        public SwitchParameter RacLogBackupConfig { get; set; }


        protected override void ProcessRecord()
        {
            try
            {
                switch(Op)
                {
                    case "TopLevelDescendant":
                        this.ProcessRecord_TopLevelDescendant();
                        break;
                    case "Database":
                        this.ProcessRecord_Database();
                        break;
                    case "Host":
                        this.ProcessRecord_Host();
                        break;
                    case "Rac":
                        this.ProcessRecord_Rac();
                        break;
                    case "DataGuardGroup":
                        this.ProcessRecord_DataGuardGroup();
                        break;
                    case "LiveMount":
                        this.ProcessRecord_LiveMount();
                        break;
                    case "AcoParameter":
                        this.ProcessRecord_AcoParameter();
                        break;
                    case "RecoverableRange":
                        this.ProcessRecord_RecoverableRange();
                        break;
                    case "MissedRecoverableRange":
                        this.ProcessRecord_MissedRecoverableRange();
                        break;
                    case "MissedSnapshot":
                        this.ProcessRecord_MissedSnapshot();
                        break;
                    case "AcoExampleDownloadLink":
                        this.ProcessRecord_AcoExampleDownloadLink();
                        break;
                    case "PdbDetail":
                        this.ProcessRecord_PdbDetail();
                        break;
                    case "HostLogBackupConfig":
                        this.ProcessRecord_HostLogBackupConfig();
                        break;
                    case "DatabaseLogBackupConfig":
                        this.ProcessRecord_DatabaseLogBackupConfig();
                        break;
                    case "RacLogBackupConfig":
                        this.ProcessRecord_RacLogBackupConfig();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + Op);
                }
           }
           catch (Exception ex)
           {
                this._logger.Flush();
                var error = new ErrorRecord(
                    ex,
                    "Invoke-RscQueryOracle",
                    ErrorCategory.InvalidOperation,
                    null);
                ThrowTerminatingError(error);
           }
        }

        // This parameter set invokes a single graphql operation:
        // oracleTopLevelDescendants.
        protected void ProcessRecord_TopLevelDescendant()
        {
            this._logger.name += " -TopLevelDescendant";
            // Invoke graphql operation oracleTopLevelDescendants
            InvokeQueryOracleTopLevelDescendants();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabases.
        protected void ProcessRecord_Database()
        {
            this._logger.name += " -Database";
            // Invoke graphql operation oracleDatabases
            InvokeQueryOracleDatabases();
        }

        // This parameter set invokes a single graphql operation:
        // oracleHost.
        protected void ProcessRecord_Host()
        {
            this._logger.name += " -Host";
            // Invoke graphql operation oracleHost
            InvokeQueryOracleHost();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRac.
        protected void ProcessRecord_Rac()
        {
            this._logger.name += " -Rac";
            // Invoke graphql operation oracleRac
            InvokeQueryOracleRac();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDataGuardGroup.
        protected void ProcessRecord_DataGuardGroup()
        {
            this._logger.name += " -DataGuardGroup";
            // Invoke graphql operation oracleDataGuardGroup
            InvokeQueryOracleDataGuardGroup();
        }

        // This parameter set invokes a single graphql operation:
        // oracleLiveMounts.
        protected void ProcessRecord_LiveMount()
        {
            this._logger.name += " -LiveMount";
            // Invoke graphql operation oracleLiveMounts
            InvokeQueryOracleLiveMounts();
        }

        // This parameter set invokes a single graphql operation:
        // oracleAcoParameters.
        protected void ProcessRecord_AcoParameter()
        {
            this._logger.name += " -AcoParameter";
            // Invoke graphql operation oracleAcoParameters
            InvokeQueryOracleAcoParameters();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRecoverableRanges.
        protected void ProcessRecord_RecoverableRange()
        {
            this._logger.name += " -RecoverableRange";
            // Invoke graphql operation oracleRecoverableRanges
            InvokeQueryOracleRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // oracleMissedRecoverableRanges.
        protected void ProcessRecord_MissedRecoverableRange()
        {
            this._logger.name += " -MissedRecoverableRange";
            // Invoke graphql operation oracleMissedRecoverableRanges
            InvokeQueryOracleMissedRecoverableRanges();
        }

        // This parameter set invokes a single graphql operation:
        // oracleMissedSnapshots.
        protected void ProcessRecord_MissedSnapshot()
        {
            this._logger.name += " -MissedSnapshot";
            // Invoke graphql operation oracleMissedSnapshots
            InvokeQueryOracleMissedSnapshots();
        }

        // This parameter set invokes a single graphql operation:
        // oracleAcoExampleDownloadLink.
        protected void ProcessRecord_AcoExampleDownloadLink()
        {
            this._logger.name += " -AcoExampleDownloadLink";
            // Invoke graphql operation oracleAcoExampleDownloadLink
            InvokeQueryOracleAcoExampleDownloadLink();
        }

        // This parameter set invokes a single graphql operation:
        // oraclePdbDetails.
        protected void ProcessRecord_PdbDetail()
        {
            this._logger.name += " -PdbDetail";
            // Invoke graphql operation oraclePdbDetails
            InvokeQueryOraclePdbDetails();
        }

        // This parameter set invokes a single graphql operation:
        // oracleHostLogBackupConfig.
        protected void ProcessRecord_HostLogBackupConfig()
        {
            this._logger.name += " -HostLogBackupConfig";
            // Invoke graphql operation oracleHostLogBackupConfig
            InvokeQueryOracleHostLogBackupConfig();
        }

        // This parameter set invokes a single graphql operation:
        // oracleDatabaseLogBackupConfig.
        protected void ProcessRecord_DatabaseLogBackupConfig()
        {
            this._logger.name += " -DatabaseLogBackupConfig";
            // Invoke graphql operation oracleDatabaseLogBackupConfig
            InvokeQueryOracleDatabaseLogBackupConfig();
        }

        // This parameter set invokes a single graphql operation:
        // oracleRacLogBackupConfig.
        protected void ProcessRecord_RacLogBackupConfig()
        {
            this._logger.name += " -RacLogBackupConfig";
            // Invoke graphql operation oracleRacLogBackupConfig
            InvokeQueryOracleRacLogBackupConfig();
        }


        // Invoke GraphQL Query:
        // oracleTopLevelDescendants(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //     filter: [Filter!]
        //   ): OracleTopLevelDescendantTypeConnection!
        protected void InvokeQueryOracleTopLevelDescendants()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
                Tuple.Create("filter", "[Filter!]"),
            };
            OracleTopLevelDescendantTypeConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleTopLevelDescendantTypeConnection)psObject.BaseObject;
                } else {
                    fields = (OracleTopLevelDescendantTypeConnection)this.Field;
                }
            }
            string document = Query.OracleTopLevelDescendants(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleTopLevelDescendants");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$typeFilter: [HierarchyObjectTypeEnum!],$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleTopLevelDescendants" + parameters + "{" + document + "}",
                OperationName = "QueryOracleTopLevelDescendants",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleTopLevelDescendantTypeConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleDatabases(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): OracleDatabaseConnection!
        protected void InvokeQueryOracleDatabases()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            OracleDatabaseConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleDatabaseConnection)psObject.BaseObject;
                } else {
                    fields = (OracleDatabaseConnection)this.Field;
                }
            }
            string document = Query.OracleDatabases(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleDatabases");
            var parameters = "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleDatabases" + parameters + "{" + document + "}",
                OperationName = "QueryOracleDatabases",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleDatabaseConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleHost(fid: UUID!): OracleHost!
        protected void InvokeQueryOracleHost()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            OracleHost? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleHost)psObject.BaseObject;
                } else {
                    fields = (OracleHost)this.Field;
                }
            }
            string document = Query.OracleHost(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleHost");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleHost" + parameters + "{" + document + "}",
                OperationName = "QueryOracleHost",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleHost", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleRac(fid: UUID!): OracleRac!
        protected void InvokeQueryOracleRac()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            OracleRac? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleRac)psObject.BaseObject;
                } else {
                    fields = (OracleRac)this.Field;
                }
            }
            string document = Query.OracleRac(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleRac");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleRac" + parameters + "{" + document + "}",
                OperationName = "QueryOracleRac",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleRac", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleDataGuardGroup(fid: UUID!): OracleDataGuardGroup!
        protected void InvokeQueryOracleDataGuardGroup()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            OracleDataGuardGroup? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleDataGuardGroup)psObject.BaseObject;
                } else {
                    fields = (OracleDataGuardGroup)this.Field;
                }
            }
            string document = Query.OracleDataGuardGroup(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleDataGuardGroup");
            var parameters = "($fid: UUID!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleDataGuardGroup" + parameters + "{" + document + "}",
                OperationName = "QueryOracleDataGuardGroup",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleDataGuardGroup", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleLiveMounts(
        //     first: Int
        //     after: String
        //     filters: [OracleLiveMountFilterInput!]
        //     sortBy: OracleLiveMountSortBy
        //   ): OracleLiveMountConnection!
        protected void InvokeQueryOracleLiveMounts()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("filters", "[OracleLiveMountFilterInput!]"),
                Tuple.Create("sortBy", "OracleLiveMountSortBy"),
            };
            OracleLiveMountConnection? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleLiveMountConnection)psObject.BaseObject;
                } else {
                    fields = (OracleLiveMountConnection)this.Field;
                }
            }
            string document = Query.OracleLiveMounts(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleLiveMounts");
            var parameters = "($first: Int,$after: String,$filters: [OracleLiveMountFilterInput!],$sortBy: OracleLiveMountSortBy)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleLiveMounts" + parameters + "{" + document + "}",
                OperationName = "QueryOracleLiveMounts",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleLiveMountConnection", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleAcoParameters(input: ClusterUuidWithDbIdInput!): OracleAcoParameterList!
        protected void InvokeQueryOracleAcoParameters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterUuidWithDbIdInput!"),
            };
            OracleAcoParameterList? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleAcoParameterList)psObject.BaseObject;
                } else {
                    fields = (OracleAcoParameterList)this.Field;
                }
            }
            string document = Query.OracleAcoParameters(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleAcoParameters");
            var parameters = "($input: ClusterUuidWithDbIdInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleAcoParameters" + parameters + "{" + document + "}",
                OperationName = "QueryOracleAcoParameters",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleAcoParameterList", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleRecoverableRanges(input: GetOracleDbRecoverableRangesInput!): OracleRecoverableRangeListResponse!
        protected void InvokeQueryOracleRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetOracleDbRecoverableRangesInput!"),
            };
            OracleRecoverableRangeListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleRecoverableRangeListResponse)psObject.BaseObject;
                } else {
                    fields = (OracleRecoverableRangeListResponse)this.Field;
                }
            }
            string document = Query.OracleRecoverableRanges(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleRecoverableRanges");
            var parameters = "($input: GetOracleDbRecoverableRangesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleRecoverableRanges" + parameters + "{" + document + "}",
                OperationName = "QueryOracleRecoverableRanges",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleRecoverableRangeListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleMissedRecoverableRanges(input: GetOracleDbMissedRecoverableRangesInput!): OracleMissedRecoverableRangeListResponse!
        protected void InvokeQueryOracleMissedRecoverableRanges()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetOracleDbMissedRecoverableRangesInput!"),
            };
            OracleMissedRecoverableRangeListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleMissedRecoverableRangeListResponse)psObject.BaseObject;
                } else {
                    fields = (OracleMissedRecoverableRangeListResponse)this.Field;
                }
            }
            string document = Query.OracleMissedRecoverableRanges(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleMissedRecoverableRanges");
            var parameters = "($input: GetOracleDbMissedRecoverableRangesInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleMissedRecoverableRanges" + parameters + "{" + document + "}",
                OperationName = "QueryOracleMissedRecoverableRanges",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleMissedRecoverableRangeListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleMissedSnapshots(input: GetMissedOracleDbSnapshotsInput!): MissedSnapshotListResponse!
        protected void InvokeQueryOracleMissedSnapshots()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "GetMissedOracleDbSnapshotsInput!"),
            };
            MissedSnapshotListResponse? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (MissedSnapshotListResponse)psObject.BaseObject;
                } else {
                    fields = (MissedSnapshotListResponse)this.Field;
                }
            }
            string document = Query.OracleMissedSnapshots(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleMissedSnapshots");
            var parameters = "($input: GetMissedOracleDbSnapshotsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleMissedSnapshots" + parameters + "{" + document + "}",
                OperationName = "QueryOracleMissedSnapshots",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "MissedSnapshotListResponse", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleAcoExampleDownloadLink(input: ClusterUuidWithDbIdInput!): OracleFileDownloadLink!
        protected void InvokeQueryOracleAcoExampleDownloadLink()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "ClusterUuidWithDbIdInput!"),
            };
            OracleFileDownloadLink? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleFileDownloadLink)psObject.BaseObject;
                } else {
                    fields = (OracleFileDownloadLink)this.Field;
                }
            }
            string document = Query.OracleAcoExampleDownloadLink(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleAcoExampleDownloadLink");
            var parameters = "($input: ClusterUuidWithDbIdInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleAcoExampleDownloadLink" + parameters + "{" + document + "}",
                OperationName = "QueryOracleAcoExampleDownloadLink",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleFileDownloadLink", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oraclePdbDetails(input: OraclePdbDetailsInput!): OraclePdbDetails!
        protected void InvokeQueryOraclePdbDetails()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OraclePdbDetailsInput!"),
            };
            OraclePdbDetails? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OraclePdbDetails)psObject.BaseObject;
                } else {
                    fields = (OraclePdbDetails)this.Field;
                }
            }
            string document = Query.OraclePdbDetails(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OraclePdbDetails");
            var parameters = "($input: OraclePdbDetailsInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOraclePdbDetails" + parameters + "{" + document + "}",
                OperationName = "QueryOraclePdbDetails",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OraclePdbDetails", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleHostLogBackupConfig(input: OracleHostInput!): OracleLogBackupConfig!
        protected void InvokeQueryOracleHostLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleHostInput!"),
            };
            OracleLogBackupConfig? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleLogBackupConfig)psObject.BaseObject;
                } else {
                    fields = (OracleLogBackupConfig)this.Field;
                }
            }
            string document = Query.OracleHostLogBackupConfig(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleHostLogBackupConfig");
            var parameters = "($input: OracleHostInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleHostLogBackupConfig" + parameters + "{" + document + "}",
                OperationName = "QueryOracleHostLogBackupConfig",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleLogBackupConfig", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleDatabaseLogBackupConfig(input: OracleDbInput!): OracleLogBackupConfig!
        protected void InvokeQueryOracleDatabaseLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleDbInput!"),
            };
            OracleLogBackupConfig? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleLogBackupConfig)psObject.BaseObject;
                } else {
                    fields = (OracleLogBackupConfig)this.Field;
                }
            }
            string document = Query.OracleDatabaseLogBackupConfig(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleDatabaseLogBackupConfig");
            var parameters = "($input: OracleDbInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleDatabaseLogBackupConfig" + parameters + "{" + document + "}",
                OperationName = "QueryOracleDatabaseLogBackupConfig",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleLogBackupConfig", this._logger, GetMetricTags());
            WriteObject(result, true);
        }

        // Invoke GraphQL Query:
        // oracleRacLogBackupConfig(input: OracleRacInput!): OracleLogBackupConfig!
        protected void InvokeQueryOracleRacLogBackupConfig()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "OracleRacInput!"),
            };
            OracleLogBackupConfig? fields = null ;
            if (this.Field != null)
            {
                if (this.Field is PSObject psObject) {
                    fields = (OracleLogBackupConfig)psObject.BaseObject;
                } else {
                    fields = (OracleLogBackupConfig)this.Field;
                }
            }
            string document = Query.OracleRacLogBackupConfig(ref fields);
            this._input.Initialize(argDefs, fields, "Query.OracleRacLogBackupConfig");
            var parameters = "($input: OracleRacInput!)\n";
            var request = new GraphQL.GraphQLRequest
            {
                Query = "query QueryOracleRacLogBackupConfig" + parameters + "{" + document + "}",
                OperationName = "QueryOracleRacLogBackupConfig",
            };
            OperationVariableSet vars = new();
            if (this.GetInputs) {
                this._logger.Debug("Query: " + request.Query);
                this.WriteObject(this._input);
                return;
            }
            vars.Variables = this._input.GetArgDict();
            var result = this._rbkClient.Invoke(
                request, vars, "OracleLogBackupConfig", this._logger, GetMetricTags());
            WriteObject(result, true);
        }


    } // class Invoke_RscQueryOracle
}
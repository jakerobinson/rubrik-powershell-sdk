// New-RscQuerySla.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Management.Automation;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using RubrikSecurityCloud;
using RubrikSecurityCloud.Types;
using RubrikSecurityCloud.NetSDK.Client;
using RubrikSecurityCloud.PowerShell.Private;

// ignore warning 'Missing XML comment'
#pragma warning disable 1591

namespace RubrikSecurityCloud.PowerShell.Cmdlets
{
    /// <summary>
    /// Create a new RscQuery object for any of the 30
    /// operations in the 'SLA' API domain:
    /// ArchivalValidationWarnings, AuditDetail, CdpVmNames, ClusterDomainFilterList, ClusterDomains, ClusterGlobals, ClustersWithSwitchInfo, ConflictObjects, ConflictObjectsWithParents, CountOfObjectsProtected, CurrentAutoMigrationState, Domain, DomainWithWarnings, DomainWithWarningsList, Domains, DownloadWithReplicationCsv, GlobalDomainsWithExternalReplicationTargets, GlobalFilterList, GlobalStatuses, IofilterStatuses, ManagedVolume, ManagedVolumes, NcdComplianceData, Partials, PendingsToBeUpgraded, ProtectedClustersForGlobal, QueryClustersWithNotSyncableReasons, SourceClusters, SummariesByIds, or VerifyWithReplicationToCluster.
    /// </summary>
    /// <description>
    /// New-RscQuerySla creates a new
    /// query object for operations
    /// in the 'SLA' API domain. It only creates a data structure,
    /// it does not execute the operation. This cmdlet does not need a
    /// connection to run. To execute the operation, either call Invoke()
    /// on the object returned by this cmdlet, or pass the object to
    /// Invoke-Rsc.
    /// There are 30 operations
    /// in the 'SLA' API domain. Select the operation this
    /// query is for by specifying the appropriate value for the
    /// -Operation parameter;
    /// one of: ArchivalValidationWarnings, AuditDetail, CdpVmNames, ClusterDomainFilterList, ClusterDomains, ClusterGlobals, ClustersWithSwitchInfo, ConflictObjects, ConflictObjectsWithParents, CountOfObjectsProtected, CurrentAutoMigrationState, Domain, DomainWithWarnings, DomainWithWarningsList, Domains, DownloadWithReplicationCsv, GlobalDomainsWithExternalReplicationTargets, GlobalFilterList, GlobalStatuses, IofilterStatuses, ManagedVolume, ManagedVolumes, NcdComplianceData, Partials, PendingsToBeUpgraded, ProtectedClustersForGlobal, QueryClustersWithNotSyncableReasons, SourceClusters, SummariesByIds, or VerifyWithReplicationToCluster.
    /// Each operation has its own set of variables that can be set with
    /// the -Var parameter. For more info about the variables, 
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQuerySla -ArchivalValidationWarnings).Info().
    /// Each operation also has its own set of fields that can be
    /// selected for retrieval. If you do not specify any fields,
    /// a set of default fields will be selected. The selection is
    /// rule-based, and tries to select the most commonly used fields.
    /// For example if a field is named 'id' or 'name', 
    /// it will be selected. If you give -FieldProfile DETAIL, then
    /// another set of rules will be used to select more fields on top
    /// of the default fields. The set of rules for selecting fields
    /// is called a field profile. You can specify a field profile
    /// with the -FieldProfile parameter. You can add or remove fields
    /// from the field profile with the -AddField and -RemoveField
    /// parameters. If you end up with too many -AddField and -RemoveField
    /// parameters, you can list them in a text file, one per line,
    /// with a '+' or '-' prefix, and pass the file name to the
    /// -FilePatch parameter. Profiles and Patches are one way to
    /// customize the fields that are selected. Another way is to
    /// specify the fields by passing the -Field parameter an object
    /// that contains the fields you want to select as properties.
    /// Any property that is not null in that object is interpreted
    /// as a field to select
    /// (and the actual values they are set to do not matter).
    /// The [RubrikSecurityCloud.Types] namespace
    /// contains a set of classes that you can use to specify fields.
    /// To know what [RubrikSecurityCloud.Types] object to use
    /// for a specific operation,
    /// call Info() on the object returned by this cmdlet, for example:
    /// (New-RscQuerySla -ArchivalValidationWarnings).Info().
    /// You can combine a -Field parameter with patching parameters.
    /// -Field is applied first, then -FilePatch, -AddField and -RemoveField.
    ///
    /// </description>
    ///
    /// <example>
    /// Runs the ArchivalValidationWarnings operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ArchivalValidationWarnings
    /// 
    /// $query = New-RscQuerySla -ArchivalValidationWarnings
    /// 
    /// # REQUIRED
    /// $query.Var.input = @{
    /// 	# OPTIONAL
    /// 	snapshotSchedule = @{
    /// 		# OPTIONAL
    /// 		minute = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		hourly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		daily = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 		}
    /// 		# OPTIONAL
    /// 		weekly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfWeek = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		monthly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfMonth = $someDayOfMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfMonth]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		quarterly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfQuarter = $someDayOfQuarter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfQuarter]) for enum values.
    /// 			# OPTIONAL
    /// 			quarterStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
    /// 		}
    /// 		# OPTIONAL
    /// 		yearly = @{
    /// 			# OPTIONAL
    /// 			basicSchedule = @{
    /// 				# OPTIONAL
    /// 				frequency = $someInt
    /// 				# OPTIONAL
    /// 				retention = $someInt
    /// 				# OPTIONAL
    /// 				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 			}
    /// 			# OPTIONAL
    /// 			dayOfYear = $someDayOfYear # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfYear]) for enum values.
    /// 			# OPTIONAL
    /// 			yearStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
    /// 		}
    /// 	}
    /// 	# OPTIONAL
    /// 	archivalThreshold = $someInt
    /// 	# OPTIONAL
    /// 	archivalThresholdUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 	# OPTIONAL
    /// 	archivalGroupId = $someString
    /// 	# OPTIONAL
    /// 	archivalLocationToClusterMapping = @(
    /// 		@{
    /// 			# OPTIONAL
    /// 			clusterUuid = $someString
    /// 			# OPTIONAL
    /// 			locationId = $someString
    /// 		}
    /// 	)
    /// 	# OPTIONAL
    /// 	frequencies = @(
    /// 		$someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
    /// 	)
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaArchivalValidationWithWarnings
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the AuditDetail operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: AuditDetail
    /// 
    /// $query = New-RscQuerySla -AuditDetail
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.SlaId = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someSLAAuditDetailFilterFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SLAAuditDetailFilterFieldEnum]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.timezone = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;SlaAuditDetail&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CdpVmNames operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: CdpVmNames
    /// 
    /// $query = New-RscQuerySla -CdpVmNames
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;System.String&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterDomainFilterList operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ClusterDomainFilterList
    /// 
    /// $query = New-RscQuerySla -ClusterDomainFilterList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterSlaDomainForFilterConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterDomains operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ClusterDomains
    /// 
    /// $query = New-RscQuerySla -ClusterDomains
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterSlaDomainConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClusterGlobals operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ClusterGlobals
    /// 
    /// $query = New-RscQuerySla -ClusterGlobals
    /// 
    /// # REQUIRED
    /// $query.Var.cdmClusterUUID = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;SlaInfo&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ClustersWithSwitchInfo operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ClustersWithSwitchInfo
    /// 
    /// $query = New-RscQuerySla -ClustersWithSwitchInfo
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClustersWithSlaSwitchInfo
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ConflictObjects operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ConflictObjects
    /// 
    /// $query = New-RscQuerySla -ConflictObjects
    /// 
    /// # REQUIRED
    /// $query.Var.fids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;HierarchyObject&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ConflictObjectsWithParents operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ConflictObjectsWithParents
    /// 
    /// $query = New-RscQuerySla -ConflictObjectsWithParents
    /// 
    /// # REQUIRED
    /// $query.Var.fids = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;SlaConflictObjectsWithParent&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CountOfObjectsProtected operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: CountOfObjectsProtected
    /// 
    /// $query = New-RscQuerySla -CountOfObjectsProtected
    /// 
    /// # OPTIONAL
    /// $query.Var.rootOptionalFid = $someString
    /// # REQUIRED
    /// $query.Var.slaIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.typeFilter = @(
    /// 	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: CountOfObjectsProtectedBySlAsResult
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the CurrentAutoMigrationState operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: CurrentAutoMigrationState
    /// 
    /// $query = New-RscQuerySla -CurrentAutoMigrationState
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaAutoMigrationStateInfo
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Domain operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: Domain
    /// 
    /// $query = New-RscQuerySla -Domain
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// # OPTIONAL
    /// $query.Var.shouldShowSyncStatus = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowUpgradeInfo = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowPausedClusters = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaDomain
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DomainWithWarnings operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: DomainWithWarnings
    /// 
    /// $query = New-RscQuerySla -DomainWithWarnings
    /// 
    /// # REQUIRED
    /// $query.Var.id = $someString
    /// # REQUIRED
    /// $query.Var.objectIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.applicableSnappableTypes = @(
    /// 	$someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaDomainWithWarnings
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DomainWithWarningsList operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: DomainWithWarningsList
    /// 
    /// $query = New-RscQuerySla -DomainWithWarningsList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someGlobalSlaQueryFilterInputField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		objectTypeList = @(
    /// 			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.objectIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.applicableSnappableTypes = @(
    /// 	$someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
    /// )
    /// # OPTIONAL
    /// $query.Var.snapshotIds = @(
    /// 	$someString
    /// )
    /// # OPTIONAL
    /// $query.Var.operation = $someSlaWarningsOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaWarningsOperation]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;SlaDomainWithWarnings&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Domains operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: Domains
    /// 
    /// $query = New-RscQuerySla -Domains
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someGlobalSlaQueryFilterInputField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		objectTypeList = @(
    /// 			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.contextFilterInput = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		field = $someString
    /// 		# REQUIRED
    /// 		text = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.shouldShowSyncStatus = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowProtectedObjectCount = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowUpgradeInfo = $someBoolean
    /// # OPTIONAL
    /// $query.Var.showRemoteSlas = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowPausedClusters = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaDomainConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the DownloadWithReplicationCsv operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: DownloadWithReplicationCsv
    /// 
    /// $query = New-RscQuerySla -DownloadWithReplicationCsv
    /// 
    /// # REQUIRED
    /// $query.Var.cdmClusterUUID = $someString
    /// # REQUIRED
    /// $query.Var.includeArchived = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: DownloadSlaWithReplicationCsvReply
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GlobalDomainsWithExternalReplicationTargets operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: GlobalDomainsWithExternalReplicationTargets
    /// 
    /// $query = New-RscQuerySla -GlobalDomainsWithExternalReplicationTargets
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaWithExternalReplicationTargetSummaryConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GlobalFilterList operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: GlobalFilterList
    /// 
    /// $query = New-RscQuerySla -GlobalFilterList
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someGlobalSlaQueryFilterInputField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// 		# OPTIONAL
    /// 		objectTypeList = @(
    /// 			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		textList = @(
    /// 			$someString
    /// 		)
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
    /// # OPTIONAL
    /// $query.Var.contextFilterInput = @(
    /// 	@{
    /// 		# REQUIRED
    /// 		field = $someString
    /// 		# REQUIRED
    /// 		text = $someString
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.shouldShowSyncStatus = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowProtectedObjectCount = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowUpgradeInfo = $someBoolean
    /// # OPTIONAL
    /// $query.Var.showRemoteSlas = $someBoolean
    /// # OPTIONAL
    /// $query.Var.shouldShowPausedClusters = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GlobalSlaForFilterConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the GlobalStatuses operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: GlobalStatuses
    /// 
    /// $query = New-RscQuerySla -GlobalStatuses
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someSlaStatusFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaStatusFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		text = $someString
    /// }
    /// )
    /// # REQUIRED
    /// $query.Var.SlaId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: GlobalSlaStatusConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the IofilterStatuses operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: IofilterStatuses
    /// 
    /// $query = New-RscQuerySla -IofilterStatuses
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;ComputeClusterIofilterStatus&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ManagedVolume operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ManagedVolume
    /// 
    /// $query = New-RscQuerySla -ManagedVolume
    /// 
    /// # REQUIRED
    /// $query.Var.fid = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ManagedVolume
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ManagedVolumes operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ManagedVolumes
    /// 
    /// $query = New-RscQuerySla -ManagedVolumes
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# OPTIONAL
    /// 		tagFilterParams = @(
    /// 			@{
    /// 				# OPTIONAL
    /// 				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
    /// 				# OPTIONAL
    /// 				tagKey = $someString
    /// 				# OPTIONAL
    /// 				tagValue = $someString
    /// 			}
    /// 		)
    /// 		# OPTIONAL
    /// 		objectTypeFilterParams = @(
    /// 			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		awsNativeProtectionFeatureNames = @(
    /// 			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		isNegative = $someBoolean
    /// 		# OPTIONAL
    /// 		isSlowSearchEnabled = $someBoolean
    /// 		# OPTIONAL
    /// 		azureNativeProtectionFeatureNames = @(
    /// 			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
    /// 		)
    /// 		# OPTIONAL
    /// 		unmanagedObjectAvailabilityFilter = @(
    /// 			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
    /// 		)
    /// }
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ManagedVolumeConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the NcdComplianceData operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: NcdComplianceData
    /// 
    /// $query = New-RscQuerySla -NcdComplianceData
    /// 
    /// # REQUIRED
    /// $query.Var.clusters = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;NcdSlaComplianceData&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the Partials operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: Partials
    /// 
    /// $query = New-RscQuerySla -Partials
    /// 
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	shouldShowClusterSlasOnly = $someBoolean
    /// 	# OPTIONAL
    /// 	shouldIncludeRemoteSlas = $someBoolean
    /// 	# OPTIONAL
    /// 	slaObjectTypeFilter = @{
    /// 		# OPTIONAL
    /// 		isValid = $someBoolean
    /// 		# OPTIONAL
    /// 		objectTypeList = @(
    /// 			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
    /// 		)
    /// 	}
    /// }
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PartialSlaSummaries
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the PendingsToBeUpgraded operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: PendingsToBeUpgraded
    /// 
    /// $query = New-RscQuerySla -PendingsToBeUpgraded
    /// 
    /// # No variables for this query.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: PendingSlAsToBeUpgradedRes
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the ProtectedClustersForGlobal operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: ProtectedClustersForGlobal
    /// 
    /// $query = New-RscQuerySla -ProtectedClustersForGlobal
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # REQUIRED
    /// $query.Var.slaId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the QueryClustersWithNotSyncableReasons operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: QueryClustersWithNotSyncableReasons
    /// 
    /// $query = New-RscQuerySla -QueryClustersWithNotSyncableReasons
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = @{
    /// 	# OPTIONAL
    /// 	field = $someQueryClustersSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.QueryClustersSortByField]) for enum values.
    /// 	# OPTIONAL
    /// 	order = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// }
    /// # OPTIONAL
    /// $query.Var.filter = @{
    /// 	# OPTIONAL
    /// 	field = $someQueryClusterFilterByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.QueryClusterFilterByField]) for enum values.
    /// 	# OPTIONAL
    /// 	text = $someString
    /// }
    /// # REQUIRED
    /// $query.Var.slaId = $someString
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: ClusterInfoWithNotSyncableReasonsConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SourceClusters operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: SourceClusters
    /// 
    /// $query = New-RscQuerySla -SourceClusters
    /// 
    /// # OPTIONAL
    /// $query.Var.first = $someInt
    /// # OPTIONAL
    /// $query.Var.after = $someString
    /// # OPTIONAL
    /// $query.Var.last = $someInt
    /// # OPTIONAL
    /// $query.Var.before = $someString
    /// # OPTIONAL
    /// $query.Var.sortBy = $someSlaSourceClustersSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaSourceClustersSortByField]) for enum values.
    /// # OPTIONAL
    /// $query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
    /// # OPTIONAL
    /// $query.Var.filter = @(
    /// 	@{
    /// 		# OPTIONAL
    /// 		texts = @(
    /// 			$someString
    /// 		)
    /// 		# REQUIRED
    /// 		field = $someSlaSourceClustersFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaSourceClustersFilterField]) for enum values.
    /// }
    /// )
    /// # OPTIONAL
    /// $query.Var.isArchivalSelected = $someBoolean
    /// # OPTIONAL
    /// $query.Var.selectedReplication = $someSlaReplicationConfiguration # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaReplicationConfiguration]) for enum values.
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: SlaSourceClustersSelectionInfoConnection
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the SummariesByIds operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: SummariesByIds
    /// 
    /// $query = New-RscQuerySla -SummariesByIds
    /// 
    /// # REQUIRED
    /// $query.Var.slaIds = @(
    /// 	$someString
    /// )
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: List&lt;SlaDomain&gt;
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    /// <example>
    /// Runs the VerifyWithReplicationToCluster operation
    /// of the 'SLA' API domain.
    /// <code>
    /// PS &gt;
    ///
    /// 
    /// # Create an RscQuery object for:
    /// # API Domain:    Sla
    /// # API Operation: VerifyWithReplicationToCluster
    /// 
    /// $query = New-RscQuerySla -VerifyWithReplicationToCluster
    /// 
    /// # REQUIRED
    /// $query.Var.cdmClusterUUID = $someString
    /// # REQUIRED
    /// $query.Var.includeArchived = $someBoolean
    /// 
    /// # Execute the query
    /// 
    /// $result = $query | Invoke-Rsc
    /// 
    /// Write-Host $result.GetType().Name # prints: VerifySlaWithReplicationToClusterResponse
    /// 
    /// 
    /// 
    /// </code>
    ///
    /// </example>
    ///
    [CmdletBinding()]
    [Cmdlet(
        "New",
        "RscQuerySla",
        DefaultParameterSetName = "Operation")
    ]
    public class New_RscQuerySla : RscGqlPSCmdlet
    {
        [Parameter(
            Mandatory = true, 
            ParameterSetName = "Operation",
            HelpMessage = "API Operation. The set of operations depends on the API domain. See reference at: https://github.com/rubrikinc/rubrik-powershell-sdk/blob/main/docs/domains_and_operations.md",
            Position = 0,
            ValueFromPipelineByPropertyName = true,
            ValueFromPipeline = true)]
            [ValidateSet(
                "ArchivalValidationWarnings",
                "AuditDetail",
                "CdpVmNames",
                "ClusterDomainFilterList",
                "ClusterDomains",
                "ClusterGlobals",
                "ClustersWithSwitchInfo",
                "ConflictObjects",
                "ConflictObjectsWithParents",
                "CountOfObjectsProtected",
                "CurrentAutoMigrationState",
                "Domain",
                "DomainWithWarnings",
                "DomainWithWarningsList",
                "Domains",
                "DownloadWithReplicationCsv",
                "GlobalDomainsWithExternalReplicationTargets",
                "GlobalFilterList",
                "GlobalStatuses",
                "IofilterStatuses",
                "ManagedVolume",
                "ManagedVolumes",
                "NcdComplianceData",
                "Partials",
                "PendingsToBeUpgraded",
                "ProtectedClustersForGlobal",
                "QueryClustersWithNotSyncableReasons",
                "SourceClusters",
                "SummariesByIds",
                "VerifyWithReplicationToCluster",
                IgnoreCase = true)]
        public string Operation { get; set; } = "";

        internal override string GetOperationParameter()
        {
            return this.Operation;
        }

        protected override void ProcessRecord()
        {
            base.ProcessRecord();
            try
            {
                switch(this.GetOp().OpName())
                {
                    case "ArchivalValidationWarnings":
                        this.ProcessRecord_ArchivalValidationWarnings();
                        break;
                    case "AuditDetail":
                        this.ProcessRecord_AuditDetail();
                        break;
                    case "CdpVmNames":
                        this.ProcessRecord_CdpVmNames();
                        break;
                    case "ClusterDomainFilterList":
                        this.ProcessRecord_ClusterDomainFilterList();
                        break;
                    case "ClusterDomains":
                        this.ProcessRecord_ClusterDomains();
                        break;
                    case "ClusterGlobals":
                        this.ProcessRecord_ClusterGlobals();
                        break;
                    case "ClustersWithSwitchInfo":
                        this.ProcessRecord_ClustersWithSwitchInfo();
                        break;
                    case "ConflictObjects":
                        this.ProcessRecord_ConflictObjects();
                        break;
                    case "ConflictObjectsWithParents":
                        this.ProcessRecord_ConflictObjectsWithParents();
                        break;
                    case "CountOfObjectsProtected":
                        this.ProcessRecord_CountOfObjectsProtected();
                        break;
                    case "CurrentAutoMigrationState":
                        this.ProcessRecord_CurrentAutoMigrationState();
                        break;
                    case "Domain":
                        this.ProcessRecord_Domain();
                        break;
                    case "DomainWithWarnings":
                        this.ProcessRecord_DomainWithWarnings();
                        break;
                    case "DomainWithWarningsList":
                        this.ProcessRecord_DomainWithWarningsList();
                        break;
                    case "Domains":
                        this.ProcessRecord_Domains();
                        break;
                    case "DownloadWithReplicationCsv":
                        this.ProcessRecord_DownloadWithReplicationCsv();
                        break;
                    case "GlobalDomainsWithExternalReplicationTargets":
                        this.ProcessRecord_GlobalDomainsWithExternalReplicationTargets();
                        break;
                    case "GlobalFilterList":
                        this.ProcessRecord_GlobalFilterList();
                        break;
                    case "GlobalStatuses":
                        this.ProcessRecord_GlobalStatuses();
                        break;
                    case "IofilterStatuses":
                        this.ProcessRecord_IofilterStatuses();
                        break;
                    case "ManagedVolume":
                        this.ProcessRecord_ManagedVolume();
                        break;
                    case "ManagedVolumes":
                        this.ProcessRecord_ManagedVolumes();
                        break;
                    case "NcdComplianceData":
                        this.ProcessRecord_NcdComplianceData();
                        break;
                    case "Partials":
                        this.ProcessRecord_Partials();
                        break;
                    case "PendingsToBeUpgraded":
                        this.ProcessRecord_PendingsToBeUpgraded();
                        break;
                    case "ProtectedClustersForGlobal":
                        this.ProcessRecord_ProtectedClustersForGlobal();
                        break;
                    case "QueryClustersWithNotSyncableReasons":
                        this.ProcessRecord_QueryClustersWithNotSyncableReasons();
                        break;
                    case "SourceClusters":
                        this.ProcessRecord_SourceClusters();
                        break;
                    case "SummariesByIds":
                        this.ProcessRecord_SummariesByIds();
                        break;
                    case "VerifyWithReplicationToCluster":
                        this.ProcessRecord_VerifyWithReplicationToCluster();
                        break;
                    default:
                        throw new Exception("Unknown Operation " + this.GetOp().OpName());
                }
           }
           catch (Exception ex)
           {
                ThrowTerminatingException(ex);
           }
        }

        // This parameter set invokes a single graphql operation:
        // slaArchivalValidationWarnings.
        internal void ProcessRecord_ArchivalValidationWarnings()
        {
            this._logger.name += " -ArchivalValidationWarnings";
            // Create new graphql operation slaArchivalValidationWarnings
            InitQuerySlaArchivalValidationWarnings();
        }

        // This parameter set invokes a single graphql operation:
        // slaAuditDetail.
        internal void ProcessRecord_AuditDetail()
        {
            this._logger.name += " -AuditDetail";
            // Create new graphql operation slaAuditDetail
            InitQuerySlaAuditDetail();
        }

        // This parameter set invokes a single graphql operation:
        // allCdpSlaVmNames.
        internal void ProcessRecord_CdpVmNames()
        {
            this._logger.name += " -CdpVmNames";
            // Create new graphql operation allCdpSlaVmNames
            InitQueryAllCdpSlaVmNames();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomainFilterConnection.
        internal void ProcessRecord_ClusterDomainFilterList()
        {
            this._logger.name += " -ClusterDomainFilterList";
            // Create new graphql operation clusterSlaDomainFilterConnection
            InitQueryClusterSlaDomainFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // clusterSlaDomains.
        internal void ProcessRecord_ClusterDomains()
        {
            this._logger.name += " -ClusterDomains";
            // Create new graphql operation clusterSlaDomains
            InitQueryClusterSlaDomains();
        }

        // This parameter set invokes a single graphql operation:
        // allClusterGlobalSlas.
        internal void ProcessRecord_ClusterGlobals()
        {
            this._logger.name += " -ClusterGlobals";
            // Create new graphql operation allClusterGlobalSlas
            InitQueryAllClusterGlobalSlas();
        }

        // This parameter set invokes a single graphql operation:
        // clustersWithSLASwitchInfo.
        internal void ProcessRecord_ClustersWithSwitchInfo()
        {
            this._logger.name += " -ClustersWithSwitchInfo";
            // Create new graphql operation clustersWithSLASwitchInfo
            InitQueryClustersWithSlaSwitchInfo();
        }

        // This parameter set invokes a single graphql operation:
        // slaConflictObjects.
        internal void ProcessRecord_ConflictObjects()
        {
            this._logger.name += " -ConflictObjects";
            // Create new graphql operation slaConflictObjects
            InitQuerySlaConflictObjects();
        }

        // This parameter set invokes a single graphql operation:
        // slaConflictObjectsWithParents.
        internal void ProcessRecord_ConflictObjectsWithParents()
        {
            this._logger.name += " -ConflictObjectsWithParents";
            // Create new graphql operation slaConflictObjectsWithParents
            InitQuerySlaConflictObjectsWithParents();
        }

        // This parameter set invokes a single graphql operation:
        // countOfObjectsProtectedBySlas.
        internal void ProcessRecord_CountOfObjectsProtected()
        {
            this._logger.name += " -CountOfObjectsProtected";
            // Create new graphql operation countOfObjectsProtectedBySlas
            InitQueryCountOfObjectsProtectedBySlas();
        }

        // This parameter set invokes a single graphql operation:
        // currentSlaAutoMigrationState.
        internal void ProcessRecord_CurrentAutoMigrationState()
        {
            this._logger.name += " -CurrentAutoMigrationState";
            // Create new graphql operation currentSlaAutoMigrationState
            InitQueryCurrentSlaAutoMigrationState();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomain.
        internal void ProcessRecord_Domain()
        {
            this._logger.name += " -Domain";
            // Create new graphql operation slaDomain
            InitQuerySlaDomain();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomainWithWarnings.
        internal void ProcessRecord_DomainWithWarnings()
        {
            this._logger.name += " -DomainWithWarnings";
            // Create new graphql operation slaDomainWithWarnings
            InitQuerySlaDomainWithWarnings();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomainWithWarningsList.
        internal void ProcessRecord_DomainWithWarningsList()
        {
            this._logger.name += " -DomainWithWarningsList";
            // Create new graphql operation slaDomainWithWarningsList
            InitQuerySlaDomainWithWarningsList();
        }

        // This parameter set invokes a single graphql operation:
        // slaDomains.
        internal void ProcessRecord_Domains()
        {
            this._logger.name += " -Domains";
            // Create new graphql operation slaDomains
            InitQuerySlaDomains();
        }

        // This parameter set invokes a single graphql operation:
        // downloadSlaWithReplicationCsv.
        internal void ProcessRecord_DownloadWithReplicationCsv()
        {
            this._logger.name += " -DownloadWithReplicationCsv";
            // Create new graphql operation downloadSlaWithReplicationCsv
            InitQueryDownloadSlaWithReplicationCsv();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaDomainsWithExternalReplicationTargets.
        internal void ProcessRecord_GlobalDomainsWithExternalReplicationTargets()
        {
            this._logger.name += " -GlobalDomainsWithExternalReplicationTargets";
            // Create new graphql operation globalSlaDomainsWithExternalReplicationTargets
            InitQueryGlobalSlaDomainsWithExternalReplicationTargets();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaFilterConnection.
        internal void ProcessRecord_GlobalFilterList()
        {
            this._logger.name += " -GlobalFilterList";
            // Create new graphql operation globalSlaFilterConnection
            InitQueryGlobalSlaFilterConnection();
        }

        // This parameter set invokes a single graphql operation:
        // globalSlaStatuses.
        internal void ProcessRecord_GlobalStatuses()
        {
            this._logger.name += " -GlobalStatuses";
            // Create new graphql operation globalSlaStatuses
            InitQueryGlobalSlaStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // allSlaIofilterStatuses.
        internal void ProcessRecord_IofilterStatuses()
        {
            this._logger.name += " -IofilterStatuses";
            // Create new graphql operation allSlaIofilterStatuses
            InitQueryAllSlaIofilterStatuses();
        }

        // This parameter set invokes a single graphql operation:
        // slaManagedVolume.
        internal void ProcessRecord_ManagedVolume()
        {
            this._logger.name += " -ManagedVolume";
            // Create new graphql operation slaManagedVolume
            InitQuerySlaManagedVolume();
        }

        // This parameter set invokes a single graphql operation:
        // slaManagedVolumes.
        internal void ProcessRecord_ManagedVolumes()
        {
            this._logger.name += " -ManagedVolumes";
            // Create new graphql operation slaManagedVolumes
            InitQuerySlaManagedVolumes();
        }

        // This parameter set invokes a single graphql operation:
        // allNcdSlaComplianceData.
        internal void ProcessRecord_NcdComplianceData()
        {
            this._logger.name += " -NcdComplianceData";
            // Create new graphql operation allNcdSlaComplianceData
            InitQueryAllNcdSlaComplianceData();
        }

        // This parameter set invokes a single graphql operation:
        // partialSlas.
        internal void ProcessRecord_Partials()
        {
            this._logger.name += " -Partials";
            // Create new graphql operation partialSlas
            InitQueryPartialSlas();
        }

        // This parameter set invokes a single graphql operation:
        // pendingSlasToBeUpgraded.
        internal void ProcessRecord_PendingsToBeUpgraded()
        {
            this._logger.name += " -PendingsToBeUpgraded";
            // Create new graphql operation pendingSlasToBeUpgraded
            InitQueryPendingSlasToBeUpgraded();
        }

        // This parameter set invokes a single graphql operation:
        // protectedClustersForGlobalSla.
        internal void ProcessRecord_ProtectedClustersForGlobal()
        {
            this._logger.name += " -ProtectedClustersForGlobal";
            // Create new graphql operation protectedClustersForGlobalSla
            InitQueryProtectedClustersForGlobalSla();
        }

        // This parameter set invokes a single graphql operation:
        // queryClustersWithSLANotSyncableReasons.
        internal void ProcessRecord_QueryClustersWithNotSyncableReasons()
        {
            this._logger.name += " -QueryClustersWithNotSyncableReasons";
            // Create new graphql operation queryClustersWithSLANotSyncableReasons
            InitQueryQueryClustersWithSlaNotSyncableReasons();
        }

        // This parameter set invokes a single graphql operation:
        // slaSourceClusters.
        internal void ProcessRecord_SourceClusters()
        {
            this._logger.name += " -SourceClusters";
            // Create new graphql operation slaSourceClusters
            InitQuerySlaSourceClusters();
        }

        // This parameter set invokes a single graphql operation:
        // allSlaSummariesByIds.
        internal void ProcessRecord_SummariesByIds()
        {
            this._logger.name += " -SummariesByIds";
            // Create new graphql operation allSlaSummariesByIds
            InitQueryAllSlaSummariesByIds();
        }

        // This parameter set invokes a single graphql operation:
        // verifySlaWithReplicationToCluster.
        internal void ProcessRecord_VerifyWithReplicationToCluster()
        {
            this._logger.name += " -VerifyWithReplicationToCluster";
            // Create new graphql operation verifySlaWithReplicationToCluster
            InitQueryVerifySlaWithReplicationToCluster();
        }


        // Create new GraphQL Query:
        // slaArchivalValidationWarnings(input: SlaArchivalWarningsInput!): SlaArchivalValidationWithWarnings!
        internal void InitQuerySlaArchivalValidationWarnings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("input", "SlaArchivalWarningsInput!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaArchivalValidationWarnings",
                "($input: SlaArchivalWarningsInput!)",
                "SlaArchivalValidationWithWarnings",
                Query.SlaArchivalValidationWarnings,
                Query.SlaArchivalValidationWarningsFieldSpec,
                @"# REQUIRED
$query.Var.input = @{
	# OPTIONAL
	snapshotSchedule = @{
		# OPTIONAL
		minute = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		hourly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		daily = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
		}
		# OPTIONAL
		weekly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfWeek = $someDayOfWeek # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfWeek]) for enum values.
		}
		# OPTIONAL
		monthly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfMonth = $someDayOfMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfMonth]) for enum values.
		}
		# OPTIONAL
		quarterly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfQuarter = $someDayOfQuarter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfQuarter]) for enum values.
			# OPTIONAL
			quarterStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
		# OPTIONAL
		yearly = @{
			# OPTIONAL
			basicSchedule = @{
				# OPTIONAL
				frequency = $someInt
				# OPTIONAL
				retention = $someInt
				# OPTIONAL
				retentionUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
			}
			# OPTIONAL
			dayOfYear = $someDayOfYear # Call [Enum]::GetValues([RubrikSecurityCloud.Types.DayOfYear]) for enum values.
			# OPTIONAL
			yearStartMonth = $someMonth # Call [Enum]::GetValues([RubrikSecurityCloud.Types.Month]) for enum values.
		}
	}
	# OPTIONAL
	archivalThreshold = $someInt
	# OPTIONAL
	archivalThresholdUnit = $someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
	# OPTIONAL
	archivalGroupId = $someString
	# OPTIONAL
	archivalLocationToClusterMapping = @(
		@{
			# OPTIONAL
			clusterUuid = $someString
			# OPTIONAL
			locationId = $someString
		}
	)
	# OPTIONAL
	frequencies = @(
		$someRetentionUnit # Call [Enum]::GetValues([RubrikSecurityCloud.Types.RetentionUnit]) for enum values.
	)
}"
            );
        }

        // Create new GraphQL Query:
        // slaAuditDetail(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     SlaId: UUID!
        //     filter: [SLAAuditDetailFilterInput!]
        //     timezone: String
        //   ): [SlaAuditDetail!]!
        internal void InitQuerySlaAuditDetail()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("SlaId", "UUID!"),
                Tuple.Create("filter", "[SLAAuditDetailFilterInput!]"),
                Tuple.Create("timezone", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaAuditDetail",
                "($first: Int,$after: String,$last: Int,$before: String,$SlaId: UUID!,$filter: [SLAAuditDetailFilterInput!],$timezone: String)",
                "List<SlaAuditDetail>",
                Query.SlaAuditDetail,
                Query.SlaAuditDetailFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.SlaId = $someString
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someSLAAuditDetailFilterFieldEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SLAAuditDetailFilterFieldEnum]) for enum values.
		# OPTIONAL
		text = $someString
}
)
# OPTIONAL
$query.Var.timezone = $someString"
            );
        }

        // Create new GraphQL Query:
        // allCdpSlaVmNames(fid: UUID!): [String!]!
        internal void InitQueryAllCdpSlaVmNames()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllCdpSlaVmNames",
                "($fid: UUID!)",
                "List<System.String>",
                Query.AllCdpSlaVmNames,
                Query.AllCdpSlaVmNamesFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterSlaDomainFilterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ClusterSlaDomainForFilterConnection!
        internal void InitQueryClusterSlaDomainFilterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterSlaDomainFilterConnection",
                "($first: Int,$after: String,$last: Int,$before: String)",
                "ClusterSlaDomainForFilterConnection",
                Query.ClusterSlaDomainFilterConnection,
                Query.ClusterSlaDomainFilterConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // clusterSlaDomains(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //   ): ClusterSlaDomainConnection!
        internal void InitQueryClusterSlaDomains()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryClusterSlaDomains",
                "($first: Int,$after: String,$last: Int,$before: String)",
                "ClusterSlaDomainConnection",
                Query.ClusterSlaDomains,
                Query.ClusterSlaDomainsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString"
            );
        }

        // Create new GraphQL Query:
        // allClusterGlobalSlas(cdmClusterUUID: UUID!): [SlaInfo!]!
        internal void InitQueryAllClusterGlobalSlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllClusterGlobalSlas",
                "($cdmClusterUUID: UUID!)",
                "List<SlaInfo>",
                Query.AllClusterGlobalSlas,
                Query.AllClusterGlobalSlasFieldSpec,
                @"# REQUIRED
$query.Var.cdmClusterUUID = $someString"
            );
        }

        // Create new GraphQL Query:
        // clustersWithSLASwitchInfo: ClustersWithSlaSwitchInfo!
        internal void InitQueryClustersWithSlaSwitchInfo()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryClustersWithSlaSwitchInfo",
                "",
                "ClustersWithSlaSwitchInfo",
                Query.ClustersWithSlaSwitchInfo,
                Query.ClustersWithSlaSwitchInfoFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // slaConflictObjects(fids: [UUID!]!): [HierarchyObject!]!
        internal void InitQuerySlaConflictObjects()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaConflictObjects",
                "($fids: [UUID!]!)",
                "List<HierarchyObject>",
                Query.SlaConflictObjects,
                Query.SlaConflictObjectsFieldSpec,
                @"# REQUIRED
$query.Var.fids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // slaConflictObjectsWithParents(fids: [UUID!]!): [SlaConflictObjectsWithParent!]!
        internal void InitQuerySlaConflictObjectsWithParents()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fids", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaConflictObjectsWithParents",
                "($fids: [UUID!]!)",
                "List<SlaConflictObjectsWithParent>",
                Query.SlaConflictObjectsWithParents,
                Query.SlaConflictObjectsWithParentsFieldSpec,
                @"# REQUIRED
$query.Var.fids = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // countOfObjectsProtectedBySlas(
        //     rootOptionalFid: UUID
        //     slaIds: [UUID!]!
        //     filter: [Filter!]
        //     typeFilter: [HierarchyObjectTypeEnum!]
        //   ): CountOfObjectsProtectedBySLAsResult!
        internal void InitQueryCountOfObjectsProtectedBySlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("rootOptionalFid", "UUID"),
                Tuple.Create("slaIds", "[UUID!]!"),
                Tuple.Create("filter", "[Filter!]"),
                Tuple.Create("typeFilter", "[HierarchyObjectTypeEnum!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryCountOfObjectsProtectedBySlas",
                "($rootOptionalFid: UUID,$slaIds: [UUID!]!,$filter: [Filter!],$typeFilter: [HierarchyObjectTypeEnum!])",
                "CountOfObjectsProtectedBySlAsResult",
                Query.CountOfObjectsProtectedBySlas,
                Query.CountOfObjectsProtectedBySlasFieldSpec,
                @"# OPTIONAL
$query.Var.rootOptionalFid = $someString
# REQUIRED
$query.Var.slaIds = @(
	$someString
)
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)
# OPTIONAL
$query.Var.typeFilter = @(
	$someHierarchyObjectTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyObjectTypeEnum]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // currentSlaAutoMigrationState: SlaAutoMigrationStateInfo!
        internal void InitQueryCurrentSlaAutoMigrationState()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryCurrentSlaAutoMigrationState",
                "",
                "SlaAutoMigrationStateInfo",
                Query.CurrentSlaAutoMigrationState,
                Query.CurrentSlaAutoMigrationStateFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // slaDomain(
        //     id: UUID!
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     shouldShowPausedClusters: Boolean = false
        //   ): SlaDomain!
        internal void InitQuerySlaDomain()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomain",
                "($id: UUID!,$shouldShowSyncStatus: Boolean,$shouldShowUpgradeInfo: Boolean,$shouldShowPausedClusters: Boolean)",
                "SlaDomain",
                Query.SlaDomain,
                Query.SlaDomainFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString
# OPTIONAL
$query.Var.shouldShowSyncStatus = $someBoolean
# OPTIONAL
$query.Var.shouldShowUpgradeInfo = $someBoolean
# OPTIONAL
$query.Var.shouldShowPausedClusters = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // slaDomainWithWarnings(id: UUID!, objectIds: [UUID!]!, applicableSnappableTypes: [WorkloadLevelHierarchy!]): SlaDomainWithWarnings!
        internal void InitQuerySlaDomainWithWarnings()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("id", "UUID!"),
                Tuple.Create("objectIds", "[UUID!]!"),
                Tuple.Create("applicableSnappableTypes", "[WorkloadLevelHierarchy!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomainWithWarnings",
                "($id: UUID!,$objectIds: [UUID!]!,$applicableSnappableTypes: [WorkloadLevelHierarchy!])",
                "SlaDomainWithWarnings",
                Query.SlaDomainWithWarnings,
                Query.SlaDomainWithWarningsFieldSpec,
                @"# REQUIRED
$query.Var.id = $someString
# REQUIRED
$query.Var.objectIds = @(
	$someString
)
# OPTIONAL
$query.Var.applicableSnappableTypes = @(
	$someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)"
            );
        }

        // Create new GraphQL Query:
        // slaDomainWithWarningsList(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [GlobalSlaFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     objectIds: [UUID!]
        //     applicableSnappableTypes: [WorkloadLevelHierarchy!]
        //     snapshotIds: [UUID!]
        //     operation: SlaWarningsOperation
        //   ): [SlaDomainWithWarnings!]!
        internal void InitQuerySlaDomainWithWarningsList()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("objectIds", "[UUID!]"),
                Tuple.Create("applicableSnappableTypes", "[WorkloadLevelHierarchy!]"),
                Tuple.Create("snapshotIds", "[UUID!]"),
                Tuple.Create("operation", "SlaWarningsOperation"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomainWithWarningsList",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$objectIds: [UUID!],$applicableSnappableTypes: [WorkloadLevelHierarchy!],$snapshotIds: [UUID!],$operation: SlaWarningsOperation)",
                "List<SlaDomainWithWarnings>",
                Query.SlaDomainWithWarningsList,
                Query.SlaDomainWithWarningsListFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someGlobalSlaQueryFilterInputField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		objectTypeList = @(
			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$query.Var.objectIds = @(
	$someString
)
# OPTIONAL
$query.Var.applicableSnappableTypes = @(
	$someWorkloadLevelHierarchy # Call [Enum]::GetValues([RubrikSecurityCloud.Types.WorkloadLevelHierarchy]) for enum values.
)
# OPTIONAL
$query.Var.snapshotIds = @(
	$someString
)
# OPTIONAL
$query.Var.operation = $someSlaWarningsOperation # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaWarningsOperation]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // slaDomains(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [GlobalSlaFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     contextFilterInput: [ContextFilterInputField!]
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowProtectedObjectCount: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     showRemoteSlas: Boolean
        //     shouldShowPausedClusters: Boolean = false
        //   ): SlaDomainConnection!
        internal void InitQuerySlaDomains()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("contextFilterInput", "[ContextFilterInputField!]"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowProtectedObjectCount", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("showRemoteSlas", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaDomains",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)",
                "SlaDomainConnection",
                Query.SlaDomains,
                Query.SlaDomainsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someGlobalSlaQueryFilterInputField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		objectTypeList = @(
			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$query.Var.contextFilterInput = @(
	@{
		# REQUIRED
		field = $someString
		# REQUIRED
		text = $someString
}
)
# OPTIONAL
$query.Var.shouldShowSyncStatus = $someBoolean
# OPTIONAL
$query.Var.shouldShowProtectedObjectCount = $someBoolean
# OPTIONAL
$query.Var.shouldShowUpgradeInfo = $someBoolean
# OPTIONAL
$query.Var.showRemoteSlas = $someBoolean
# OPTIONAL
$query.Var.shouldShowPausedClusters = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // downloadSlaWithReplicationCsv(cdmClusterUUID: UUID!, includeArchived: Boolean!): DownloadSlaWithReplicationCsvReply!
        internal void InitQueryDownloadSlaWithReplicationCsv()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
                Tuple.Create("includeArchived", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryDownloadSlaWithReplicationCsv",
                "($cdmClusterUUID: UUID!,$includeArchived: Boolean!)",
                "DownloadSlaWithReplicationCsvReply",
                Query.DownloadSlaWithReplicationCsv,
                Query.DownloadSlaWithReplicationCsvFieldSpec,
                @"# REQUIRED
$query.Var.cdmClusterUUID = $someString
# REQUIRED
$query.Var.includeArchived = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // globalSlaDomainsWithExternalReplicationTargets(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //   ): SLAWithExternalReplicationTargetSummaryConnection!
        internal void InitQueryGlobalSlaDomainsWithExternalReplicationTargets()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalSlaDomainsWithExternalReplicationTargets",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder)",
                "SlaWithExternalReplicationTargetSummaryConnection",
                Query.GlobalSlaDomainsWithExternalReplicationTargets,
                Query.GlobalSlaDomainsWithExternalReplicationTargetsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // globalSlaFilterConnection(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaQuerySortByField
        //     sortOrder: SortOrder
        //     filter: [GlobalSlaFilterInput!]
        //     contextFilter: ContextFilterTypeEnum
        //     contextFilterInput: [ContextFilterInputField!]
        //     shouldShowSyncStatus: Boolean = false
        //     shouldShowProtectedObjectCount: Boolean = false
        //     shouldShowUpgradeInfo: Boolean = false
        //     showRemoteSlas: Boolean
        //     shouldShowPausedClusters: Boolean = false
        //   ): GlobalSlaForFilterConnection!
        internal void InitQueryGlobalSlaFilterConnection()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaQuerySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[GlobalSlaFilterInput!]"),
                Tuple.Create("contextFilter", "ContextFilterTypeEnum"),
                Tuple.Create("contextFilterInput", "[ContextFilterInputField!]"),
                Tuple.Create("shouldShowSyncStatus", "Boolean"),
                Tuple.Create("shouldShowProtectedObjectCount", "Boolean"),
                Tuple.Create("shouldShowUpgradeInfo", "Boolean"),
                Tuple.Create("showRemoteSlas", "Boolean"),
                Tuple.Create("shouldShowPausedClusters", "Boolean"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalSlaFilterConnection",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaQuerySortByField,$sortOrder: SortOrder,$filter: [GlobalSlaFilterInput!],$contextFilter: ContextFilterTypeEnum,$contextFilterInput: [ContextFilterInputField!],$shouldShowSyncStatus: Boolean,$shouldShowProtectedObjectCount: Boolean,$shouldShowUpgradeInfo: Boolean,$showRemoteSlas: Boolean,$shouldShowPausedClusters: Boolean)",
                "GlobalSlaForFilterConnection",
                Query.GlobalSlaFilterConnection,
                Query.GlobalSlaFilterConnectionFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someSlaQuerySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaQuerySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someGlobalSlaQueryFilterInputField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.GlobalSlaQueryFilterInputField]) for enum values.
		# OPTIONAL
		text = $someString
		# OPTIONAL
		objectTypeList = @(
			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
		# OPTIONAL
		textList = @(
			$someString
		)
}
)
# OPTIONAL
$query.Var.contextFilter = $someContextFilterTypeEnum # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ContextFilterTypeEnum]) for enum values.
# OPTIONAL
$query.Var.contextFilterInput = @(
	@{
		# REQUIRED
		field = $someString
		# REQUIRED
		text = $someString
}
)
# OPTIONAL
$query.Var.shouldShowSyncStatus = $someBoolean
# OPTIONAL
$query.Var.shouldShowProtectedObjectCount = $someBoolean
# OPTIONAL
$query.Var.shouldShowUpgradeInfo = $someBoolean
# OPTIONAL
$query.Var.showRemoteSlas = $someBoolean
# OPTIONAL
$query.Var.shouldShowPausedClusters = $someBoolean"
            );
        }

        // Create new GraphQL Query:
        // globalSlaStatuses(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     filter: [SlaStatusFilterInput!]
        //     SlaId: UUID!
        //   ): GlobalSlaStatusConnection!
        internal void InitQueryGlobalSlaStatuses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("filter", "[SlaStatusFilterInput!]"),
                Tuple.Create("SlaId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryGlobalSlaStatuses",
                "($first: Int,$after: String,$last: Int,$before: String,$filter: [SlaStatusFilterInput!],$SlaId: UUID!)",
                "GlobalSlaStatusConnection",
                Query.GlobalSlaStatuses,
                Query.GlobalSlaStatusesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someSlaStatusFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaStatusFilterField]) for enum values.
		# OPTIONAL
		text = $someString
}
)
# REQUIRED
$query.Var.SlaId = $someString"
            );
        }

        // Create new GraphQL Query:
        // allSlaIofilterStatuses(fid: UUID!): [ComputeClusterIofilterStatus!]!
        internal void InitQueryAllSlaIofilterStatuses()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSlaIofilterStatuses",
                "($fid: UUID!)",
                "List<ComputeClusterIofilterStatus>",
                Query.AllSlaIofilterStatuses,
                Query.AllSlaIofilterStatusesFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // slaManagedVolume(fid: UUID!): ManagedVolume!
        internal void InitQuerySlaManagedVolume()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("fid", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaManagedVolume",
                "($fid: UUID!)",
                "ManagedVolume",
                Query.SlaManagedVolume,
                Query.SlaManagedVolumeFieldSpec,
                @"# REQUIRED
$query.Var.fid = $someString"
            );
        }

        // Create new GraphQL Query:
        // slaManagedVolumes(
        //     first: Int
        //     after: String
        //     sortBy: HierarchySortByField
        //     sortOrder: SortOrder
        //     filter: [Filter!]
        //   ): ManagedVolumeConnection!
        internal void InitQuerySlaManagedVolumes()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("sortBy", "HierarchySortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[Filter!]"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaManagedVolumes",
                "($first: Int,$after: String,$sortBy: HierarchySortByField,$sortOrder: SortOrder,$filter: [Filter!])",
                "ManagedVolumeConnection",
                Query.SlaManagedVolumes,
                Query.SlaManagedVolumesFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.sortBy = $someHierarchySortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchySortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		field = $someHierarchyFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.HierarchyFilterField]) for enum values.
		# OPTIONAL
		texts = @(
			$someString
		)
		# OPTIONAL
		tagFilterParams = @(
			@{
				# OPTIONAL
				filterType = $someTagFilterType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.TagFilterType]) for enum values.
				# OPTIONAL
				tagKey = $someString
				# OPTIONAL
				tagValue = $someString
			}
		)
		# OPTIONAL
		objectTypeFilterParams = @(
			$someManagedObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.ManagedObjectType]) for enum values.
		)
		# OPTIONAL
		awsNativeProtectionFeatureNames = @(
			$someAwsNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AwsNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		isNegative = $someBoolean
		# OPTIONAL
		isSlowSearchEnabled = $someBoolean
		# OPTIONAL
		azureNativeProtectionFeatureNames = @(
			$someAzureNativeProtectionFeature # Call [Enum]::GetValues([RubrikSecurityCloud.Types.AzureNativeProtectionFeature]) for enum values.
		)
		# OPTIONAL
		unmanagedObjectAvailabilityFilter = @(
			$someUnmanagedObjectAvailabilityFilter # Call [Enum]::GetValues([RubrikSecurityCloud.Types.UnmanagedObjectAvailabilityFilter]) for enum values.
		)
}
)"
            );
        }

        // Create new GraphQL Query:
        // allNcdSlaComplianceData(clusters: [UUID!]!): [NcdSlaComplianceData!]!
        internal void InitQueryAllNcdSlaComplianceData()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("clusters", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllNcdSlaComplianceData",
                "($clusters: [UUID!]!)",
                "List<NcdSlaComplianceData>",
                Query.AllNcdSlaComplianceData,
                Query.AllNcdSlaComplianceDataFieldSpec,
                @"# REQUIRED
$query.Var.clusters = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // partialSlas(filter: PartialSlaFilterInput): PartialSlaSummaries!
        internal void InitQueryPartialSlas()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("filter", "PartialSlaFilterInput"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryPartialSlas",
                "($filter: PartialSlaFilterInput)",
                "PartialSlaSummaries",
                Query.PartialSlas,
                Query.PartialSlasFieldSpec,
                @"# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	shouldShowClusterSlasOnly = $someBoolean
	# OPTIONAL
	shouldIncludeRemoteSlas = $someBoolean
	# OPTIONAL
	slaObjectTypeFilter = @{
		# OPTIONAL
		isValid = $someBoolean
		# OPTIONAL
		objectTypeList = @(
			$someSlaObjectType # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaObjectType]) for enum values.
		)
	}
}"
            );
        }

        // Create new GraphQL Query:
        // pendingSlasToBeUpgraded: PendingSLAsToBeUpgradedRes!
        internal void InitQueryPendingSlasToBeUpgraded()
        {
            Tuple<string, string>[] argDefs = {
            };
            Initialize(
                argDefs,
                "query",
                "QueryPendingSlasToBeUpgraded",
                "",
                "PendingSlAsToBeUpgradedRes",
                Query.PendingSlasToBeUpgraded,
                Query.PendingSlasToBeUpgradedFieldSpec,
                @""
            );
        }

        // Create new GraphQL Query:
        // protectedClustersForGlobalSla(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     slaId: UUID!
        //   ): ClusterConnection!
        internal void InitQueryProtectedClustersForGlobalSla()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("slaId", "UUID!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryProtectedClustersForGlobalSla",
                "($first: Int,$after: String,$last: Int,$before: String,$slaId: UUID!)",
                "ClusterConnection",
                Query.ProtectedClustersForGlobalSla,
                Query.ProtectedClustersForGlobalSlaFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# REQUIRED
$query.Var.slaId = $someString"
            );
        }

        // Create new GraphQL Query:
        // queryClustersWithSLANotSyncableReasons(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: QueryClustersSortByParamInput
        //     filter: QueryClustersFilterInput
        //     slaId: String!
        //   ): ClusterInfoWithNotSyncableReasonsConnection!
        internal void InitQueryQueryClustersWithSlaNotSyncableReasons()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "QueryClustersSortByParamInput"),
                Tuple.Create("filter", "QueryClustersFilterInput"),
                Tuple.Create("slaId", "String!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryQueryClustersWithSlaNotSyncableReasons",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: QueryClustersSortByParamInput,$filter: QueryClustersFilterInput,$slaId: String!)",
                "ClusterInfoWithNotSyncableReasonsConnection",
                Query.QueryClustersWithSlaNotSyncableReasons,
                Query.QueryClustersWithSlaNotSyncableReasonsFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = @{
	# OPTIONAL
	field = $someQueryClustersSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.QueryClustersSortByField]) for enum values.
	# OPTIONAL
	order = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
}
# OPTIONAL
$query.Var.filter = @{
	# OPTIONAL
	field = $someQueryClusterFilterByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.QueryClusterFilterByField]) for enum values.
	# OPTIONAL
	text = $someString
}
# REQUIRED
$query.Var.slaId = $someString"
            );
        }

        // Create new GraphQL Query:
        // slaSourceClusters(
        //     first: Int
        //     after: String
        //     last: Int
        //     before: String
        //     sortBy: SlaSourceClustersSortByField
        //     sortOrder: SortOrder
        //     filter: [SlaSourceClustersFilter!]
        //     isArchivalSelected: Boolean = false
        //     selectedReplication: SlaReplicationConfiguration = REPLICATION_UNSPECIFIED
        //   ): SlaSourceClustersSelectionInfoConnection!
        internal void InitQuerySlaSourceClusters()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("first", "Int"),
                Tuple.Create("after", "String"),
                Tuple.Create("last", "Int"),
                Tuple.Create("before", "String"),
                Tuple.Create("sortBy", "SlaSourceClustersSortByField"),
                Tuple.Create("sortOrder", "SortOrder"),
                Tuple.Create("filter", "[SlaSourceClustersFilter!]"),
                Tuple.Create("isArchivalSelected", "Boolean"),
                Tuple.Create("selectedReplication", "SlaReplicationConfiguration"),
            };
            Initialize(
                argDefs,
                "query",
                "QuerySlaSourceClusters",
                "($first: Int,$after: String,$last: Int,$before: String,$sortBy: SlaSourceClustersSortByField,$sortOrder: SortOrder,$filter: [SlaSourceClustersFilter!],$isArchivalSelected: Boolean,$selectedReplication: SlaReplicationConfiguration)",
                "SlaSourceClustersSelectionInfoConnection",
                Query.SlaSourceClusters,
                Query.SlaSourceClustersFieldSpec,
                @"# OPTIONAL
$query.Var.first = $someInt
# OPTIONAL
$query.Var.after = $someString
# OPTIONAL
$query.Var.last = $someInt
# OPTIONAL
$query.Var.before = $someString
# OPTIONAL
$query.Var.sortBy = $someSlaSourceClustersSortByField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaSourceClustersSortByField]) for enum values.
# OPTIONAL
$query.Var.sortOrder = $someSortOrder # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SortOrder]) for enum values.
# OPTIONAL
$query.Var.filter = @(
	@{
		# OPTIONAL
		texts = @(
			$someString
		)
		# REQUIRED
		field = $someSlaSourceClustersFilterField # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaSourceClustersFilterField]) for enum values.
}
)
# OPTIONAL
$query.Var.isArchivalSelected = $someBoolean
# OPTIONAL
$query.Var.selectedReplication = $someSlaReplicationConfiguration # Call [Enum]::GetValues([RubrikSecurityCloud.Types.SlaReplicationConfiguration]) for enum values."
            );
        }

        // Create new GraphQL Query:
        // allSlaSummariesByIds(slaIds: [UUID!]!): [SlaDomain!]!
        internal void InitQueryAllSlaSummariesByIds()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("slaIds", "[UUID!]!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryAllSlaSummariesByIds",
                "($slaIds: [UUID!]!)",
                "List<SlaDomain>",
                Query.AllSlaSummariesByIds,
                Query.AllSlaSummariesByIdsFieldSpec,
                @"# REQUIRED
$query.Var.slaIds = @(
	$someString
)"
            );
        }

        // Create new GraphQL Query:
        // verifySlaWithReplicationToCluster(cdmClusterUUID: UUID!, includeArchived: Boolean!): VerifySlaWithReplicationToClusterResponse!
        internal void InitQueryVerifySlaWithReplicationToCluster()
        {
            Tuple<string, string>[] argDefs = {
                Tuple.Create("cdmClusterUUID", "UUID!"),
                Tuple.Create("includeArchived", "Boolean!"),
            };
            Initialize(
                argDefs,
                "query",
                "QueryVerifySlaWithReplicationToCluster",
                "($cdmClusterUUID: UUID!,$includeArchived: Boolean!)",
                "VerifySlaWithReplicationToClusterResponse",
                Query.VerifySlaWithReplicationToCluster,
                Query.VerifySlaWithReplicationToClusterFieldSpec,
                @"# REQUIRED
$query.Var.cdmClusterUUID = $someString
# REQUIRED
$query.Var.includeArchived = $someBoolean"
            );
        }


    } // class New_RscQuerySla
}
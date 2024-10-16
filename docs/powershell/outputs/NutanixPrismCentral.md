### NutanixPrismCentral
Nutanix Prism Central details.

- cdmId: System.String
  - CDM ID of the Nutanix Virtual Machine.
- lastRefreshTime: DateTime
  - Last refresh timestamp of Nutanix Prism Central.
- hostName: System.String
  - IP address of Nutanix Prism Central.
- userName: System.String
  - Username.
- naturalId: System.String
  - Natural ID of Nutanix Prism Central.
- nosVersion: System.String
  - Nutanix Prism Central version.
- nutanixClusterIds: list of System.Strings
  - List of Nutanix Clusters that are protected as part of this Nutanix Prism Central.
- id: System.String
  - Object ID.
- connectionStatus: RefreshableObjectConnectionStatus
  - Connection status of the Nutanix Prism Central. If the CDM cluster is disconnected, then the status is set to 'Disconnected'.
- descendantConnection: NutanixPrismCentralDescendantTypeConnection
  - List of descendants.
- logicalChildConnection: NutanixPrismCentralLogicalChildTypeConnection
  - List of logical children.
- cluster: Cluster
  - Rubrik cluster where this object originated.
- primaryClusterLocation: DataLocation
  - The source cluster of this object. Returned as a data location because there is no guarantee that Rubrik has knowledge about the source cluster.
- pendingSla: SlaDomain
  - SLA Domain assignment of the object during the process of being communicated over to Rubrik CDM.
- pendingObjectDeletionStatus: PendingSnapshotsOfObjectDeletion
  - Mapping from object ID to pending object deletion status.
- replicatedObjects: list of CdmHierarchyObjects
  - Objects either replicated by this object or related to this object by replication.
- latestUserNote: LatestUserNote
  - Latest user note information.
- replicatedObjectCount: System.Int32
  - The number of objects either replicated by this object or related to this object by replication.
- authorizedOperations: list of Operations
  - The authorized operations on the object.
- name: System.String
  - The name of the hierarchy object.
- objectType: HierarchyObjectTypeEnum
  - The type of this object.
- slaAssignment: SlaAssignmentTypeEnum
  - The SLA Domain assignment type for this object.
- effectiveSlaDomain: SlaDomain
  - The effective SLA Domain of the hierarchy object.
- slaPauseStatus: System.Boolean
  - The pause status of the effective SLA Domain of the hierarchy object.
- snapshotDistribution: SnapshotDistribution
  - The distribution of the snapshots of the hierarchy object.
- effectiveRetentionSlaDomain: SlaDomain
  - The effective retention of the SLA Domain of the hierarchy object.
- configuredSlaDomain: SlaDomain
  - The SLA Domain configured for the hierarchy object.
- effectiveSlaSourceObject: PathNode
  - The path node of the effective SLA Domain source.
- logicalPath: list of PathNodes
  - A sequential list of this object's logical ancestors.
- physicalPath: list of PathNodes
  - A sequential list of this object's physical ancestors.
- numWorkloadDescendants: System.Int32
  - The number of descendant workloads of this object.
- allOrgs: list of Orgs
  - The organizations to which this hierarchy object belongs.

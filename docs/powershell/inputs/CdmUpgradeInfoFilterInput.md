### CdmUpgradeInfoFilterInput
Filters for the cluster list.

- id: list of System.Strings
  - Cluster UUIDs.
- name: list of System.Strings
  - Cluster names.
- type: list of ClusterTypeEnums
  - Cluster types.
- registrationTime_gt: DateTime
  - Cluster registration time greater than.
- registrationTime_lt: DateTime
  - Cluster registration time less than.
- minSoftwareVersion: System.String
  - Cluster software version greater than or equal to.
- downloadedVersion: list of System.Strings
  - Cluster software version greater than or equal to.
- installedVersion: list of System.Strings
- upgradeJobStatus: list of ClusterJobStatusTypeEnums
  - Cluster upgrade job status.
- clusterLocation: list of System.Strings
  - Location of cluster.
- versionStatus: list of VersionStatuss
- prechecksStatus: list of PrechecksStatusTypeEnums
  - Prechecks status of cluster.
- connectionState: list of ClusterStatuss
- upgradeScheduled: System.Boolean
- productType: list of ClusterProductEnums
  - Product type of Rubrik cluster.

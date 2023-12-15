### GlobalCertificatesQueryInput
Input to list global certificates.

- searchText: System.String
  - The query to filter the certificates.
- hasKey: System.Boolean
  - Specifies whether to return only the certificates with private keys.
- statuses: list of GlobalCertificateStatuss
  - The status of the certificates.
- clusterIds: list of System.Strings
  - The UUIDs of the Rubrik clusters on which to filter.
- isTrustedAny: System.Boolean
  - Specifies whether the certificate is in the trust store of the Rubrik cluster.
- isRscBorn: System.Boolean
  - Specifies whether to include only certificates imported via RSC.

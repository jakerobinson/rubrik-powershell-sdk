### MongoSourceAddRequestConfigInput
Supported in v8.1+
  Configuration for adding a MongoDB source.

- caCertfilePath: System.String
  - Supported in v8.1+
      Path to the CA certificate file.
- ignoreSecondaries: list of System.Strings
  - Supported in v8.1+
      List of secondaries that should be ignored.
- sourceDriverPassword: System.String
  - Supported in v8.1+
      Password of the mongod driver user account.
- sourceDriverUser: System.String
  - Supported in v8.1+
      Username of mongod driver user account.
- sslKeyfilePath: System.String
  - Supported in v8.1+
      Path to the SSL key file.
- sslCertfilePath: System.String
  - Path to the SSL certificate file.
- mongoType: MongoType
  - Required. Supported in v8.1+
      Type of MongoDB cluster.
- sourceAuthenticationType: MongoAuthenticationType
  - Supported in v9.0+
      Type of user authentication used when adding the MongoDB cluster.
- sslCertificateRequired: MongoSslCertificateRequirement
  - Supported in v8.1+
      Specifies whether SSL certificates are required for the connection.
- mongoClientHosts: list of MongoClientHostInputs
  - Required. Supported in v8.1+
      List of host details where MongoDB is hosted.
- sourceName: System.String
  - Required. Supported in v8.1+
      Name of the MongoDB cluster.

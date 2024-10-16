### FinalizeAwsCloudAccountProtectionInput
Input to finalize set up of an AWS cloud account.

- action: CloudAccountAction
  - Action to be performed with cloud account.
- features: list of CloudAccountFeatures
  - List of features for native protection of cloud account.
- awsAdminAccount: AwsCloudAccountInput
  - Admin account, required for bulk upload.
- awsChildAccounts: list of AwsCloudAccountInputs
  - List of AWS accounts.
- awsRegions: list of AwsCloudAccountRegions
  - List of AWS regions for the cloud account.
- stackName: System.String
  - Name of the CloudFormation stack to be created.
- stackSetName: System.String
  - Stackset name of the CloudFormation stack to be created.
- externalId: System.String
  - External ID of the IAM role trust policy for the cloud account.
- featureVersion: list of AwsCloudAccountFeatureVersionInputs
  - List of feature types to be protected for the cloud account.

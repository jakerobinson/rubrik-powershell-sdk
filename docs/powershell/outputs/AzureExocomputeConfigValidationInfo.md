### AzureExocomputeConfigValidationInfo
Contains validation information, such as blockers or errors encountered in validating the Exocompute configuration.

- config: AzureExocomputeRegionConfig
  - Specifies the Exocompute configuration which needs validation.
- hasBlockedSecurityRules: System.Boolean
  - Specifies whether the configuration has blocking security rules in its associated network security group attached to the subnet for running AKS cluster in the specific region. For more details, visit https://docs.microsoft.com/en-us/azure/aks/limit-egress-traffic#required-outbound-network-rules-and-fqdns-for-aks-clusters.
- hasRestrictedAddressRangeOverlap: System.Boolean
  - Specifies whether the configuration has the corresponding subnet address range overlap with Azure restricted address ranges. For more details, visit https://docs.microsoft.com/en-us/azure/aks/configure-azure-cni#prerequisites.
- isSubnetDelegated: System.Boolean
  - Specifies whether the subnet specified in configuration is delegated. For more details, visit https://docs.microsoft.com/en-us/azure/aks/configure-azure-cni#prerequisites.
- isPodAndClusterSubnetSame: System.Boolean
  - Specifies whether the subnet specified in configuration is same for the pod and cluster. Pod and cluster subnets should be different for a valid configuration. For more details, visit https://docs.microsoft.com/en-us/azure/aks/configure-azure-cni#dynamic-allocation-of-ip-addresses-and-enhanced-subnet-support-faqs.
- isPodAndClusterVnetDifferent: System.Boolean
  - Specifies whether the VNET associated with the subnet specified in configuration is different for the pod and cluster. Pod and cluster VNETs should be same for a valid configuration. For more details, visit https://docs.microsoft.com/en-us/azure/aks/configure-azure-cni#dynamic-allocation-of-ip-addresses-and-enhanced-subnet-support-faqs.
- isClusterSubnetSizeTooSmall: System.Boolean
  - Specifies whether the size of the cluster subnet provided for the Exocompute configuration is smaller than desired to create exo-cluster.
- isPodSubnetSizeTooSmall: System.Boolean
  - Specifies whether the size of the pod subnet provided for the Exocompute configuration is smaller than desired to create exo-cluster.
- isPodCidrAndSubnetCidrOverlap: System.Boolean
  - Specifies whether there is an overlap between the pod CIDR range used for the CNI overlay network and the cluster subnet CIDR range. Make sure that there is no overlap between the pod CIDR range and the cluster subnet to prevent conflicts. For more details, visit https://learn.microsoft.com/en-us/azure/aks/azure-cni-overlay#ip-address-planning.
- isPodCidrRangeTooSmall: System.Boolean
  - Specifies whether the size of the pod CIDR range provided for Exocompute configuration using CNI overlay network mode is smaller than desired for creating an exo-cluster. For more details, visit https://learn.microsoft.com/en-us/azure/aks/azure-cni-overlay#ip-address-planning.
- errorMessage: System.String
  - Error received while validating Exocompute configuration.

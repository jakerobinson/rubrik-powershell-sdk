// AzureKeyVaultsInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region AzureKeyVaultsInput

    public class AzureKeyVaultsInput: IInput
    {
        #region members

        //      C# -> System.String? CloudAccountId
        // GraphQL -> cloudAccountId: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("cloudAccountId")]
        public System.String? CloudAccountId { get; set; }

        //      C# -> AzureRegion? Region
        // GraphQL -> region: AzureRegion! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("region")]
        public AzureRegion? Region { get; set; }

        //      C# -> System.String? UserAssignedManagedIdentityPrincipalId
        // GraphQL -> userAssignedManagedIdentityPrincipalId: UUID (scalar)
        [JsonProperty("userAssignedManagedIdentityPrincipalId")]
        public System.String? UserAssignedManagedIdentityPrincipalId { get; set; }


        #endregion

    
        #region methods
        public dynamic GetInputObject()
        {
            IDictionary<string, object> d = new System.Dynamic.ExpandoObject();

            var properties = GetType().GetProperties(System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public);
            foreach (var propertyInfo in properties)
            {
                var value = propertyInfo.GetValue(this);
                var defaultValue = propertyInfo.PropertyType.IsValueType ? Activator.CreateInstance(propertyInfo.PropertyType) : null;

                var requiredProp = propertyInfo.GetCustomAttributes(typeof(JsonRequiredAttribute), false).Length > 0;

                if (requiredProp || value != defaultValue)
                {
                    d[propertyInfo.Name] = value;
                }
            }
            return d;
        }
        #endregion

    } // class AzureKeyVaultsInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
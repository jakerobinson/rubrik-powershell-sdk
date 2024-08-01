// StartSaasAppsDeleteOrgInput.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
{
    #region StartSaasAppsDeleteOrgInput

    public class StartSaasAppsDeleteOrgInput: IInput
    {
        #region members

        //      C# -> System.String? OrgId
        // GraphQL -> orgID: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("orgID")]
        public System.String? OrgId { get; set; }

        //      C# -> SaasAppType? SaasAppType
        // GraphQL -> saasAppType: SaasAppType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("saasAppType")]
        public SaasAppType? SaasAppType { get; set; }


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

    } // class StartSaasAppsDeleteOrgInput
    #endregion

} // namespace RubrikSecurityCloud.Types
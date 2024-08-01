// PrincipalSummaryFilter.cs
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
    #region PrincipalSummaryFilter

    public class PrincipalSummaryFilter: IInput
    {
        #region members

        //      C# -> System.String? PolicyId
        // GraphQL -> policyId: String (scalar)
        [JsonProperty("policyId")]
        public System.String? PolicyId { get; set; }

        //      C# -> PrincipalSummaryCategoryType? PrincipalSummaryCategory
        // GraphQL -> principalSummaryCategory: PrincipalSummaryCategoryType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("principalSummaryCategory")]
        public PrincipalSummaryCategoryType? PrincipalSummaryCategory { get; set; }

        //      C# -> System.String? GroupId
        // GraphQL -> groupId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("groupId")]
        public System.String? GroupId { get; set; }

        //      C# -> System.String? ObjectId
        // GraphQL -> objectId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("objectId")]
        public System.String? ObjectId { get; set; }


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

    } // class PrincipalSummaryFilter
    #endregion

} // namespace RubrikSecurityCloud.Types
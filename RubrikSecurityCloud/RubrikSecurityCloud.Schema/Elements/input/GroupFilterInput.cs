// GroupFilterInput.cs
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
    #region GroupFilterInput

    public class GroupFilterInput: IInput
    {
        #region members

        //      C# -> List<System.String>? OrgIdsFilter
        // GraphQL -> orgIdsFilter: [String!] (scalar)
        [JsonProperty("orgIdsFilter")]
        public List<System.String>? OrgIdsFilter { get; set; }

        //      C# -> List<System.String>? RoleIdsFilter
        // GraphQL -> roleIdsFilter: [String!] (scalar)
        [JsonProperty("roleIdsFilter")]
        public List<System.String>? RoleIdsFilter { get; set; }

        //      C# -> System.String? NameFilter
        // GraphQL -> nameFilter: String (scalar)
        [JsonProperty("nameFilter")]
        public System.String? NameFilter { get; set; }


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

    } // class GroupFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types
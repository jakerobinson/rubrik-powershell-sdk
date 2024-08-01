// LatestConfigBackupFilterInput.cs
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
    #region LatestConfigBackupFilterInput

    public class LatestConfigBackupFilterInput: IInput
    {
        #region members

        //      C# -> List<System.String>? Id
        // GraphQL -> id: [UUID!] (scalar)
        [JsonProperty("id")]
        public List<System.String>? Id { get; set; }

        //      C# -> List<System.String>? Name
        // GraphQL -> name: [String!] (scalar)
        [JsonProperty("name")]
        public List<System.String>? Name { get; set; }

        //      C# -> List<ClusterStatus>? ConnectionState
        // GraphQL -> connectionState: [ClusterStatus!] (enum)
        [JsonProperty("connectionState")]
        public List<ClusterStatus>? ConnectionState { get; set; }


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

    } // class LatestConfigBackupFilterInput
    #endregion

} // namespace RubrikSecurityCloud.Types
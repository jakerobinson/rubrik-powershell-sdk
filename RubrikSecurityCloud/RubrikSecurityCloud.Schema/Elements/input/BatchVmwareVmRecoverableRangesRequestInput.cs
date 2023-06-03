// BatchVmwareVmRecoverableRangesRequestInput.cs
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
    #region BatchVmwareVmRecoverableRangesRequestInput

    public class BatchVmwareVmRecoverableRangesRequestInput: IInput
    {
        #region members

        //      C# -> DateTime? AfterTime
        // GraphQL -> afterTime: DateTime (scalar)
        [JsonProperty("afterTime")]
        public DateTime? AfterTime { get; set; }

        //      C# -> DateTime? BeforeTime
        // GraphQL -> beforeTime: DateTime (scalar)
        [JsonProperty("beforeTime")]
        public DateTime? BeforeTime { get; set; }

        //      C# -> List<System.String>? VmIds
        // GraphQL -> vmIds: [String!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("vmIds")]
        public List<System.String>? VmIds { get; set; }


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

    } // class BatchVmwareVmRecoverableRangesRequestInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
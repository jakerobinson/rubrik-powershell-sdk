// StartCreateAzureNativeManagedDiskSnapshotsJobInput.cs
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
    #region StartCreateAzureNativeManagedDiskSnapshotsJobInput

    public class StartCreateAzureNativeManagedDiskSnapshotsJobInput: IInput
    {
        #region members

        //      C# -> List<System.String>? ManagedDiskRubrikIds
        // GraphQL -> managedDiskRubrikIds: [UUID!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("managedDiskRubrikIds")]
        public List<System.String>? ManagedDiskRubrikIds { get; set; }

        //      C# -> System.String? RetentionSlaId
        // GraphQL -> retentionSlaId: String (scalar)
        [JsonProperty("retentionSlaId")]
        public System.String? RetentionSlaId { get; set; }


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

    } // class StartCreateAzureNativeManagedDiskSnapshotsJobInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
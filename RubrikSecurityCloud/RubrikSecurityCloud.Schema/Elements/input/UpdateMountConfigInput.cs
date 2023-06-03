// UpdateMountConfigInput.cs
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
    #region UpdateMountConfigInput

    public class UpdateMountConfigInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldForce
        // GraphQL -> shouldForce: Boolean (scalar)
        [JsonProperty("shouldForce")]
        public System.Boolean? ShouldForce { get; set; }

        //      C# -> System.Boolean? PowerStatus
        // GraphQL -> powerStatus: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("powerStatus")]
        public System.Boolean? PowerStatus { get; set; }


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

    } // class UpdateMountConfigInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
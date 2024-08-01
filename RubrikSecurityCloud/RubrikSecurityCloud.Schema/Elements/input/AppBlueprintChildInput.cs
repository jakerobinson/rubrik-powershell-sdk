// AppBlueprintChildInput.cs
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
    #region AppBlueprintChildInput

    public class AppBlueprintChildInput: IInput
    {
        #region members

        //      C# -> System.String? Fid
        // GraphQL -> fid: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("fid")]
        public System.String? Fid { get; set; }

        //      C# -> ObjectTypeEnum? SnappableType
        // GraphQL -> snappableType: ObjectTypeEnum! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("snappableType")]
        public ObjectTypeEnum? SnappableType { get; set; }

        //      C# -> System.Int32? BootPriority
        // GraphQL -> bootPriority: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("bootPriority")]
        public System.Int32? BootPriority { get; set; }

        //      C# -> System.Int64? LastRecoveryPoint
        // GraphQL -> lastRecoveryPoint: Long (scalar)
        [JsonProperty("lastRecoveryPoint")]
        public System.Int64? LastRecoveryPoint { get; set; }


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

    } // class AppBlueprintChildInput
    #endregion

} // namespace RubrikSecurityCloud.Types
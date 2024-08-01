// UpdateRecoveryPlanInput.cs
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
    #region UpdateRecoveryPlanInput

    public class UpdateRecoveryPlanInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? TargetLocationId
        // GraphQL -> targetLocationId: UUID (scalar)
        [JsonProperty("targetLocationId")]
        public System.String? TargetLocationId { get; set; }

        //      C# -> BlueprintLocationType? TargetLocationType
        // GraphQL -> targetLocationType: BlueprintLocationType (enum)
        [JsonProperty("targetLocationType")]
        public BlueprintLocationType? TargetLocationType { get; set; }

        //      C# -> List<AppBlueprintChildInput>? Children
        // GraphQL -> children: [AppBlueprintChildInput!]! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("children")]
        public List<AppBlueprintChildInput>? Children { get; set; }

        //      C# -> System.Int32? Version
        // GraphQL -> version: Int! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("version")]
        public System.Int32? Version { get; set; }

        //      C# -> System.Boolean? IsHydrationEnabled
        // GraphQL -> isHydrationEnabled: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isHydrationEnabled")]
        public System.Boolean? IsHydrationEnabled { get; set; }

        //      C# -> List<System.Int64>? PauseBetweenPriorityGroups
        // GraphQL -> pauseBetweenPriorityGroups: [Long!]! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("pauseBetweenPriorityGroups")]
        public List<System.Int64>? PauseBetweenPriorityGroups { get; set; }

        //      C# -> System.Boolean? IsVisible
        // GraphQL -> isVisible: Boolean! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("isVisible")]
        public System.Boolean? IsVisible { get; set; }


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

    } // class UpdateRecoveryPlanInput
    #endregion

} // namespace RubrikSecurityCloud.Types
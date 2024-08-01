// BulkRecoveryDefinition.cs
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
    #region BulkRecoveryDefinition

    public class BulkRecoveryDefinition: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> O365GroupSelectorWithRecoverySpec? O365GroupSelectorWithRecoverySpec
        // GraphQL -> o365GroupSelectorWithRecoverySpec: O365GroupSelectorWithRecoverySpec (input)
        [JsonProperty("o365GroupSelectorWithRecoverySpec")]
        public O365GroupSelectorWithRecoverySpec? O365GroupSelectorWithRecoverySpec { get; set; }

        //      C# -> FailureActionType? FailureAction
        // GraphQL -> failureAction: FailureActionType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("failureAction")]
        public FailureActionType? FailureAction { get; set; }

        //      C# -> RecoveryModeType? RecoveryMode
        // GraphQL -> recoveryMode: RecoveryModeType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryMode")]
        public RecoveryModeType? RecoveryMode { get; set; }

        //      C# -> RecoveryDomainType? RecoveryDomain
        // GraphQL -> recoveryDomain: RecoveryDomainType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryDomain")]
        public RecoveryDomainType? RecoveryDomain { get; set; }


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

    } // class BulkRecoveryDefinition
    #endregion

} // namespace RubrikSecurityCloud.Types
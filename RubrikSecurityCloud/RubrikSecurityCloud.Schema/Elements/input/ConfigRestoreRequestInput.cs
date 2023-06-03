// ConfigRestoreRequestInput.cs
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
    #region ConfigRestoreRequestInput

    public class ConfigRestoreRequestInput: IInput
    {
        #region members

        //      C# -> System.Boolean? IsSourceSafe
        // GraphQL -> isSourceSafe: Boolean (scalar)
        [JsonProperty("isSourceSafe")]
        public System.Boolean? IsSourceSafe { get; set; }

        //      C# -> System.String? BackupFileName
        // GraphQL -> backupFileName: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("backupFileName")]
        public System.String? BackupFileName { get; set; }

        //      C# -> CustomizedRestoreFormInput? CustomizedRestoreForm
        // GraphQL -> customizedRestoreForm: CustomizedRestoreFormInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("customizedRestoreForm")]
        public CustomizedRestoreFormInput? CustomizedRestoreForm { get; set; }

        //      C# -> System.String? EncryptionPassword
        // GraphQL -> encryptionPassword: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("encryptionPassword")]
        public System.String? EncryptionPassword { get; set; }


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

    } // class ConfigRestoreRequestInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
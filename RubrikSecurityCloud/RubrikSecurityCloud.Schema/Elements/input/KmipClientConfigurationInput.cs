// KmipClientConfigurationInput.cs
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
    #region KmipClientConfigurationInput

    public class KmipClientConfigurationInput: IInput
    {
        #region members

        //      C# -> System.String? ClientCertificate
        // GraphQL -> clientCertificate: String (scalar)
        [JsonProperty("clientCertificate")]
        public System.String? ClientCertificate { get; set; }

        //      C# -> System.String? Password
        // GraphQL -> password: String (scalar)
        [JsonProperty("password")]
        public System.String? Password { get; set; }

        //      C# -> System.String? ClientCertificateId
        // GraphQL -> clientCertificateId: String (scalar)
        [JsonProperty("clientCertificateId")]
        public System.String? ClientCertificateId { get; set; }

        //      C# -> System.String? Username
        // GraphQL -> username: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("username")]
        public System.String? Username { get; set; }


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

    } // class KmipClientConfigurationInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
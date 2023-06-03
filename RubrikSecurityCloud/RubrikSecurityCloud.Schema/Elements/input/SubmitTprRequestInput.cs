// SubmitTprRequestInput.cs
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
    #region SubmitTprRequestInput

    public class SubmitTprRequestInput: IInput
    {
        #region members

        //      C# -> System.String? Id
        // GraphQL -> id: UUID! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Comment
        // GraphQL -> comment: String (scalar)
        [JsonProperty("comment")]
        public System.String? Comment { get; set; }

        //      C# -> System.Int32? ExecutionTimeoutHours
        // GraphQL -> executionTimeoutHours: Int (scalar)
        [JsonProperty("executionTimeoutHours")]
        public System.Int32? ExecutionTimeoutHours { get; set; }

        //      C# -> TprExecutionType? ExecutionType
        // GraphQL -> executionType: TprExecutionType! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("executionType")]
        public TprExecutionType? ExecutionType { get; set; }


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

    } // class SubmitTprRequestInput
    #endregion

} // namespace Rubrik.SecurityCloud.Types
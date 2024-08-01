// TicketInfoInput.cs
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
    #region TicketInfoInput

    public class TicketInfoInput: IInput
    {
        #region members

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Reason
        // GraphQL -> reason: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("reason")]
        public System.String? Reason { get; set; }

        //      C# -> List<InsightTicketAttachmentType>? AttachmentTypes
        // GraphQL -> attachmentTypes: [InsightTicketAttachmentType!]! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("attachmentTypes")]
        public List<InsightTicketAttachmentType>? AttachmentTypes { get; set; }

        //      C# -> System.String? Comment
        // GraphQL -> comment: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("comment")]
        public System.String? Comment { get; set; }


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

    } // class TicketInfoInput
    #endregion

} // namespace RubrikSecurityCloud.Types
// UsageTimeseriesInput.cs
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
    #region UsageTimeseriesInput

    public class UsageTimeseriesInput: IInput
    {
        #region members

        //      C# -> DateTime? StartTime
        // GraphQL -> startTime: DateTime (scalar)
        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        //      C# -> DateTime? EndTime
        // GraphQL -> endTime: DateTime (scalar)
        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        //      C# -> LicenseMeasurementUnit? Uom
        // GraphQL -> uom: LicenseMeasurementUnit! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("uom")]
        public LicenseMeasurementUnit? Uom { get; set; }

        //      C# -> LicenseProduct? Product
        // GraphQL -> product: LicenseProduct! (enum)
        [Required]
        [JsonRequired]
        [JsonProperty("product")]
        public LicenseProduct? Product { get; set; }

        //      C# -> System.Boolean? IncludeLicenseTimeseries
        // GraphQL -> includeLicenseTimeseries: Boolean (scalar)
        [JsonProperty("includeLicenseTimeseries")]
        public System.Boolean? IncludeLicenseTimeseries { get; set; }


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

    } // class UsageTimeseriesInput
    #endregion

} // namespace RubrikSecurityCloud.Types
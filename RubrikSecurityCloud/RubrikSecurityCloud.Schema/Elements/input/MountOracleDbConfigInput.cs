// MountOracleDbConfigInput.cs
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
    #region MountOracleDbConfigInput

    public class MountOracleDbConfigInput: IInput
    {
        #region members

        //      C# -> System.Boolean? ShouldMountFilesOnly
        // GraphQL -> shouldMountFilesOnly: Boolean (scalar)
        [JsonProperty("shouldMountFilesOnly")]
        public System.Boolean? ShouldMountFilesOnly { get; set; }

        //      C# -> System.String? TargetMountPath
        // GraphQL -> targetMountPath: String (scalar)
        [JsonProperty("targetMountPath")]
        public System.String? TargetMountPath { get; set; }

        //      C# -> System.String? AdvancedRecoveryConfigBase64
        // GraphQL -> advancedRecoveryConfigBase64: String (scalar)
        [JsonProperty("advancedRecoveryConfigBase64")]
        public System.String? AdvancedRecoveryConfigBase64 { get; set; }

        //      C# -> System.String? CustomPfilePath
        // GraphQL -> customPfilePath: String (scalar)
        [JsonProperty("customPfilePath")]
        public System.String? CustomPfilePath { get; set; }

        //      C# -> System.Int32? NumChannels
        // GraphQL -> numChannels: Int (scalar)
        [JsonProperty("numChannels")]
        public System.Int32? NumChannels { get; set; }

        //      C# -> System.String? PostScriptPath
        // GraphQL -> postScriptPath: String (scalar)
        [JsonProperty("postScriptPath")]
        public System.String? PostScriptPath { get; set; }

        //      C# -> System.String? PreScriptPath
        // GraphQL -> preScriptPath: String (scalar)
        [JsonProperty("preScriptPath")]
        public System.String? PreScriptPath { get; set; }

        //      C# -> System.Boolean? ShouldStopRecoveryOnPreScriptFailure
        // GraphQL -> shouldStopRecoveryOnPreScriptFailure: Boolean (scalar)
        [JsonProperty("shouldStopRecoveryOnPreScriptFailure")]
        public System.Boolean? ShouldStopRecoveryOnPreScriptFailure { get; set; }

        //      C# -> List<System.String>? PdbsToLiveMount
        // GraphQL -> pdbsToLiveMount: [String!] (scalar)
        [JsonProperty("pdbsToLiveMount")]
        public List<System.String>? PdbsToLiveMount { get; set; }

        //      C# -> List<System.String>? TargetRacHostIds
        // GraphQL -> targetRacHostIds: [String!] (scalar)
        [JsonProperty("targetRacHostIds")]
        public List<System.String>? TargetRacHostIds { get; set; }

        //      C# -> System.String? LmDbName
        // GraphQL -> lmDbName: String (scalar)
        [JsonProperty("lmDbName")]
        public System.String? LmDbName { get; set; }

        //      C# -> System.String? TargetRacPrimaryHostId
        // GraphQL -> targetRacPrimaryHostId: String (scalar)
        [JsonProperty("targetRacPrimaryHostId")]
        public System.String? TargetRacPrimaryHostId { get; set; }

        //      C# -> System.Boolean? ShouldAllowRenameToSource
        // GraphQL -> shouldAllowRenameToSource: Boolean (scalar)
        [JsonProperty("shouldAllowRenameToSource")]
        public System.Boolean? ShouldAllowRenameToSource { get; set; }

        //      C# -> OracleRecoveryPointInput? RecoveryPoint
        // GraphQL -> recoveryPoint: OracleRecoveryPointInput! (input)
        [Required]
        [JsonRequired]
        [JsonProperty("recoveryPoint")]
        public OracleRecoveryPointInput? RecoveryPoint { get; set; }

        //      C# -> System.String? TargetOracleHostOrRacId
        // GraphQL -> targetOracleHostOrRacId: String! (scalar)
        [Required]
        [JsonRequired]
        [JsonProperty("targetOracleHostOrRacId")]
        public System.String? TargetOracleHostOrRacId { get; set; }


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

    } // class MountOracleDbConfigInput
    #endregion

} // namespace RubrikSecurityCloud.Types
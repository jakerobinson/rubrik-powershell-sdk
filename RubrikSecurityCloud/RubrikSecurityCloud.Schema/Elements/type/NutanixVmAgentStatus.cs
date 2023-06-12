// NutanixVmAgentStatus.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Reflection;
using System.Text.RegularExpressions;
using RubrikSecurityCloud.Schema.Utils;

namespace Rubrik.SecurityCloud.Types
{
    #region NutanixVmAgentStatus
    public class NutanixVmAgentStatus: BaseType
    {
        #region members

        //      C# -> NutanixVmAgentConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: NutanixVmAgentConnectionStatus! (enum)
        [JsonProperty("connectionStatus")]
        public NutanixVmAgentConnectionStatus? ConnectionStatus { get; set; }

        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        [JsonProperty("disconnectReason")]
        public System.String? DisconnectReason { get; set; }


        #endregion

    #region methods

    public NutanixVmAgentStatus Set(
        NutanixVmAgentConnectionStatus? ConnectionStatus = null,
        System.String? DisconnectReason = null
    ) 
    {
        if ( ConnectionStatus != null ) {
            this.ConnectionStatus = ConnectionStatus;
        }
        if ( DisconnectReason != null ) {
            this.DisconnectReason = DisconnectReason;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(int indent=0)
    {
        string ind = new string(' ', indent*2);
        string s = "";
        //      C# -> NutanixVmAgentConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: NutanixVmAgentConnectionStatus! (enum)
        if (this.ConnectionStatus != null) {
            s += ind + "connectionStatus\n" ;
        }
        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        if (this.DisconnectReason != null) {
            s += ind + "disconnectReason\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> NutanixVmAgentConnectionStatus? ConnectionStatus
        // GraphQL -> connectionStatus: NutanixVmAgentConnectionStatus! (enum)
        if (this.ConnectionStatus == null && Exploration.Includes(parent + ".connectionStatus", true))
        {
            this.ConnectionStatus = new NutanixVmAgentConnectionStatus();
        }
        //      C# -> System.String? DisconnectReason
        // GraphQL -> disconnectReason: String (scalar)
        if (this.DisconnectReason == null && Exploration.Includes(parent + ".disconnectReason", true))
        {
            this.DisconnectReason = "FETCH";
        }
    }


    #endregion

    } // class NutanixVmAgentStatus
    
    #endregion

    public static class ListNutanixVmAgentStatusExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of fields that are not null in an object.
        // When creating a field spec from an (non-list) object,
        // all fields (including nested objects) that are not null are
        // included in the fieldspec.
        // When creating a fieldspec from a list of objects,
        // we arbitrarily choose to use the fieldspec of the first item
        // in the list. This is not a perfect solution, but it is a
        // reasonable one.
        // When creating a fieldspec from a list of interfaces,
        // we include the fieldspec of each item in the list
        // as an inline fragment (... on)
        public static string AsFieldSpec(
            this List<NutanixVmAgentStatus> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<NutanixVmAgentStatus> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new NutanixVmAgentStatus());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
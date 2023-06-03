// VappNetworkSummary.cs
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
    #region VappNetworkSummary
    public class VappNetworkSummary: BaseType
    {
        #region members

        //      C# -> System.Boolean? IsDeployed
        // GraphQL -> isDeployed: Boolean! (scalar)
        [JsonProperty("isDeployed")]
        public System.Boolean? IsDeployed { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? ParentNetworkId
        // GraphQL -> parentNetworkId: String (scalar)
        [JsonProperty("parentNetworkId")]
        public System.String? ParentNetworkId { get; set; }


        #endregion

    #region methods

    public VappNetworkSummary Set(
        System.Boolean? IsDeployed = null,
        System.String? Name = null,
        System.String? ParentNetworkId = null
    ) 
    {
        if ( IsDeployed != null ) {
            this.IsDeployed = IsDeployed;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( ParentNetworkId != null ) {
            this.ParentNetworkId = ParentNetworkId;
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
        //      C# -> System.Boolean? IsDeployed
        // GraphQL -> isDeployed: Boolean! (scalar)
        if (this.IsDeployed != null) {
            s += ind + "isDeployed\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> System.String? ParentNetworkId
        // GraphQL -> parentNetworkId: String (scalar)
        if (this.ParentNetworkId != null) {
            s += ind + "parentNetworkId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? IsDeployed
        // GraphQL -> isDeployed: Boolean! (scalar)
        if (this.IsDeployed == null && Exploration.Includes(parent + ".isDeployed", true))
        {
            this.IsDeployed = true;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> System.String? ParentNetworkId
        // GraphQL -> parentNetworkId: String (scalar)
        if (this.ParentNetworkId == null && Exploration.Includes(parent + ".parentNetworkId", true))
        {
            this.ParentNetworkId = new System.String("FETCH");
        }
    }


    #endregion

    } // class VappNetworkSummary
    
    #endregion

    public static class ListVappNetworkSummaryExtensions
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
            this List<VappNetworkSummary> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<VappNetworkSummary> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new VappNetworkSummary());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
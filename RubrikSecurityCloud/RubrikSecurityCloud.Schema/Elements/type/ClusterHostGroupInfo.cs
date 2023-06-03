// ClusterHostGroupInfo.cs
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
    #region ClusterHostGroupInfo
    public class ClusterHostGroupInfo: BaseType
    {
        #region members

        //      C# -> System.String? DatacenterName
        // GraphQL -> datacenterName: String! (scalar)
        [JsonProperty("datacenterName")]
        public System.String? DatacenterName { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> List<HostGroupInfo>? HostGroups
        // GraphQL -> hostGroups: [HostGroupInfo!]! (type)
        [JsonProperty("hostGroups")]
        public List<HostGroupInfo>? HostGroups { get; set; }


        #endregion

    #region methods

    public ClusterHostGroupInfo Set(
        System.String? DatacenterName = null,
        System.String? Id = null,
        System.String? Name = null,
        List<HostGroupInfo>? HostGroups = null
    ) 
    {
        if ( DatacenterName != null ) {
            this.DatacenterName = DatacenterName;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( HostGroups != null ) {
            this.HostGroups = HostGroups;
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
        //      C# -> System.String? DatacenterName
        // GraphQL -> datacenterName: String! (scalar)
        if (this.DatacenterName != null) {
            s += ind + "datacenterName\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            s += ind + "name\n" ;
        }
        //      C# -> List<HostGroupInfo>? HostGroups
        // GraphQL -> hostGroups: [HostGroupInfo!]! (type)
        if (this.HostGroups != null) {
            s += ind + "hostGroups {\n" + this.HostGroups.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? DatacenterName
        // GraphQL -> datacenterName: String! (scalar)
        if (this.DatacenterName == null && Exploration.Includes(parent + ".datacenterName", true))
        {
            this.DatacenterName = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name == null && Exploration.Includes(parent + ".name", true))
        {
            this.Name = new System.String("FETCH");
        }
        //      C# -> List<HostGroupInfo>? HostGroups
        // GraphQL -> hostGroups: [HostGroupInfo!]! (type)
        if (this.HostGroups == null && Exploration.Includes(parent + ".hostGroups"))
        {
            this.HostGroups = new List<HostGroupInfo>();
            this.HostGroups.ApplyExploratoryFieldSpec(parent + ".hostGroups");
        }
    }


    #endregion

    } // class ClusterHostGroupInfo
    
    #endregion

    public static class ListClusterHostGroupInfoExtensions
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
            this List<ClusterHostGroupInfo> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterHostGroupInfo> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterHostGroupInfo());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
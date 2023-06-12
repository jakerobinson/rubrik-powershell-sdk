// O365SharepointDriveConnection.cs
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
    #region O365SharepointDriveConnection
    public class O365SharepointDriveConnection: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> List<O365SharepointDriveEdge>? Edges
        // GraphQL -> edges: [O365SharepointDriveEdge!]! (type)
        [JsonProperty("edges")]
        public List<O365SharepointDriveEdge>? Edges { get; set; }

        //      C# -> List<O365SharepointDrive>? Nodes
        // GraphQL -> nodes: [O365SharepointDrive!]! (type)
        [JsonProperty("nodes")]
        public List<O365SharepointDrive>? Nodes { get; set; }

        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        [JsonProperty("pageInfo")]
        public PageInfo? PageInfo { get; set; }


        #endregion

    #region methods

    public O365SharepointDriveConnection Set(
        System.Int32? Count = null,
        List<O365SharepointDriveEdge>? Edges = null,
        List<O365SharepointDrive>? Nodes = null,
        PageInfo? PageInfo = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Edges != null ) {
            this.Edges = Edges;
        }
        if ( Nodes != null ) {
            this.Nodes = Nodes;
        }
        if ( PageInfo != null ) {
            this.PageInfo = PageInfo;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            s += ind + "count\n" ;
        }
        //      C# -> List<O365SharepointDriveEdge>? Edges
        // GraphQL -> edges: [O365SharepointDriveEdge!]! (type)
        if (this.Edges != null) {
            var fspec = this.Edges.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "edges {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> List<O365SharepointDrive>? Nodes
        // GraphQL -> nodes: [O365SharepointDrive!]! (type)
        if (this.Nodes != null) {
            var fspec = this.Nodes.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "nodes {\n" + fspec + ind + "}\n" ;
            }
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo != null) {
            var fspec = this.PageInfo.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "pageInfo {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count == null && Exploration.Includes(parent + ".count", true))
        {
            this.Count = Int32.MinValue;
        }
        //      C# -> List<O365SharepointDriveEdge>? Edges
        // GraphQL -> edges: [O365SharepointDriveEdge!]! (type)
        if (this.Edges == null && Exploration.Includes(parent + ".edges"))
        {
            this.Edges = new List<O365SharepointDriveEdge>();
            this.Edges.ApplyExploratoryFieldSpec(parent + ".edges");
        }
        //      C# -> List<O365SharepointDrive>? Nodes
        // GraphQL -> nodes: [O365SharepointDrive!]! (type)
        if (this.Nodes == null && Exploration.Includes(parent + ".nodes"))
        {
            this.Nodes = new List<O365SharepointDrive>();
            this.Nodes.ApplyExploratoryFieldSpec(parent + ".nodes");
        }
        //      C# -> PageInfo? PageInfo
        // GraphQL -> pageInfo: PageInfo! (type)
        if (this.PageInfo == null && Exploration.Includes(parent + ".pageInfo"))
        {
            this.PageInfo = new PageInfo();
            this.PageInfo.ApplyExploratoryFieldSpec(parent + ".pageInfo");
        }
    }


    #endregion

    } // class O365SharepointDriveConnection
    
    #endregion

    public static class ListO365SharepointDriveConnectionExtensions
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
            this List<O365SharepointDriveConnection> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<O365SharepointDriveConnection> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new O365SharepointDriveConnection());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
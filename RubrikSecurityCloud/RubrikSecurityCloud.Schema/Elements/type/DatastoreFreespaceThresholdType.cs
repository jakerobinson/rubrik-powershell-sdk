// DatastoreFreespaceThresholdType.cs
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
    #region DatastoreFreespaceThresholdType
    public class DatastoreFreespaceThresholdType: BaseType
    {
        #region members

        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        [JsonProperty("cluster")]
        public Cluster? Cluster { get; set; }

        //      C# -> VmwareDatastoreFreespaceThreshold? DatastoreFreespaceThreshold
        // GraphQL -> datastoreFreespaceThreshold: VmwareDatastoreFreespaceThreshold! (type)
        [JsonProperty("datastoreFreespaceThreshold")]
        public VmwareDatastoreFreespaceThreshold? DatastoreFreespaceThreshold { get; set; }


        #endregion

    #region methods

    public DatastoreFreespaceThresholdType Set(
        Cluster? Cluster = null,
        VmwareDatastoreFreespaceThreshold? DatastoreFreespaceThreshold = null
    ) 
    {
        if ( Cluster != null ) {
            this.Cluster = Cluster;
        }
        if ( DatastoreFreespaceThreshold != null ) {
            this.DatastoreFreespaceThreshold = DatastoreFreespaceThreshold;
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
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            s += ind + "cluster {\n" + this.Cluster.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> VmwareDatastoreFreespaceThreshold? DatastoreFreespaceThreshold
        // GraphQL -> datastoreFreespaceThreshold: VmwareDatastoreFreespaceThreshold! (type)
        if (this.DatastoreFreespaceThreshold != null) {
            s += ind + "datastoreFreespaceThreshold {\n" + this.DatastoreFreespaceThreshold.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster == null && Exploration.Includes(parent + ".cluster"))
        {
            this.Cluster = new Cluster();
            this.Cluster.ApplyExploratoryFieldSpec(parent + ".cluster");
        }
        //      C# -> VmwareDatastoreFreespaceThreshold? DatastoreFreespaceThreshold
        // GraphQL -> datastoreFreespaceThreshold: VmwareDatastoreFreespaceThreshold! (type)
        if (this.DatastoreFreespaceThreshold == null && Exploration.Includes(parent + ".datastoreFreespaceThreshold"))
        {
            this.DatastoreFreespaceThreshold = new VmwareDatastoreFreespaceThreshold();
            this.DatastoreFreespaceThreshold.ApplyExploratoryFieldSpec(parent + ".datastoreFreespaceThreshold");
        }
    }


    #endregion

    } // class DatastoreFreespaceThresholdType
    
    #endregion

    public static class ListDatastoreFreespaceThresholdTypeExtensions
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
            this List<DatastoreFreespaceThresholdType> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DatastoreFreespaceThresholdType> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DatastoreFreespaceThresholdType());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
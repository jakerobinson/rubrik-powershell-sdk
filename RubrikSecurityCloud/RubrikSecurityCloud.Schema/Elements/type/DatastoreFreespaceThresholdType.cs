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
using RubrikSecurityCloud;

namespace RubrikSecurityCloud.Types
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

    public override string GetGqlTypeName() {
        return "DatastoreFreespaceThresholdType";
    }

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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (this.Cluster != null) {
            var fspec = this.Cluster.AsFieldSpec(conf.Child("cluster"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "cluster {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> VmwareDatastoreFreespaceThreshold? DatastoreFreespaceThreshold
        // GraphQL -> datastoreFreespaceThreshold: VmwareDatastoreFreespaceThreshold! (type)
        if (this.DatastoreFreespaceThreshold != null) {
            var fspec = this.DatastoreFreespaceThreshold.AsFieldSpec(conf.Child("datastoreFreespaceThreshold"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "datastoreFreespaceThreshold {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> Cluster? Cluster
        // GraphQL -> cluster: Cluster! (type)
        if (ec.Includes("cluster",false))
        {
            if(this.Cluster == null) {

                this.Cluster = new Cluster();
                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            } else {

                this.Cluster.ApplyExploratoryFieldSpec(ec.NewChild("cluster"));

            }
        }
        else if (this.Cluster != null && ec.Excludes("cluster",false))
        {
            this.Cluster = null;
        }
        //      C# -> VmwareDatastoreFreespaceThreshold? DatastoreFreespaceThreshold
        // GraphQL -> datastoreFreespaceThreshold: VmwareDatastoreFreespaceThreshold! (type)
        if (ec.Includes("datastoreFreespaceThreshold",false))
        {
            if(this.DatastoreFreespaceThreshold == null) {

                this.DatastoreFreespaceThreshold = new VmwareDatastoreFreespaceThreshold();
                this.DatastoreFreespaceThreshold.ApplyExploratoryFieldSpec(ec.NewChild("datastoreFreespaceThreshold"));

            } else {

                this.DatastoreFreespaceThreshold.ApplyExploratoryFieldSpec(ec.NewChild("datastoreFreespaceThreshold"));

            }
        }
        else if (this.DatastoreFreespaceThreshold != null && ec.Excludes("datastoreFreespaceThreshold",false))
        {
            this.DatastoreFreespaceThreshold = null;
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
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<DatastoreFreespaceThresholdType> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DatastoreFreespaceThresholdType> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DatastoreFreespaceThresholdType());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DatastoreFreespaceThresholdType> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
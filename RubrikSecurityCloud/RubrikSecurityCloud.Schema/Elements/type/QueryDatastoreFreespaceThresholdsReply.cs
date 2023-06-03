// QueryDatastoreFreespaceThresholdsReply.cs
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
    #region QueryDatastoreFreespaceThresholdsReply
    public class QueryDatastoreFreespaceThresholdsReply: BaseType
    {
        #region members

        //      C# -> List<DatastoreFreespaceThresholdType>? Thresholds
        // GraphQL -> thresholds: [DatastoreFreespaceThresholdType!]! (type)
        [JsonProperty("thresholds")]
        public List<DatastoreFreespaceThresholdType>? Thresholds { get; set; }


        #endregion

    #region methods

    public QueryDatastoreFreespaceThresholdsReply Set(
        List<DatastoreFreespaceThresholdType>? Thresholds = null
    ) 
    {
        if ( Thresholds != null ) {
            this.Thresholds = Thresholds;
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
        //      C# -> List<DatastoreFreespaceThresholdType>? Thresholds
        // GraphQL -> thresholds: [DatastoreFreespaceThresholdType!]! (type)
        if (this.Thresholds != null) {
            s += ind + "thresholds {\n" + this.Thresholds.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<DatastoreFreespaceThresholdType>? Thresholds
        // GraphQL -> thresholds: [DatastoreFreespaceThresholdType!]! (type)
        if (this.Thresholds == null && Exploration.Includes(parent + ".thresholds"))
        {
            this.Thresholds = new List<DatastoreFreespaceThresholdType>();
            this.Thresholds.ApplyExploratoryFieldSpec(parent + ".thresholds");
        }
    }


    #endregion

    } // class QueryDatastoreFreespaceThresholdsReply
    
    #endregion

    public static class ListQueryDatastoreFreespaceThresholdsReplyExtensions
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
            this List<QueryDatastoreFreespaceThresholdsReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<QueryDatastoreFreespaceThresholdsReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new QueryDatastoreFreespaceThresholdsReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
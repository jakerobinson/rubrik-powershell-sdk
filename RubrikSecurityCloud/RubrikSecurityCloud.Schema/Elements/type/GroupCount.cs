// GroupCount.cs
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
    #region GroupCount
    public class GroupCount: BaseType
    {
        #region members

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }

        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        [JsonProperty("group")]
        public System.String? Group { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "GroupCount";
    }

    public GroupCount Set(
        System.Int32? Count = null,
        System.String? Group = null
    ) 
    {
        if ( Count != null ) {
            this.Count = Count;
        }
        if ( Group != null ) {
            this.Group = Group;
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
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        if (this.Group != null) {
            if (conf.Flat) {
                s += conf.Prefix + "group\n" ;
            } else {
                s += ind + "group\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (ec.Includes("count",true))
        {
            if(this.Count == null) {

                this.Count = Int32.MinValue;

            } else {


            }
        }
        else if (this.Count != null && ec.Excludes("count",true))
        {
            this.Count = null;
        }
        //      C# -> System.String? Group
        // GraphQL -> group: String! (scalar)
        if (ec.Includes("group",true))
        {
            if(this.Group == null) {

                this.Group = "FETCH";

            } else {


            }
        }
        else if (this.Group != null && ec.Excludes("group",true))
        {
            this.Group = null;
        }
    }


    #endregion

    } // class GroupCount
    
    #endregion

    public static class ListGroupCountExtensions
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
            this List<GroupCount> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<GroupCount> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<GroupCount> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new GroupCount());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<GroupCount> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
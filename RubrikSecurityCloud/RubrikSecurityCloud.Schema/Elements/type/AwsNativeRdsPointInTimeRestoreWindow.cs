// AwsNativeRdsPointInTimeRestoreWindow.cs
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
    #region AwsNativeRdsPointInTimeRestoreWindow
    public class AwsNativeRdsPointInTimeRestoreWindow: BaseType
    {
        #region members

        //      C# -> DateTime? EarliestTime
        // GraphQL -> earliestTime: DateTime (scalar)
        [JsonProperty("earliestTime")]
        public DateTime? EarliestTime { get; set; }

        //      C# -> DateTime? LatestTime
        // GraphQL -> latestTime: DateTime (scalar)
        [JsonProperty("latestTime")]
        public DateTime? LatestTime { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsNativeRdsPointInTimeRestoreWindow";
    }

    public AwsNativeRdsPointInTimeRestoreWindow Set(
        DateTime? EarliestTime = null,
        DateTime? LatestTime = null
    ) 
    {
        if ( EarliestTime != null ) {
            this.EarliestTime = EarliestTime;
        }
        if ( LatestTime != null ) {
            this.LatestTime = LatestTime;
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
        //      C# -> DateTime? EarliestTime
        // GraphQL -> earliestTime: DateTime (scalar)
        if (this.EarliestTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "earliestTime\n" ;
            } else {
                s += ind + "earliestTime\n" ;
            }
        }
        //      C# -> DateTime? LatestTime
        // GraphQL -> latestTime: DateTime (scalar)
        if (this.LatestTime != null) {
            if (conf.Flat) {
                s += conf.Prefix + "latestTime\n" ;
            } else {
                s += ind + "latestTime\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? EarliestTime
        // GraphQL -> earliestTime: DateTime (scalar)
        if (ec.Includes("earliestTime",true))
        {
            if(this.EarliestTime == null) {

                this.EarliestTime = new DateTime();

            } else {


            }
        }
        else if (this.EarliestTime != null && ec.Excludes("earliestTime",true))
        {
            this.EarliestTime = null;
        }
        //      C# -> DateTime? LatestTime
        // GraphQL -> latestTime: DateTime (scalar)
        if (ec.Includes("latestTime",true))
        {
            if(this.LatestTime == null) {

                this.LatestTime = new DateTime();

            } else {


            }
        }
        else if (this.LatestTime != null && ec.Excludes("latestTime",true))
        {
            this.LatestTime = null;
        }
    }


    #endregion

    } // class AwsNativeRdsPointInTimeRestoreWindow
    
    #endregion

    public static class ListAwsNativeRdsPointInTimeRestoreWindowExtensions
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
            this List<AwsNativeRdsPointInTimeRestoreWindow> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AwsNativeRdsPointInTimeRestoreWindow> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsNativeRdsPointInTimeRestoreWindow> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsNativeRdsPointInTimeRestoreWindow());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsNativeRdsPointInTimeRestoreWindow> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
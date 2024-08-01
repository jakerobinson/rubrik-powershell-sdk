// SonarChartInfo.cs
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
    #region SonarChartInfo
 
    public class SonarChartInfo: BaseType, NestedMessageParams
    {
        #region members

        //      C# -> SonarChartParams? Value
        // GraphQL -> value: SonarChartParams! (type)
        [JsonProperty("value")]
        public SonarChartParams? Value { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "SonarChartInfo";
    }

    public SonarChartInfo Set(
        SonarChartParams? Value = null
    ) 
    {
        if ( Value != null ) {
            this.Value = Value;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> SonarChartParams? Value
        // GraphQL -> value: SonarChartParams! (type)
        if (this.Value != null) {
            var fspec = this.Value.AsFieldSpec(conf.Child("value"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "value" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> SonarChartParams? Value
        // GraphQL -> value: SonarChartParams! (type)
        if (ec.Includes("value",false))
        {
            if(this.Value == null) {

                this.Value = new SonarChartParams();
                this.Value.ApplyExploratoryFieldSpec(ec.NewChild("value"));

            } else {

                this.Value.ApplyExploratoryFieldSpec(ec.NewChild("value"));

            }
        }
        else if (this.Value != null && ec.Excludes("value",false))
        {
            this.Value = null;
        }
    }


    #endregion

    } // class SonarChartInfo
    
    #endregion

    public static class ListSonarChartInfoExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<SonarChartInfo> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<SonarChartInfo> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<SonarChartInfo> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new SonarChartInfo());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<SonarChartInfo> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
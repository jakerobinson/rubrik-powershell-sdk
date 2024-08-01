// CascadingImpactKeys.cs
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
    #region CascadingImpactKeys
    public class CascadingImpactKeys: BaseType
    {
        #region members

        //      C# -> CascadingImpactActionType? ActionType
        // GraphQL -> actionType: CascadingImpactActionType! (enum)
        [JsonProperty("actionType")]
        public CascadingImpactActionType? ActionType { get; set; }

        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        [JsonProperty("count")]
        public System.Int32? Count { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "cascadingImpactKeys";
    }

    public CascadingImpactKeys Set(
        CascadingImpactActionType? ActionType = null,
        System.Int32? Count = null
    ) 
    {
        if ( ActionType != null ) {
            this.ActionType = ActionType;
        }
        if ( Count != null ) {
            this.Count = Count;
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
        //      C# -> CascadingImpactActionType? ActionType
        // GraphQL -> actionType: CascadingImpactActionType! (enum)
        if (this.ActionType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "actionType\n" ;
            } else {
                s += ind + "actionType\n" ;
            }
        }
        //      C# -> System.Int32? Count
        // GraphQL -> count: Int! (scalar)
        if (this.Count != null) {
            if (conf.Flat) {
                s += conf.Prefix + "count\n" ;
            } else {
                s += ind + "count\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> CascadingImpactActionType? ActionType
        // GraphQL -> actionType: CascadingImpactActionType! (enum)
        if (ec.Includes("actionType",true))
        {
            if(this.ActionType == null) {

                this.ActionType = new CascadingImpactActionType();

            } else {


            }
        }
        else if (this.ActionType != null && ec.Excludes("actionType",true))
        {
            this.ActionType = null;
        }
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
    }


    #endregion

    } // class CascadingImpactKeys
    
    #endregion

    public static class ListCascadingImpactKeysExtensions
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
            this List<CascadingImpactKeys> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<CascadingImpactKeys> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CascadingImpactKeys> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CascadingImpactKeys());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CascadingImpactKeys> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
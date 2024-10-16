// CellData.cs
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
    #region CellData
    public class CellData: BaseType
    {
        #region members

        //      C# -> DisplayableValue? DisplayableValue
        // GraphQL -> displayableValue: DisplayableValue (interface)
        [JsonProperty("displayableValue")]
        public DisplayableValue? DisplayableValue { get; set; }

        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        [JsonProperty("metadata")]
        public List<Metadata>? Metadata { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "CellData";
    }

    public CellData Set(
        DisplayableValue? DisplayableValue = null,
        List<Metadata>? Metadata = null
    ) 
    {
        if ( DisplayableValue != null ) {
            this.DisplayableValue = DisplayableValue;
        }
        if ( Metadata != null ) {
            this.Metadata = Metadata;
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
        //      C# -> DisplayableValue? DisplayableValue
        // GraphQL -> displayableValue: DisplayableValue (interface)
        if (this.DisplayableValue != null) {
                var fspec = InterfaceHelper.MakeListFromComposite((BaseType)this.DisplayableValue).AsFieldSpec(conf.Child("displayableValue"));
            string trimmedFspec = fspec.Replace(" ", "").Replace("\n", "");
            if(trimmedFspec.Length > 0 && !trimmedFspec.Contains("{}")) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "displayableValue {\n" + fspec + ind + "}\n";
                }
            }
        }
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (this.Metadata != null) {
            var fspec = this.Metadata.AsFieldSpec(conf.Child("metadata"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "metadata {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DisplayableValue? DisplayableValue
        // GraphQL -> displayableValue: DisplayableValue (interface)
        if (ec.Includes("displayableValue",false))
        {
            if(this.DisplayableValue == null) {

                var impls = new List<DisplayableValue>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("displayableValue"));
                this.DisplayableValue = (DisplayableValue)InterfaceHelper.MakeCompositeFromList(impls);

            } else {

                // NOT IMPLEMENTED: 
                // adding on to an existing composite object
                var impls = new List<DisplayableValue>();
                impls.ApplyExploratoryFieldSpec(ec.NewChild("displayableValue"));
                this.DisplayableValue = (DisplayableValue)InterfaceHelper.MakeCompositeFromList(impls);

            }
        }
        else if (this.DisplayableValue != null && ec.Excludes("displayableValue",false))
        {
            this.DisplayableValue = null;
        }
        //      C# -> List<Metadata>? Metadata
        // GraphQL -> metadata: [Metadata!]! (type)
        if (ec.Includes("metadata",false))
        {
            if(this.Metadata == null) {

                this.Metadata = new List<Metadata>();
                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            } else {

                this.Metadata.ApplyExploratoryFieldSpec(ec.NewChild("metadata"));

            }
        }
        else if (this.Metadata != null && ec.Excludes("metadata",false))
        {
            this.Metadata = null;
        }
    }


    #endregion

    } // class CellData
    
    #endregion

    public static class ListCellDataExtensions
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
            this List<CellData> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<CellData> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<CellData> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new CellData());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<CellData> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
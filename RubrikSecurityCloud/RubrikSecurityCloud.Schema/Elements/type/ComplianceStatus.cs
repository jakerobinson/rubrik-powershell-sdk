// ComplianceStatus.cs
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
    #region ComplianceStatus
 
    public class ComplianceStatus: BaseType, SnappableGroupByInfo
    {
        #region members

        //      C# -> ComplianceStatusEnum? EnumValue
        // GraphQL -> enumValue: ComplianceStatusEnum! (enum)
        [JsonProperty("enumValue")]
        public ComplianceStatusEnum? EnumValue { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ComplianceStatus";
    }

    public ComplianceStatus Set(
        ComplianceStatusEnum? EnumValue = null
    ) 
    {
        if ( EnumValue != null ) {
            this.EnumValue = EnumValue;
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
        //      C# -> ComplianceStatusEnum? EnumValue
        // GraphQL -> enumValue: ComplianceStatusEnum! (enum)
        if (this.EnumValue != null) {
            if (conf.Flat) {
                s += conf.Prefix + "enumValue\n" ;
            } else {
                s += ind + "enumValue\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> ComplianceStatusEnum? EnumValue
        // GraphQL -> enumValue: ComplianceStatusEnum! (enum)
        if (ec.Includes("enumValue",true))
        {
            if(this.EnumValue == null) {

                this.EnumValue = new ComplianceStatusEnum();

            } else {


            }
        }
        else if (this.EnumValue != null && ec.Excludes("enumValue",true))
        {
            this.EnumValue = null;
        }
    }


    #endregion

    } // class ComplianceStatus
    
    #endregion

    public static class ListComplianceStatusExtensions
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
            this List<ComplianceStatus> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ComplianceStatus> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ComplianceStatus> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ComplianceStatus());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ComplianceStatus> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
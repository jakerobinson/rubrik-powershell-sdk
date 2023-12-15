// ObjectTypeAccessSummary.cs
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
    #region ObjectTypeAccessSummary
    public class ObjectTypeAccessSummary: BaseType
    {
        #region members

        //      C# -> DataGovObjectType? ObjectType
        // GraphQL -> objectType: DataGovObjectType! (enum)
        [JsonProperty("objectType")]
        public DataGovObjectType? ObjectType { get; set; }

        //      C# -> System.Int64? DeltaHits
        // GraphQL -> deltaHits: Long! (scalar)
        [JsonProperty("deltaHits")]
        public System.Int64? DeltaHits { get; set; }

        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        [JsonProperty("totalHits")]
        public System.Int64? TotalHits { get; set; }

        //      C# -> List<PolicySummaryDetails>? PolicySummaryDetails
        // GraphQL -> policySummaryDetails: [PolicySummaryDetails!]! (type)
        [JsonProperty("policySummaryDetails")]
        public List<PolicySummaryDetails>? PolicySummaryDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "ObjectTypeAccessSummary";
    }

    public ObjectTypeAccessSummary Set(
        DataGovObjectType? ObjectType = null,
        System.Int64? DeltaHits = null,
        System.Int64? TotalHits = null,
        List<PolicySummaryDetails>? PolicySummaryDetails = null
    ) 
    {
        if ( ObjectType != null ) {
            this.ObjectType = ObjectType;
        }
        if ( DeltaHits != null ) {
            this.DeltaHits = DeltaHits;
        }
        if ( TotalHits != null ) {
            this.TotalHits = TotalHits;
        }
        if ( PolicySummaryDetails != null ) {
            this.PolicySummaryDetails = PolicySummaryDetails;
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
        //      C# -> DataGovObjectType? ObjectType
        // GraphQL -> objectType: DataGovObjectType! (enum)
        if (this.ObjectType != null) {
            if (conf.Flat) {
                s += conf.Prefix + "objectType\n" ;
            } else {
                s += ind + "objectType\n" ;
            }
        }
        //      C# -> System.Int64? DeltaHits
        // GraphQL -> deltaHits: Long! (scalar)
        if (this.DeltaHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "deltaHits\n" ;
            } else {
                s += ind + "deltaHits\n" ;
            }
        }
        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        if (this.TotalHits != null) {
            if (conf.Flat) {
                s += conf.Prefix + "totalHits\n" ;
            } else {
                s += ind + "totalHits\n" ;
            }
        }
        //      C# -> List<PolicySummaryDetails>? PolicySummaryDetails
        // GraphQL -> policySummaryDetails: [PolicySummaryDetails!]! (type)
        if (this.PolicySummaryDetails != null) {
            var fspec = this.PolicySummaryDetails.AsFieldSpec(conf.Child("policySummaryDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "policySummaryDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DataGovObjectType? ObjectType
        // GraphQL -> objectType: DataGovObjectType! (enum)
        if (ec.Includes("objectType",true))
        {
            if(this.ObjectType == null) {

                this.ObjectType = new DataGovObjectType();

            } else {


            }
        }
        else if (this.ObjectType != null && ec.Excludes("objectType",true))
        {
            this.ObjectType = null;
        }
        //      C# -> System.Int64? DeltaHits
        // GraphQL -> deltaHits: Long! (scalar)
        if (ec.Includes("deltaHits",true))
        {
            if(this.DeltaHits == null) {

                this.DeltaHits = new System.Int64();

            } else {


            }
        }
        else if (this.DeltaHits != null && ec.Excludes("deltaHits",true))
        {
            this.DeltaHits = null;
        }
        //      C# -> System.Int64? TotalHits
        // GraphQL -> totalHits: Long! (scalar)
        if (ec.Includes("totalHits",true))
        {
            if(this.TotalHits == null) {

                this.TotalHits = new System.Int64();

            } else {


            }
        }
        else if (this.TotalHits != null && ec.Excludes("totalHits",true))
        {
            this.TotalHits = null;
        }
        //      C# -> List<PolicySummaryDetails>? PolicySummaryDetails
        // GraphQL -> policySummaryDetails: [PolicySummaryDetails!]! (type)
        if (ec.Includes("policySummaryDetails",false))
        {
            if(this.PolicySummaryDetails == null) {

                this.PolicySummaryDetails = new List<PolicySummaryDetails>();
                this.PolicySummaryDetails.ApplyExploratoryFieldSpec(ec.NewChild("policySummaryDetails"));

            } else {

                this.PolicySummaryDetails.ApplyExploratoryFieldSpec(ec.NewChild("policySummaryDetails"));

            }
        }
        else if (this.PolicySummaryDetails != null && ec.Excludes("policySummaryDetails",false))
        {
            this.PolicySummaryDetails = null;
        }
    }


    #endregion

    } // class ObjectTypeAccessSummary
    
    #endregion

    public static class ListObjectTypeAccessSummaryExtensions
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
            this List<ObjectTypeAccessSummary> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<ObjectTypeAccessSummary> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<ObjectTypeAccessSummary> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new ObjectTypeAccessSummary());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<ObjectTypeAccessSummary> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
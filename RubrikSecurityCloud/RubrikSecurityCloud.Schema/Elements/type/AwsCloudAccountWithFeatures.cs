// AwsCloudAccountWithFeatures.cs
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
    #region AwsCloudAccountWithFeatures
    public class AwsCloudAccountWithFeatures: BaseType
    {
        #region members

        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
        [JsonProperty("awsCloudAccount")]
        public AwsCloudAccount? AwsCloudAccount { get; set; }

        //      C# -> List<FeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [FeatureDetail!]! (type)
        [JsonProperty("featureDetails")]
        public List<FeatureDetail>? FeatureDetails { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AwsCloudAccountWithFeatures";
    }

    public AwsCloudAccountWithFeatures Set(
        AwsCloudAccount? AwsCloudAccount = null,
        List<FeatureDetail>? FeatureDetails = null
    ) 
    {
        if ( AwsCloudAccount != null ) {
            this.AwsCloudAccount = AwsCloudAccount;
        }
        if ( FeatureDetails != null ) {
            this.FeatureDetails = FeatureDetails;
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
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
        if (this.AwsCloudAccount != null) {
            var fspec = this.AwsCloudAccount.AsFieldSpec(conf.Child("awsCloudAccount"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "awsCloudAccount {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        //      C# -> List<FeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [FeatureDetail!]! (type)
        if (this.FeatureDetails != null) {
            var fspec = this.FeatureDetails.AsFieldSpec(conf.Child("featureDetails"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "featureDetails {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> AwsCloudAccount? AwsCloudAccount
        // GraphQL -> awsCloudAccount: AwsCloudAccount (type)
        if (ec.Includes("awsCloudAccount",false))
        {
            if(this.AwsCloudAccount == null) {

                this.AwsCloudAccount = new AwsCloudAccount();
                this.AwsCloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsCloudAccount"));

            } else {

                this.AwsCloudAccount.ApplyExploratoryFieldSpec(ec.NewChild("awsCloudAccount"));

            }
        }
        else if (this.AwsCloudAccount != null && ec.Excludes("awsCloudAccount",false))
        {
            this.AwsCloudAccount = null;
        }
        //      C# -> List<FeatureDetail>? FeatureDetails
        // GraphQL -> featureDetails: [FeatureDetail!]! (type)
        if (ec.Includes("featureDetails",false))
        {
            if(this.FeatureDetails == null) {

                this.FeatureDetails = new List<FeatureDetail>();
                this.FeatureDetails.ApplyExploratoryFieldSpec(ec.NewChild("featureDetails"));

            } else {

                this.FeatureDetails.ApplyExploratoryFieldSpec(ec.NewChild("featureDetails"));

            }
        }
        else if (this.FeatureDetails != null && ec.Excludes("featureDetails",false))
        {
            this.FeatureDetails = null;
        }
    }


    #endregion

    } // class AwsCloudAccountWithFeatures
    
    #endregion

    public static class ListAwsCloudAccountWithFeaturesExtensions
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
            this List<AwsCloudAccountWithFeatures> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<AwsCloudAccountWithFeatures> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccountWithFeatures> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccountWithFeatures());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AwsCloudAccountWithFeatures> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
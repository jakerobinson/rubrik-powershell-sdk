// AwsCloudAccountValidateResponse.cs
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
    #region AwsCloudAccountValidateResponse
    public class AwsCloudAccountValidateResponse: BaseType
    {
        #region members

        //      C# -> List<AwsAccountValidationResponse>? InvalidAwsAccounts
        // GraphQL -> invalidAwsAccounts: [AwsAccountValidationResponse!]! (type)
        [JsonProperty("invalidAwsAccounts")]
        public List<AwsAccountValidationResponse>? InvalidAwsAccounts { get; set; }

        //      C# -> AwsAccountValidationResponse? InvalidAwsAdminAccount
        // GraphQL -> invalidAwsAdminAccount: AwsAccountValidationResponse (type)
        [JsonProperty("invalidAwsAdminAccount")]
        public AwsAccountValidationResponse? InvalidAwsAdminAccount { get; set; }


        #endregion

    #region methods

    public AwsCloudAccountValidateResponse Set(
        List<AwsAccountValidationResponse>? InvalidAwsAccounts = null,
        AwsAccountValidationResponse? InvalidAwsAdminAccount = null
    ) 
    {
        if ( InvalidAwsAccounts != null ) {
            this.InvalidAwsAccounts = InvalidAwsAccounts;
        }
        if ( InvalidAwsAdminAccount != null ) {
            this.InvalidAwsAdminAccount = InvalidAwsAdminAccount;
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
        //      C# -> List<AwsAccountValidationResponse>? InvalidAwsAccounts
        // GraphQL -> invalidAwsAccounts: [AwsAccountValidationResponse!]! (type)
        if (this.InvalidAwsAccounts != null) {
            s += ind + "invalidAwsAccounts {\n" + this.InvalidAwsAccounts.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> AwsAccountValidationResponse? InvalidAwsAdminAccount
        // GraphQL -> invalidAwsAdminAccount: AwsAccountValidationResponse (type)
        if (this.InvalidAwsAdminAccount != null) {
            s += ind + "invalidAwsAdminAccount {\n" + this.InvalidAwsAdminAccount.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<AwsAccountValidationResponse>? InvalidAwsAccounts
        // GraphQL -> invalidAwsAccounts: [AwsAccountValidationResponse!]! (type)
        if (this.InvalidAwsAccounts == null && Exploration.Includes(parent + ".invalidAwsAccounts"))
        {
            this.InvalidAwsAccounts = new List<AwsAccountValidationResponse>();
            this.InvalidAwsAccounts.ApplyExploratoryFieldSpec(parent + ".invalidAwsAccounts");
        }
        //      C# -> AwsAccountValidationResponse? InvalidAwsAdminAccount
        // GraphQL -> invalidAwsAdminAccount: AwsAccountValidationResponse (type)
        if (this.InvalidAwsAdminAccount == null && Exploration.Includes(parent + ".invalidAwsAdminAccount"))
        {
            this.InvalidAwsAdminAccount = new AwsAccountValidationResponse();
            this.InvalidAwsAdminAccount.ApplyExploratoryFieldSpec(parent + ".invalidAwsAdminAccount");
        }
    }


    #endregion

    } // class AwsCloudAccountValidateResponse
    
    #endregion

    public static class ListAwsCloudAccountValidateResponseExtensions
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
            this List<AwsCloudAccountValidateResponse> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AwsCloudAccountValidateResponse> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AwsCloudAccountValidateResponse());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
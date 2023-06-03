// BatchInstantRecoverHypervVmReply.cs
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
    #region BatchInstantRecoverHypervVmReply
    public class BatchInstantRecoverHypervVmReply: BaseType
    {
        #region members

        //      C# -> List<HypervAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [HypervAsyncRequestFailureSummary!]! (type)
        [JsonProperty("failedRequests")]
        public List<HypervAsyncRequestFailureSummary>? FailedRequests { get; set; }

        //      C# -> List<HypervAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [HypervAsyncRequestSuccessSummary!]! (type)
        [JsonProperty("successfulRequests")]
        public List<HypervAsyncRequestSuccessSummary>? SuccessfulRequests { get; set; }


        #endregion

    #region methods

    public BatchInstantRecoverHypervVmReply Set(
        List<HypervAsyncRequestFailureSummary>? FailedRequests = null,
        List<HypervAsyncRequestSuccessSummary>? SuccessfulRequests = null
    ) 
    {
        if ( FailedRequests != null ) {
            this.FailedRequests = FailedRequests;
        }
        if ( SuccessfulRequests != null ) {
            this.SuccessfulRequests = SuccessfulRequests;
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
        //      C# -> List<HypervAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [HypervAsyncRequestFailureSummary!]! (type)
        if (this.FailedRequests != null) {
            s += ind + "failedRequests {\n" + this.FailedRequests.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<HypervAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [HypervAsyncRequestSuccessSummary!]! (type)
        if (this.SuccessfulRequests != null) {
            s += ind + "successfulRequests {\n" + this.SuccessfulRequests.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> List<HypervAsyncRequestFailureSummary>? FailedRequests
        // GraphQL -> failedRequests: [HypervAsyncRequestFailureSummary!]! (type)
        if (this.FailedRequests == null && Exploration.Includes(parent + ".failedRequests"))
        {
            this.FailedRequests = new List<HypervAsyncRequestFailureSummary>();
            this.FailedRequests.ApplyExploratoryFieldSpec(parent + ".failedRequests");
        }
        //      C# -> List<HypervAsyncRequestSuccessSummary>? SuccessfulRequests
        // GraphQL -> successfulRequests: [HypervAsyncRequestSuccessSummary!]! (type)
        if (this.SuccessfulRequests == null && Exploration.Includes(parent + ".successfulRequests"))
        {
            this.SuccessfulRequests = new List<HypervAsyncRequestSuccessSummary>();
            this.SuccessfulRequests.ApplyExploratoryFieldSpec(parent + ".successfulRequests");
        }
    }


    #endregion

    } // class BatchInstantRecoverHypervVmReply
    
    #endregion

    public static class ListBatchInstantRecoverHypervVmReplyExtensions
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
            this List<BatchInstantRecoverHypervVmReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BatchInstantRecoverHypervVmReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BatchInstantRecoverHypervVmReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
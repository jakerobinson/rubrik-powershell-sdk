// ReportGenerateReply.cs
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
    #region ReportGenerateReply
    public class ReportGenerateReply: BaseType
    {
        #region members

        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        [JsonProperty("jobId")]
        public System.Int64? JobId { get; set; }

        //      C# -> System.String? ReferenceId
        // GraphQL -> referenceId: String! (scalar)
        [JsonProperty("referenceId")]
        public System.String? ReferenceId { get; set; }


        #endregion

    #region methods

    public ReportGenerateReply Set(
        System.Int64? JobId = null,
        System.String? ReferenceId = null
    ) 
    {
        if ( JobId != null ) {
            this.JobId = JobId;
        }
        if ( ReferenceId != null ) {
            this.ReferenceId = ReferenceId;
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
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        if (this.JobId != null) {
            s += ind + "jobId\n" ;
        }
        //      C# -> System.String? ReferenceId
        // GraphQL -> referenceId: String! (scalar)
        if (this.ReferenceId != null) {
            s += ind + "referenceId\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int64? JobId
        // GraphQL -> jobId: Long! (scalar)
        if (this.JobId == null && Exploration.Includes(parent + ".jobId", true))
        {
            this.JobId = new System.Int64();
        }
        //      C# -> System.String? ReferenceId
        // GraphQL -> referenceId: String! (scalar)
        if (this.ReferenceId == null && Exploration.Includes(parent + ".referenceId", true))
        {
            this.ReferenceId = new System.String("FETCH");
        }
    }


    #endregion

    } // class ReportGenerateReply
    
    #endregion

    public static class ListReportGenerateReplyExtensions
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
            this List<ReportGenerateReply> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ReportGenerateReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ReportGenerateReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
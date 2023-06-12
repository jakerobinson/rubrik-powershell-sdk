// BulkUpdateFilesetTemplateReply.cs
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
    #region BulkUpdateFilesetTemplateReply
    public class BulkUpdateFilesetTemplateReply: BaseType
    {
        #region members

        //      C# -> BulkCreateFilesetTemplatesReply? Output
        // GraphQL -> output: BulkCreateFilesetTemplatesReply (type)
        [JsonProperty("output")]
        public BulkCreateFilesetTemplatesReply? Output { get; set; }


        #endregion

    #region methods

    public BulkUpdateFilesetTemplateReply Set(
        BulkCreateFilesetTemplatesReply? Output = null
    ) 
    {
        if ( Output != null ) {
            this.Output = Output;
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
        //      C# -> BulkCreateFilesetTemplatesReply? Output
        // GraphQL -> output: BulkCreateFilesetTemplatesReply (type)
        if (this.Output != null) {
            var fspec = this.Output.AsFieldSpec(indent+1);
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                s += ind + "output {\n" + fspec + ind + "}\n" ;
            }
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> BulkCreateFilesetTemplatesReply? Output
        // GraphQL -> output: BulkCreateFilesetTemplatesReply (type)
        if (this.Output == null && Exploration.Includes(parent + ".output"))
        {
            this.Output = new BulkCreateFilesetTemplatesReply();
            this.Output.ApplyExploratoryFieldSpec(parent + ".output");
        }
    }


    #endregion

    } // class BulkUpdateFilesetTemplateReply
    
    #endregion

    public static class ListBulkUpdateFilesetTemplateReplyExtensions
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
            this List<BulkUpdateFilesetTemplateReply> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<BulkUpdateFilesetTemplateReply> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkUpdateFilesetTemplateReply());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
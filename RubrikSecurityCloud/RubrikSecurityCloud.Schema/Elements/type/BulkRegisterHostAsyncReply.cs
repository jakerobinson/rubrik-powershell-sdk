// BulkRegisterHostAsyncReply.cs
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
    #region BulkRegisterHostAsyncReply
    public class BulkRegisterHostAsyncReply: BaseType
    {
        #region members

        //      C# -> V1BulkRegisterHostAsyncResponse? Output
        // GraphQL -> output: V1BulkRegisterHostAsyncResponse (type)
        [JsonProperty("output")]
        public V1BulkRegisterHostAsyncResponse? Output { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "BulkRegisterHostAsyncReply";
    }

    public BulkRegisterHostAsyncReply Set(
        V1BulkRegisterHostAsyncResponse? Output = null
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
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> V1BulkRegisterHostAsyncResponse? Output
        // GraphQL -> output: V1BulkRegisterHostAsyncResponse (type)
        if (this.Output != null) {
            var fspec = this.Output.AsFieldSpec(conf.Child("output"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "output {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> V1BulkRegisterHostAsyncResponse? Output
        // GraphQL -> output: V1BulkRegisterHostAsyncResponse (type)
        if (ec.Includes("output",false))
        {
            if(this.Output == null) {

                this.Output = new V1BulkRegisterHostAsyncResponse();
                this.Output.ApplyExploratoryFieldSpec(ec.NewChild("output"));

            } else {

                this.Output.ApplyExploratoryFieldSpec(ec.NewChild("output"));

            }
        }
        else if (this.Output != null && ec.Excludes("output",false))
        {
            this.Output = null;
        }
    }


    #endregion

    } // class BulkRegisterHostAsyncReply
    
    #endregion

    public static class ListBulkRegisterHostAsyncReplyExtensions
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
            this List<BulkRegisterHostAsyncReply> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<BulkRegisterHostAsyncReply> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<BulkRegisterHostAsyncReply> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new BulkRegisterHostAsyncReply());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<BulkRegisterHostAsyncReply> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
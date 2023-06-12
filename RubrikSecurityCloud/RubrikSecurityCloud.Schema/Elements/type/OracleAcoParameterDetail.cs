// OracleAcoParameterDetail.cs
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
    #region OracleAcoParameterDetail
    public class OracleAcoParameterDetail: BaseType
    {
        #region members

        //      C# -> System.String? Parameter
        // GraphQL -> parameter: String! (scalar)
        [JsonProperty("parameter")]
        public System.String? Parameter { get; set; }

        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        [JsonProperty("value")]
        public System.String? Value { get; set; }


        #endregion

    #region methods

    public OracleAcoParameterDetail Set(
        System.String? Parameter = null,
        System.String? Value = null
    ) 
    {
        if ( Parameter != null ) {
            this.Parameter = Parameter;
        }
        if ( Value != null ) {
            this.Value = Value;
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
        //      C# -> System.String? Parameter
        // GraphQL -> parameter: String! (scalar)
        if (this.Parameter != null) {
            s += ind + "parameter\n" ;
        }
        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        if (this.Value != null) {
            s += ind + "value\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? Parameter
        // GraphQL -> parameter: String! (scalar)
        if (this.Parameter == null && Exploration.Includes(parent + ".parameter", true))
        {
            this.Parameter = "FETCH";
        }
        //      C# -> System.String? Value
        // GraphQL -> value: String! (scalar)
        if (this.Value == null && Exploration.Includes(parent + ".value", true))
        {
            this.Value = "FETCH";
        }
    }


    #endregion

    } // class OracleAcoParameterDetail
    
    #endregion

    public static class ListOracleAcoParameterDetailExtensions
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
            this List<OracleAcoParameterDetail> list,
            int indent=0)
        {
            return list[0].AsFieldSpec(indent);
        }

        public static void ApplyExploratoryFieldSpec(
            this List<OracleAcoParameterDetail> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new OracleAcoParameterDetail());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
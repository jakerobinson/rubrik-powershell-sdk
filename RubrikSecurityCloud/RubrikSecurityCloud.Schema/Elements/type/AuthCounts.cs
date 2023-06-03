// AuthCounts.cs
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
    #region AuthCounts
    public class AuthCounts: BaseType
    {
        #region members

        //      C# -> System.Int32? Authenticated
        // GraphQL -> authenticated: Int! (scalar)
        [JsonProperty("authenticated")]
        public System.Int32? Authenticated { get; set; }

        //      C# -> System.Int32? PartiallyAuthenticated
        // GraphQL -> partiallyAuthenticated: Int! (scalar)
        [JsonProperty("partiallyAuthenticated")]
        public System.Int32? PartiallyAuthenticated { get; set; }

        //      C# -> System.Int32? Unauthenticated
        // GraphQL -> unauthenticated: Int! (scalar)
        [JsonProperty("unauthenticated")]
        public System.Int32? Unauthenticated { get; set; }


        #endregion

    #region methods

    public AuthCounts Set(
        System.Int32? Authenticated = null,
        System.Int32? PartiallyAuthenticated = null,
        System.Int32? Unauthenticated = null
    ) 
    {
        if ( Authenticated != null ) {
            this.Authenticated = Authenticated;
        }
        if ( PartiallyAuthenticated != null ) {
            this.PartiallyAuthenticated = PartiallyAuthenticated;
        }
        if ( Unauthenticated != null ) {
            this.Unauthenticated = Unauthenticated;
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
        //      C# -> System.Int32? Authenticated
        // GraphQL -> authenticated: Int! (scalar)
        if (this.Authenticated != null) {
            s += ind + "authenticated\n" ;
        }
        //      C# -> System.Int32? PartiallyAuthenticated
        // GraphQL -> partiallyAuthenticated: Int! (scalar)
        if (this.PartiallyAuthenticated != null) {
            s += ind + "partiallyAuthenticated\n" ;
        }
        //      C# -> System.Int32? Unauthenticated
        // GraphQL -> unauthenticated: Int! (scalar)
        if (this.Unauthenticated != null) {
            s += ind + "unauthenticated\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Int32? Authenticated
        // GraphQL -> authenticated: Int! (scalar)
        if (this.Authenticated == null && Exploration.Includes(parent + ".authenticated", true))
        {
            this.Authenticated = new System.Int32();
        }
        //      C# -> System.Int32? PartiallyAuthenticated
        // GraphQL -> partiallyAuthenticated: Int! (scalar)
        if (this.PartiallyAuthenticated == null && Exploration.Includes(parent + ".partiallyAuthenticated", true))
        {
            this.PartiallyAuthenticated = new System.Int32();
        }
        //      C# -> System.Int32? Unauthenticated
        // GraphQL -> unauthenticated: Int! (scalar)
        if (this.Unauthenticated == null && Exploration.Includes(parent + ".unauthenticated", true))
        {
            this.Unauthenticated = new System.Int32();
        }
    }


    #endregion

    } // class AuthCounts
    
    #endregion

    public static class ListAuthCountsExtensions
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
            this List<AuthCounts> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<AuthCounts> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new AuthCounts());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
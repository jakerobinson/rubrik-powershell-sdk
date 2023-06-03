// FullSpSiteExclusions.cs
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
    #region FullSpSiteExclusions
    public class FullSpSiteExclusions: BaseType
    {
        #region members

        //      C# -> System.String? SiteFid
        // GraphQL -> siteFid: String! (scalar)
        [JsonProperty("siteFid")]
        public System.String? SiteFid { get; set; }

        //      C# -> List<FullSpObjectExclusion>? ExcludedObjects
        // GraphQL -> excludedObjects: [FullSpObjectExclusion!]! (type)
        [JsonProperty("excludedObjects")]
        public List<FullSpObjectExclusion>? ExcludedObjects { get; set; }


        #endregion

    #region methods

    public FullSpSiteExclusions Set(
        System.String? SiteFid = null,
        List<FullSpObjectExclusion>? ExcludedObjects = null
    ) 
    {
        if ( SiteFid != null ) {
            this.SiteFid = SiteFid;
        }
        if ( ExcludedObjects != null ) {
            this.ExcludedObjects = ExcludedObjects;
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
        //      C# -> System.String? SiteFid
        // GraphQL -> siteFid: String! (scalar)
        if (this.SiteFid != null) {
            s += ind + "siteFid\n" ;
        }
        //      C# -> List<FullSpObjectExclusion>? ExcludedObjects
        // GraphQL -> excludedObjects: [FullSpObjectExclusion!]! (type)
        if (this.ExcludedObjects != null) {
            s += ind + "excludedObjects {\n" + this.ExcludedObjects.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? SiteFid
        // GraphQL -> siteFid: String! (scalar)
        if (this.SiteFid == null && Exploration.Includes(parent + ".siteFid", true))
        {
            this.SiteFid = new System.String("FETCH");
        }
        //      C# -> List<FullSpObjectExclusion>? ExcludedObjects
        // GraphQL -> excludedObjects: [FullSpObjectExclusion!]! (type)
        if (this.ExcludedObjects == null && Exploration.Includes(parent + ".excludedObjects"))
        {
            this.ExcludedObjects = new List<FullSpObjectExclusion>();
            this.ExcludedObjects.ApplyExploratoryFieldSpec(parent + ".excludedObjects");
        }
    }


    #endregion

    } // class FullSpSiteExclusions
    
    #endregion

    public static class ListFullSpSiteExclusionsExtensions
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
            this List<FullSpSiteExclusions> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<FullSpSiteExclusions> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new FullSpSiteExclusions());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
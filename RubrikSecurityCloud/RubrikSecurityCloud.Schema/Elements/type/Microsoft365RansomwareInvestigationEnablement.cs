// Microsoft365RansomwareInvestigationEnablement.cs
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
    #region Microsoft365RansomwareInvestigationEnablement
    public class Microsoft365RansomwareInvestigationEnablement: BaseType
    {
        #region members

        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        [JsonProperty("enabled")]
        public System.Boolean? Enabled { get; set; }

        //      C# -> HierarchyObjectCommon? Subscription
        // GraphQL -> subscription: HierarchyObjectCommon! (type)
        [JsonProperty("subscription")]
        public HierarchyObjectCommon? Subscription { get; set; }


        #endregion

    #region methods

    public Microsoft365RansomwareInvestigationEnablement Set(
        System.Boolean? Enabled = null,
        HierarchyObjectCommon? Subscription = null
    ) 
    {
        if ( Enabled != null ) {
            this.Enabled = Enabled;
        }
        if ( Subscription != null ) {
            this.Subscription = Subscription;
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
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled != null) {
            s += ind + "enabled\n" ;
        }
        //      C# -> HierarchyObjectCommon? Subscription
        // GraphQL -> subscription: HierarchyObjectCommon! (type)
        if (this.Subscription != null) {
            s += ind + "subscription {\n" + this.Subscription.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.Boolean? Enabled
        // GraphQL -> enabled: Boolean! (scalar)
        if (this.Enabled == null && Exploration.Includes(parent + ".enabled", true))
        {
            this.Enabled = true;
        }
        //      C# -> HierarchyObjectCommon? Subscription
        // GraphQL -> subscription: HierarchyObjectCommon! (type)
        if (this.Subscription == null && Exploration.Includes(parent + ".subscription"))
        {
            this.Subscription = new HierarchyObjectCommon();
            this.Subscription.ApplyExploratoryFieldSpec(parent + ".subscription");
        }
    }


    #endregion

    } // class Microsoft365RansomwareInvestigationEnablement
    
    #endregion

    public static class ListMicrosoft365RansomwareInvestigationEnablementExtensions
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
            this List<Microsoft365RansomwareInvestigationEnablement> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<Microsoft365RansomwareInvestigationEnablement> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new Microsoft365RansomwareInvestigationEnablement());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
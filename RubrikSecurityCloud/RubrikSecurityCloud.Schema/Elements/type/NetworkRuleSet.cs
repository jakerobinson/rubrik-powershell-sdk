// NetworkRuleSet.cs
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
    #region NetworkRuleSet
    public class NetworkRuleSet: BaseType
    {
        #region members

        //      C# -> DefaultActionType? DefaultAction
        // GraphQL -> defaultAction: DefaultActionType! (enum)
        [JsonProperty("defaultAction")]
        public DefaultActionType? DefaultAction { get; set; }

        //      C# -> List<IpRule>? IpRules
        // GraphQL -> ipRules: [IpRule!]! (type)
        [JsonProperty("ipRules")]
        public List<IpRule>? IpRules { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NetworkRuleSet";
    }

    public NetworkRuleSet Set(
        DefaultActionType? DefaultAction = null,
        List<IpRule>? IpRules = null
    ) 
    {
        if ( DefaultAction != null ) {
            this.DefaultAction = DefaultAction;
        }
        if ( IpRules != null ) {
            this.IpRules = IpRules;
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
        //      C# -> DefaultActionType? DefaultAction
        // GraphQL -> defaultAction: DefaultActionType! (enum)
        if (this.DefaultAction != null) {
            if (conf.Flat) {
                s += conf.Prefix + "defaultAction\n" ;
            } else {
                s += ind + "defaultAction\n" ;
            }
        }
        //      C# -> List<IpRule>? IpRules
        // GraphQL -> ipRules: [IpRule!]! (type)
        if (this.IpRules != null) {
            var fspec = this.IpRules.AsFieldSpec(conf.Child("ipRules"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "ipRules {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DefaultActionType? DefaultAction
        // GraphQL -> defaultAction: DefaultActionType! (enum)
        if (ec.Includes("defaultAction",true))
        {
            if(this.DefaultAction == null) {

                this.DefaultAction = new DefaultActionType();

            } else {


            }
        }
        else if (this.DefaultAction != null && ec.Excludes("defaultAction",true))
        {
            this.DefaultAction = null;
        }
        //      C# -> List<IpRule>? IpRules
        // GraphQL -> ipRules: [IpRule!]! (type)
        if (ec.Includes("ipRules",false))
        {
            if(this.IpRules == null) {

                this.IpRules = new List<IpRule>();
                this.IpRules.ApplyExploratoryFieldSpec(ec.NewChild("ipRules"));

            } else {

                this.IpRules.ApplyExploratoryFieldSpec(ec.NewChild("ipRules"));

            }
        }
        else if (this.IpRules != null && ec.Excludes("ipRules",false))
        {
            this.IpRules = null;
        }
    }


    #endregion

    } // class NetworkRuleSet
    
    #endregion

    public static class ListNetworkRuleSetExtensions
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
            this List<NetworkRuleSet> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<NetworkRuleSet> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NetworkRuleSet> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NetworkRuleSet());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NetworkRuleSet> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
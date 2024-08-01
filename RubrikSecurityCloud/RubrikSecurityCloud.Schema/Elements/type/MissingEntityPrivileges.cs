// MissingEntityPrivileges.cs
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
    #region MissingEntityPrivileges
    public class MissingEntityPrivileges: BaseType
    {
        #region members

        //      C# -> List<System.String>? MissingPrivileges
        // GraphQL -> missingPrivileges: [String!]! (scalar)
        [JsonProperty("missingPrivileges")]
        public List<System.String>? MissingPrivileges { get; set; }

        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        [JsonProperty("moid")]
        public System.String? Moid { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "MissingEntityPrivileges";
    }

    public MissingEntityPrivileges Set(
        List<System.String>? MissingPrivileges = null,
        System.String? Moid = null,
        System.String? Name = null
    ) 
    {
        if ( MissingPrivileges != null ) {
            this.MissingPrivileges = MissingPrivileges;
        }
        if ( Moid != null ) {
            this.Moid = Moid;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        return this;
    }

        //[JsonIgnore]
    // AsFieldSpec returns a string that denotes what
    // fields are not null, recursively for non-scalar fields.
    public override string AsFieldSpec(FieldSpecConfig? conf=null)
    {
        conf=(conf==null)?new FieldSpecConfig():conf;
        if (this.IsComposite() && ! conf.IgnoreComposition) {
            return InterfaceHelper.CompositeAsFieldSpec((BaseType)this, conf);
        }
        string ind = conf.IndentStr();
        string s = "";
        //      C# -> List<System.String>? MissingPrivileges
        // GraphQL -> missingPrivileges: [String!]! (scalar)
        if (this.MissingPrivileges != null) {
            if (conf.Flat) {
                s += conf.Prefix + "missingPrivileges\n" ;
            } else {
                s += ind + "missingPrivileges\n" ;
            }
        }
        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        if (this.Moid != null) {
            if (conf.Flat) {
                s += conf.Prefix + "moid\n" ;
            } else {
                s += ind + "moid\n" ;
            }
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (this.Name != null) {
            if (conf.Flat) {
                s += conf.Prefix + "name\n" ;
            } else {
                s += ind + "name\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> List<System.String>? MissingPrivileges
        // GraphQL -> missingPrivileges: [String!]! (scalar)
        if (ec.Includes("missingPrivileges",true))
        {
            if(this.MissingPrivileges == null) {

                this.MissingPrivileges = new List<System.String>();

            } else {


            }
        }
        else if (this.MissingPrivileges != null && ec.Excludes("missingPrivileges",true))
        {
            this.MissingPrivileges = null;
        }
        //      C# -> System.String? Moid
        // GraphQL -> moid: String! (scalar)
        if (ec.Includes("moid",true))
        {
            if(this.Moid == null) {

                this.Moid = "FETCH";

            } else {


            }
        }
        else if (this.Moid != null && ec.Excludes("moid",true))
        {
            this.Moid = null;
        }
        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        if (ec.Includes("name",true))
        {
            if(this.Name == null) {

                this.Name = "FETCH";

            } else {


            }
        }
        else if (this.Name != null && ec.Excludes("name",true))
        {
            this.Name = null;
        }
    }


    #endregion

    } // class MissingEntityPrivileges
    
    #endregion

    public static class ListMissingEntityPrivilegesExtensions
    {
        // This SDK uses the convention of defining field specs as
        // the collection of properties that are not null in an object.
        // When creating a field spec for an object, we look at whether
        // the object is a list or not, and whether it implements an interface
        // or not. The following are the possible combinations:
        // S or L: single object or list object
        // SD or II: self-defined or interface-implementing
        // | S/L | SD/II | How fied spec is created
        // |-----|-------|-------------------------
        // | S   | SD    | all properties (including nested objects) that are not null are included in the field spec.
        // | L   | SD    | the field spec of the first item in the list is used. Other items are ignored.
        // | S   | II    | same as S-SD if object is not composite. If object is composite, the field spec of each item in the composition is included as an inline fragment (... on)
        // | L   | II    | the field spec of each item in the list is included as an inline fragment (... on)
        //
        // Note that L-II means that each item in the list is II (not the list itself).
        // This function handles L-SD and L-II cases.
        public static string AsFieldSpec(
            this List<MissingEntityPrivileges> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<MissingEntityPrivileges> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<MissingEntityPrivileges> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new MissingEntityPrivileges());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<MissingEntityPrivileges> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
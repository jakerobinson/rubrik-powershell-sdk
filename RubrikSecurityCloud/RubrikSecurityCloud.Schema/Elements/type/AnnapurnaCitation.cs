// AnnapurnaCitation.cs
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
    #region AnnapurnaCitation
    public class AnnapurnaCitation: BaseType
    {
        #region members

        //      C# -> DateTime? CreatedOn
        // GraphQL -> createdOn: DateTime (scalar)
        [JsonProperty("createdOn")]
        public DateTime? CreatedOn { get; set; }

        //      C# -> System.String? Href
        // GraphQL -> href: String! (scalar)
        [JsonProperty("href")]
        public System.String? Href { get; set; }

        //      C# -> DateTime? LastUpdatedOn
        // GraphQL -> lastUpdatedOn: DateTime (scalar)
        [JsonProperty("lastUpdatedOn")]
        public DateTime? LastUpdatedOn { get; set; }

        //      C# -> System.String? Name
        // GraphQL -> name: String! (scalar)
        [JsonProperty("name")]
        public System.String? Name { get; set; }

        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        [JsonProperty("path")]
        public System.String? Path { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "AnnapurnaCitation";
    }

    public AnnapurnaCitation Set(
        DateTime? CreatedOn = null,
        System.String? Href = null,
        DateTime? LastUpdatedOn = null,
        System.String? Name = null,
        System.String? Path = null
    ) 
    {
        if ( CreatedOn != null ) {
            this.CreatedOn = CreatedOn;
        }
        if ( Href != null ) {
            this.Href = Href;
        }
        if ( LastUpdatedOn != null ) {
            this.LastUpdatedOn = LastUpdatedOn;
        }
        if ( Name != null ) {
            this.Name = Name;
        }
        if ( Path != null ) {
            this.Path = Path;
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
        //      C# -> DateTime? CreatedOn
        // GraphQL -> createdOn: DateTime (scalar)
        if (this.CreatedOn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "createdOn\n" ;
            } else {
                s += ind + "createdOn\n" ;
            }
        }
        //      C# -> System.String? Href
        // GraphQL -> href: String! (scalar)
        if (this.Href != null) {
            if (conf.Flat) {
                s += conf.Prefix + "href\n" ;
            } else {
                s += ind + "href\n" ;
            }
        }
        //      C# -> DateTime? LastUpdatedOn
        // GraphQL -> lastUpdatedOn: DateTime (scalar)
        if (this.LastUpdatedOn != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lastUpdatedOn\n" ;
            } else {
                s += ind + "lastUpdatedOn\n" ;
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
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (this.Path != null) {
            if (conf.Flat) {
                s += conf.Prefix + "path\n" ;
            } else {
                s += ind + "path\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> DateTime? CreatedOn
        // GraphQL -> createdOn: DateTime (scalar)
        if (ec.Includes("createdOn",true))
        {
            if(this.CreatedOn == null) {

                this.CreatedOn = new DateTime();

            } else {


            }
        }
        else if (this.CreatedOn != null && ec.Excludes("createdOn",true))
        {
            this.CreatedOn = null;
        }
        //      C# -> System.String? Href
        // GraphQL -> href: String! (scalar)
        if (ec.Includes("href",true))
        {
            if(this.Href == null) {

                this.Href = "FETCH";

            } else {


            }
        }
        else if (this.Href != null && ec.Excludes("href",true))
        {
            this.Href = null;
        }
        //      C# -> DateTime? LastUpdatedOn
        // GraphQL -> lastUpdatedOn: DateTime (scalar)
        if (ec.Includes("lastUpdatedOn",true))
        {
            if(this.LastUpdatedOn == null) {

                this.LastUpdatedOn = new DateTime();

            } else {


            }
        }
        else if (this.LastUpdatedOn != null && ec.Excludes("lastUpdatedOn",true))
        {
            this.LastUpdatedOn = null;
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
        //      C# -> System.String? Path
        // GraphQL -> path: String! (scalar)
        if (ec.Includes("path",true))
        {
            if(this.Path == null) {

                this.Path = "FETCH";

            } else {


            }
        }
        else if (this.Path != null && ec.Excludes("path",true))
        {
            this.Path = null;
        }
    }


    #endregion

    } // class AnnapurnaCitation
    
    #endregion

    public static class ListAnnapurnaCitationExtensions
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
            this List<AnnapurnaCitation> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<AnnapurnaCitation> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<AnnapurnaCitation> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new AnnapurnaCitation());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<AnnapurnaCitation> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
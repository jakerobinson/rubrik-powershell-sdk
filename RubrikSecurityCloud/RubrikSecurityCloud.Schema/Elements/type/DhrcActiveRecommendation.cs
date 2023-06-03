// DhrcActiveRecommendation.cs
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
    #region DhrcActiveRecommendation
    public class DhrcActiveRecommendation: BaseType
    {
        #region members

        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        [JsonProperty("category")]
        public DhrcCategory? Category { get; set; }

        //      C# -> DhrcRecommendationKey? Key
        // GraphQL -> key: DhrcRecommendationKey! (enum)
        [JsonProperty("key")]
        public DhrcRecommendationKey? Key { get; set; }

        //      C# -> DateTime? CompiledAt
        // GraphQL -> compiledAt: DateTime (scalar)
        [JsonProperty("compiledAt")]
        public DateTime? CompiledAt { get; set; }

        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        [JsonProperty("earliestMetric")]
        public DateTime? EarliestMetric { get; set; }

        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        [JsonProperty("message")]
        public System.String? Message { get; set; }

        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        [JsonProperty("weight")]
        public System.Single? Weight { get; set; }

        //      C# -> List<DhrcKeyValue>? TranslationArgs
        // GraphQL -> translationArgs: [DhrcKeyValue!]! (type)
        [JsonProperty("translationArgs")]
        public List<DhrcKeyValue>? TranslationArgs { get; set; }


        #endregion

    #region methods

    public DhrcActiveRecommendation Set(
        DhrcCategory? Category = null,
        DhrcRecommendationKey? Key = null,
        DateTime? CompiledAt = null,
        DateTime? EarliestMetric = null,
        System.String? Message = null,
        System.Single? Weight = null,
        List<DhrcKeyValue>? TranslationArgs = null
    ) 
    {
        if ( Category != null ) {
            this.Category = Category;
        }
        if ( Key != null ) {
            this.Key = Key;
        }
        if ( CompiledAt != null ) {
            this.CompiledAt = CompiledAt;
        }
        if ( EarliestMetric != null ) {
            this.EarliestMetric = EarliestMetric;
        }
        if ( Message != null ) {
            this.Message = Message;
        }
        if ( Weight != null ) {
            this.Weight = Weight;
        }
        if ( TranslationArgs != null ) {
            this.TranslationArgs = TranslationArgs;
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
        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        if (this.Category != null) {
            s += ind + "category\n" ;
        }
        //      C# -> DhrcRecommendationKey? Key
        // GraphQL -> key: DhrcRecommendationKey! (enum)
        if (this.Key != null) {
            s += ind + "key\n" ;
        }
        //      C# -> DateTime? CompiledAt
        // GraphQL -> compiledAt: DateTime (scalar)
        if (this.CompiledAt != null) {
            s += ind + "compiledAt\n" ;
        }
        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        if (this.EarliestMetric != null) {
            s += ind + "earliestMetric\n" ;
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message != null) {
            s += ind + "message\n" ;
        }
        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        if (this.Weight != null) {
            s += ind + "weight\n" ;
        }
        //      C# -> List<DhrcKeyValue>? TranslationArgs
        // GraphQL -> translationArgs: [DhrcKeyValue!]! (type)
        if (this.TranslationArgs != null) {
            s += ind + "translationArgs {\n" + this.TranslationArgs.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> DhrcCategory? Category
        // GraphQL -> category: DhrcCategory! (enum)
        if (this.Category == null && Exploration.Includes(parent + ".category", true))
        {
            this.Category = new DhrcCategory();
        }
        //      C# -> DhrcRecommendationKey? Key
        // GraphQL -> key: DhrcRecommendationKey! (enum)
        if (this.Key == null && Exploration.Includes(parent + ".key", true))
        {
            this.Key = new DhrcRecommendationKey();
        }
        //      C# -> DateTime? CompiledAt
        // GraphQL -> compiledAt: DateTime (scalar)
        if (this.CompiledAt == null && Exploration.Includes(parent + ".compiledAt", true))
        {
            this.CompiledAt = new DateTime();
        }
        //      C# -> DateTime? EarliestMetric
        // GraphQL -> earliestMetric: DateTime (scalar)
        if (this.EarliestMetric == null && Exploration.Includes(parent + ".earliestMetric", true))
        {
            this.EarliestMetric = new DateTime();
        }
        //      C# -> System.String? Message
        // GraphQL -> message: String! (scalar)
        if (this.Message == null && Exploration.Includes(parent + ".message", true))
        {
            this.Message = new System.String("FETCH");
        }
        //      C# -> System.Single? Weight
        // GraphQL -> weight: Float! (scalar)
        if (this.Weight == null && Exploration.Includes(parent + ".weight", true))
        {
            this.Weight = new System.Single();
        }
        //      C# -> List<DhrcKeyValue>? TranslationArgs
        // GraphQL -> translationArgs: [DhrcKeyValue!]! (type)
        if (this.TranslationArgs == null && Exploration.Includes(parent + ".translationArgs"))
        {
            this.TranslationArgs = new List<DhrcKeyValue>();
            this.TranslationArgs.ApplyExploratoryFieldSpec(parent + ".translationArgs");
        }
    }


    #endregion

    } // class DhrcActiveRecommendation
    
    #endregion

    public static class ListDhrcActiveRecommendationExtensions
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
            this List<DhrcActiveRecommendation> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<DhrcActiveRecommendation> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new DhrcActiveRecommendation());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
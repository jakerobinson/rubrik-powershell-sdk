// KnowledgeBaseArticle.cs
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
    #region KnowledgeBaseArticle
    public class KnowledgeBaseArticle: BaseType
    {
        #region members

        //      C# -> System.String? ArticleNumber
        // GraphQL -> articleNumber: String! (scalar)
        [JsonProperty("articleNumber")]
        public System.String? ArticleNumber { get; set; }

        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        [JsonProperty("description")]
        public System.String? Description { get; set; }

        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        [JsonProperty("id")]
        public System.String? Id { get; set; }

        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        [JsonProperty("title")]
        public System.String? Title { get; set; }

        //      C# -> List<ContentNode>? Cause
        // GraphQL -> cause: [ContentNode!]! (type)
        [JsonProperty("cause")]
        public List<ContentNode>? Cause { get; set; }

        //      C# -> List<ContentNode>? Environment
        // GraphQL -> environment: [ContentNode!]! (type)
        [JsonProperty("environment")]
        public List<ContentNode>? Environment { get; set; }

        //      C# -> List<ContentNode>? Notes
        // GraphQL -> notes: [ContentNode!]! (type)
        [JsonProperty("notes")]
        public List<ContentNode>? Notes { get; set; }

        //      C# -> List<ContentNode>? Resolution
        // GraphQL -> resolution: [ContentNode!]! (type)
        [JsonProperty("resolution")]
        public List<ContentNode>? Resolution { get; set; }

        //      C# -> List<ContentNode>? Summary
        // GraphQL -> summary: [ContentNode!]! (type)
        [JsonProperty("summary")]
        public List<ContentNode>? Summary { get; set; }


        #endregion

    #region methods

    public KnowledgeBaseArticle Set(
        System.String? ArticleNumber = null,
        System.String? Description = null,
        System.String? Id = null,
        System.String? Title = null,
        List<ContentNode>? Cause = null,
        List<ContentNode>? Environment = null,
        List<ContentNode>? Notes = null,
        List<ContentNode>? Resolution = null,
        List<ContentNode>? Summary = null
    ) 
    {
        if ( ArticleNumber != null ) {
            this.ArticleNumber = ArticleNumber;
        }
        if ( Description != null ) {
            this.Description = Description;
        }
        if ( Id != null ) {
            this.Id = Id;
        }
        if ( Title != null ) {
            this.Title = Title;
        }
        if ( Cause != null ) {
            this.Cause = Cause;
        }
        if ( Environment != null ) {
            this.Environment = Environment;
        }
        if ( Notes != null ) {
            this.Notes = Notes;
        }
        if ( Resolution != null ) {
            this.Resolution = Resolution;
        }
        if ( Summary != null ) {
            this.Summary = Summary;
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
        //      C# -> System.String? ArticleNumber
        // GraphQL -> articleNumber: String! (scalar)
        if (this.ArticleNumber != null) {
            s += ind + "articleNumber\n" ;
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description != null) {
            s += ind + "description\n" ;
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id != null) {
            s += ind + "id\n" ;
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title != null) {
            s += ind + "title\n" ;
        }
        //      C# -> List<ContentNode>? Cause
        // GraphQL -> cause: [ContentNode!]! (type)
        if (this.Cause != null) {
            s += ind + "cause {\n" + this.Cause.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ContentNode>? Environment
        // GraphQL -> environment: [ContentNode!]! (type)
        if (this.Environment != null) {
            s += ind + "environment {\n" + this.Environment.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ContentNode>? Notes
        // GraphQL -> notes: [ContentNode!]! (type)
        if (this.Notes != null) {
            s += ind + "notes {\n" + this.Notes.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ContentNode>? Resolution
        // GraphQL -> resolution: [ContentNode!]! (type)
        if (this.Resolution != null) {
            s += ind + "resolution {\n" + this.Resolution.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> List<ContentNode>? Summary
        // GraphQL -> summary: [ContentNode!]! (type)
        if (this.Summary != null) {
            s += ind + "summary {\n" + this.Summary.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ArticleNumber
        // GraphQL -> articleNumber: String! (scalar)
        if (this.ArticleNumber == null && Exploration.Includes(parent + ".articleNumber", true))
        {
            this.ArticleNumber = new System.String("FETCH");
        }
        //      C# -> System.String? Description
        // GraphQL -> description: String! (scalar)
        if (this.Description == null && Exploration.Includes(parent + ".description", true))
        {
            this.Description = new System.String("FETCH");
        }
        //      C# -> System.String? Id
        // GraphQL -> id: String! (scalar)
        if (this.Id == null && Exploration.Includes(parent + ".id", true))
        {
            this.Id = new System.String("FETCH");
        }
        //      C# -> System.String? Title
        // GraphQL -> title: String! (scalar)
        if (this.Title == null && Exploration.Includes(parent + ".title", true))
        {
            this.Title = new System.String("FETCH");
        }
        //      C# -> List<ContentNode>? Cause
        // GraphQL -> cause: [ContentNode!]! (type)
        if (this.Cause == null && Exploration.Includes(parent + ".cause"))
        {
            this.Cause = new List<ContentNode>();
            this.Cause.ApplyExploratoryFieldSpec(parent + ".cause");
        }
        //      C# -> List<ContentNode>? Environment
        // GraphQL -> environment: [ContentNode!]! (type)
        if (this.Environment == null && Exploration.Includes(parent + ".environment"))
        {
            this.Environment = new List<ContentNode>();
            this.Environment.ApplyExploratoryFieldSpec(parent + ".environment");
        }
        //      C# -> List<ContentNode>? Notes
        // GraphQL -> notes: [ContentNode!]! (type)
        if (this.Notes == null && Exploration.Includes(parent + ".notes"))
        {
            this.Notes = new List<ContentNode>();
            this.Notes.ApplyExploratoryFieldSpec(parent + ".notes");
        }
        //      C# -> List<ContentNode>? Resolution
        // GraphQL -> resolution: [ContentNode!]! (type)
        if (this.Resolution == null && Exploration.Includes(parent + ".resolution"))
        {
            this.Resolution = new List<ContentNode>();
            this.Resolution.ApplyExploratoryFieldSpec(parent + ".resolution");
        }
        //      C# -> List<ContentNode>? Summary
        // GraphQL -> summary: [ContentNode!]! (type)
        if (this.Summary == null && Exploration.Includes(parent + ".summary"))
        {
            this.Summary = new List<ContentNode>();
            this.Summary.ApplyExploratoryFieldSpec(parent + ".summary");
        }
    }


    #endregion

    } // class KnowledgeBaseArticle
    
    #endregion

    public static class ListKnowledgeBaseArticleExtensions
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
            this List<KnowledgeBaseArticle> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<KnowledgeBaseArticle> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new KnowledgeBaseArticle());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
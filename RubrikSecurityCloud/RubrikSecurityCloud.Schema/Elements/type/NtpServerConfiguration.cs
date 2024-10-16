// NtpServerConfiguration.cs
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
    #region NtpServerConfiguration
    public class NtpServerConfiguration: BaseType
    {
        #region members

        //      C# -> System.String? Server
        // GraphQL -> server: String! (scalar)
        [JsonProperty("server")]
        public System.String? Server { get; set; }

        //      C# -> NtpSymmKeyConfiguration? SymmetricKey
        // GraphQL -> symmetricKey: NtpSymmKeyConfiguration (type)
        [JsonProperty("symmetricKey")]
        public NtpSymmKeyConfiguration? SymmetricKey { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "NtpServerConfiguration";
    }

    public NtpServerConfiguration Set(
        System.String? Server = null,
        NtpSymmKeyConfiguration? SymmetricKey = null
    ) 
    {
        if ( Server != null ) {
            this.Server = Server;
        }
        if ( SymmetricKey != null ) {
            this.SymmetricKey = SymmetricKey;
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
        //      C# -> System.String? Server
        // GraphQL -> server: String! (scalar)
        if (this.Server != null) {
            if (conf.Flat) {
                s += conf.Prefix + "server\n" ;
            } else {
                s += ind + "server\n" ;
            }
        }
        //      C# -> NtpSymmKeyConfiguration? SymmetricKey
        // GraphQL -> symmetricKey: NtpSymmKeyConfiguration (type)
        if (this.SymmetricKey != null) {
            var fspec = this.SymmetricKey.AsFieldSpec(conf.Child("symmetricKey"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "symmetricKey {\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? Server
        // GraphQL -> server: String! (scalar)
        if (ec.Includes("server",true))
        {
            if(this.Server == null) {

                this.Server = "FETCH";

            } else {


            }
        }
        else if (this.Server != null && ec.Excludes("server",true))
        {
            this.Server = null;
        }
        //      C# -> NtpSymmKeyConfiguration? SymmetricKey
        // GraphQL -> symmetricKey: NtpSymmKeyConfiguration (type)
        if (ec.Includes("symmetricKey",false))
        {
            if(this.SymmetricKey == null) {

                this.SymmetricKey = new NtpSymmKeyConfiguration();
                this.SymmetricKey.ApplyExploratoryFieldSpec(ec.NewChild("symmetricKey"));

            } else {

                this.SymmetricKey.ApplyExploratoryFieldSpec(ec.NewChild("symmetricKey"));

            }
        }
        else if (this.SymmetricKey != null && ec.Excludes("symmetricKey",false))
        {
            this.SymmetricKey = null;
        }
    }


    #endregion

    } // class NtpServerConfiguration
    
    #endregion

    public static class ListNtpServerConfigurationExtensions
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
            this List<NtpServerConfiguration> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<NtpServerConfiguration> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<NtpServerConfiguration> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new NtpServerConfiguration());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<NtpServerConfiguration> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
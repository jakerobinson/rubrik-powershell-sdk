// DataLocationsPerKmsKeyVault.cs
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
    #region DataLocationsPerKmsKeyVault
    public class DataLocationsPerKmsKeyVault: BaseType
    {
        #region members

        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        [JsonProperty("keyName")]
        public System.String? KeyName { get; set; }

        //      C# -> System.String? KeyVersion
        // GraphQL -> keyVersion: String! (scalar)
        [JsonProperty("keyVersion")]
        public System.String? KeyVersion { get; set; }

        //      C# -> System.String? KmsKeyVaultId
        // GraphQL -> kmsKeyVaultId: UUID! (scalar)
        [JsonProperty("kmsKeyVaultId")]
        public System.String? KmsKeyVaultId { get; set; }

        //      C# -> DataLocationInfo? DataLocationInfo
        // GraphQL -> dataLocationInfo: DataLocationInfo (type)
        [JsonProperty("dataLocationInfo")]
        public DataLocationInfo? DataLocationInfo { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "DataLocationsPerKmsKeyVault";
    }

    public DataLocationsPerKmsKeyVault Set(
        System.String? KeyName = null,
        System.String? KeyVersion = null,
        System.String? KmsKeyVaultId = null,
        DataLocationInfo? DataLocationInfo = null
    ) 
    {
        if ( KeyName != null ) {
            this.KeyName = KeyName;
        }
        if ( KeyVersion != null ) {
            this.KeyVersion = KeyVersion;
        }
        if ( KmsKeyVaultId != null ) {
            this.KmsKeyVaultId = KmsKeyVaultId;
        }
        if ( DataLocationInfo != null ) {
            this.DataLocationInfo = DataLocationInfo;
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
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (this.KeyName != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyName\n" ;
            } else {
                s += ind + "keyName\n" ;
            }
        }
        //      C# -> System.String? KeyVersion
        // GraphQL -> keyVersion: String! (scalar)
        if (this.KeyVersion != null) {
            if (conf.Flat) {
                s += conf.Prefix + "keyVersion\n" ;
            } else {
                s += ind + "keyVersion\n" ;
            }
        }
        //      C# -> System.String? KmsKeyVaultId
        // GraphQL -> kmsKeyVaultId: UUID! (scalar)
        if (this.KmsKeyVaultId != null) {
            if (conf.Flat) {
                s += conf.Prefix + "kmsKeyVaultId\n" ;
            } else {
                s += ind + "kmsKeyVaultId\n" ;
            }
        }
        //      C# -> DataLocationInfo? DataLocationInfo
        // GraphQL -> dataLocationInfo: DataLocationInfo (type)
        if (this.DataLocationInfo != null) {
            var fspec = this.DataLocationInfo.AsFieldSpec(conf.Child("dataLocationInfo"));
            if(fspec.Replace(" ", "").Replace("\n", "").Length > 0) {
                if (conf.Flat) {
                    s += conf.Prefix + fspec;
                } else {
                    s += ind + "dataLocationInfo" + " " + "{\n" + fspec + ind + "}\n" ;
                }
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> System.String? KeyName
        // GraphQL -> keyName: String! (scalar)
        if (ec.Includes("keyName",true))
        {
            if(this.KeyName == null) {

                this.KeyName = "FETCH";

            } else {


            }
        }
        else if (this.KeyName != null && ec.Excludes("keyName",true))
        {
            this.KeyName = null;
        }
        //      C# -> System.String? KeyVersion
        // GraphQL -> keyVersion: String! (scalar)
        if (ec.Includes("keyVersion",true))
        {
            if(this.KeyVersion == null) {

                this.KeyVersion = "FETCH";

            } else {


            }
        }
        else if (this.KeyVersion != null && ec.Excludes("keyVersion",true))
        {
            this.KeyVersion = null;
        }
        //      C# -> System.String? KmsKeyVaultId
        // GraphQL -> kmsKeyVaultId: UUID! (scalar)
        if (ec.Includes("kmsKeyVaultId",true))
        {
            if(this.KmsKeyVaultId == null) {

                this.KmsKeyVaultId = "FETCH";

            } else {


            }
        }
        else if (this.KmsKeyVaultId != null && ec.Excludes("kmsKeyVaultId",true))
        {
            this.KmsKeyVaultId = null;
        }
        //      C# -> DataLocationInfo? DataLocationInfo
        // GraphQL -> dataLocationInfo: DataLocationInfo (type)
        if (ec.Includes("dataLocationInfo",false))
        {
            if(this.DataLocationInfo == null) {

                this.DataLocationInfo = new DataLocationInfo();
                this.DataLocationInfo.ApplyExploratoryFieldSpec(ec.NewChild("dataLocationInfo"));

            } else {

                this.DataLocationInfo.ApplyExploratoryFieldSpec(ec.NewChild("dataLocationInfo"));

            }
        }
        else if (this.DataLocationInfo != null && ec.Excludes("dataLocationInfo",false))
        {
            this.DataLocationInfo = null;
        }
    }


    #endregion

    } // class DataLocationsPerKmsKeyVault
    
    #endregion

    public static class ListDataLocationsPerKmsKeyVaultExtensions
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
            this List<DataLocationsPerKmsKeyVault> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child(ignoreComposition: true)); // L-SD
        }

        public static List<string> SelectedFields(this List<DataLocationsPerKmsKeyVault> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<DataLocationsPerKmsKeyVault> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new DataLocationsPerKmsKeyVault());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<DataLocationsPerKmsKeyVault> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
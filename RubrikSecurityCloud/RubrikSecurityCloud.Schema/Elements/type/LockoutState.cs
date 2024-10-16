// LockoutState.cs
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
    #region LockoutState
    public class LockoutState: BaseType
    {
        #region members

        //      C# -> LockMethod? LockMethod
        // GraphQL -> lockMethod: LockMethod! (enum)
        [JsonProperty("lockMethod")]
        public LockMethod? LockMethod { get; set; }

        //      C# -> UnlockMethod? UnlockMethod
        // GraphQL -> unlockMethod: UnlockMethod! (enum)
        [JsonProperty("unlockMethod")]
        public UnlockMethod? UnlockMethod { get; set; }

        //      C# -> System.Boolean? IsLocked
        // GraphQL -> isLocked: Boolean! (scalar)
        [JsonProperty("isLocked")]
        public System.Boolean? IsLocked { get; set; }

        //      C# -> DateTime? LockedAt
        // GraphQL -> lockedAt: DateTime (scalar)
        [JsonProperty("lockedAt")]
        public DateTime? LockedAt { get; set; }

        //      C# -> DateTime? UnlockedAt
        // GraphQL -> unlockedAt: DateTime (scalar)
        [JsonProperty("unlockedAt")]
        public DateTime? UnlockedAt { get; set; }


        #endregion

    #region methods

    public override string GetGqlTypeName() {
        return "LockoutState";
    }

    public LockoutState Set(
        LockMethod? LockMethod = null,
        UnlockMethod? UnlockMethod = null,
        System.Boolean? IsLocked = null,
        DateTime? LockedAt = null,
        DateTime? UnlockedAt = null
    ) 
    {
        if ( LockMethod != null ) {
            this.LockMethod = LockMethod;
        }
        if ( UnlockMethod != null ) {
            this.UnlockMethod = UnlockMethod;
        }
        if ( IsLocked != null ) {
            this.IsLocked = IsLocked;
        }
        if ( LockedAt != null ) {
            this.LockedAt = LockedAt;
        }
        if ( UnlockedAt != null ) {
            this.UnlockedAt = UnlockedAt;
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
        //      C# -> LockMethod? LockMethod
        // GraphQL -> lockMethod: LockMethod! (enum)
        if (this.LockMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lockMethod\n" ;
            } else {
                s += ind + "lockMethod\n" ;
            }
        }
        //      C# -> UnlockMethod? UnlockMethod
        // GraphQL -> unlockMethod: UnlockMethod! (enum)
        if (this.UnlockMethod != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unlockMethod\n" ;
            } else {
                s += ind + "unlockMethod\n" ;
            }
        }
        //      C# -> System.Boolean? IsLocked
        // GraphQL -> isLocked: Boolean! (scalar)
        if (this.IsLocked != null) {
            if (conf.Flat) {
                s += conf.Prefix + "isLocked\n" ;
            } else {
                s += ind + "isLocked\n" ;
            }
        }
        //      C# -> DateTime? LockedAt
        // GraphQL -> lockedAt: DateTime (scalar)
        if (this.LockedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "lockedAt\n" ;
            } else {
                s += ind + "lockedAt\n" ;
            }
        }
        //      C# -> DateTime? UnlockedAt
        // GraphQL -> unlockedAt: DateTime (scalar)
        if (this.UnlockedAt != null) {
            if (conf.Flat) {
                s += conf.Prefix + "unlockedAt\n" ;
            } else {
                s += ind + "unlockedAt\n" ;
            }
        }
        return s;
    }


    
    public override void ApplyExploratoryFieldSpec(ExplorationContext ec)
    {
        //      C# -> LockMethod? LockMethod
        // GraphQL -> lockMethod: LockMethod! (enum)
        if (ec.Includes("lockMethod",true))
        {
            if(this.LockMethod == null) {

                this.LockMethod = new LockMethod();

            } else {


            }
        }
        else if (this.LockMethod != null && ec.Excludes("lockMethod",true))
        {
            this.LockMethod = null;
        }
        //      C# -> UnlockMethod? UnlockMethod
        // GraphQL -> unlockMethod: UnlockMethod! (enum)
        if (ec.Includes("unlockMethod",true))
        {
            if(this.UnlockMethod == null) {

                this.UnlockMethod = new UnlockMethod();

            } else {


            }
        }
        else if (this.UnlockMethod != null && ec.Excludes("unlockMethod",true))
        {
            this.UnlockMethod = null;
        }
        //      C# -> System.Boolean? IsLocked
        // GraphQL -> isLocked: Boolean! (scalar)
        if (ec.Includes("isLocked",true))
        {
            if(this.IsLocked == null) {

                this.IsLocked = true;

            } else {


            }
        }
        else if (this.IsLocked != null && ec.Excludes("isLocked",true))
        {
            this.IsLocked = null;
        }
        //      C# -> DateTime? LockedAt
        // GraphQL -> lockedAt: DateTime (scalar)
        if (ec.Includes("lockedAt",true))
        {
            if(this.LockedAt == null) {

                this.LockedAt = new DateTime();

            } else {


            }
        }
        else if (this.LockedAt != null && ec.Excludes("lockedAt",true))
        {
            this.LockedAt = null;
        }
        //      C# -> DateTime? UnlockedAt
        // GraphQL -> unlockedAt: DateTime (scalar)
        if (ec.Includes("unlockedAt",true))
        {
            if(this.UnlockedAt == null) {

                this.UnlockedAt = new DateTime();

            } else {


            }
        }
        else if (this.UnlockedAt != null && ec.Excludes("unlockedAt",true))
        {
            this.UnlockedAt = null;
        }
    }


    #endregion

    } // class LockoutState
    
    #endregion

    public static class ListLockoutStateExtensions
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
            this List<LockoutState> list,
            FieldSpecConfig? conf=null)
        {
            conf=(conf==null)?new FieldSpecConfig():conf;
            return list[0].AsFieldSpec(conf.Child());
        }

        public static List<string> SelectedFields(this List<LockoutState> list)
        {
            return StringUtils.FieldSpecStringToList(
                list.AsFieldSpec(new FieldSpecConfig { Flat = true }));
        }



        public static void ApplyExploratoryFieldSpec(
            this List<LockoutState> list, 
            ExplorationContext ec)
        {
            if ( list.Count == 0 ) {
                list.Add(new LockoutState());
            }
            list[0].ApplyExploratoryFieldSpec(ec);
        }

        public static void SelectForRetrieval(this List<LockoutState> list)
        {
            list.ApplyExploratoryFieldSpec(new ExplorationContext());
        }
    }


} // namespace RubrikSecurityCloud.Types
// ClusterWebCertAndIpmi.cs
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
    #region ClusterWebCertAndIpmi
    public class ClusterWebCertAndIpmi: BaseType
    {
        #region members

        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        [JsonProperty("clusterUuid")]
        public System.String? ClusterUuid { get; set; }

        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        [JsonProperty("error")]
        public System.String? Error { get; set; }

        //      C# -> ClusterWebSignedCertificateReply? CertInfo
        // GraphQL -> certInfo: ClusterWebSignedCertificateReply (type)
        [JsonProperty("certInfo")]
        public ClusterWebSignedCertificateReply? CertInfo { get; set; }

        //      C# -> ModifyIpmiReply? IpmiInfo
        // GraphQL -> ipmiInfo: ModifyIpmiReply (type)
        [JsonProperty("ipmiInfo")]
        public ModifyIpmiReply? IpmiInfo { get; set; }


        #endregion

    #region methods

    public ClusterWebCertAndIpmi Set(
        System.String? ClusterUuid = null,
        System.String? Error = null,
        ClusterWebSignedCertificateReply? CertInfo = null,
        ModifyIpmiReply? IpmiInfo = null
    ) 
    {
        if ( ClusterUuid != null ) {
            this.ClusterUuid = ClusterUuid;
        }
        if ( Error != null ) {
            this.Error = Error;
        }
        if ( CertInfo != null ) {
            this.CertInfo = CertInfo;
        }
        if ( IpmiInfo != null ) {
            this.IpmiInfo = IpmiInfo;
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
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid != null) {
            s += ind + "clusterUuid\n" ;
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error != null) {
            s += ind + "error\n" ;
        }
        //      C# -> ClusterWebSignedCertificateReply? CertInfo
        // GraphQL -> certInfo: ClusterWebSignedCertificateReply (type)
        if (this.CertInfo != null) {
            s += ind + "certInfo {\n" + this.CertInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        //      C# -> ModifyIpmiReply? IpmiInfo
        // GraphQL -> ipmiInfo: ModifyIpmiReply (type)
        if (this.IpmiInfo != null) {
            s += ind + "ipmiInfo {\n" + this.IpmiInfo.AsFieldSpec(indent+1) + ind + "}\n" ;
        }
        return s;
    }


    
    //[JsonIgnore]
    public override void ApplyExploratoryFieldSpec(String parent = "")
    {
        //      C# -> System.String? ClusterUuid
        // GraphQL -> clusterUuid: UUID! (scalar)
        if (this.ClusterUuid == null && Exploration.Includes(parent + ".clusterUuid", true))
        {
            this.ClusterUuid = new System.String("FETCH");
        }
        //      C# -> System.String? Error
        // GraphQL -> error: String! (scalar)
        if (this.Error == null && Exploration.Includes(parent + ".error", true))
        {
            this.Error = new System.String("FETCH");
        }
        //      C# -> ClusterWebSignedCertificateReply? CertInfo
        // GraphQL -> certInfo: ClusterWebSignedCertificateReply (type)
        if (this.CertInfo == null && Exploration.Includes(parent + ".certInfo"))
        {
            this.CertInfo = new ClusterWebSignedCertificateReply();
            this.CertInfo.ApplyExploratoryFieldSpec(parent + ".certInfo");
        }
        //      C# -> ModifyIpmiReply? IpmiInfo
        // GraphQL -> ipmiInfo: ModifyIpmiReply (type)
        if (this.IpmiInfo == null && Exploration.Includes(parent + ".ipmiInfo"))
        {
            this.IpmiInfo = new ModifyIpmiReply();
            this.IpmiInfo.ApplyExploratoryFieldSpec(parent + ".ipmiInfo");
        }
    }


    #endregion

    } // class ClusterWebCertAndIpmi
    
    #endregion

    public static class ListClusterWebCertAndIpmiExtensions
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
            this List<ClusterWebCertAndIpmi> list,
            int indent=0)
        {
            string ind = new string(' ', indent*2);
            return ind + list[0].AsFieldSpec();
        }

        public static void ApplyExploratoryFieldSpec(
            this List<ClusterWebCertAndIpmi> list, 
            String parent = "")
        {
            if ( list.Count == 0 ) {
                list.Add(new ClusterWebCertAndIpmi());
            }
            list[0].ApplyExploratoryFieldSpec(parent);
        }
    }


} // namespace Rubrik.SecurityCloud.Types
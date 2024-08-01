// EmailAddressFilterType.cs
//
// This generated file is part of the Rubrik PowerShell SDK.
// Manual changes to this file may be lost.

#nullable enable
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using System.Runtime.Serialization;

namespace RubrikSecurityCloud.Types
{
    public enum EmailAddressFilterType
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "FROM")]
        FROM,

        [EnumMember(Value = "TO")]
        TO,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum EmailAddressFilterType

} // namespace RubrikSecurityCloud.Types
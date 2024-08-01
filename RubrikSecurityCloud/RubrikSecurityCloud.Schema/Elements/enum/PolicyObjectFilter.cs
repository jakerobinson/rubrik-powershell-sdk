// PolicyObjectFilter.cs
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
    public enum PolicyObjectFilter
    {
        [EnumMember(Value = "ALL")]
        ALL,

        [EnumMember(Value = "HAS_OBJECTS")]
        HAS_OBJECTS,

        [EnumMember(Value = "NO_OBJECTS")]
        NO_OBJECTS,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum PolicyObjectFilter

} // namespace RubrikSecurityCloud.Types
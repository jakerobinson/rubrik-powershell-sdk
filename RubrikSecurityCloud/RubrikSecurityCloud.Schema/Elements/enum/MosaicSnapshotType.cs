// MosaicSnapshotType.cs
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
    public enum MosaicSnapshotType
    {
        [EnumMember(Value = "FULL")]
        FULL,

        [EnumMember(Value = "INCREMENTAL")]
        INCREMENTAL,

        [EnumMember(Value = "INVALID")]
        INVALID,

        [EnumMember(Value = "UNKNOWN")]
        UNKNOWN


    } // enum MosaicSnapshotType

} // namespace RubrikSecurityCloud.Types
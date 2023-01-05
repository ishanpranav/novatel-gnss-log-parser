// GnssFirmwareSignatureStatus.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using CsvHelper.Configuration.Attributes;

namespace IrvineCubeSat.GpsParser
{
    /// <summary>
    /// Specifies a firmware signature status.
    /// </summary>
    public enum GnssFirmwareSignatureStatus
    {
        /// <summary>
        /// Empty.
        /// </summary>
        Empty,

        /// <summary>
        /// No status.
        /// </summary>
        [Name("NONE")]
        None = 1,

        /// <summary>
        /// An invalid firmware signature.
        /// </summary>
        [Name("INVALID")]
        Invalid = 2,

        /// <summary>
        /// A valid firmware signature.
        /// </summary>
        [Name("VALID")]
        Valid = 3,

        /// <summary>
        /// Reserved.
        /// </summary>
        [Name("RESERVED")]
        Reserved = 4,

        /// <summary>
        /// High speed firmware signature status.
        /// </summary>
        [Name("HIGH_SPEED")]
        HighSpeed = 5
    }
}

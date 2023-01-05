// GnssAuthorizationCodeType.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using CsvHelper.Configuration.Attributes;

namespace IrvineCubeSat.GpsParser
{
    /// <summary>
    /// Specifies the types of authorization codes.
    /// </summary>
    public enum GnssAuthorizationCodeType
    {
        /// <summary>
        /// No authorization code.
        /// </summary>
        None = 0,

        /// <summary>
        /// A standard authorization code.
        /// </summary>
        [Name("STANDARD")]
        Standard = 1,

        /// <summary>
        /// A signature authorization code.
        /// </summary>
        [Name("SIGNATURE")]
        Signature = 2,

        /// <summary>
        /// An embedded authorization code.
        /// </summary>
        [Name("EMBEDDED")]
        Embedded = 3
    }
}

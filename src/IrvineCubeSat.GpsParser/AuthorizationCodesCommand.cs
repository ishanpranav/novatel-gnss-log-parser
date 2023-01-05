// AuthorizationCodesCommand.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;
using IrvineCubeSat.GpsParser.Attributes;
using IrvineCubeSat.GpsParser.BodyParsers;

namespace IrvineCubeSat.GpsParser
{
    /// <summary>
    /// Represents a list of authorization codes (<c>AUTHCODES</c>) command message body.
    /// </summary>
    [Command("AUTHCODES", typeof(AuthorizationCodesParser))]
    public class AuthorizationCodesCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuthorizationCodesCommand"/> class.
        /// </summary>
        /// <param name="firmwareSignatureStatus">The status of the firmware signature.</param>
        /// <param name="authorizationCodeType">The authorization code type.</param>
        /// <param name="valid"><see langword="true"/> if the authorization code has been verified; otherwise, <see langword="false"/>.</param>
        /// <param name="authorizationCode">The authorization code string.</param>
        public AuthorizationCodesCommand(GnssFirmwareSignatureStatus firmwareSignatureStatus, GnssAuthorizationCodeType authorizationCodeType, bool valid, string authorizationCode)
        {
            FirmwareSignatureStatus = firmwareSignatureStatus;
            AuthorizationCodeType = authorizationCodeType;
            Valid = valid;
            AuthorizationCode = authorizationCode;
        }

        /// <summary>
        /// Gets the status of the firmware signature.
        /// </summary>
        /// <value>The status of the firmware signature.</value>
        [LocalizedCategory(nameof(AuthorizationCode))]
        [LocalizedDescription(nameof(FirmwareSignatureStatus))]
        [LocalizedDisplayName(nameof(FirmwareSignatureStatus))]
        public GnssFirmwareSignatureStatus FirmwareSignatureStatus { get; }

        /// <summary>
        /// Gets the authorization code type.
        /// </summary>
        /// <value>The authorization code type.</value>
        [LocalizedCategory(nameof(AuthorizationCode))]
        [LocalizedDescription(nameof(AuthorizationCodeType))]
        [LocalizedDisplayName(nameof(AuthorizationCodeType))]
        public GnssAuthorizationCodeType AuthorizationCodeType { get; }

        /// <summary>
        /// Gets a value indicating whether the authorization code has been verified.
        /// </summary>
        /// <value><see langword="true"/> if the authorization code has been verified; otherwise, <see langword="false"/>.</value>
        [LocalizedCategory(nameof(AuthorizationCode))]
        [LocalizedDescription(nameof(Valid))]
        [LocalizedDisplayName(nameof(Valid))]
        public bool Valid { get; }

        /// <summary>
        /// Gets an ASCII string representing the authorization code.
        /// </summary>
        /// <value>The authorization code string.</value>
        [LocalizedCategory(nameof(AuthorizationCode))]
        [LocalizedDescription(nameof(AuthorizationCode))]
        [LocalizedDisplayName(nameof(AuthorizationCode))]
        public string AuthorizationCode { get; }
    }
}

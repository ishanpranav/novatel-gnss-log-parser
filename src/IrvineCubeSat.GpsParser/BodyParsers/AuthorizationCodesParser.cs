// AuthorizationCodesParser.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using CsvHelper;

namespace IrvineCubeSat.GpsParser.BodyParsers
{
    /// <summary>
    /// Provides a specialized parser for the body of the <see cref="AuthorizationCodesCommand"/>. 
    /// </summary>
    public class AuthorizationCodesParser : IBodyParser
    {
        /// <inheritdoc/>
        public object ParseBody(Type type, CsvReader reader)
        {
            if (!type.IsAssignableFrom(typeof(AuthorizationCodesCommand)))
            {
                throw new ArgumentException("The specified type is not supported by this parser.", nameof(type));
            }

            int index = 2;
            int count = reader.GetField<int>(index: 1);
            GnssFirmwareSignatureStatus firmwareSignatureStatus = reader.GetField<GnssFirmwareSignatureStatus>(index: 0);
            AuthorizationCodesCommand[] messages = new AuthorizationCodesCommand[count];

            for (int i = 0; i < count; i++)
            {
                messages[i] = new AuthorizationCodesCommand(
                    firmwareSignatureStatus,
                    reader.GetField<GnssAuthorizationCodeType>(index),
                    reader.GetField<bool>(index + 1),
                    reader.GetField<string>(index + 2));
                index += 3;
            }

            return messages;
        }
    }
}

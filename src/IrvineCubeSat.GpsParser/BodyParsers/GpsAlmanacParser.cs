// GpsAlmanacParser.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using CsvHelper;
using CsvHelper.TypeConversion;

namespace IrvineCubeSat.GpsParser.BodyParsers
{
    /// <summary>
    /// Provides a specialized parser for the body of the <see cref="GpsAlmanacCommand"/>. 
    /// </summary>
    public class GpsAlmanacParser : IBodyParser
    {
        /// <inheritdoc/>
        public object ParseBody(Type type, CsvReader reader)
        {
            if (!type.IsAssignableFrom(typeof(GpsAlmanacCommand)))
            {
                throw new ArgumentException("The specified type is not supported by this parser.", nameof(type));
            }

            int index = 1;
            int count = reader.GetField<int>(index: 0);
            GpsAlmanacCommand[] messages = new GpsAlmanacCommand[count];
            ExponentDoubleConverter converter = ExponentDoubleConverter.Default;

            for (int i = 0; i < count; i++)
            {
                messages[i] = new GpsAlmanacCommand(
                    reader.GetField<uint>(index),
                    reader.GetField<uint>(index + 1),
                    reader.GetField<double>(index + 2),
                    reader.GetField<double>(index + 3, converter),
                    reader.GetField<double>(index + 5, converter),
                    reader.GetField<double>(index + 4, converter),
                    reader.GetField<double>(index + 6, converter),
                    reader.GetField<double>(index + 7, converter),
                    reader.GetField<double>(index + 8, converter),
                    reader.GetField<double>(index + 9, converter),
                    reader.GetField<double>(index + 10, converter),
                    reader.GetField<double>(index + 11, converter),
                    reader.GetField<double>(index + 12, converter),
                    reader.GetField<bool>(index + 16));
                index += 17;
            }

            return messages;
        }
    }
}

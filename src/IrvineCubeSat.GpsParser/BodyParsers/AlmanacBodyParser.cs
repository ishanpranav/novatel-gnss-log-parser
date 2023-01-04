// AlmanacBodyParser.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using CsvHelper;
using CsvHelper.TypeConversion;

namespace IrvineCubeSat.GpsParser.BodyParsers
{
    /// <summary>
    /// A specialized parser for the body of the <see cref="AlmanacCommand"/>. 
    /// </summary>
    public class AlmanacBodyParser : IBodyParser
    {
        /// <inheritdoc/>
        public object ParseBody(Type type, CsvReader reader)
        {
            if (!type.IsAssignableFrom(typeof(AlmanacCommand)))
            {
                throw new ArgumentException("The specified type is not supported by this parser.", nameof(type));
            }

            int count = reader.GetField<int>(0);
            int index = 1;
            AlmanacCommand[] messages = new AlmanacCommand[count];
            ExponentDoubleConverter converter = new ExponentDoubleConverter();

            for (int i = 0; i < count; i++)
            {
                messages[i] = new AlmanacCommand(
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

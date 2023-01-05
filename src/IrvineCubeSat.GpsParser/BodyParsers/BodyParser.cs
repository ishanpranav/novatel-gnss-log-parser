// BodyParser.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using CsvHelper;

namespace IrvineCubeSat.GpsParser.BodyParsers
{
    /// <summary>
    /// Provides a generalized <see cref="IBodyParser"/> which reads directly from a CSV reader.
    /// </summary>
    public class BodyParser : IBodyParser
    {
        /// <inheritdoc/>
        public object ParseBody(Type type, CsvReader reader)
        {
            return reader.GetRecord(type);
        }
    }
}

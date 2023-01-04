// IBodyParser.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using CsvHelper;

namespace IrvineCubeSat.GpsParser.BodyParsers
{
    /// <summary>
    /// Defines a method for parsing a command log body.
    /// </summary>
    public interface IBodyParser
    {
        /// <summary>
        /// Parses the command log body.
        /// </summary>
        /// <param name="type">The command type.</param>
        /// <param name="reader">The CSV reader.</param>
        /// <returns>A command model of the specified <see cref="type"/>.</returns>
        /// <exception cref="ArgumentException">The parser cannot interpret the specified command <see cref="type"/>.</exception>
        object ParseBody(Type type, CsvReader reader);
    }
}

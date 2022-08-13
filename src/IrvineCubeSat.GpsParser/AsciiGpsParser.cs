﻿// AsciiGpsParser.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.TypeConversion;
using IrvineCubeSat.GpsParser.Attributes;

namespace IrvineCubeSat.GpsParser
{
    /// <summary>
    /// Represents an ASCII GNSS log parser.
    /// </summary>
    public class AsciiGpsParser
    {
        private const RegexOptions Options = RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant;

        private static readonly Regex s_messageRegex = new Regex(pattern: @"#(?<A>(?<B>[^;\*]+);(?<C>[^;\*]+))\*(?<D>[a-f\d]+)", Options);
        private static readonly Regex s_whiteSpaceRegex = new Regex(pattern: @"[\n\r\s\t]+", Options);

        private readonly Dictionary<string, Type> _types = new Dictionary<string, Type>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Initializes a new instance of the <see cref="AsciiGpsParser"/> class.
        /// </summary>
        public AsciiGpsParser()
        {
            foreach (Type exportedType in typeof(AsciiGpsParser).Assembly.GetExportedTypes())
            {
                TryRegister(exportedType);
            }
        }

        /// <summary>
        /// Attempts to register the specified command message body type.
        /// </summary>
        /// <typeparam name="T">The type containing the model for the command message body.</typeparam>
        /// <returns><see langword="true"/> if the command message body type was registered successfully; otherwise, <see langword="false"/>.</returns>
        /// <remarks><typeparamref name="T"/> must be annotated with the <see cref="CommandAttribute"/>.</remarks>
        public bool TryRegister<T>()
        {
            return TryRegister(typeof(T));
        }

        /// <summary>
        /// Attempts to register the specified command message body type.
        /// </summary>
        /// <param name="type">The type containing the model for the command message body.</param>
        /// <returns><see langword="true"/> if the command message body type was registered successfully; otherwise, <see langword="false"/>.</returns>
        /// <remarks>The <paramref name="type"/> must be annotated with the <see cref="CommandAttribute"/>.</remarks>
        public bool TryRegister(Type type)
        {
            if (Attribute.GetCustomAttribute(type, typeof(CommandAttribute)) is CommandAttribute attribute)
            {
                return _types.TryAdd(attribute.Command, type);
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Asynchronously parses the ASCII GNSS log. 
        /// </summary>
        /// <param name="value">The log text.</param>
        /// <returns>An asynchronous iterator containing the ASCII messages read.</returns>
        public async IAsyncEnumerable<AsciiMessage> ParseAsync(string value)
        {
            value = s_whiteSpaceRegex.Replace(value, string.Empty);

            foreach (Match match in s_messageRegex.Matches(value))
            {
                AsciiMessageHeader header;
                CsvConfiguration configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Encoding = Encoding.ASCII,
                    HasHeaderRecord = false,
                    MissingFieldFound = null
                };
                SecondsTimeSpanConverter timeSpanConverter = new SecondsTimeSpanConverter();

                using (StringReader stringReader = new StringReader(match.Groups["B"].Value))
                using (CsvReader csvReader = new CsvReader(stringReader, configuration))
                {
                    csvReader.Context.TypeConverterCache.AddConverter<TimeSpan>(timeSpanConverter);

                    await csvReader.ReadAsync();

                    header = csvReader.GetRecord<AsciiMessageHeader>();

                    header.Command = header.Command.Substring(startIndex: 0, header.Command.Length - 1);
                }

                object body;

                using (StringReader stringReader = new StringReader(match.Groups["C"].Value))
                using (CsvReader csvReader = new CsvReader(stringReader, configuration))
                {
                    csvReader.Context.TypeConverterCache.AddConverter<TimeSpan>(timeSpanConverter);

                    await csvReader.ReadAsync();

                    body = csvReader.GetRecord(_types[header.Command]);
                }

                yield return new AsciiMessage(match.Groups["A"].Value, header, body, uint.Parse(match.Groups["D"].Value, NumberStyles.HexNumber));
            }
        }
    }
}

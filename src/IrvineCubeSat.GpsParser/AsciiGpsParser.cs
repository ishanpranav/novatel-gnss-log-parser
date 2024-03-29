﻿// AsciiGpsParser.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using CsvHelper;
using CsvHelper.Configuration;
using IrvineCubeSat.GpsParser.Attributes;
using IrvineCubeSat.GpsParser.BodyParsers;

namespace IrvineCubeSat.GpsParser
{
    /// <summary>
    /// Represents an ASCII GNSS log parser.
    /// </summary>
    public class AsciiGpsParser
    {
        private const RegexOptions Options = RegexOptions.IgnoreCase | RegexOptions.Compiled | RegexOptions.CultureInvariant;

        private static readonly Regex s_messageRegex = new Regex(pattern: @"#(?<A>[^\*]+)\*(?<B>[a-f\d]+)", Options);
        private static readonly Regex s_whiteSpaceRegex = new Regex(pattern: @"[\n\r\s\t]+", Options);

        private readonly Dictionary<string, TypePair> _types = new Dictionary<string, TypePair>(StringComparer.OrdinalIgnoreCase);

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
            CommandAttribute? attribute = type.GetCustomAttribute<CommandAttribute>();

            if (attribute == null)
            {
                return false;
            }
            else
            {
                return _types.TryAdd(attribute.Name, new TypePair(type, attribute.ParserType));
            }
        }

        /// <summary>
        /// Registers the specified command message body type.
        /// </summary>
        /// <typeparam name="T">The type containing the model for the command message body.</typeparam>
        /// <exception cref="ArgumentException">The command message body type is not annotated with the <see cref="CommandAttribute"/>.</exception>
        public void Register<T>()
        {
            if (!TryRegister<T>())
            {
                throw new ArgumentException($"The command message body type must be annotated with {typeof(CommandAttribute).FullName}.", nameof(T));
            }
        }

        /// <summary>
        /// Registers the specified command message body type.
        /// </summary>
        /// <param name="type">The type containing the model for the command message body.</typeparam>
        /// <exception cref="ArgumentException">The command message body type is not annotated with the <see cref="CommandAttribute"/>.</exception>
        public void Register(Type type)
        {
            if (!TryRegister(type))
            {
                throw new ArgumentException($"The command message body type must be annotated with {typeof(CommandAttribute).FullName}.", nameof(type));
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
                string a = match.Groups["A"].Value;

                using StringReader stringReader = new StringReader(a);
                using CsvReader csvReader = new CsvReader(stringReader, new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    Encoding = Encoding.ASCII,
                    HasHeaderRecord = false,
                    MissingFieldFound = null,
                    NewLine = ";"
                });

                await csvReader.ReadAsync();

                AsciiMessageHeader header = csvReader.GetRecord<AsciiMessageHeader>();

                header.Command = header.Command.Substring(startIndex: 0, header.Command.Length - 1);

                if (_types.TryGetValue(header.Command, out TypePair pair))
                {
                    IBodyParser parser = (IBodyParser)Activator.CreateInstance(pair.ParserType);

                    await csvReader.ReadAsync();

                    object body = parser.ParseBody(pair.CommandType, csvReader);

                    yield return new AsciiMessage(a, header, body, uint.Parse(match.Groups["B"].Value, NumberStyles.HexNumber));
                }
            }
        }
    }
}

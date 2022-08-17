// HexUInt32Converter.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System.Globalization;
using CsvHelper.Configuration;

namespace CsvHelper.TypeConversion
{
    /// <summary>
    /// Converts a <see cref="uint"/> to and from a hexadecimal <see cref="string"/>.
    /// </summary>
    public class HexUInt32Converter : DefaultTypeConverter
    {
        /// <inheritdoc/>
        public override object ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
        {
            if (text == null)
            {
                return 0u;
            }
            else
            {
                return uint.Parse(text, NumberStyles.HexNumber);
            }
        }

        /// <inheritdoc/>
        public override string ConvertToString(object? value, IWriterRow row, MemberMapData memberMapData)
        {
            if (value is uint integer)
            {
                return integer.ToString(format: "x");
            }
            else
            {
                return base.ConvertToString(value, row, memberMapData);
            }
        }
    }
}

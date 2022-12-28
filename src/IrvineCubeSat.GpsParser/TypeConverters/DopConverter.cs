// DopConverter.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using CsvHelper.Configuration;
using IrvineCubeSat.GpsParser;

namespace CsvHelper.TypeConversion
{
    internal sealed class DopConverter : DefaultTypeConverter
    {
        /// <inheritdoc/>
        public override object ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
        {
            if (float.TryParse(text, out float result))
            {
                return new Dop(result);
            }
            else
            {
                return Dop.Empty;
            }
        }

        /// <inheritdoc/>
        public override string ConvertToString(object? value, IWriterRow row, MemberMapData memberMapData)
        {
            if (value is Dop dop)
            {
                return dop.Value.ToString();
            }
            else
            {
                return base.ConvertToString(value, row, memberMapData);
            }
        }
    }
}

// ExponentDoubleConverter.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;
using CsvHelper.Configuration;

namespace CsvHelper.TypeConversion
{
    internal sealed class ExponentDoubleConverter : DoubleConverter
    {
        private static ExponentDoubleConverter? s_instance;

        private ExponentDoubleConverter() { }

        public static ExponentDoubleConverter Default
        {
            get
            {
                s_instance ??= new ExponentDoubleConverter();

                return s_instance;
            }
        }

        /// <inheritdoc/>
        public override object ConvertFromString(string? text, IReaderRow row, MemberMapData memberMapData)
        {
            if (double.TryParse(text, NumberStyles.Float, CultureInfo.InvariantCulture, out double result))
            {
                return result;
            }
            else
            {
                return 0d;
            }
        }

        /// <inheritdoc/>
        public override string ConvertToString(object? value, IWriterRow row, MemberMapData memberMapData)
        {
            if (value is IFormattable formattable)
            {
                return formattable.ToString(format: "e", formatProvider: null);
            }
            else
            {
                return base.ConvertToString(value, row, memberMapData);
            }
        }
    }
}

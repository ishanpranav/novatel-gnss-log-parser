// SecondsTimeSpanConverter.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using CsvHelper.Configuration;

namespace CsvHelper.TypeConversion
{
    internal sealed class SecondsTimeSpanConverter : DefaultTypeConverter
    {
        public override object ConvertFromString(string text, IReaderRow row, MemberMapData memberMapData)
        {
            if (float.TryParse(text, out float result))
            {
                return TimeSpan.FromSeconds(result);
            }
            else
            {
                return base.ConvertFromString(text, row, memberMapData);
            }
        }

        public override string ConvertToString(object value, IWriterRow row, MemberMapData memberMapData)
        {
            if (value is TimeSpan timeSpan)
            {
                return timeSpan.TotalSeconds.ToString();
            }
            else
            {
                return base.ConvertToString(value, row, memberMapData);
            }
        }
    }
}

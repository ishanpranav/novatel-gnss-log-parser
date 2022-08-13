// ReceiverStatusCommand.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;
using CsvHelper.Configuration.Attributes;
using CsvHelper.TypeConversion;
using IrvineCubeSat.GpsParser.Attributes;

namespace IrvineCubeSat.GpsParser
{
    [Command("RXSTATUS")]
    [DefaultProperty(nameof(ReceiverStatus))]
    public class ReceiverStatusCommand
    {
        [Index(0)]
        [ReadOnly(true)]
        public GnssReceiverErrors Error { get; set; }

        [Index(1)]
        [LocalizedDescription(nameof(StatusCodes))]
        [LocalizedDisplayName(nameof(StatusCodes))]
        [ReadOnly(true)]
        public uint StatusCodes { get; set; }

        [Index(2)]
        [LocalizedDescription(nameof(ReceiverStatus))]
        [LocalizedDisplayName(nameof(ReceiverStatus))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(HexUInt32Converter))]
        public GnssReceiverStatus ReceiverStatus { get; set; }

        [Index(6)]
        [LocalizedDescription(nameof(Auxiliary1Status))]
        [LocalizedDisplayName(nameof(Auxiliary1Status))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(HexUInt32Converter))]
        public GnssAuxiliary1Status Auxiliary1Status { get; set; }

        [Index(10)]
        [LocalizedDescription(nameof(Auxiliary2Status))]
        [LocalizedDisplayName(nameof(Auxiliary2Status))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(HexUInt32Converter))]
        public GnssAuxiliary2Status Auxiliary2Status { get; set; }

        [Index(14)]
        [LocalizedDescription(nameof(Auxiliary3Status))]
        [LocalizedDisplayName(nameof(Auxiliary3Status))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(HexUInt32Converter))]
        public GnssAuxiliary3Status Auxiliary3Status { get; set; }

        [Index(18)]
        [LocalizedDescription(nameof(Auxiliary4Status))]
        [LocalizedDisplayName(nameof(Auxiliary4Status))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(HexUInt32Converter))]
        public GnssAuxiliary4Status Auxiliary4Status { get; set; }
    }
}

// ReceiverStatusCommand.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;
using System.Globalization;
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
        [LocalizedCategory(nameof(ReceiverStatus))]
        [LocalizedDescription(nameof(Error))]
        [LocalizedDisplayName(nameof(Error))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssReceiverErrors Error { get; set; }

        [Index(1)]
        [LocalizedCategory(nameof(ReceiverStatus))]
        [LocalizedDescription(nameof(StatusCodes))]
        [LocalizedDisplayName(nameof(StatusCodes))]
        [ReadOnly(true)]
        public uint StatusCodes { get; set; }

        [Index(2)]
        [LocalizedCategory(nameof(ReceiverStatus))]
        [LocalizedDescription(nameof(ReceiverStatus))]
        [LocalizedDisplayName(nameof(ReceiverStatus))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssReceiverStatus ReceiverStatus { get; set; }

        [Index(3)]
        [LocalizedCategory(nameof(ReceiverStatus))]
        [LocalizedDescription(nameof(ReceiverStatusPriorityMask))]
        [LocalizedDisplayName(nameof(ReceiverStatusPriorityMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssReceiverStatus ReceiverStatusPriorityMask { get; set; }

        [Index(4)]
        [LocalizedCategory(nameof(ReceiverStatus))]
        [LocalizedDescription(nameof(ReceiverStatusEventSetMask))]
        [LocalizedDisplayName(nameof(ReceiverStatusEventSetMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssReceiverStatus ReceiverStatusEventSetMask { get; set; }

        [Index(5)]
        [LocalizedCategory(nameof(ReceiverStatus))]
        [LocalizedDescription(nameof(ReceiverStatusEventSetMask))]
        [LocalizedDisplayName(nameof(ReceiverStatusEventSetMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssReceiverStatus ReceiverStatusEventClearMask { get; set; }

        [Index(6)]
        [LocalizedCategory(nameof(Auxiliary1Status))]
        [LocalizedDescription(nameof(Auxiliary1Status))]
        [LocalizedDisplayName(nameof(Auxiliary1Status))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary1Status Auxiliary1Status { get; set; }

        [Index(7)]
        [LocalizedCategory(nameof(Auxiliary1Status))]
        [LocalizedDescription(nameof(Auxiliary1StatusPriorityMask))]
        [LocalizedDisplayName(nameof(Auxiliary1StatusPriorityMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary1Status Auxiliary1StatusPriorityMask { get; set; }

        [Index(8)]
        [LocalizedCategory(nameof(Auxiliary1Status))]
        [LocalizedDescription(nameof(Auxiliary1StatusEventSetMask))]
        [LocalizedDisplayName(nameof(Auxiliary1StatusEventSetMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary1Status Auxiliary1StatusEventSetMask { get; set; }

        [Index(9)]
        [LocalizedCategory(nameof(Auxiliary1Status))]
        [LocalizedDescription(nameof(Auxiliary1StatusEventClearMask))]
        [LocalizedDisplayName(nameof(Auxiliary1StatusEventClearMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary1Status Auxiliary1StatusEventClearMask { get; set; }

        [Index(10)]
        [LocalizedCategory(nameof(Auxiliary2Status))]
        [LocalizedDescription(nameof(Auxiliary2Status))]
        [LocalizedDisplayName(nameof(Auxiliary2Status))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary2Status Auxiliary2Status { get; set; }

        [Index(11)]
        [LocalizedCategory(nameof(Auxiliary2Status))]
        [LocalizedDescription(nameof(Auxiliary2StatusPriorityMask))]
        [LocalizedDisplayName(nameof(Auxiliary2StatusPriorityMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary2Status Auxiliary2StatusPriorityMask { get; set; }

        [Index(12)]
        [LocalizedCategory(nameof(Auxiliary2Status))]
        [LocalizedDescription(nameof(Auxiliary2StatusEventSetMask))]
        [LocalizedDisplayName(nameof(Auxiliary2StatusEventSetMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary2Status Auxiliary2StatusEventSetMask { get; set; }

        [Index(13)]
        [LocalizedCategory(nameof(Auxiliary2Status))]
        [LocalizedDescription(nameof(Auxiliary2StatusEventClearMask))]
        [LocalizedDisplayName(nameof(Auxiliary2StatusEventClearMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary2Status Auxiliary2StatusEventClearMask { get; set; }

        [Index(14)]
        [LocalizedCategory(nameof(Auxiliary3Status))]
        [LocalizedDescription(nameof(Auxiliary3Status))]
        [LocalizedDisplayName(nameof(Auxiliary3Status))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary3Status Auxiliary3Status { get; set; }

        [Index(15)]
        [LocalizedCategory(nameof(Auxiliary3Status))]
        [LocalizedDescription(nameof(Auxiliary3StatusPriorityMask))]
        [LocalizedDisplayName(nameof(Auxiliary3StatusPriorityMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary3Status Auxiliary3StatusPriorityMask { get; set; }

        [Index(16)]
        [LocalizedCategory(nameof(Auxiliary3Status))]
        [LocalizedDescription(nameof(Auxiliary3StatusEventSetMask))]
        [LocalizedDisplayName(nameof(Auxiliary3StatusEventSetMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary3Status Auxiliary3StatusEventSetMask { get; set; }

        [Index(17)]
        [LocalizedCategory(nameof(Auxiliary3Status))]
        [LocalizedDescription(nameof(Auxiliary3StatusEventClearMask))]
        [LocalizedDisplayName(nameof(Auxiliary3StatusEventClearMask))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssAuxiliary3Status Auxiliary3StatusEventClearMask { get; set; }

        [Index(18)]
        [LocalizedCategory(nameof(Auxiliary4Status))]
        [LocalizedDescription(nameof(Auxiliary4Status))]
        [LocalizedDisplayName(nameof(Auxiliary4Status))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(HexUInt32Converter))]
        public GnssAuxiliary4Status Auxiliary4Status { get; set; }

        [Index(19)]
        [LocalizedCategory(nameof(Auxiliary4Status))]
        [LocalizedDescription(nameof(Auxiliary4StatusPriorityMask))]
        [LocalizedDisplayName(nameof(Auxiliary4StatusPriorityMask))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(HexUInt32Converter))]
        public GnssAuxiliary4Status Auxiliary4StatusPriorityMask { get; set; }

        [Index(20)]
        [LocalizedCategory(nameof(Auxiliary4Status))]
        [LocalizedDescription(nameof(Auxiliary4StatusEventSetMask))]
        [LocalizedDisplayName(nameof(Auxiliary4StatusEventSetMask))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(HexUInt32Converter))]
        public GnssAuxiliary4Status Auxiliary4StatusEventSetMask { get; set; }

        [Index(21)]
        [LocalizedCategory(nameof(Auxiliary4Status))]
        [LocalizedDescription(nameof(Auxiliary4StatusEventClearMask))]
        [LocalizedDisplayName(nameof(Auxiliary4StatusEventClearMask))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(HexUInt32Converter))]
        public GnssAuxiliary4Status Auxiliary4StatusEventClearMask { get; set; }
    }
}

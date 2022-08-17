// AsciiMessageHeader.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Globalization;
using CsvHelper.Configuration.Attributes;

namespace IrvineCubeSat.GpsParser
{
    public class AsciiMessageHeader
    {
        [Index(0)]
        [LocalizedCategory(nameof(Command))]
        [LocalizedDescription(nameof(Command))]
        [LocalizedDisplayName(nameof(Command))]
        [ReadOnly(true)]
        public string Command { get; set; } = string.Empty;

        [Index(1)]
        [LocalizedCategory(nameof(ReceiverStatus))]
        [LocalizedDescription(nameof(Port))]
        [LocalizedDisplayName(nameof(Port))]
        [ReadOnly(true)]
        public string Port { get; set; } = string.Empty;

        [Index(2)]
        [LocalizedCategory(nameof(Command))]
        [LocalizedDescription(nameof(SequenceNumber))]
        [LocalizedDisplayName(nameof(SequenceNumber))]
        [ReadOnly(true)]
        public long SequenceNumber { get; set; }

        [Index(3)]
        [LocalizedCategory(nameof(ReceiverStatus))]
        [LocalizedDescription(nameof(IdleTime))]
        [LocalizedDisplayName(nameof(IdleTime))]
        [ReadOnly(true)]
        public float IdleTime { get; set; }

        [Index(4)]
        [LocalizedCategory(nameof(Timestamp))]
        [LocalizedDescription(nameof(TimeStatus))]
        [LocalizedDisplayName(nameof(TimeStatus))]
        [ReadOnly(true)]
        public GnssTimeStatus TimeStatus { get; set; }

        [Index(5)]
        [LocalizedCategory(nameof(Timestamp))]
        [LocalizedDescription(nameof(Weeks))]
        [LocalizedDisplayName(nameof(Weeks))]
        [ReadOnly(true)]
        public uint Weeks { get; set; }

        [Index(6)]
        [LocalizedCategory(nameof(Timestamp))]
        [LocalizedDescription(nameof(Seconds))]
        [LocalizedDisplayName(nameof(Seconds))]
        [ReadOnly(true)]
        public float Seconds { get; set; }

        [LocalizedCategory(nameof(Timestamp))]
        [LocalizedDescription(nameof(Timestamp))]
        [LocalizedDisplayName(nameof(Timestamp))]
        public DateTime Timestamp
        {
            get
            {
                return new DateTime(year: 1980, month: 1, day: 6)
                    .AddDays(Weeks * 7)
                    .AddSeconds(Seconds);
            }
        }

        [Index(7)]
        [LocalizedCategory(nameof(ReceiverStatus))]
        [LocalizedDescription(nameof(ReceiverStatus))]
        [LocalizedDisplayName(nameof(ReceiverStatus))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.UInt32Converter))]
        public GnssReceiverStatus ReceiverStatus { get; set; }

        [Index(9)]
        [LocalizedCategory(nameof(ReceiverStatus))]
        [LocalizedDescription(nameof(ReceiverSoftwareVersion))]
        [LocalizedDisplayName(nameof(ReceiverSoftwareVersion))]
        [ReadOnly(true)]
        public uint ReceiverSoftwareVersion { get; set; }
    }
}

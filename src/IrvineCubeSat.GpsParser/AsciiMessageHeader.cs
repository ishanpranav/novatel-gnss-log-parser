// AsciiMessageHeader.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using CsvHelper.Configuration.Attributes;
using CsvHelper.TypeConversion;

namespace IrvineCubeSat.GpsParser
{
    public class AsciiMessageHeader
    {
        [Index(0)]
        [ReadOnly(true)]
        [LocalizedDescription(nameof(Command))]
        [LocalizedDisplayName(nameof(Command))]
        public string Command { get; set; } = string.Empty;

        [Index(1)]
        [LocalizedDescription(nameof(Port))]
        [LocalizedDisplayName(nameof(Port))]
        [ReadOnly(true)]
        public string Port { get; set; } = string.Empty;

        [Index(2)]
        [LocalizedDescription(nameof(SequenceNumber))]
        [LocalizedDisplayName(nameof(SequenceNumber))]
        [ReadOnly(true)]
        public long SequenceNumber { get; set; }

        [Index(3)]
        [LocalizedDescription(nameof(IdleTime))]
        [LocalizedDisplayName(nameof(IdleTime))]
        [ReadOnly(true)]
        public float IdleTime { get; set; }

        [Index(4)]
        [LocalizedDescription(nameof(TimeStatus))]
        [LocalizedDisplayName(nameof(TimeStatus))]
        [ReadOnly(true)]
        public GnssTimeStatus TimeStatus { get; set; }

        [Index(5)]
        [LocalizedDescription(nameof(Week))]
        [LocalizedDisplayName(nameof(Week))]
        [ReadOnly(true)]
        public uint Week { get; set; }

        [Index(6)]
        [LocalizedDescription(nameof(WeekOffset))]
        [LocalizedDisplayName(nameof(WeekOffset))]
        [ReadOnly(true)]
        public TimeSpan WeekOffset { get; set; }

        [LocalizedDescription(nameof(Timestamp))]
        [LocalizedDisplayName(nameof(Timestamp))]
        public DateTime Timestamp
        {
            get
            {
                return new DateTime(year: 1980, month: 1, day: 5).AddDays(Week * 7) + WeekOffset;
            }
        }

        [Index(7)]
        [LocalizedDescription(nameof(ReceiverStatus))]
        [LocalizedDisplayName(nameof(ReceiverStatus))]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(HexUInt32Converter))]
        [ReadOnly(true)]
        public GnssReceiverStatus ReceiverStatus { get; set; }

        [Index(9)]
        [LocalizedDescription(nameof(ReceiverSoftwareVersion))]
        [LocalizedDisplayName(nameof(ReceiverSoftwareVersion))]
        [ReadOnly(true)]
        public uint ReceiverSoftwareVersion { get; set; }
    }
}

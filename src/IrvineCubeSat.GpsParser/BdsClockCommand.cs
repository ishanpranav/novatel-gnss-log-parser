// BdsClockCommand.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using CsvHelper.Configuration.Attributes;
using IrvineCubeSat.GpsParser.Attributes;

namespace IrvineCubeSat.GpsParser
{
    [Command("BDSCLOCK")]
    public class BdsClockCommand
    {
        [Index(0)]
        [LocalizedCategory(nameof(UtcClockOffset))]
        [LocalizedDescription(nameof(UtcClockOffset))]
        [LocalizedDisplayName(nameof(UtcClockOffset))]
        [ReadOnly(true)]
        public double UtcClockOffset { get; set; }

        [Index(1)]
        [LocalizedCategory(nameof(UtcClockOffset))]
        [LocalizedDescription(nameof(UtcClockRate))]
        [LocalizedDisplayName(nameof(UtcClockRate))]
        [ReadOnly(true)]
        public double UtcClockRate { get; set; }

        [Index(6)]
        [LocalizedCategory(nameof(GpsClockOffset))]
        [LocalizedDescription(nameof(GpsClockOffset))]
        [LocalizedDisplayName(nameof(GpsClockOffset))]
        [ReadOnly(true)]
        public double GpsClockOffset { get; set; }

        [Index(7)]
        [LocalizedCategory(nameof(GpsClockOffset))]
        [LocalizedDescription(nameof(GpsClockRate))]
        [LocalizedDisplayName(nameof(GpsClockRate))]
        [ReadOnly(true)]
        public double GpsClockRate { get; set; }

        [Index(8)]
        [LocalizedCategory(nameof(GalileoClockOffset))]
        [LocalizedDescription(nameof(GalileoClockOffset))]
        [LocalizedDisplayName(nameof(GalileoClockOffset))]
        [ReadOnly(true)]
        public double GalileoClockOffset { get; set; }

        [Index(9)]
        [LocalizedCategory(nameof(GalileoClockOffset))]
        [LocalizedDescription(nameof(GalileoClockRate))]
        [LocalizedDisplayName(nameof(GalileoClockRate))]
        [ReadOnly(true)]
        public double GalileoClockRate { get; set; }

        [Index(10)]
        [LocalizedCategory(nameof(GlonassClockOffset))]
        [LocalizedDescription(nameof(GlonassClockOffset))]
        [LocalizedDisplayName(nameof(GlonassClockOffset))]
        [ReadOnly(true)]
        public double GlonassClockOffset { get; set; }

        [Index(11)]
        [LocalizedCategory(nameof(GlonassClockOffset))]
        [LocalizedDescription(nameof(GlonassClockRate))]
        [LocalizedDisplayName(nameof(GlonassClockRate))]
        [ReadOnly(true)]
        public double GlonassClockRate { get; set; }

        [Index(2)]
        [LocalizedCategory(nameof(PreLeapSecondDelta))]
        [LocalizedDescription(nameof(PreLeapSecondDelta))]
        [LocalizedDisplayName(nameof(PreLeapSecondDelta))]
        [ReadOnly(true)]
        public short PreLeapSecondDelta { get; set; }

        [Index(5)]
        [LocalizedCategory(nameof(PreLeapSecondDelta))]
        [LocalizedDescription(nameof(PostLeapSecondDelta))]
        [LocalizedDisplayName(nameof(PostLeapSecondDelta))]
        [ReadOnly(true)]
        public short PostLeapSecondDelta { get; set; }

        [Index(3)]
        [LocalizedCategory(nameof(PreLeapSecondDelta))]
        [LocalizedDescription(nameof(LeapSecondWeek))]
        [LocalizedDisplayName(nameof(LeapSecondWeek))]
        [ReadOnly(true)]
        public ushort LeapSecondWeek { get; set; }

        [Index(4)]
        [LocalizedCategory(nameof(PreLeapSecondDelta))]
        [LocalizedDescription(nameof(LeapSecondDay))]
        [LocalizedDisplayName(nameof(LeapSecondDay))]
        [ReadOnly(true)]
        public ushort LeapSecondDay { get; set; }
    }
}

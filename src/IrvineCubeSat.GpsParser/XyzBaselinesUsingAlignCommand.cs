// XyzBaselinesUsingAlignCommand.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Globalization;
using CsvHelper.Configuration.Attributes;
using IrvineCubeSat.GpsParser.Attributes;

namespace IrvineCubeSat.GpsParser
{
    [Command("ALIGNBSLNXYZ")]
    [DefaultProperty(nameof(SolutionStatus))]
    public class XyzBaselinesUsingAlignCommand
    {
        [Index(0)]
        [LocalizedCategory(nameof(SolutionStatus))]
        [LocalizedDescription(nameof(SolutionStatus))]
        [LocalizedDisplayName(nameof(SolutionStatus))]
        [ReadOnly(true)]
        public GnssSolutionStatus SolutionStatus { get; set; }

        [Index(1)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(PositionType))]
        [LocalizedDisplayName(nameof(PositionType))]
        [ReadOnly(true)]
        public GnssPositionType PositionType { get; set; }

        [Index(2)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(XBaseline))]
        [LocalizedDisplayName(nameof(XBaseline))]
        [ReadOnly(true)]
        public double XBaseline { get; set; }

        [Index(3)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(YBaseline))]
        [LocalizedDisplayName(nameof(YBaseline))]
        [ReadOnly(true)]
        public double YBaseline { get; set; }

        [Index(4)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(ZBaseline))]
        [LocalizedDisplayName(nameof(ZBaseline))]
        [ReadOnly(true)]
        public double ZBaseline { get; set; }

        [Index(5)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(XBaselineStandardDeviation))]
        [LocalizedDisplayName(nameof(XBaselineStandardDeviation))]
        [ReadOnly(true)]
        public double XBaselineStandardDeviation { get; set; }

        [Index(6)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(YBaselineStandardDeviation))]
        [LocalizedDisplayName(nameof(YBaselineStandardDeviation))]
        [ReadOnly(true)]
        public double YBaselineStandardDeviation { get; set; }

        [Index(7)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(ZBaselineStandardDeviation))]
        [LocalizedDisplayName(nameof(ZBaselineStandardDeviation))]
        [ReadOnly(true)]
        public double ZBaselineStandardDeviation { get; set; }

        [Index(8)]
        [LocalizedCategory(nameof(RoverReceiverId))]
        [LocalizedDescription(nameof(RoverReceiverId))]
        [LocalizedDisplayName(nameof(RoverReceiverId))]
        [ReadOnly(true)]
        public string RoverReceiverId { get; set; } = "    ";

        [Index(9)]
        [LocalizedCategory(nameof(RoverReceiverId))]
        [LocalizedDescription(nameof(MasterReceiverId))]
        [LocalizedDisplayName(nameof(MasterReceiverId))]
        [ReadOnly(true)]
        public string MasterReceiverId { get; set; } = "AAAA";

        [Index(10)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(SatellitesTracked))]
        [LocalizedDisplayName(nameof(SatellitesTracked))]
        [ReadOnly(true)]
        public byte SatellitesTracked { get; set; }

        [Index(11)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(SatellitesInSolution))]
        [LocalizedDisplayName(nameof(SatellitesInSolution))]
        [ReadOnly(true)]
        public byte SatellitesInSolution { get; set; }

        [Index(12)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(SatellitesAboveElevationMaskAngle))]
        [LocalizedDisplayName(nameof(SatellitesAboveElevationMaskAngle))]
        [ReadOnly(true)]
        public byte SatellitesAboveElevationMaskAngle { get; set; }

        [Index(13)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(MultiFrequencySatellitesInSolution))]
        [LocalizedDisplayName(nameof(MultiFrequencySatellitesInSolution))]
        [ReadOnly(true)]
        public byte MultiFrequencySatellitesInSolution { get; set; }

        [Index(14)]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.ByteConverter))]
        public GnssHex Field16 { get; set; }

        [Index(15)]
        [LocalizedCategory(nameof(SolutionStatus))]
        [LocalizedDescription(nameof(ExtendedSolutionStatus))]
        [LocalizedDisplayName(nameof(ExtendedSolutionStatus))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.ByteConverter))]
        public GnssExtendedSolutionStatus ExtendedSolutionStatus { get; set; }

        [Index(16)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(GalileoBeiDouSignalsInSolution))]
        [LocalizedDisplayName(nameof(GalileoBeiDouSignalsInSolution))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.ByteConverter))]
        public GnssGalileoBeiDouSignals GalileoBeiDouSignalsInSolution { get; set; }

        [Index(17)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(GpsGlonassSignalsInSolution))]
        [LocalizedDisplayName(nameof(GpsGlonassSignalsInSolution))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.ByteConverter))]
        public GnssGpsGlonassSignals GpsGlonassSignalsInSolution { get; set; }
    }
}

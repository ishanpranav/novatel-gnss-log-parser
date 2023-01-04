// EnuBaselinesUsingAlignCommand.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;
using System.Globalization;
using CsvHelper.Configuration.Attributes;
using IrvineCubeSat.GpsParser.Attributes;

namespace IrvineCubeSat.GpsParser
{
    [Command("ALIGNBSLNENU")]
    [DefaultProperty(nameof(SolutionStatus))]
    public class EnuBaselinesUsingAlignCommand
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
        [LocalizedDescription(nameof(EastBaseline))]
        [LocalizedDisplayName(nameof(EastBaseline))]
        [ReadOnly(true)]
        public double EastBaseline { get; set; }

        [Index(3)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(NorthBaseline))]
        [LocalizedDisplayName(nameof(NorthBaseline))]
        [ReadOnly(true)]
        public double NorthBaseline { get; set; }

        [Index(4)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(UpBaseline))]
        [LocalizedDisplayName(nameof(UpBaseline))]
        [ReadOnly(true)]
        public double UpBaseline { get; set; }

        [Index(5)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(EastBaselineStandardDeviation))]
        [LocalizedDisplayName(nameof(EastBaselineStandardDeviation))]
        [ReadOnly(true)]
        public double EastBaselineStandardDeviation { get; set; }

        [Index(6)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(NorthBaselineStandardDeviation))]
        [LocalizedDisplayName(nameof(NorthBaselineStandardDeviation))]
        [ReadOnly(true)]
        public double NorthBaselineStandardDeviation { get; set; }

        [Index(7)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(UpBaselineStandardDeviation))]
        [LocalizedDisplayName(nameof(UpBaselineStandardDeviation))]
        [ReadOnly(true)]
        public double UpBaselineStandardDeviation { get; set; }

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

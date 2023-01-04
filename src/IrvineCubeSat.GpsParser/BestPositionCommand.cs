// BestPositionCommand.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using System.Globalization;
using CsvHelper.Configuration.Attributes;
using CsvHelper.TypeConversion;
using IrvineCubeSat.GpsParser.Attributes;

namespace IrvineCubeSat.GpsParser
{
    [Command("BESTPOS")]
    [DefaultProperty(nameof(SolutionStatus))]
    public class BestPositionCommand
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
        [LocalizedDescription(nameof(Latitude))]
        [LocalizedDisplayName(nameof(Latitude))]
        [ReadOnly(true)]
        public double Latitude { get; set; }

        [Index(3)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(Longitude))]
        [LocalizedDisplayName(nameof(Longitude))]
        [ReadOnly(true)]
        public double Longitude { get; set; }

        [Index(4)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(Height))]
        [LocalizedDisplayName(nameof(Height))]
        [ReadOnly(true)]
        public double Height { get; set; }

        [Index(5)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(Undulation))]
        [LocalizedDisplayName(nameof(Undulation))]
        [ReadOnly(true)]
        public float Undulation { get; set; }

        [Index(6)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(DatumIdNumber))]
        [LocalizedDisplayName(nameof(DatumIdNumber))]
        [ReadOnly(true)]
        public GnssDatumIdNumber DatumIdNumber { get; set; }

        [Index(7)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(LatitudeStandardDeviation))]
        [LocalizedDisplayName(nameof(LatitudeStandardDeviation))]
        [ReadOnly(true)]
        public float LatitudeStandardDeviation { get; set; }

        [Index(8)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(LongitudeStandardDeviation))]
        [LocalizedDisplayName(nameof(LongitudeStandardDeviation))]
        [ReadOnly(true)]
        public float LongitudeStandardDeviation { get; set; }

        [Index(9)]
        [LocalizedCategory(nameof(PositionType))]
        [LocalizedDescription(nameof(HeightStandardDeviation))]
        [LocalizedDisplayName(nameof(HeightStandardDeviation))]
        [ReadOnly(true)]
        public float HeightStandardDeviation { get; set; }

        [Index(10)]
        [LocalizedCategory(nameof(BaseStationId))]
        [LocalizedDescription(nameof(BaseStationId))]
        [LocalizedDisplayName(nameof(BaseStationId))]
        [ReadOnly(true)]
        public string BaseStationId { get; set; } = "    ";

        [Index(11)]
        [LocalizedCategory(nameof(BaseStationId))]
        [LocalizedDescription(nameof(DifferentialAge))]
        [LocalizedDisplayName(nameof(DifferentialAge))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(SecondsTimeSpanConverter))]
        public TimeSpan DifferentialAge { get; set; }

        [Index(12)]
        [LocalizedCategory(nameof(BaseStationId))]
        [LocalizedDescription(nameof(SolutionAge))]
        [LocalizedDisplayName(nameof(SolutionAge))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(SecondsTimeSpanConverter))]
        public TimeSpan SolutionAge { get; set; }

        [Index(13)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(SatellitesTracked))]
        [LocalizedDisplayName(nameof(SatellitesTracked))]
        [ReadOnly(true)]
        public byte SatellitesTracked { get; set; }

        [Index(14)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(SatellitesInSolution))]
        [LocalizedDisplayName(nameof(SatellitesInSolution))]
        [ReadOnly(true)]
        public byte SatellitesInSolution { get; set; }

        [Index(15)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(L1SatellitesInSolution))]
        [LocalizedDisplayName(nameof(L1SatellitesInSolution))]
        [ReadOnly(true)]
        public byte L1SatellitesInSolution { get; set; }

        [Index(16)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(MultiFrequencySatellitesInSolution))]
        [LocalizedDisplayName(nameof(MultiFrequencySatellitesInSolution))]
        [ReadOnly(true)]
        public byte MultiFrequencySatellitesInSolution { get; set; }

        [Index(17)]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.ByteConverter))]
        public GnssHex Field19 { get; set; }

        [Index(18)]
        [LocalizedCategory(nameof(SolutionStatus))]
        [LocalizedDescription(nameof(ExtendedSolutionStatus))]
        [LocalizedDisplayName(nameof(ExtendedSolutionStatus))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.ByteConverter))]
        public GnssExtendedSolutionStatus ExtendedSolutionStatus { get; set; }

        [Index(19)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(GalileoBeiDouSignalsInSolution))]
        [LocalizedDisplayName(nameof(GalileoBeiDouSignalsInSolution))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.ByteConverter))]
        public GnssGalileoBeiDouSignals GalileoBeiDouSignalsInSolution { get; set; }

        [Index(20)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(GpsGlonassSignalsInSolution))]
        [LocalizedDisplayName(nameof(GpsGlonassSignalsInSolution))]
        [NumberStyles(NumberStyles.HexNumber)]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(CsvHelper.TypeConversion.ByteConverter))]
        public GnssGpsGlonassSignals GpsGlonassSignalsInSolution { get; set; }
    }
}

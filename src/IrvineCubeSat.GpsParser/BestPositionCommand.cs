// BestPositionCommand.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using CsvHelper.Configuration.Attributes;
using IrvineCubeSat.GpsParser.Attributes;

namespace IrvineCubeSat.GpsParser
{
    [Command("BESTPOS")]
    public class BestPositionCommand
    {
        [Index(0)]
        [LocalizedDescription(nameof(SolutionStatus))]
        [LocalizedDisplayName(nameof(SolutionStatus))]
        [ReadOnly(true)]
        public GnssSolutionStatus SolutionStatus { get; set; }

        [Index(1)]
        [LocalizedDescription(nameof(PositionType))]
        [LocalizedDisplayName(nameof(PositionType))]
        [ReadOnly(true)]
        public GnssPositionType PositionType { get; set; }

        [Index(2)]
        [LocalizedDescription(nameof(Latitude))]
        [LocalizedDisplayName(nameof(Latitude))]
        [ReadOnly(true)]
        public double Latitude { get; set; }

        [Index(3)]
        [LocalizedDescription(nameof(Longitude))]
        [LocalizedDisplayName(nameof(Longitude))]
        [ReadOnly(true)]
        public double Longitude { get; set; }

        [Index(4)]
        [LocalizedDescription(nameof(Height))]
        [LocalizedDisplayName(nameof(Height))]
        [ReadOnly(true)]
        public double Height { get; set; }

        [Index(5)]
        [LocalizedDescription(nameof(Undulation))]
        [LocalizedDisplayName(nameof(Undulation))]
        [ReadOnly(true)]
        public float Undulation { get; set; }

        [Index(6)]
        [LocalizedDescription(nameof(DatumIdNumber))]
        [LocalizedDisplayName(nameof(DatumIdNumber))]
        [ReadOnly(true)]
        public GnssDatumIdNumber DatumIdNumber { get; set; }

        [Index(7)]
        [LocalizedDescription(nameof(LatitudeStandardDeviation))]
        [LocalizedDisplayName(nameof(LatitudeStandardDeviation))]
        [ReadOnly(true)]
        public float LatitudeStandardDeviation { get; set; }

        [Index(8)]
        [LocalizedDescription(nameof(LongitudeStandardDeviation))]
        [LocalizedDisplayName(nameof(LongitudeStandardDeviation))]
        [ReadOnly(true)]
        public float LongitudeStandardDeviation { get; set; }

        [Index(9)]
        [LocalizedDescription(nameof(HeightStandardDeviation))]
        [LocalizedDisplayName(nameof(HeightStandardDeviation))]
        [ReadOnly(true)]
        public float HeightStandardDeviation { get; set; }

        [Index(10)]
        [LocalizedDescription(nameof(BaseStationId))]
        [LocalizedDisplayName(nameof(BaseStationId))]
        [ReadOnly(true)]
        public string BaseStationId { get; set; } = "????";

        [Index(11)]
        [LocalizedDescription(nameof(DifferentialAge))]
        [LocalizedDisplayName(nameof(DifferentialAge))]
        [ReadOnly(true)]
        public TimeSpan DifferentialAge { get; set; }

        [Index(12)]
        [LocalizedDescription(nameof(SolutionAge))]
        [LocalizedDisplayName(nameof(SolutionAge))]
        [ReadOnly(true)]
        public TimeSpan SolutionAge { get; set; }

        [Index(13)]
        [LocalizedDescription(nameof(SatellitesTracked))]
        [LocalizedDisplayName(nameof(SatellitesTracked))]
        [ReadOnly(true)]
        public byte SatellitesTracked { get; set; }

        [Index(14)]
        [LocalizedDescription(nameof(SatellitesInSolution))]
        [LocalizedDisplayName(nameof(SatellitesInSolution))]
        [ReadOnly(true)]
        public byte SatellitesInSolution { get; set; }

        [Index(15)]
        [LocalizedDescription(nameof(L1SatellitesInSolution))]
        [LocalizedDisplayName(nameof(L1SatellitesInSolution))]
        [ReadOnly(true)]
        public byte L1SatellitesInSolution { get; set; }

        [Index(16)]
        [LocalizedDescription(nameof(MultiFrequencySatellitesInSolution))]
        [LocalizedDisplayName(nameof(MultiFrequencySatellitesInSolution))]
        [ReadOnly(true)]
        public byte MultiFrequencySatellitesInSolution { get; set; }
    }
}

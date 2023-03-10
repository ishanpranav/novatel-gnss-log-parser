// PositionAveragingCommand.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using CsvHelper.Configuration.Attributes;
using IrvineCubeSat.GpsParser.Attributes;

namespace IrvineCubeSat.GpsParser
{
    [Command("AVEPOS")]
    public class PositionAveragingCommand
    {
        [Index(0)]
        [LocalizedCategory(nameof(PositionAveragingStatus))]
        [LocalizedDescription(nameof(Latitude))]
        [LocalizedDisplayName(nameof(Latitude))]
        [ReadOnly(true)]
        public double Latitude { get; set; }

        [Index(1)]
        [LocalizedCategory(nameof(PositionAveragingStatus))]
        [LocalizedDescription(nameof(Longitude))]
        [LocalizedDisplayName(nameof(Longitude))]
        [ReadOnly(true)]
        public double Longitude { get; set; }

        [Index(2)]
        [LocalizedCategory(nameof(PositionAveragingStatus))]
        [LocalizedDescription(nameof(HeightStandardDeviation))]
        [LocalizedDisplayName(nameof(HeightStandardDeviation))]
        [ReadOnly(true)]
        public double Height { get; set; }

        [Index(3)]
        [LocalizedCategory(nameof(PositionAveragingStatus))]
        [LocalizedDescription(nameof(LatitudeStandardDeviation))]
        [LocalizedDisplayName(nameof(LatitudeStandardDeviation))]
        [ReadOnly(true)]
        public float LatitudeStandardDeviation { get; set; }

        [Index(4)]
        [LocalizedCategory(nameof(PositionAveragingStatus))]
        [LocalizedDescription(nameof(LongitudeStandardDeviation))]
        [LocalizedDisplayName(nameof(LongitudeStandardDeviation))]
        [ReadOnly(true)]
        public float LongitudeStandardDeviation { get; set; }

        [Index(5)]
        [LocalizedCategory(nameof(PositionAveragingStatus))]
        [LocalizedDescription(nameof(HeightStandardDeviation))]
        [LocalizedDisplayName(nameof(HeightStandardDeviation))]
        [ReadOnly(true)]
        public float HeightStandardDeviation { get; set; }

        [Index(6)]
        [LocalizedCategory(nameof(PositionAveragingStatus))]
        [LocalizedDescription(nameof(PositionAveragingStatus))]
        [LocalizedDisplayName(nameof(PositionAveragingStatus))]
        [ReadOnly(true)]
        public GnssPositionAveragingStatus PositionAveragingStatus { get; set; }

        [Index(7)]
        [LocalizedCategory(nameof(PositionAveragingStatus))]
        [LocalizedDescription(nameof(AveragingTime))]
        [LocalizedDisplayName(nameof(AveragingTime))]
        [ReadOnly(true)]
        public uint AveragingTime { get; set; }

        [Index(8)]
        [LocalizedCategory(nameof(PositionAveragingStatus))]
        [LocalizedDescription(nameof(Samples))]
        [LocalizedDisplayName(nameof(Samples))]
        [ReadOnly(true)]
        public uint Samples { get; set; }
    }
}

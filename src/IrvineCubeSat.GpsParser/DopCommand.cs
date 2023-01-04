// DopCommand.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System.ComponentModel;
using CsvHelper.Configuration.Attributes;
using CsvHelper.TypeConversion;
using IrvineCubeSat.GpsParser.Attributes;

namespace IrvineCubeSat.GpsParser
{
    [Command("ALIGNDOP")]
    [DefaultProperty(nameof(GeometricDop))]
    public class DopCommand
    {
        [Index(0)]
        [LocalizedCategory(nameof(GeometricDop))]
        [LocalizedDescription(nameof(GeometricDop))]
        [LocalizedDisplayName(nameof(GeometricDop))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(DopConverter))]
        public Dop GeometricDop { get; set; }

        [Index(1)]
        [LocalizedCategory(nameof(GeometricDop))]
        [LocalizedDescription(nameof(PositionDop))]
        [LocalizedDisplayName(nameof(PositionDop))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(DopConverter))]
        public Dop PositionDop { get; set; }

        [Index(2)]
        [LocalizedCategory(nameof(GeometricDop))]
        [LocalizedDescription(nameof(HorizontalDop))]
        [LocalizedDisplayName(nameof(HorizontalDop))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(DopConverter))]
        public Dop HorizontalDop { get; set; }

        [Index(3)]
        [LocalizedCategory(nameof(GeometricDop))]
        [LocalizedDescription(nameof(HorizontalTimeDop))]
        [LocalizedDisplayName(nameof(HorizontalTimeDop))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(DopConverter))]
        public Dop HorizontalTimeDop { get; set; }

        [Index(4)]
        [LocalizedCategory(nameof(GeometricDop))]
        [LocalizedDescription(nameof(TimeDop))]
        [LocalizedDisplayName(nameof(TimeDop))]
        [ReadOnly(true)]
        [CsvHelper.Configuration.Attributes.TypeConverter(typeof(DopConverter))]
        public Dop TimeDop { get; set; }

        [Index(5)]
        [LocalizedCategory(nameof(ElevationMaskAngle))]
        [LocalizedDescription(nameof(ElevationMaskAngle))]
        [LocalizedDisplayName(nameof(ElevationMaskAngle))]
        [ReadOnly(true)]
        public float ElevationMaskAngle { get; set; }

        [Index(6)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(SatellitesTracked))]
        [LocalizedDisplayName(nameof(SatellitesTracked))]
        [ReadOnly(true)]
        public uint SatellitesTracked { get; set; }

        [Index(7)]
        [LocalizedCategory(nameof(SatellitesTracked))]
        [LocalizedDescription(nameof(SatellitesInSolution))]
        [LocalizedDisplayName(nameof(SatellitesInSolution))]
        [ReadOnly(true)]
        public uint SatellitesInSolution { get; set; }
    }
}

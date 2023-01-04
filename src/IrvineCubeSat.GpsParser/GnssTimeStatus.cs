// GnssTimeStatus.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using CsvHelper.Configuration.Attributes;

namespace IrvineCubeSat.GpsParser
{
    public enum GnssTimeStatus
    {
        None = 0,

        [Name("UNKNOWN")]
        Unknown = 20,

        [Name("APPROXIMATE")]
        Approximate = 60,

        [Name("COARSEADJUSTING")]
        CoarseAdjusting = 80,

        [Name("COARSE")]
        Coarse = 100,

        [Name("COARSESTEERING")]
        CoarseSteering = 120,

        [Name("FREEWHEELING")]
        FreeWheeling = 130,

        [Name("FINEADJUSTING")]
        FineAdjusting = 140,

        [Name("FINE")]
        Fine = 160,

        [Name("FINEBACKUPSTEERING")]
        FineBackupSteering = 170,

        [Name("FINESTEERING")]
        FineSteering = 180,

        [Name("SATTIME")]
        SatelliteTime = 200
    }
}

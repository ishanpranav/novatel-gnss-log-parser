// GnssAuxiliary4Status.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssAuxiliary4Status : uint
    {
        None = 0,
        LessThanSixtyPercentTracking = 0x00000001,
        LessThanFifteenPercentTracking = 0x00000002,
        ClockFreewheeling = 0x00001000,
        LessThanSixtyPercentRtkCorrections = 0x00004000,
        LessThanFifteenPercentRtkCorrections = 0x00008000,
        BadRtkGeometry = 0x00010000,
        LongRtkBaseline = 0x00080000,
        PoorRtkComLink = 0x00100000,
        PoorAlignComLink = 0x00200000,
        GlideNotActive = 0x00400000,
        BadPdpGeometry = 0x00800000,
        NoTerraStarSubscription = 0x01000000,
        BadPppGeometry = 0x10000000,
        NoInsAlignment = 0x40000000,
        InsNotConverged = 0x80000000
    }
}

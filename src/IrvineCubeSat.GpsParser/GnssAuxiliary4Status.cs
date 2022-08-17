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
        Bit2 = 0x00000004,
        Bit3 = 0x00000008,
        Bit4 = 0x00000010,
        Bit5 = 0x00000020,
        Bit6 = 0x00000040,
        Bit7 = 0x00000080,
        Bit8 = 0x00000100,
        Bit9 = 0x00000200,
        Bit10 = 0x0000400,
        Bit11 = 0x0000800,
        ClockFreewheeling = 0x00001000,
        Bit13 = 0x00002000,
        LessThanSixtyPercentRtkCorrections = 0x00004000,
        LessThanFifteenPercentRtkCorrections = 0x00008000,
        BadRtkGeometry = 0x00010000,
        Bit17 = 0x00020000,
        Bit18 = 0x00040000,
        LongRtkBaseline = 0x00080000,
        PoorRtkComLink = 0x00100000,
        PoorAlignComLink = 0x00200000,
        GlideNotActive = 0x00400000,
        BadPdpGeometry = 0x00800000,
        NoTerraStarSubscription = 0x01000000,
        Bit25 = 0x02000000,
        Bit26 = 0x04000000,
        Bit27 = 0x08000000,
        BadPppGeometry = 0x10000000,
        Bit29 = 0x20000000,
        NoInsAlignment = 0x40000000,
        InsNotConverged = 0x80000000
    }
}

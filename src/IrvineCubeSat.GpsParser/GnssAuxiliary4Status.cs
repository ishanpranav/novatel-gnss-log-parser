// GnssAuxiliary4Status.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssAuxiliary4Status : uint
    {
        None = 0,
        LessThanSixtyPercentTracking = Bits.Bit0,
        LessThanFifteenPercentTracking = Bits.Bit1,
        Bit2 = Bits.Bit2,
        Bit3 = Bits.Bit3,
        Bit4 = Bits.Bit4,
        Bit5 = Bits.Bit5,
        Bit6 = Bits.Bit6,
        Bit7 = Bits.Bit7,
        Bit8 = Bits.Bit8,
        Bit9 = Bits.Bit9,
        Bit10 = Bits.Bit10,
        Bit11 = Bits.Bit11,
        ClockFreewheeling = Bits.Bit12,
        Bit13 = Bits.Bit13,
        LessThanSixtyPercentRtkCorrections = Bits.Bit14,
        LessThanFifteenPercentRtkCorrections = Bits.Bit15,
        BadRtkGeometry = Bits.Bit16,
        Bit17 = Bits.Bit17,
        Bit18 = Bits.Bit18,
        LongRtkBaseline = Bits.Bit19,
        PoorRtkComLink = Bits.Bit20,
        PoorAlignComLink = Bits.Bit21,
        GlideNotActive = Bits.Bit22,
        BadPdpGeometry = Bits.Bit23,
        NoTerraStarSubscription = Bits.Bit24,
        Bit25 = Bits.Bit25,
        Bit26 = Bits.Bit26,
        Bit27 = Bits.Bit27,
        BadPppGeometry = Bits.Bit28,
        Bit29 = Bits.Bit29,
        NoInsAlignment = Bits.Bit30,
        InsNotConverged = Bits.Bit31
    }
}

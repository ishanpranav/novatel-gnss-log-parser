// GnssGpsGlonassSignals.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssGpsGlonassSignals : byte
    {
        None = Bits.None,
        GpsL1 = Bits.Bit0,
        GpsL2 = Bits.Bit1,
        GpsL5 = Bits.Bit2,
        Bit3 = Bits.Bit3,
        GlonassL1 = Bits.Bit4,
        GlonassL2 = Bits.Bit5,
        GlonassL3 = Bits.Bit6,
        Bit7 = Bits.Bit7
    }
}

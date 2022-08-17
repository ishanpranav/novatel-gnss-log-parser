// GnssGpsGlonassSignals.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssGpsGlonassSignals : byte
    {
        None = 0,
        GpsL1 = 0x01,
        GpsL2 = 0x02,
        GpsL5 = 0x04,
        Bit3 = 0x08,
        GlonassL1 = 0x10,
        GlonassL2 = 0x20,
        GlonassL3 = 0x40,
        Bit7 = 0x80
    }
}

// GnssGalileoBeidouSignals.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssGalileoBeiDouSignals : byte
    {
        None = Bits.None,
        GalileoE1 = Bits.Bit0,
        GalileoE5A = Bits.Bit1,
        GalileoE5B = Bits.Bit2,
        GalileoAltboc = Bits.Bit3,
        BeiDouB1 = Bits.Bit4,
        BeiDouB2 = Bits.Bit5,
        BeiDouB3 = Bits.Bit6,
        GalileoE6 = Bits.Bit7
    }
}

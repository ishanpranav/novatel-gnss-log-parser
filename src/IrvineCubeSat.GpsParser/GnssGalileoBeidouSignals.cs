// GnssGalileoBeidouSignals.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssGalileoBeiDouSignals : byte
    {
        None = 0,
        GalileoE1 = 0x01,
        GalileoE5A = 0x02,
        GalileoE5B = 0x04,
        GalileoAltboc = 0x08,
        BeiDouB1 = 0x10,
        BeiDouB2 = 0x20,
        BeiDouB3 = 0x40,
        GalileoE6 = 0x80
    }
}

// GnssExtendedSolutionStatus.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssExtendedSolutionStatus : byte
    {
        None = Bits.None,
        RtkVerifiedOrPdpGlide = Bits.Bit0,
        KlobucharBroadcast = Bits.Bit1,
        SbasBroadcast = Bits.Bit2,
        MultiFrequencyComputed = Bits.Bit1 | Bits.Bit2,
        PseudorangeDifferentialCorrection = Bits.Bit3,
        NovAtelBlendedIonosphericValue = Bits.Bit1 | Bits.Bit3,
        RtkAssistActive = Bits.Bit4,
        RtkAntennaInformationMissing = Bits.Bit5,
        Bit6 = Bits.Bit6,
        TerainCompensationCorrections = Bits.Bit7
    }
}

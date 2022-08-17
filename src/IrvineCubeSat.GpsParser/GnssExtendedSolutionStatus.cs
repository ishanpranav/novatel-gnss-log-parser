// GnssExtendedSolutionStatus.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssExtendedSolutionStatus : byte
    {
        RtkVerifiedOrPdpGlide = 0x01,
        KlobucharBroadcast = 0x02,
        SbasBroadcast = 0x04,
        MultiFrequencyComputed = KlobucharBroadcast | SbasBroadcast,
        PsrDifferentialCorrection = 0x08,
        NovAtelBlendedIonosphericValue = KlobucharBroadcast | PsrDifferentialCorrection,
        RtkAssistActive = 0x10,
        RtkAntennaInformationMissing = 0x20,
        Bit6 = 0x40,
        TerainCompensationCorrections = 0x80
    }
}

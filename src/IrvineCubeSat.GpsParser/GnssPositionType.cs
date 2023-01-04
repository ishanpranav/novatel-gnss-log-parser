// GnssPositionType.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using CsvHelper.Configuration.Attributes;

namespace IrvineCubeSat.GpsParser
{
    public enum GnssPositionType
    {
        [Name("NONE")]
        None = 0,

        [Name("FIXEDPOS")]
        FixedPosition = 1,

        [Name("FIXEDHEIGHT")]
        FixedHeight = 2,

        [Name("DOPPLER_VELOCITY")]
        DopplerVelocity = 8,

        [Name("SINGLE")]
        Single = 16,

        [Name("PSRDIFF")]
        PseudorangeDifferential = 17,

        [Name("WAAS")]
        Waas = 18,

        [Name("PROPAGATED")]
        Propagated = 19,

        [Name("OMNISTAR")]
        OmniStar = 20,

        [Name("L1_FLOAT")]
        L1Floating = 32,

        [Name("IONOFREE_FLOAT")]
        IonosphericFreeAmbiguityFloating = 33,

        [Name("NARROW_FLOAT")]
        NarrowFloating = 34,

        [Name("L1_INT")]
        L1Integer = 48,

        [Name("WIDE_INT")]
        WideInteger = 49,

        [Name("NARROW_INT")]
        NarrowInteger = 50,

        [Name("RTK_DIRECT_INS")]
        RtkDirectIns = 51,

        [Name("INS_SBAS")]
        InsSbas = 52,

        [Name("INS_PSRSP")]
        InsPseudorangeSinglePoint = 53,

        [Name("INS_PSRDIFF")]
        InsPseudorangeDifferential = 54,

        [Name("INS_RTKFLOAT")]
        InsRtkFloating = 55,

        [Name("INS_RTKFIXED")]
        InsRtkInteger = 56,

        [Name("OMNISTAR_HP")]
        OmniStarHP = 64,

        [Name("OMNISTAR_XP")]
        OmniStarXP = 65,

        [Name("PPP_CONVERGING")]
        PppConverging = 68,

        [Name("PPP")]
        PppConverged = 69,

        [Name("OPERATIONAL")]
        Operational = 70,

        [Name("WARNING")]
        Warning = 71,

        [Name("OUT_OF_BOUNDS")]
        OutOfBounds = 72,

        [Name("INS_PPP_CONVERGING")]
        InsPppConverging = 73,

        [Name("INS_PPP")]
        InsPppConverged = 74,

        [Name("PPP_BASIC_CONVERGING")]
        PppBasicConverging = 77,

        [Name("PPP_BASIC")]
        PppBasicConverged = 78,

        [Name("INS_PPP_BASIC_CONVERGING")]
        InsPppBasicConverging = 79,

        [Name("INS_PPP_BASIC")]
        InsPppBasicConverged = 80
    }
}

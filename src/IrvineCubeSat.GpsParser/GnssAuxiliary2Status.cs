// GnssAuxiliary2Status.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssAuxiliary2Status : uint
    {
        None = Bits.None,
        SpiCommunicationFailure = Bits.Bit0,
        ISquaredCCommunicationFailure = Bits.Bit1,
        Com4BufferOverrun = Bits.Bit2,
        Com5BufferOverrun = Bits.Bit3,
        Com6BufferOverrun = Bits.Bit4,
        Com7BufferOverrun = Bits.Bit5,
        Com8BufferOverrun = Bits.Bit6,
        Com9BufferOverrun = Bits.Bit7,
        Com10BufferOverrun = Bits.Bit8,
        Com1BufferOverrun = Bits.Bit9,
        Com2BufferOverrun = Bits.Bit10,
        Com3BufferOverrun = Bits.Bit11,
        PllRF1Unlock = Bits.Bit12,
        PllRF2Unlock = Bits.Bit13,
        PllRF3Unlock = Bits.Bit14,
        PllRF4Unlock = Bits.Bit15,
        PllRF5Unlock = Bits.Bit16,
        PllRF6Unlock = Bits.Bit17,
        Ccom1BufferOverrun = Bits.Bit18,
        Ccom2BufferOverrun = Bits.Bit19,
        Ccom3BufferOverrun = Bits.Bit20,
        Ccom4BufferOverrun = Bits.Bit21,
        Ccom5BufferOverrun = Bits.Bit22,
        Ccom6BufferOverrun = Bits.Bit23,
        Icom4BufferOverrun = Bits.Bit24,
        Icom5BufferOverrun = Bits.Bit25,
        Icom6BufferOverrun = Bits.Bit26,
        Icom7BufferOverrun = Bits.Bit27,
        SecondaryAntennaNotPowered = Bits.Bit28,
        SecondaryAntennaOpenCircuit = Bits.Bit29,
        SecondaryAntennaShortCircuit = Bits.Bit30,
        ResetLoopDetected = Bits.Bit31
    }
}

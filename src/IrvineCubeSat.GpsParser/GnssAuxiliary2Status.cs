// GnssAuxiliary2Status.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssAuxiliary2Status : uint
    {
        None = 0,
        SpiCommunicationFailure = 0x00000001,
        ISquaredCCommunicationFailure = 0x00000002,
        Com4BufferOverrun = 0x00000004,
        Com5BufferOverrun = 0x00000008,
        Com6BufferOverrun = 0x00000010,
        Com7BufferOverrun = 0x00000020,
        Com8BufferOverrun = 0x00000040,
        Com9BufferOverrun = 0x00000080,
        Com10BufferOverrun = 0x00000100,
        Com1BufferOverrun = 0x00000200,
        Com2BufferOverrun = 0x00000400,
        Com3BufferOverrun = 0x00000800,
        PllRF1Unlock = 0x00001000,
        PllRF2Unlock = 0x00002000,
        PllRF3Unlock = 0x00004000,
        PllRF4Unlock = 0x00008000,
        PllRF5Unlock = 0x00010000,
        PllRF6Unlock = 0x00020000,
        Ccom1BufferOverrun = 0x00040000,
        Ccom2BufferOverrun = 0x00080000,
        Ccom3BufferOverrun = 0x00100000,
        Ccom4BufferOverrun = 0x00200000,
        Ccom5BufferOverrun = 0x00400000,
        Ccom6BufferOverrun = 0x00800000,
        Icom4BufferOverrun = 0x01000000,
        Icom5BufferOverrun = 0x02000000,
        Icom6BufferOverrun = 0x04000000,
        Icom7BufferOverrun = 0x08000000,
        SecondaryAntennaNotPowered = 0x10000000,
        SecondaryAntennaOpenCircuit = 0x20000000,
        SecondaryAntennaShortCircuit = 0x40000000,
        ResetLoopDetected = 0x80000000
    }
}

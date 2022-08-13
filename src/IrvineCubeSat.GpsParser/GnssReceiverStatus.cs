// GnssReceiverStatus.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssReceiverStatus : uint
    {
        None = 0,
        Error = 0x00000001,
        TemperatureWarning = 0x00000002,
        VoltageSupplyWarning = 0x00000004,
        PrimaryAntennaNotPowered = 0x00000008,
        LnaFailure = 0x00000010,
        PrimaryAntennaOpenCircuit = 0x00000020,
        PrimaryAntennaShortCircuit = 0x00000040,
        CpuOverload = 0x00000080,
        ComBufferOverrun = 0x00000100,
        Bit9 = 0x00000200,
        Bit10 = 0x00000400,
        LinkOverrun = 0x00000800,
        InputOverrun = 0x00001000,
        AuxiliaryTransmitOverrun = 0x00002000,
        AntennaGainOutOfRange = 0x00004000,
        JammerDetected = 0x00008000,
        InsReset = 0x00010000,
        ImuCommunicationFailure = 0x00020000,
        GpsAlmanacInvalid = 0x00040000,
        PositionSolutionInvalid = 0x00080000,
        PositionFixed = 0x00100000,
        ClockSteeringDisabled = 0x00200000,
        ClockModelInvalid = 0x00400000,
        ExternalOscillatorLocked = 0x00800000,
        SoftwareResourceWarning = 0x01000000,
        Bit25 = 0x02000000,
        Bit26 = 0x04000000,
        HdrTracking = 0x08000000,
        DigitalFilteringEnabled = 0x10000000,
        Auxiliary3StatusEvent = 0x20000000,
        Auxiliary2StatusEvent = 0x40000000,
        Auxiliary1StatusEvent = 0x80000000
    }
}

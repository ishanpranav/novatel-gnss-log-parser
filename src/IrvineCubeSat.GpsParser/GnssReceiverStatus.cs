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
        Error = Bits.Bit0,
        TemperatureWarning = Bits.Bit1,
        VoltageSupplyWarning = Bits.Bit2,
        PrimaryAntennaNotPowered = Bits.Bit3,
        LnaFailure = Bits.Bit4,
        PrimaryAntennaOpenCircuit = Bits.Bit5,
        PrimaryAntennaShortCircuit = Bits.Bit6,
        CpuOverload = Bits.Bit7,
        ComBufferOverrun = Bits.Bit8,
        Bit9 = Bits.Bit9,
        Bit10 = Bits.Bit10,
        LinkOverrun = Bits.Bit11,
        InputOverrun = Bits.Bit12,
        AuxiliaryTransmitOverrun = Bits.Bit13,
        AntennaGainOutOfRange = Bits.Bit14,
        JammerDetected = Bits.Bit15,
        InsReset = Bits.Bit16,
        ImuCommunicationFailure = Bits.Bit17,
        GpsAlmanacInvalid = Bits.Bit18,
        PositionSolutionInvalid = Bits.Bit19,
        PositionFixed = Bits.Bit20,
        ClockSteeringDisabled = Bits.Bit21,
        ClockModelInvalid = Bits.Bit22,
        ExternalOscillatorLocked = Bits.Bit23,
        SoftwareResourceWarning = Bits.Bit24,
        Oem7 = Bits.Bit25,
        FutureVersion1 = Bits.Bit26,
        FutureVersion2 = Bits.Bit25 | Bits.Bit26,
        HdrTracking = Bits.Bit27,
        DigitalFilteringEnabled = Bits.Bit28,
        Auxiliary3StatusEvent = Bits.Bit29,
        Auxiliary2StatusEvent = Bits.Bit30,
        Auxiliary1StatusEvent = Bits.Bit31
    }
}

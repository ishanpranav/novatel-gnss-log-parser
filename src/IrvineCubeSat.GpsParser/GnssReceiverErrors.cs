// GnssReceiverErrors.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssReceiverErrors : uint
    {
        None = 0,
        DynamicRam = Bits.Bit0,
        InvalidFirmware = Bits.Bit1,
        Rom = Bits.Bit2,
        Bit3 = Bits.Bit3,
        EsnAccess = Bits.Bit4,
        AuthorizationCode = Bits.Bit5,
        Bit6 = Bits.Bit6,
        SupplyVoltage = Bits.Bit7,
        ThermometerNotRead = Bits.Bit8,
        Temperature = Bits.Bit9,
        Minos = Bits.Bit10,
        PllRF1HardwareError = Bits.Bit11,
        PllRF2HardwareError = Bits.Bit12,
        PllRF3HardwareError = Bits.Bit13,
        PllRF4HardwareError = Bits.Bit14,
        Nvm = Bits.Bit15,
        SoftwareResourceLimitExceeded = Bits.Bit16,
        InvalidModel = Bits.Bit17,
        Bit18 = Bits.Bit18,
        Bit19 = Bits.Bit19,
        RemoteLoading = Bits.Bit20,
        ExportRestriction = Bits.Bit21,
        SafeMode = Bits.Bit22,
        Bit23 = Bits.Bit23,
        Bit24 = Bits.Bit24,
        Bit25 = Bits.Bit25,
        Bit26 = Bits.Bit26,
        Bit27 = Bits.Bit27,
        Bit28 = Bits.Bit28,
        Bit29 = Bits.Bit29,
        Bit30 = Bits.Bit30,
        ComponentHardwareFailure = Bits.Bit31
    }
}

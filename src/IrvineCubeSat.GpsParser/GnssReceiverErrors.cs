// GnssReceiverErrors.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssReceiverErrors : uint
    {
        None = 0,
        DynamicRam = 0x00000001,
        InvalidFirmware = 0x00000002,
        Rom = 0x00000004,
        Bit3 = 0x00000008,
        EsnAccess = 0x00000010,
        AuthorizationCode = 0x00000020,
        Bit6 = 0x00000040,
        SupplyVoltage = 0x00000080,
        ThermometerNotRead = 0x00000100,
        Temperature = 0x00000200,
        Minos = 0x00000400,
        PllRF1HardwareError = 0x00000800,
        PllRF2HardwareError = 0x00001000,
        PllRF3HardwareError = 0x00002000,
        PllRF4HardwareError = 0x00004000,
        Nvm = 0x00008000,
        SoftwareResourceLimitExceeded = 0x00010000,
        InvalidModel = 0x00020000,
        Bit18 = 0x00040000,
        Bit19 = 0x00080000,
        RemoteLoading = 0x00100000,
        ExportRestriction = 0x00200000,
        SafeMode = 0x00400000,
        Bit23 = 0x00800000,
        Bit24 = 0x01000000,
        Bit25 = 0x02000000,
        Bit26 = 0x04000000,
        Bit27 = 0x08000000,
        Bit28 = 0x10000000,
        Bit29 = 0x20000000,
        Bit30 = 0x40000000,
        ComponentHardwareFailure = 0x80000000
    }
}

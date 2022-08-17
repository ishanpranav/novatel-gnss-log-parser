// GnssAuxiliary3Status.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssAuxiliary3Status : uint
    {
        None = 0,
        ScomBufferOverrun = 0x00000001,
        Wcom1BufferOverrun = 0x00000002,
        FileBufferOverrun = 0x00000004,
        BluetoothBufferOverrun = 0x00000008,
        Antenna1GainHigh = 0x00000010,
        Antenna1GainLow = 0x00000020,
        Antenna1GainAnomaly = Antenna1GainHigh | Antenna1GainLow,
        Antenna2GainHigh = 0x00000040,
        Antenna2GainLow = 0x00000080,
        Antenna2GainAnomaly = Antenna2GainHigh | Antenna2GainLow,
        WifiPowered = 0x00000100,
        WifiClientAPMode = 0x00000200,
        WifiConnectionReady = 0x00000400,
        BluetoothPowered = 0x00000800,
        BluetoothSppPaired = 0x00001000,
        CellRadioPowered = 0x00002000,
        SimMissingOrUnreadable = 0x00004000,
        SimLocked = 0x00008000,
        CellRoaming = 0x00010000,
        CellServiceNotAvailable = 0x00020000,
        Bit18 = 0x00040000,
        Bit19 = 0x00080000,
        Bit20 = 0x00100000,
        DualAntennaOverCurrent = 0x00200000,
        InternalApplicationRestarted = 0x00400000,
        Bit23 = 0x00800000,
        DualCardCommunicationLost = 0x01000000,
        VdcOverCurrent = 0x02000000,
        UsbStickError = 0x04000000,
        InternalStorageError = 0x08000000,
        Bit28 = 0x10000000,
        WebContentError = 0x20000000,
        RFCalibrationDataError = 0x40000000,
        RFCalibrationDataPresent = 0x80000000
    }
}

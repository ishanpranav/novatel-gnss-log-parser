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
        ScomBufferOverrun = Bits.Bit0,
        Wcom1BufferOverrun = Bits.Bit1,
        FileBufferOverrun = Bits.Bit2,
        BluetoothBufferOverrun = Bits.Bit3,
        Antenna1GainHigh = Bits.Bit4,
        Antenna1GainLow = Bits.Bit5,
        Antenna1GainAnomaly = Bits.Bit4 | Bits.Bit5,
        Antenna2GainHigh = Bits.Bit6,
        Antenna2GainLow = Bits.Bit7,
        Antenna2GainAnomaly = Bits.Bit6 | Bits.Bit6,
        WifiPowered = Bits.Bit8,
        WifiClientAPMode = Bits.Bit9,
        WifiConnectionReady = Bits.Bit10,
        BluetoothPowered = Bits.Bit11,
        BluetoothSppPaired = Bits.Bit12,
        CellRadioPowered = Bits.Bit13,
        SimMissingOrUnreadable = Bits.Bit14,
        SimLocked = Bits.Bit15,
        CellRoaming = Bits.Bit16,
        CellServiceNotAvailable = Bits.Bit17,
        Bit18 = Bits.Bit18,
        Bit19 = Bits.Bit19,
        Bit20 = Bits.Bit20,
        DualAntennaOverCurrent = Bits.Bit21,
        InternalApplicationRestarted = Bits.Bit22,
        Bit23 = Bits.Bit23,
        DualCardCommunicationLost = Bits.Bit24,
        VdcOverCurrent = Bits.Bit25,
        UsbStickError = Bits.Bit26,
        InternalStorageError = Bits.Bit27,
        Bit28 = Bits.Bit28,
        WebContentError = Bits.Bit29,
        RFCalibrationDataError = Bits.Bit30,
        RFCalibrationDataPresent = Bits.Bit31
    }
}

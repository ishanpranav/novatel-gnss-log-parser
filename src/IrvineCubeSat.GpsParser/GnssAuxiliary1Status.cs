// GnssAuxiliary1Status.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssAuxiliary1Status : uint
    {
        None = Bits.None,
        RF1JammerDetected = Bits.Bit0,
        RF2JammerDetected = Bits.Bit1,
        RF3JammerDetected = Bits.Bit2,
        PositionAveraging = Bits.Bit3,
        RF4JammerDetected = Bits.Bit4,
        RF5JammerDetected = Bits.Bit5,
        RF6JammerDetected = Bits.Bit6,
        USBNotConnected = Bits.Bit7,
        Usb1BufferOverrun = Bits.Bit8,
        Usb2BufferOverrun = Bits.Bit9,
        Usb3BufferOverrun = Bits.Bit10,
        Bit11 = Bits.Bit11,
        ProfileActivationError = Bits.Bit12,
        EthernetReceptionThrottled = Bits.Bit13,
        RF1GainOutOfRange = Bits.Bit14,
        RF2GainOutOfRange = Bits.Bit15,
        RF3GainOutOfRange = Bits.Bit16,
        RF4GainOutOfRange = Bits.Bit17,
        EthernetNotConnected = Bits.Bit18,
        Icom1BufferOverrun = Bits.Bit19,
        Icom2BufferOverrun = Bits.Bit20,
        Icom3BufferOverrun = Bits.Bit21,
        Ncom1BufferOverrun = Bits.Bit22,
        Ncom2BufferOverrun = Bits.Bit23,
        Ncom3BufferOverrun = Bits.Bit24,
        XCom1BufferOverrun = Bits.Bit25,
        XCom2BufferOverrun = Bits.Bit26,
        XCom3BufferOverrun = Bits.Bit27,
        RF5GainOutOfRange = Bits.Bit28,
        RF6GainOutOfRange = Bits.Bit29,
        ImuStatusErrorReported = Bits.Bit30,
        ImuMeasurementOutlierDetected = Bits.Bit31
    }
}

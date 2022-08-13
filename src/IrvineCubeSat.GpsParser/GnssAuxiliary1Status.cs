// GnssAuxiliary1Status.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    [Flags]
    public enum GnssAuxiliary1Status : uint
    {
        None = 0,
        RF1JammerDetected = 0x00000001,
        RF2JammerDetected = 0x00000002,
        RF3JammerDetected = 0x00000004,
        PositionAveraging = 0x00000008,
        RF4JammerDetected = 0x00000010,
        RF5JammerDetected = 0x00000020,
        RF6JammerDetected = 0x00000040,
        USBNotConnected = 0x00000080,
        Usb1BufferOverrun = 0x00000100,
        Usb2BufferOverrun = 0x00000200,
        Usb3BufferOverrun = 0x00000400,
        Bit11 = 0x00000800,
        ProfileActivationError = 0x00001000,
        EthernetReceptionThrottled = 0x00002000,
        RF1GainOutOfRange = 0x00004000,
        RF2GainOutOfRange = 0x00008000,
        RF3GainOutOfRange = 0x00010000,
        RF4GainOutOfRange = 0x00020000,
        EthernetNotConnected = 0x00040000,
        Icom1BufferOverrun = 0x00080000,
        Icom2BufferOverrun = 0x00100000,
        Icom3BufferOverrun = 0x00200000,
        Ncom1BufferOverrun = 0x00400000,
        Ncom2BufferOverrun = 0x00800000,
        Ncom3BufferOverrun = 0x01000000,
        XCom1BufferOverrun = 0x02000000,
        XCom2BufferOverrun = 0x04000000,
        XCom3BufferOverrun = 0x08000000,
        RF5GainOutOfRange = 0x10000000,
        RF6GainOutOfRange = 0x20000000,
        ImuStatusErrorReported = 0x40000000,
        ImuMeasurementOutlierDetected = 0x80000000
    }
}

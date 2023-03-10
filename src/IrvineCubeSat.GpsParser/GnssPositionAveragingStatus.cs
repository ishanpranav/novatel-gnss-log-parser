// GnssPositionAveragingStatus.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using CsvHelper.Configuration.Attributes;

namespace IrvineCubeSat.GpsParser
{
    public enum GnssPositionAveragingStatus
    {
        [Name("OFF")]
        Off = 0,

        [Name("INPROGRESS")]
        InProgress = 1,

        [Name("COMPLETE")]
        Complete = 2
    }
}

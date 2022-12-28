// DopInterpretation.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

namespace IrvineCubeSat.GpsParser
{
    public enum DopInterpretation : byte
    {
        Ideal = 0,
        Excellent = 1,
        Good = 2,
        Moderate = 5,
        Fair = 10,
        Poor = 20
    }
}

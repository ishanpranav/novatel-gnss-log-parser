// DateTimes.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    /// <summary>
    /// Provides constant fields and helper methods for working with GNSS timestamps. This class cannot be inherited. 
    /// </summary>
    public static class Time
    {
        /// <summary>
        /// Specifies the GPS reference date, January 6, 1980.
        /// </summary>
        public static readonly DateTime GpsReference = new DateTime(year: 1980, month: 1, day: 6);

        /// <summary>
        /// Specifies the BeiDou time reference date, January 1, 2006.
        /// </summary>
        public static readonly DateTime BdtReference = new DateTime(year: 2006, month: 1, day: 1);

        /// <summary>
        /// Gets a timestamp based on the specified reference date, reference week, and number of seconds.
        /// </summary>
        /// <param name="reference">The reference date.</param>
        /// <param name="weeks">The reference week number.</param>
        /// <param name="seconds">The number of seconds since the beginning of the reference week.</param>
        /// <returns>The timestamp.</returns>
        public static DateTime CreateTimestamp(DateTime reference, uint weeks, double seconds)
        {
            return reference
                .AddDays(weeks * 7)
                .AddSeconds(seconds);
        }
    }
}

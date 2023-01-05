// BdsAlmanacCommand.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using CsvHelper.Configuration.Attributes;
using IrvineCubeSat.GpsParser.Attributes;

namespace IrvineCubeSat.GpsParser
{
    /// <summary>
    /// Represents a decoded BDS almanac (<c>BDSALMANAC</c>) command message body.
    /// </summary>
    [Command("BDSALMANAC")]
    public class BdsAlmanacCommand
    {
        /// <summary>
        /// Gets or sets the satellite ranging code.
        /// </summary>
        /// <value>The identifier of the satellite, or its ranging code.</value>
        [Index(0)]
        [LocalizedCategory(nameof(SatelliteId))]
        [LocalizedDescription(nameof(SatelliteId))]
        [LocalizedDisplayName(nameof(SatelliteId))]
        [ReadOnly(true)]
        public uint SatelliteId { get; set; }

        [Index(1)]
        [LocalizedCategory(nameof(Timestamp))]
        [LocalizedDescription(nameof(Weeks))]
        [LocalizedDisplayName(nameof(Weeks))]
        [ReadOnly(true)]
        public uint Weeks { get; set; }

        [Index(2)]
        [LocalizedCategory(nameof(Timestamp))]
        [LocalizedDescription(nameof(Seconds))]
        [LocalizedDisplayName(nameof(Seconds))]
        [ReadOnly(true)]
        public uint Seconds { get; set; }

        /// <summary>
        /// Gets the BeiDou timestamp.
        /// </summary>
        /// <value>The current BeiDou time.</value>
        [LocalizedCategory(nameof(Timestamp))]
        [LocalizedDescription(nameof(Timestamp))]
        [LocalizedDisplayName(nameof(Timestamp))]
        public DateTime Timestamp
        {
            get
            {
                return Time.CreateTimestamp(Time.BdtReference, Weeks, Seconds);
            }
        }

        /// <summary>
        /// Gets or sets the eccentricity.
        /// </summary>
        /// <value>The eccentricity.</value>
        [Index(4)]
        [LocalizedCategory(nameof(BdsAlmanacCommand))]
        [LocalizedDescription(nameof(Eccentricity))]
        [LocalizedDisplayName(nameof(Eccentricity))]
        [ReadOnly(true)]
        public double Eccentricity { get; set; }

        /// <summary>
        /// Gets or sets the longitude of the ascending node of the orbital plane.
        /// </summary>
        /// <value>The right ascension (<em>Ω</em>), in radians.</value>
        [Index(7)]
        [LocalizedCategory(nameof(RightAscension))]
        [LocalizedDescription(nameof(RightAscension))]
        [LocalizedDisplayName(nameof(RightAscension))]
        [ReadOnly(true)]
        public double RightAscension { get; set; }

        /// <summary>
        /// Gets or sets the right ascension rate.
        /// </summary>
        /// <value>The rate of right ascension (<em>Ω'</em>), in radians per second.</value>
        [Index(8)]
        [LocalizedCategory(nameof(RightAscension))]
        [LocalizedDescription(nameof(RightAscensionRate))]
        [LocalizedDisplayName(nameof(RightAscensionRate))]
        [ReadOnly(true)]
        public double RightAscensionRate { get; set; }

        /// <summary>
        /// Gets or sets the argument of perigree.
        /// </summary>
        /// <value>The argument of perigree (<em>ω</em>), in radians.</value>
        [Index(5)]
        [LocalizedCategory(nameof(BdsAlmanacCommand))]
        [LocalizedDescription(nameof(ArgumentOfPerigree))]
        [LocalizedDisplayName(nameof(ArgumentOfPerigree))]
        [ReadOnly(true)]
        public double ArgumentOfPerigree { get; set; }

        /// <summary>
        /// Gets or sets the mean anomaly of the reference time.
        /// </summary>
        /// <value>The mean anomaly of the reference time (<em>M0</em>), in radians.</value>
        [Index(6)]
        [LocalizedCategory(nameof(BdsAlmanacCommand))]
        [LocalizedDescription(nameof(MeanAnomaly))]
        [LocalizedDisplayName(nameof(MeanAnomaly))]
        [ReadOnly(true)]
        public double MeanAnomaly { get; set; }

        /// <summary>
        /// Gets or sets the first clock aging parameter, or the constant term of the clock correction polynomial.
        /// </summary>
        /// <value>The clock aging parameter (<em>af0</em>), in seconds.</value>
        [Index(10)]
        [LocalizedCategory(nameof(Aging))]
        [LocalizedDescription(nameof(Aging))]
        [LocalizedDisplayName(nameof(Aging))]
        [ReadOnly(true)]
        public double Aging { get; set; }

        /// <summary>
        /// Gets or sets the second clock aging parameter, or the linear term of the clock correction polynomial.
        /// </summary>
        /// <value>The clock aging parameter (<em>af1</em>), in seconds per second.</value>
        [Index(11)]
        [LocalizedCategory(nameof(Aging))]
        [LocalizedDescription(nameof(AgingRate))]
        [LocalizedDisplayName(nameof(AgingRate))]
        [ReadOnly(true)]
        public double AgingRate { get; set; }

        /// <summary>
        /// Gets or sets the square root of the length of the semi-major axis.
        /// </summary>
        /// <value>The square root of the length of the semi-major axis (<em>sqrt(A)</em>), in meters.</value>
        [Index(3)]
        [LocalizedCategory(nameof(BdsAlmanacCommand))]
        [LocalizedDescription(nameof(RootSemiMajorAxis))]
        [LocalizedDisplayName(nameof(RootSemiMajorAxis))]
        [ReadOnly(true)]
        public double RootSemiMajorAxis { get; set; }

        /// <summary>
        /// Gets or sets the correction of the orbit reference inclination at reference time.
        /// </summary>
        /// <value>The correction of the orbit reference inclination (<em>δi</em>), in radians.</value>
        [Index(9)]
        [LocalizedCategory(nameof(BdsAlmanacCommand))]
        [LocalizedDescription(nameof(CorrectionIncline))]
        [LocalizedDisplayName(nameof(CorrectionIncline))]
        [ReadOnly(true)]
        public double CorrectionIncline { get; set; }
    }
}

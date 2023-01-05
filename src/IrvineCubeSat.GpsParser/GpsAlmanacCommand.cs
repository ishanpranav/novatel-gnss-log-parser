// AlmanacCommand.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;
using System.ComponentModel;
using IrvineCubeSat.GpsParser.Attributes;
using IrvineCubeSat.GpsParser.BodyParsers;

namespace IrvineCubeSat.GpsParser
{
    /// <summary>
    /// Represents a decoded GPS almanac (<c>ALMANAC</c>) command message body.
    /// </summary>
    [Command("ALMANAC", typeof(GpsAlmanacParser))]
    public class GpsAlmanacCommand
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GpsAlmanacCommand"/> class.
        /// </summary>
        /// <param name="prn">The satellite PRN number.</param>
        /// <param name="weeks">The GPS reference week number: the number of weeks since January 6, 1980.</param>
        /// <param name="seconds">The number of seconds from the beginning of the GPS reference week.</param>
        /// <param name="eccentricity">The eccentricity.</param>
        /// <param name="rightAscensionRate">The rate of right ascension (<em>ώ</em>), in radians per second.</param>
        /// <param name="rightAscension">The right ascension (<em>ω0</em>), in radians.</param>
        /// <param name="argumentOfPerigree">The argument of perigree (<em>ω</em>), in radians.</param>
        /// <param name="meanAnomaly">The mean anomaly of the reference time (<em>M0</em>), in radians.</param>
        /// <param name="aging">The constant clock aging parameter (<em>af0</em>), in seconds.</param>
        /// <param name="agingRate">The linear clock aging parameter (<em>af1</em>), in seconds per second.</param>
        /// <param name="meanMotion">The computed mean motion (<em>N0</em>) in radians per second.</param>
        /// <param name="semiMajorAxis">The length of the semi-major axis (<em>A</em>), in meters.</param>
        /// <param name="incline">The angle of inclination, in radians, relative to 0.3 times <see cref="Math.PI"/> radians.</param>
        /// <param name="antiSpoofing"><see langword="true"/> if anti-spoofing is on; otherwise, <see langword="false"/>.</param>
        public GpsAlmanacCommand(uint prn, uint weeks, double seconds, double eccentricity, double rightAscension, double rightAscensionRate, double argumentOfPerigree, double meanAnomaly, double aging, double agingRate, double meanMotion, double semiMajorAxis, double incline, bool antiSpoofing)
        {
            Prn = prn;
            Timestamp = Time.CreateTimestamp(Time.GpsReference, weeks, seconds);
            Eccentricity = eccentricity;
            RightAscension = rightAscension;
            RightAscensionRate = rightAscensionRate;
            ArgumentOfPerigree = argumentOfPerigree;
            MeanAnomaly = meanAnomaly;
            Aging = aging;
            AgingRate = agingRate;
            MeanMotion = meanMotion;
            SemiMajorAxis = semiMajorAxis;
            Incline = incline;
            AntiSpoofing = antiSpoofing;
        }

        /// <summary>
        /// Gets the satellite PRN number for the message.
        /// </summary>
        /// <value>The satellite PRN number.</value>
        [LocalizedDisplayName(nameof(Prn))]
        public uint Prn { get; }

        /// <summary>
        /// Gets the GPS timestamp.
        /// </summary>
        /// <value>The current GPS time.</value>
        [LocalizedDisplayName(nameof(Timestamp))]
        public DateTime Timestamp { get; }

        /// <summary>
        /// Gets the eccentricity.
        /// </summary>
        /// <value>The eccentricity.</value>
        [LocalizedDisplayName(nameof(Eccentricity))]
        public double Eccentricity { get; }

        /// <summary>
        /// Gets the right ascension.
        /// </summary>
        /// <value>The right ascension (<em>ω0</em>), in radians.</value>
        [LocalizedDisplayName(nameof(RightAscension))]
        public double RightAscension { get; }

        /// <summary>
        /// Gets the right ascension rate.
        /// </summary>
        /// <value>The rate of right ascension (<em>ώ</em>), in radians per second.</value>
        [LocalizedDisplayName(nameof(RightAscensionRate))]
        public double RightAscensionRate { get; }

        /// <summary>
        /// Gets the argument of perigree.
        /// </summary>
        /// <value>The argument of perigree (<em>ω</em>), in radians.</value>
        [LocalizedDisplayName(nameof(ArgumentOfPerigree))]
        public double ArgumentOfPerigree { get; }

        /// <summary>
        /// Gets the mean anomaly of the reference time.
        /// </summary>
        /// <value>The mean anomaly of the reference time (<em>M0</em>), in radians.</value>
        [LocalizedDisplayName(nameof(MeanAnomaly))]
        public double MeanAnomaly { get; }

        /// <summary>
        /// Gets the first clock aging parameter, or the constant term of the clock correction polynomial.
        /// </summary>
        /// <value>The clock aging parameter (<em>af0</em>), in seconds.</value>
        [LocalizedDisplayName(nameof(Aging))]
        public double Aging { get; }

        /// <summary>
        /// Gets the second clock aging parameter, or the linear term of the clock correction polynomial.
        /// </summary>
        /// <value>The clock aging parameter (<em>af1</em>), in seconds per second.</value>
        [LocalizedDisplayName(nameof(AgingRate))]
        public double AgingRate { get; }

        /// <summary>
        /// Gets the computed mean motion.
        /// </summary>
        /// <value>The computed mean motion (<em>N0</em>) in radians per second.</value>
        [LocalizedDisplayName(nameof(MeanMotion))]
        public double MeanMotion { get; }

        /// <summary>
        /// Gets the length of the semi-major axis.
        /// </summary>
        /// <value>The length of the semi-major axis (<em>A</em>), in meters.</value>
        [LocalizedDisplayName(nameof(SemiMajorAxis))]
        public double SemiMajorAxis { get; }

        /// <summary>
        /// Gets the angle of inclination.
        /// </summary>
        /// <value>The angle of inclination, in radians, relative to 0.3 times <see cref="Math.PI"/> radians.</value>
        [LocalizedDisplayName(nameof(Incline))]
        public double Incline { get; }

        /// <summary>
        /// Gets a value indicating whether anti-spoofing is on.
        /// </summary>
        /// <value><see langword="true"/> if anti-spoofing is on; otherwise, <see langword="false"/>.</value>
        [LocalizedDisplayName(nameof(AntiSpoofing))]
        public bool AntiSpoofing { get; }
    }
}

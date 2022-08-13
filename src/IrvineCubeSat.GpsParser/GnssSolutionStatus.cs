// GnssSolutionStatus.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using CsvHelper.Configuration.Attributes;

namespace IrvineCubeSat.GpsParser
{
    public enum GnssSolutionStatus
    {
        [Name("SOL_COMPUTED")]
        SolutionComputed = 0,

        [Name("INSUFFICIENT_OBS")]
        InsufficientObservations = 1,

        [Name("NO_CONVERGENCE")]
        NoConvergence = 2,

        [Name("SINGULARITY")]
        Singularity = 3,

        [Name("COV_TRACE")]
        CovariancecTrace = 4,

        [Name("TEST_DIST")]
        TestDistanceExceeded = 5,

        [Name("COLD_START")]
        ColdStart = 6,

        [Name("V_H_LIMIT")]
        VelocityOrHeightLimitExceeded = 7,

        [Name("VARIANCE")]
        VarianceLimitExceeded = 8,

        [Name("RESIDUALS")]
        ResidualsTooLarge = 9,

        [Name("INTEGRITY_WARNING")]
        IntegrityWarning = 13,

        [Name("PENDING")]
        Pending = 18,

        [Name("INVALID_FIX")]
        InvalidFixedPosition = 19,

        [Name("UNAUTHORIZED")]
        Unauthorized = 20,

        [Name("INVALID_RATE")]
        InvalidLoggingRate = 22
    }
}

// Dop.cs
// Copyright (c) 2019-2023 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    /// <summary>
    /// Represents a dilution of precision value.
    /// </summary>
    public readonly struct Dop : IComparable, IComparable<Dop>, IEquatable<Dop>
    {
        public static readonly Dop Empty;

        private static Array? _values;

        /// <summary>
        /// Initializes a new instance of the <see cref="Dop"/> struct.
        /// </summary>
        /// <param name="value">The dilution of precision value.</param>
        public Dop(float value)
        {
            Value = value;
        }

        /// <summary>
        /// Gets the dilution of precision.
        /// </summary>
        /// <value>The dilution of precision value.</value>
        public float Value { get; }

        /// <summary>
        /// Gets an interpretation of the dilution of precision value.
        /// </summary>
        /// <value>The interpretation of the <see cref="Value"/>.</value>
        public DopInterpretation Interpretation
        {
            get
            {
                _values ??= Enum.GetValues(typeof(DopInterpretation));

                for (int i = _values.Length - 1; i >= 0; i--)
                {
                    object interpretation = _values.GetValue(i);

                    if (Value >= (byte)interpretation)
                    {
                        return (DopInterpretation)interpretation;
                    }
                }

                return DopInterpretation.Ideal;
            }
        }

        /// <inheritdoc/>
        public int CompareTo(Dop other)
        {
            return other.CompareTo(Value);
        }

        /// <inheritdoc/>
        public int CompareTo(object? obj)
        {
            if (obj is null)
            {
                return -1;
            }
            else if (obj is Dop other)
            {
                return CompareTo(other);
            }
            else
            {
                throw new ArgumentException(nameof(obj));
            }
        }

        /// <inheritdoc/>
        public bool Equals(Dop other)
        {
            return other.Value == Value;
        }

        /// <inheritdoc/>
        public override bool Equals(object? obj)
        {
            return obj is Dop other && Equals(other);
        }

        /// <inheritdoc/>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        /// Returns a value that indicates whether the values of two <see cref="Dop"/> objects are equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><see langword="true"/> if <param name="left"/> and <paramref name="right"/> are equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator ==(Dop left, Dop right)
        {
            return left.Value == right.Value;
        }

        /// <summary>
        /// Returns a value that indicates whether the values of two <see cref="Dop"/> objects are not equal.
        /// </summary>
        /// <param name="left">The first value to compare.</param>
        /// <param name="right">The second value to compare.</param>
        /// <returns><see langword="true"/> if <param name="left"/> and <paramref name="right"/> are not equal; otherwise, <see langword="false"/>.</returns>
        public static bool operator !=(Dop left, Dop right)
        {
            return left.Value != right.Value;
        }

        public static bool operator <(Dop left, Dop right)
        {
            return left.CompareTo(right) < 0;
        }

        public static bool operator >(Dop left, Dop right)
        {
            return left.CompareTo(right) > 0;
        }

        public static bool operator <=(Dop left, Dop right)
        {
            return left.CompareTo(right) <= 0;
        }

        public static bool operator >=(Dop left, Dop right)
        {
            return left.CompareTo(right) >= 0;
        }

        /// <inheritdoc/>
        public override string ToString()
        {
            return $"{Value} ({Interpretation})";
        }
    }
}

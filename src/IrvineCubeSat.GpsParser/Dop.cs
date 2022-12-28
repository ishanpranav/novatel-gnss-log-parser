// Dop.cs
// Copyright (c) 2019-2022 Ishan Pranav. All rights reserved.
// Licensed under the MIT License.

using System;

namespace IrvineCubeSat.GpsParser
{
    public readonly struct Dop : IComparable, IComparable<Dop>, IEquatable<Dop>
    {
        public static readonly Dop Empty;

        private static Array? _values;

        public Dop(float value)
        {
            Value = value;
        }

        public float Value { get; }

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

        public static bool operator ==(Dop left, Dop right)
        {
            return left.Value == right.Value;
        }

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

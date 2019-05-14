using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_App.Core.Classes
{
    /// <summary>
    /// Represents range errors when assigning a value to a field.
    /// </summary>
    public class InvalidAmount<T> : Exception
    {
        /// <summary>
        /// Enumerates the types of ranges contained in <c>InvalidAmount</c>.
        /// </summary>
        public enum RangeType
        {
            OPEN_RANGE = 0,
            LOWER_CAPPED = 1,
            UPPER_CAPPED = 2,
            ZONED_RANGE = 4
        }

        /// <summary>
        /// Represents a limit in a numeric range
        /// </summary>
        public class NumericCap
        {
            T m_value;
            bool m_inclusive;

            /// <summary>
            /// Initializes a new instance of the <c>NumericCap</c>. It receives
            /// a value and a boolean that determines if the limit is open (or inclusive).
            /// </summary>
            /// <param name="value">Numeric value that represents the limit.</param>
            /// <param name="inclusive">If true, <paramref name="value"/> represents an open limit.</param>
            public NumericCap(T value, bool inclusive)
            {
                Value = value;
                Inclusive = inclusive;
            }

            /// <summary>
            /// Limit of this range
            /// </summary>
            public T Value { get => m_value; set => m_value = value; }

            /// <summary>
            /// True if this limit is open (or inclusive).
            /// </summary>
            public bool Inclusive { get => m_inclusive; set => m_inclusive = value; }
        }

        /// <summary>
        /// Represents the lowest valid value for the amount
        /// </summary>
        public NumericCap LowerRange { get; }
        /// <summary>
        /// Represents the highest valid value for the amount
        /// </summary>
        public NumericCap UpperRange { get; }
        /// <summary>
        /// Represents the type of range that governs the amount
        /// </summary>
        public RangeType TypeOfRange { get; }

        /// <summary>
        /// Initializes a new instance of <c>InvalidAmount</c>. It receives an error message to display.
        /// </summary>
        /// <param name="message">Descriptive message for this exeption.</param>
        public InvalidAmount(string message) : base(message)
        {
            TypeOfRange = RangeType.OPEN_RANGE;
        }

        /// <summary>
        /// Initializes a new instance of <c>InvalidAmount</c>. It receives a several values to define one point that separates valid from invalid values.
        /// </summary>
        /// <param name="message">Descriptive message for this exeption.</param>
        /// <param name="val">Value which separates a valid from an invalid amount.</param>
        /// <param name="inclusive">Determines if <paramref name="val"/> itself is valid (true) or invalid (false)</param>
        /// <param name="lowerIsValid">Determines if values less than <paramref name="val"/> are valid (true) or the other way around.</param>
        public InvalidAmount(string message,
            T val,
            bool inclusive,
            bool lowerIsValid) : base(message)
        {
            if (lowerIsValid)
            {
                TypeOfRange = RangeType.UPPER_CAPPED;
                UpperRange = new NumericCap(val, inclusive);
            }
            else
            {
                TypeOfRange = RangeType.LOWER_CAPPED;
                LowerRange = new NumericCap(val, inclusive);
            }
        }

        /// <summary>
        /// Initializes a new instance of <c>InvalidAmount</c>. It recieves a lower and upper cap to enclose a valid amount.
        /// </summary>
        /// <param name="message">Descriptive message for this exeption.</param>
        /// <param name="min">Determines the lower cap for valid ranges.</param>
        /// <param name="minInclusive">True when <paramref name="min"/> is valid (or included).</param>
        /// <param name="max">Determines the upper cap for valid ranges.</param>
        /// <param name="maxInclusive">True when <paramref name="max"/> is valid (or included).</param>
        public InvalidAmount(string message,
            T min,
            bool minInclusive,
            T max,
            bool maxInclusive) : base(message)
        {
            TypeOfRange = RangeType.ZONED_RANGE;
            LowerRange = new NumericCap(min, minInclusive);
            UpperRange = new NumericCap(max, maxInclusive);
        }

    }
}

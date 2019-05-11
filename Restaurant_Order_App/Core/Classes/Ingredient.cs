using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//TODO: finish documentation for this class

namespace Restaurant_Order_App.Core.Classes
{
    class Ingredient
    {
        public string Name { get; }
        private decimal m_cost;
        private decimal m_markup;
        public decimal Weight { get; }
        private decimal m_caloriePerGram;
        private decimal m_waterWeight;

        public Ingredient(string name, decimal weight, decimal markup, decimal cost, decimal caloriePerGram, decimal waterPercentage)
        {
            this.Name = name ?? throw new ArgumentNullException(nameof(name));
            this.Weight = weight;
            Markup = markup;
            Cost = cost;
            CaloriePerGram = caloriePerGram;
            WaterPercentage = waterPercentage;
        }

        private decimal Calories => m_caloriePerGram * Weight;
        
        public decimal Markup
        {
            get
            {
                return m_markup;
            }

            protected set
            {
                if (value >= 1)
                    m_markup = value;
                else
                {
                    throw new
                        IngredientExeptions.InvalidAmount(
                        "'" + value + "' is not a valid markup rate.",
                        1, true, false);
                }
            }
        }

        public decimal Cost
        {
            get
            {
                return m_cost;
            }

            protected set
            {
                if (value >= 0)
                    m_cost = value;
                else
                {
                    throw new
                        IngredientExeptions.InvalidAmount(
                            "'" + value + "' is not a valid positive dollar amount.",
                            0, true, false);
                }
            }
        }
        
        private decimal CaloriePerGram
        {
            set
            {
                if (value > 0)
                    m_caloriePerGram = value;
                else
                {
                    throw new
                        IngredientExeptions.InvalidAmount(
                            "'" + value + "' is not a valid positive weight",
                            0, false, false);
                }
            }
        }

        private decimal WaterPercentage
        {
            set
            {
                if (value >= 0 && value <= 1)
                    m_waterWeight = value;
                else
                {
                    throw new
                        IngredientExeptions.InvalidAmount(
                            "'" + value + "' is not a valid water percentage",
                            0, true, 1, true);
                }
            }
        }
    }

    namespace IngredientExeptions
    {
        /// <summary>
        /// Represents range errors when assigning a value to a field.
        /// </summary>
        public class InvalidAmount : Exception
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
                /// <summary>
                /// Initializes a new instance of the <c>NumericCap</c>. It receives
                /// a value and a boolean that determines if the limit is open (or inclusive).
                /// </summary>
                /// <param name="value">Numeric value that represents the limit.</param>
                /// <param name="inclusive">If true, <paramref name="value"/> represents an open limit.</param>
                public NumericCap(decimal value, bool inclusive)
                {
                    Value = value;
                    Inclusive = inclusive;
                }

                /// <summary>
                /// Limit of this range
                /// </summary>
                public decimal Value { get => Value; set => Value = value; }
                
                /// <summary>
                /// True if this limit is open (or inclusive).
                /// </summary>
                public bool Inclusive { get => Inclusive; set => Inclusive = value; }
            }

            public NumericCap LowerRange { get; }
            public NumericCap UpperRange { get; }
            public RangeType TypeOfRange { get; }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="message"></param>
            public InvalidAmount(string message) : base(message)
            {
                TypeOfRange = RangeType.OPEN_RANGE;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="message"></param>
            /// <param name="val"></param>
            /// <param name="inclusive"></param>
            /// <param name="lowerIsValid">A false value means that this range is valid towards the positive side.</param>
            public InvalidAmount(string message,
                decimal val,
                bool inclusive,
                bool lowerIsValid) : base(message)
            {
                if (lowerIsValid)
                {
                    TypeOfRange = RangeType.UPPER_CAPPED;
                    UpperRange.Value = val;
                    UpperRange.Inclusive = inclusive;
                }
                else
                {
                    TypeOfRange = RangeType.LOWER_CAPPED;
                    LowerRange.Value = val;
                    LowerRange.Inclusive = inclusive;
                }
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="message"></param>
            /// <param name="min"></param>
            /// <param name="minInclusive"></param>
            /// <param name="max"></param>
            /// <param name="maxInclusive"></param>
            public InvalidAmount(string message,
                decimal min,
                bool minInclusive,
                decimal max,
                bool maxInclusive) : base(message)
            {
                TypeOfRange = RangeType.ZONED_RANGE;
                UpperRange.Value = max;
                UpperRange.Inclusive = minInclusive;
                LowerRange.Value = min;
                LowerRange.Inclusive = maxInclusive;
            }

        }
    }
}

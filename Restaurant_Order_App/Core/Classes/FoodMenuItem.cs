using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_App.Core.Classes
{
    enum FoodType
    {
        FT_MAINDISH = 0,
        FT_BEVERAGE = 1,
        FT_DESSERT = 2
    }

    class FoodMenuItem
    {
        private decimal m_price;
        private double m_calories;
        private TimeSpan m_prepareTime;
        private FoodType m_DishType;

        public decimal Price
        {
            get
            {
                return m_price;
            }

            private set
            {
                if (value >= 0)
                {
                    m_price = value;
                }
                else
                {
                    throw new InvalidAmount<decimal>(
                        "'" + value + "' is not a valid positive dollar amount.",
                        0m, true, false);
                }
            }
        }

        public double Calories
        {
            get
            {
                return m_calories;
            }

            private set
            {
                if (value > 0)
                {
                    m_calories = value;
                }
                else
                {
                    throw new InvalidAmount<double>(
                        "'" + value + "' is not a valid positve non-zero caloric count.",
                        0, false, false);
                }
            }
        }

        public TimeSpan PreparationTime
        {
            get
            {
                return m_prepareTime;
            }

            private set
            {
                if(value.CompareTo(TimeSpan.Zero) < 0)
                {
                    m_prepareTime = value;
                }
                else
                {
                    throw new InvalidAmount<TimeSpan>(
                        "'" + value + "' is not a valid positive non-zero preparation time.",
                        TimeSpan.Zero, false, false);
                }
            }
        }

        public FoodType DishType
        {
            get
            {
                return m_DishType;
            }

            private set
            {
                switch (value)
                {
                    case FoodType.FT_MAINDISH:
                    case FoodType.FT_BEVERAGE:
                    case FoodType.FT_DESSERT:
                        m_DishType = value;
                        break;
                    default:
                        throw new InvalidAmount<int>("'" + value + "' is not a valid food type.");
                }
            }
        }
    }
}

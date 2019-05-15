using System;
using System.Collections.Generic;
using System.Globalization;
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

    struct AdditionsList
    {
        string name;
        decimal price;

        public AdditionsList(string name, decimal price)
        {
            this.name = name ?? throw new ArgumentNullException(nameof(name));
            this.price = price;
        }
    }
    

    class FoodMenuItem
    {
        private const char LIST_ITEM_SEPARATOR = ',';
        private const char OPTIONS_SEPARATOR = '|';

        private string m_name;
        private decimal m_price;
        private double m_calories;
        private TimeSpan m_prepareTime;
        private FoodType m_dishType;
        private List<string> m_options;
        private List<AdditionsList> m_additions;
        private List<AdditionsList> m_extras;

        public FoodMenuItem(string parseString)
        {
            string[] splitParams = parseString.Split(LIST_ITEM_SEPARATOR);

            string name;
            decimal price;
            double calories;
            TimeSpan preparationTime;
            int dishTypeInt;
            FoodType dishType;

            //sets a static format for TimeSpan parsing
            CultureInfo en_us_lang = new CultureInfo("en-US");

            name = splitParams[0];
            decimal.TryParse(splitParams[1], out price);
            double.TryParse(splitParams[2], out calories);
            TimeSpan.TryParse(splitParams[3], en_us_lang, out preparationTime);
            int.TryParse(splitParams[4], out dishTypeInt);
            dishType = (FoodType)dishTypeInt;

            m_options = new List<string>();
            m_additions = new List<AdditionsList>();
            m_extras = new List<AdditionsList>();

            Name = name;
            Price = price;
            Calories = calories;
            PreparationTime = preparationTime;
            DishType = dishType;

            string[] options = splitParams[5].Split(OPTIONS_SEPARATOR);
            string[] additions = splitParams[6].Split(OPTIONS_SEPARATOR);
            string[] extras = splitParams[7].Split(OPTIONS_SEPARATOR);

            foreach (var item in options)
            {
                m_options.Add(item);
            }

            decimal newPrice;

            for (int i = 0; i < additions.Length && splitParams[6].Length != 0; i += 2)
            {
                decimal.TryParse(additions[i + 1] , out newPrice);
                m_additions.Add(new AdditionsList(additions[i], newPrice));
            }

            for (int i = 0; i < extras.Length && splitParams[7].Length != 0; i += 2)
            {
                decimal.TryParse(extras[i + 1], out newPrice);
                m_additions.Add(new AdditionsList(extras[i], newPrice));
            }
        }

        public string Name
        {
            get
            {
                return m_name;
            }

            private set
            {
                m_name = value;
            }
        }

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
                if (value >= 0)
                {
                    m_calories = value;
                }
                else
                {
                    throw new InvalidAmount<double>(
                        "'" + value + "' is not a valid positve non-zero caloric count.",
                        0, true, false);
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
                if(value.CompareTo(TimeSpan.Zero) > 0)
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
                return m_dishType;
            }

            private set
            {
                switch (value)
                {
                    case FoodType.FT_MAINDISH:
                    case FoodType.FT_BEVERAGE:
                    case FoodType.FT_DESSERT:
                        m_dishType = value;
                        break;
                    default:
                        throw new InvalidAmount<int>("'" + value + "' is not a valid food type.");
                }
            }
        }

        public string Options(int index)
        {
            return m_options[index];
        }

        public AdditionsList Additions(int index)
        {
            return m_additions[index];
        }

        public AdditionsList Extra(int index)
        {
            return m_additions[index];
        }
    }
}

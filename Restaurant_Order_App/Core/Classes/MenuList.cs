using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Order_App.Core.Classes;

namespace Restaurant_Order_App.Core.Classes
{
    class MenuList
    {
        Dictionary<string, string> keyDishes;
        //Dictionary<string, Ingredient> keyToppings;
        //Dictionary<string, Ingredient> keyExtras;
        private TimeSpan m_prepareTime;

        public MenuList(string s)
        {
            //Ingredient.Parse("");
            //this.keyIngredients = keyIngredients ?? throw new ArgumentNullException(nameof(keyIngredients));
        }

        public TimeSpan PreparationTime
        {
            get
            {
                return m_prepareTime;
            }

            private set
            {
                if (value.CompareTo(TimeSpan.Zero) >= 0)
                {
                    m_prepareTime = value;
                }
                else
                {
                    throw new
                        InvalidAmount<TimeSpan>(
                            "'" + value + "' is not a valid preparation time.",
                            TimeSpan.Zero, true, false);
                }
            }
        }
    }
}

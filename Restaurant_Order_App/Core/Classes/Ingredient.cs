using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Order_App.Core.Classes
{
    class Ingredient
    {
        private decimal m_cost;
        private decimal m_markup;

        public decimal calories;

        public decimal Markup
        {
            get
            {
                return m_markup;
            }

            protected set
            {
                if (value >= 1)
                    m_cost = value;
                else
                    throw new IngredientExeptions.InvalidMarkup("'" + value + "' is not a valid markup rate.");
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
                    throw new IngredientExeptions.InvalidCost("'" + value + "' is not a valid positive dollar amount.");
                
            }
        }
    }

    namespace IngredientExeptions
    {
        public class InvalidCost : Exception
        {
            public InvalidCost(string message) : base(message)
            {
                //nothing to do here
            }
        }

        public class InvalidMarkup : Exception
        {
            public InvalidMarkup(string message) : base(message)
            {
                //nothing to do here
            }
        }
    }
}

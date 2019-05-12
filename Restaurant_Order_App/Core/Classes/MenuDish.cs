using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Restaurant_Order_App.Core.Classes;

namespace Restaurant_Order_App.Core.Classes
{
    class MenuDish
    {
        Dictionary<string, Ingredient> keyIngredients;
        Dictionary<string, Ingredient> keyToppings;
        Dictionary<string, Ingredient> keyExtras;

        public MenuDish(string s)
        {
            //Ingredient.Parse("");
            //this.keyIngredients = keyIngredients ?? throw new ArgumentNullException(nameof(keyIngredients));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Restaurant_Order_App.Core.Classes
{
    /// <summary>
    /// Lists the possible outcome states of the readSalesData
    /// </summary>
    enum ReadOutcome
    {
        READ_SUCCESS = 0,
        READ_WITH_ERRORS = 1,
        READ_FAILED = 2
    }

    class MenuList
    {
        private const char DB_ITEM_SEPARATOR = ';';
        private const char LIST_ITEM_SEPARATOR = ',';

        public Dictionary<string, FoodMenuItem> keyDishes;
        public Dictionary<string, FoodMenuItem> keyBeverages;
        public Dictionary<string, FoodMenuItem> keyDesserts;

        public MenuList()
        {
            keyDishes = new Dictionary<string, FoodMenuItem>();
            keyBeverages = new Dictionary<string, FoodMenuItem>();
            keyDesserts = new Dictionary<string, FoodMenuItem>();
        }

        public ReadOutcome LoadMenu(string path)
        {
            //input file variable
            StreamReader inFile = null;
            //stores the whole text in the file
            string flatText = "";
            string[] stringItems;
            string id;
            FoodMenuItem intermediate;

            //stores a value that deteremines if the dataset contains error values
            bool errFlag = false;

            //checks if file exists
            if (File.Exists(path))
            {
                inFile = File.OpenText(path);

                //adds all text into the string without spaces
                while (!inFile.EndOfStream)
                {
                    flatText += inFile.ReadLine();
                }

                stringItems = flatText.Split(DB_ITEM_SEPARATOR);

                foreach (var item in stringItems)
                {
                    id = item.Substring(0, item.IndexOf(LIST_ITEM_SEPARATOR));
                    intermediate = new FoodMenuItem(item.Substring(item.IndexOf(LIST_ITEM_SEPARATOR) + 1));

                    switch (intermediate.DishType)
                    {
                        case FoodType.FT_MAINDISH:
                            keyDishes.Add(id, intermediate);
                            break;
                        case FoodType.FT_BEVERAGE:
                            keyBeverages.Add(id, intermediate);
                            break;
                        case FoodType.FT_DESSERT:
                            keyDesserts.Add(id, intermediate);
                            break;
                        default:
                            break;
                    }

                    intermediate = null;
                }

                //properly closes the file connection
                inFile.Dispose();
                inFile = null;

                //if (dataSet.Count == 0)
                //    return ReadOutcome.READ_FAILED;
            }
            else
            {
                return ReadOutcome.READ_FAILED;
            }

            if (errFlag)
            {
                return ReadOutcome.READ_WITH_ERRORS;
            }

            return ReadOutcome.READ_SUCCESS;
        }
    }
}

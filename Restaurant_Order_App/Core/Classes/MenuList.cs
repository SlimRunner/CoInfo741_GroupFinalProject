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
        public Dictionary<string, FoodMenuItem> keySalads;

        public MenuList()
        {
            keyDishes = new Dictionary<string, FoodMenuItem>();
            keyBeverages = new Dictionary<string, FoodMenuItem>();
            keyDesserts = new Dictionary<string, FoodMenuItem>();
            keySalads = new Dictionary<string, FoodMenuItem>();
        }

        public ReadOutcome LoadMenu(string path)
        {
            //input file variable
            StreamReader inFile = null;
            //stores the whole text in the file
            string flatText = "";
            string[] stringItems;
            string keyDict;
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
                    keyDict = item.Substring(5, item.IndexOf(LIST_ITEM_SEPARATOR,5)-5);
                    intermediate = new FoodMenuItem(item);

                    switch (intermediate.DishType)
                    {
                        case FoodType.FT_MAINDISH:
                            keyDishes.Add(keyDict, intermediate);
                            break;
                        case FoodType.FT_BEVERAGE:
                            keyBeverages.Add(keyDict, intermediate);
                            break;
                        case FoodType.FT_DESSERT:
                            keyDesserts.Add(keyDict, intermediate);
                            break;
                        case FoodType.FT_SALAD:
                            keySalads.Add(keyDict, intermediate);
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

        public FoodMenuItem GetItemById(string id)
        {
            if (keyBeverages.ContainsKey(id))
                return keyBeverages[id];
            else if (keyDesserts.ContainsKey(id))
                return keyDesserts[id];
            else if (keyDishes.ContainsKey(id))
                return keyDishes[id];
            else if (keySalads.ContainsKey(id))
                return keySalads[id];
            else
                return null;
        }
    }
}

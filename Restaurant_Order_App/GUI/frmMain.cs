using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Order_App.Core.Libraries;
using Restaurant_Order_App.Core.Classes;
using Restaurant_Order_App.GUI;

namespace Restaurant_Order_App
{
    public partial class frmMain : Form
    {
        //Param Types (PT)
        private const string PT_OPTIONS = "[options]";
        private const string PT_ADDITIONS = "[additions]";
        private const string PT_EXTRAS = "[extras]";
        
        private const char PARAM_SEPARATOR = ';';
        private const char ITEMS_SEPARATOR = ',';

        private MenuList menuCarte;
        private List<string> orderedItems;
        private List<string> customOptions;
        private FoodType selectedCategory;

        private const string INFO_LABEL_FORMAT = "Price: {0:c}\nCalories: {1}\nPreparation: {2} min";

        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            menuCarte = new MenuList();
            menuCarte.LoadMenu("../../../../Final_Workspace/menu_database.txt");

            orderedItems = new List<string>();
            customOptions = new List<string>();

        submMainDishes.PerformClick();
        }

        private void submExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want ro exit",
                    "Confirm close",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void submFoodCategory_GroupClick(object sender, EventArgs e)
        {
            var senderCasted = (ToolStripRadioButtonMenuItem)sender;
            selectedCategory = (FoodType)int.Parse(senderCasted.Tag.ToString());

            lstMenuCarte.Items.Clear();
            if (picSelectedFood.Image != null)
            {
                picSelectedFood.Image.Dispose();
                picSelectedFood.Image = null;
            }
            lblFoodInfo.Text = string.Format(INFO_LABEL_FORMAT, "", "", "");

            setEnabledToCustomEntry(false);

            switch (selectedCategory)
            {
                case FoodType.FT_MAINDISH:
                    foreach (var item in menuCarte.keyDishes)
                    {
                        lstMenuCarte.Items.Add(item.Key);
                    }
                    break;
                case FoodType.FT_BEVERAGE:
                    foreach (var item in menuCarte.keyBeverages)
                    {
                        lstMenuCarte.Items.Add(item.Key);
                    }
                    break;
                case FoodType.FT_DESSERT:
                    foreach (var item in menuCarte.keyDesserts)
                    {
                        lstMenuCarte.Items.Add(item.Key);
                    }
                    break;
                case FoodType.FT_SALAD:
                    foreach (var item in menuCarte.keySalads)
                    {
                        lstMenuCarte.Items.Add(item.Key);
                    }
                    break;
                default:
                    break;
            }
        }

        private void lstMenuCarte_SelectedIndexChanged(object sender, EventArgs e)
        {
            FoodMenuItem currentItem = menuCarte.GetItemById(lstMenuCarte.SelectedItem.ToString());

            if (lstMenuCarte.SelectedIndex >= 0)
            {
                
                if (picSelectedFood.Image != null) picSelectedFood.Image.Dispose();
                picSelectedFood.Image = Image.FromFile("../../../../Final_Workspace/food_images/" + currentItem.ID + ".jpg");
                lblFoodInfo.Text = string.Format(INFO_LABEL_FORMAT, currentItem.Price, currentItem.Calories, currentItem.PreparationTime.Minutes);
                setEnabledToCustomEntry(currentItem.CanModify);
            }
        }

        //Group of event handlers that add items to the order with custom options.
        private void cmdAddItems_GroupClick(object sender, EventArgs e)
        {
            if (lstMenuCarte.SelectedIndex < 0)
            {
                MessageBox.Show("You have not selected any items",
                    this.Text,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            else
            {
                customOptions.Add("");
                //adds order to dynamic array
                orderedItems.Add(lstMenuCarte.SelectedItem.ToString());
                //refreshes list of current order
                PrintTotalPrice();
            }
        }

        //Group of event handlers that add items to the order with custom options.
        private void cmdCustomItems_GroupClick(object sender, EventArgs e)
        {
            dynamic thisControl;

            try
            {
                thisControl = (Control)sender;
            }
            catch (InvalidCastException)
            {
                thisControl = (ToolStripItem)sender;
            }

            ListBox lstSource;
            string selectedItem;
            bool isEditing = thisControl.Tag != null;

            if (isEditing)
                lstSource = lstOrderedItems;
            else
                lstSource = lstMenuCarte;

            if (lstSource.SelectedIndex >= 0)
            {
                string proxyOptions = "";

                if (isEditing)
                {
                    selectedItem = orderedItems[lstSource.SelectedIndex];
                    proxyOptions = customOptions[lstSource.SelectedIndex];
                }
                else
                {
                    selectedItem = lstSource.SelectedItem.ToString();
                }

                FoodMenuItem currentItem = menuCarte.GetItemById(selectedItem);

                if (frmCustomizeDialog.GetCustomPicks(currentItem, ref proxyOptions, isEditing))
                {
                    //adds order to dynamic array is not editing
                    if (!isEditing)
                    {
                        orderedItems.Add(selectedItem);
                        customOptions.Add(proxyOptions);
                    }
                    else
                    {
                        customOptions[lstSource.SelectedIndex] = proxyOptions;
                    }
                }

                //refreshes list of current order
                PrintTotalPrice();
            }
            else
            {
                MessageBox.Show("You have not selected any items",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //Group of event handlers that delete items from the order.
        private void cmdRemoveItems_GroupClick(object sender, EventArgs e)
        {
            //deletes items only if there is a valid selected index
            if (lstOrderedItems.SelectedIndex < 0)
            {
                MessageBox.Show("You have not selected an item to delete!",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                //deletes items from order from last to first
                for (int i = lstOrderedItems.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    orderedItems.RemoveAt(lstOrderedItems.SelectedIndices[i]);
                    customOptions.RemoveAt(lstOrderedItems.SelectedIndices[i]);
                }

                //refreshes list of current order
                PrintTotalPrice();
            }
        }

        private void PrintTotalPrice()
        {
            decimal total = 0;
            int index = 0;
            string description;

            //clear listbox
            lstOrderedItems.Items.Clear();
            //foreach orderedItems
            foreach (var item in orderedItems)
            {
                total += menuCarte.GetItemById(item).Price + getPriceOfCustomAditions(index, out description);
                lstOrderedItems.Items.Add(string.Format("{0,-35}{1:c} {2}", item, menuCarte.GetItemById(item).Price, description));
                ++index;
            }

            lblDisplaySubtotal.Text = "Subtotal\n" + total.ToString("c");
        }

        /// <summary>
        /// Returns the total price of the addtions and options of the item in the current order by index.
        /// </summary>
        /// <param name="index">This index refers to the corresponding selected item in lstOrderedItems</param>
        /// <returns></returns>
        private decimal getPriceOfCustomAditions(int index, out string description)
        {
            var parsedParams = MyMath.DispatchParams(customOptions[index], PARAM_SEPARATOR, ITEMS_SEPARATOR);
            decimal priceTotal = 0;

            description = "";

            if (parsedParams.Count == 0)
                return 0;

            foreach (var item in parsedParams[PT_ADDITIONS])
            {
                priceTotal += menuCarte.GetItemById(orderedItems[index]).Additions(item).price;
            }

            foreach (var item in parsedParams[PT_EXTRAS])
            {
                priceTotal += menuCarte.GetItemById(orderedItems[index]).Extra(item).price;
            }

            if (priceTotal > 0)
                description = "[Custom]";

            return priceTotal;
        }

        private void setEnabledToCustomEntry(bool newValue)
        {
            btnCustomItem.Enabled = newValue;
            cmnuCustomAdd.Enabled = newValue;
        }

        private void cmnuOrderOptions_Opening(object sender, CancelEventArgs e)
        {
            if (lstOrderedItems.SelectedIndices.Count != 1)
                cmnuEditItem.Enabled = false;
            else
                cmnuEditItem.Enabled = menuCarte.GetItemById(orderedItems[lstOrderedItems.SelectedIndex]).CanModify;
        }
    }
}

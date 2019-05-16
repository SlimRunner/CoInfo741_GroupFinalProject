using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Restaurant_Order_App.Core.Classes;

namespace Restaurant_Order_App
{
    public partial class frmMain : Form
    {
        private MenuList menuCarte;
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
            btnCustomItem.Enabled = false;

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
            FoodMenuItem currentItem;

            if (lstMenuCarte.SelectedIndex >= 0)
            {
                switch (selectedCategory)
                {
                    case FoodType.FT_MAINDISH:
                        currentItem = menuCarte.keyDishes[lstMenuCarte.SelectedItem.ToString()];
                        break;
                    case FoodType.FT_BEVERAGE:
                        currentItem = menuCarte.keyBeverages[lstMenuCarte.SelectedItem.ToString()];
                        break;
                    case FoodType.FT_DESSERT:
                        currentItem = menuCarte.keyDesserts[lstMenuCarte.SelectedItem.ToString()];
                        break;
                    case FoodType.FT_SALAD:
                        currentItem = menuCarte.keySalads[lstMenuCarte.SelectedItem.ToString()];
                        break;
                    default:
                        currentItem = null;
                        break;
                }
                
                if (picSelectedFood.Image != null) picSelectedFood.Image.Dispose();
                picSelectedFood.Image = Image.FromFile("../../../../Final_Workspace/food_images/" + currentItem.ID + ".jpg");
                lblFoodInfo.Text = string.Format(INFO_LABEL_FORMAT, currentItem.Price, currentItem.Calories, currentItem.PreparationTime.Minutes);
                btnCustomItem.Enabled = currentItem.CanModify;
            }
        }

        private void cmdAddItems_Group(object sender, EventArgs e)
        {
            if (lstMenuCarte.Text == "")
                MessageBox.Show("You have not selected any items",
                    this.Text,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            else
            {

                //foreach (var item in lstMenuCarte.SelectedItems)
                //{
                //    lstOrderedItems.Items.Add(item);
                //}
                lstOrderedItems.Items.Add(lstMenuCarte.SelectedItem);
            }
        }

        private void cmdRemoveItems_Group(object sender, EventArgs e)
        {
            if (lstOrderedItems.Text == "")
                MessageBox.Show("You have not selected an item to delete!",
                    this.Text, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                for (int i = lstOrderedItems.SelectedIndices.Count - 1; i >= 0; i--)
                {
                    lstOrderedItems.Items.RemoveAt(lstOrderedItems.SelectedIndices[i]);
                }
            }
        }
    }
}

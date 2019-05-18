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
using Restaurant_Order_App.Core.Libraries;
using System.Text.RegularExpressions;

namespace Restaurant_Order_App.GUI
{
    public partial class frmCustomizeDialog : Form
    {
        #region Constants
        /// <summary>
        /// Param Types
        /// </summary>
        private const string PT_OPTIONS = "[options]";
        /// <summary>
        /// Param Types
        /// </summary>
        private const string PT_ADDITIONS = "[additions]";
        /// <summary>
        /// Param Types
        /// </summary>
        private const string PT_EXTRAS = "[extras]";
        #endregion

        private const string PARAM_FORMAT = "[options]{0};[additions]{1};[extras]{2}";
        private const char PARAM_SEPARATOR = ';';
        private const char ITEMS_SEPARATOR = ',';

        private static string outString;

        public frmCustomizeDialog()
        {
            InitializeComponent();
        }

        internal static bool GetCustomPicks(FoodMenuItem currentItem, ref string selected, bool isEditing)
        {
            var myForm = new frmCustomizeDialog();

            myForm.chkAdditions.Items.Clear();
            myForm.chkExtras.Items.Clear();
            myForm.lstOptions.Items.Clear();

            for (int i = 0; i < currentItem.OptionsLength; ++i)
            {
                myForm.lstOptions.Items.Add(currentItem.Options(i));
            }
            if(myForm.lstOptions.Items.Count == 0)
            {
                myForm.lblOptions.Enabled = false;
                myForm.lstOptions.Enabled = false;
            }
            else
            {
                myForm.lstOptions.SelectedIndex = 0;
            }

            for (int i = 0; i < currentItem.AdditionsLength; ++i)
            {
                myForm.chkAdditions.Items.Add(currentItem.Additions(i).name + " " + currentItem.Additions(i).price);
            }
            if (myForm.chkAdditions.Items.Count == 0)
            {
                myForm.lblAdditions.Enabled = false;
                myForm.chkAdditions.Enabled = false;
            }

            for (int i = 0; i < currentItem.ExtraLength; ++i)
            {
                myForm.chkExtras.Items.Add(currentItem.Extra(i).name + " " + currentItem.Extra(i).price);
            }
            if (myForm.chkExtras.Items.Count == 0)
            {
                myForm.lblExtras.Enabled = false;
                myForm.chkExtras.Enabled = false;
            }

            if (isEditing)
            {
                myForm.btnAdd.Text = "Update";
                myForm.InitOptions(selected);
            }

            if (myForm.ShowDialog() == DialogResult.OK)
            {
                selected = outString;

                return true;   // public property on your form of the result selected
            }

            selected = "";
            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            List<string> genericList = new List<string>();
            string[] selections = new string[3];

            if (lstOptions.SelectedIndex >= 0)
                selections[0] = lstOptions.SelectedIndex.ToString();
            else
                selections[0] = string.Empty;

            genericList.Clear();
            foreach (var item in chkAdditions.CheckedIndices)
            {
                genericList.Add(item.ToString());
            }
            selections[1] = string.Join(",", genericList);

            genericList.Clear();
            foreach (var item in chkExtras.CheckedIndices)
            {
                genericList.Add(item.ToString());
            }
            selections[2] = string.Join(",", genericList);

            outString = string.Format(PARAM_FORMAT, selections);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void InitOptions(string srcParams)
        {
            Dictionary<string, List<int>> parsedParams = MyMath.DispatchParams(srcParams, PARAM_SEPARATOR, ITEMS_SEPARATOR);

            foreach (var item in parsedParams)
            {
                switch (item.Key)
                {
                    case PT_OPTIONS:
                        if(item.Value.Count > 0)
                            lstOptions.SelectedIndex = item.Value[0];
                        break;
                    case PT_ADDITIONS:
                        foreach (var param in item.Value)
                        {
                            chkAdditions.SetItemChecked(param, true);
                        }

                        break;
                    case PT_EXTRAS:
                        foreach (var param in item.Value)
                        {
                            chkExtras.SetItemChecked(param, true);
                        }

                        break;
                    default:
                        break;
                }
            }
        }
    }
}

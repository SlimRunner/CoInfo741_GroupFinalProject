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

namespace Restaurant_Order_App
{
    public partial class frmSplashScreen : Form
    {
        private double fade_transition = 0;

        #region Use of Window's API to enable the user to move a borderless form

        /* Source of this code
         * https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable
         * By
         * https://stackoverflow.com/users/73070/joey
         */
        
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        private void MouseDown_MoveClient(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        #endregion

        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            //determines if fade-in is done
            if (fade_transition < 1)
            {
                //increases the opacity of the form
                fade_transition += 0.03;
                this.Opacity = MyMath.getBezier(fade_transition, 0, 0, .58, 1); //ease-out
            }
            else
            {
                //disables this timer
                fade_transition = 1;
                timerFadeIn.Enabled = false;
            }
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            //speeds up timer
            timerFadeOut.Interval = 1;

            //determines if fade-out is done
            if (fade_transition > 0)
            {
                //decreases the opacity of the form
                fade_transition -= 0.03;
                this.Opacity = MyMath.getBezier(fade_transition, 0.42, 0, 1, 1); //ease-in
            }
            else
            {
                //disables this timer and closes form
                fade_transition = 0;
                timerFadeOut.Enabled = false;
                this.Close();
            }
        }
    }
}

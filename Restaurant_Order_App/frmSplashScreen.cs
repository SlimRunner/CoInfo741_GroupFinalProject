using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_Order_App
{
    public partial class frmSplashScreen : Form
    {
        #region This are dll declarations that enable the user to move a borderless form
        //Reference
        //https://stackoverflow.com/questions/1592876/make-a-borderless-form-movable

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

        static public double getBezierFlat(double trans,
            double pivot1_X, double pivot1_Y,
            double pivot2_X, double pivot2_Y)
        {
            /*
             * P0 = (X0,Y0)
             * P1 = (X1,Y1)
             * P2 = (X2,Y2)
             * P3 = (X3,Y3)
             * 
             * X(t) = (1-t)^3 * X0 + 3*(1-t)^2 * t * X1 + 3*(1-t) * t^2 * X2 + t^3 * X3
             * Y(t) = (1-t)^3 * Y0 + 3*(1-t)^2 * t * Y1 + 3*(1-t) * t^2 * Y2 + t^3 * Y3
             */
            /*
            const double ANCHOR1_XY = 0;
            const double ANCHOR2_XY = 1;

            double outLinearY;

            outLinearY = Math.Pow(1 - trans, 3) * ANCHOR1_XY + 3 * Math.Pow(1 - trans, 2) * trans * pivot1_Y + 3 * (1 - trans) * Math.Pow(trans , 2) * pivot2_Y + Math.Pow(trans , 3) * ANCHOR1_XY;

            return outLinearY;*/
            return trans;
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1)
            {
                this.Opacity += 0.03;
            }
            else
            {
                timerFadeIn.Enabled = false;
            }
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            timerFadeOut.Interval = 1;

            if (this.Opacity > 0)
            {
                this.Opacity -= 0.03;
            }
            else
            {
                timerFadeOut.Enabled = false;
                this.Close();
            }
        }
    }
}

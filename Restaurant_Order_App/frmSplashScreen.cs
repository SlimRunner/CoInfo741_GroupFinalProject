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
        double fade_transition = 0;

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

        #region Extra stuff for eye candy effects

        static public double getBezier(double trans,
            double pivot1_X, double pivot1_Y,
            double pivot2_X, double pivot2_Y)
        {
            return trans;

            /*The following code contains errors testing is still going on*/
            const double INI_ANCHOR = 0;
            const double END_ANCHOR = 1;

            double xout, yout, transX;
            double bin_jump = 0.5; //binary search jump

            transX = trans;
            do
            {
                xout = (INI_ANCHOR * Math.Pow(1 - transX, 3)) +
                    (3 * pivot1_X * transX * Math.Pow(1 - transX, 2)) +
                    (3 * pivot2_X * Math.Pow(transX, 2) * (1 - transX)) +
                    (END_ANCHOR * Math.Pow(transX, 3));

                if (xout < trans)
                    transX += bin_jump;
                else
                    transX -= bin_jump;
                bin_jump /= 2;
            } while (Math.Abs(xout - trans) > 0.001);

            yout = (INI_ANCHOR * Math.Pow(1 - transX, 3)) +
                (3 * pivot1_Y * transX * Math.Pow(1 - transX, 2)) +
                (3 * pivot2_Y * Math.Pow(transX, 2) * (1 - transX)) +
                (END_ANCHOR * Math.Pow(transX, 3));

            return yout;
        }

        #endregion

        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private void timerFadeIn_Tick(object sender, EventArgs e)
        {
            if (fade_transition < 1)
            {
                fade_transition += 0.03;
                this.Opacity = getBezier(fade_transition, 0.42, 0, .58, 1); //ease-in-out
            }
            else
            {
                fade_transition = 1;
                timerFadeIn.Enabled = false;
            }
        }

        private void timerFadeOut_Tick(object sender, EventArgs e)
        {
            timerFadeOut.Interval = 1;

            if (fade_transition > 0)
            {
                fade_transition -= 0.03;
                this.Opacity = getBezier(fade_transition, 0.42, 0, .58, 1); //ease-in-out
            }
            else
            {
                fade_transition = 0;
                timerFadeOut.Enabled = false;
                this.Close();
            }
        }
    }
}

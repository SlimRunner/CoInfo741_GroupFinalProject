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
            const double TOLERANCE = 0.0001;
            double x_out, y_out;
            double newTrans;
            double leftNode, rightNode;
            double binSide;

            if (trans > 1)
                trans = 1;
            else if (trans < 0)
                trans = 0;

            leftNode = 0;
            rightNode = 1;

            x_out = 3 * pivot1_X * trans * Math.Pow(1 - trans, 2) +
                3 * pivot2_X * Math.Pow(trans, 2) * (1 - trans) +
                Math.Pow(trans, 3);

            //negative is left side, positive is right side
            //left needs addition, right needs subtraction
            binSide = x_out - trans;

            if (Math.Abs(binSide) < TOLERANCE)
                return trans;

            newTrans = trans;

            while (Math.Abs(binSide) > TOLERANCE)
            {
                if (binSide > 0)
                    rightNode = newTrans;
                else
                    leftNode = newTrans;

                //gets average
                newTrans = (leftNode + rightNode) * 0.5;

                x_out = 3 * pivot1_X * newTrans * Math.Pow(1 - newTrans, 2) +
                    3 * pivot2_X * Math.Pow(newTrans, 2) * (1 - newTrans) +
                    Math.Pow(newTrans, 3);

                binSide = x_out - trans;
            }

            y_out = 3 * pivot1_Y * newTrans * Math.Pow(1 - newTrans, 2) +
                3 * pivot2_Y * Math.Pow(newTrans, 2) * (1 - newTrans) +
                Math.Pow(newTrans, 3);

            return y_out;
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
                this.Opacity = getBezier(fade_transition, 0, 0, .58, 1); //ease-out
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
                this.Opacity = getBezier(fade_transition, 0.42, 0, 1, 1); //ease-in
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

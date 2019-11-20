using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class WaterClicker : Form
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd,
          int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);



        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        int iterate = 0;
        int offsetbegin = 0;
        int offsetend = 0;


        public WaterClicker()
        {
            InitializeComponent();
            groupBoxRand.Enabled = false;
            // Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            WaterClicker.RegisterHotKey(this.Handle, this.GetType().GetHashCode(), 2, (int)'1');
        }

        public void buttonStart_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            iterate = 0;
            offsetbegin = rnd.Next(20, 40);
            offsetend = rnd.Next(105, 140);

            if (checkBoxRand.Checked == true)
            {
                if (numericUpDownRand2.Value < numericUpDownRand1.Value)
                {
                    MessageBox.Show("The second time constraint cannot be smaller than the first.");
                    return;
                }
                int time = rnd.Next(Convert.ToInt32(numericUpDownRand1.Value), Convert.ToInt32(numericUpDownRand2.Value) + 1);
                timerClick.Interval = time;
            }
            else
            {
                timerClick.Interval = Convert.ToInt32(numericUpDownMsec.Value);
            }

            buttonStart.Enabled = false;
            buttonHelp.Enabled = false;
            numericUpDownIteration.Enabled = false;
            groupBoxTime.Enabled = false;
            groupBoxRand.Enabled = false;
            checkBoxRand.Enabled = false;
            checkBoxFast.Enabled = false;


            timerClick.Enabled = true;
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            iterate = 0;

            buttonStart.Enabled = true;
            buttonHelp.Enabled = true;
            numericUpDownIteration.Enabled = true;
            checkBoxRand.Enabled = true;
            checkBoxFast.Enabled = true;

            if (checkBoxRand.Checked == true)
            {
                groupBoxTime.Enabled = false;
                groupBoxRand.Enabled = true;
            }
            else if (checkBoxRand.Checked == false)
            {
                groupBoxTime.Enabled = true;
                groupBoxRand.Enabled = false;
            }

            timerClick.Enabled = false;
        }
   
        private void timerClick_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            if (checkBoxRand.Checked == true)
            {
                int time = rnd.Next(Convert.ToInt32(numericUpDownRand1.Value), Convert.ToInt32(numericUpDownRand2.Value) + 1);
                timerClick.Interval = time;
            }

            labelTime.Text = Convert.ToString(timerClick.Interval);
            labelClicks.Text = Convert.ToString(iterate + 1);

            //Get x/y coordinates of mouse
            int X = Cursor.Position.X;
            int Y = Cursor.Position.Y;

            //Click mouse at x/y coordinates
            //mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

            mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
            int offset = rnd.Next(offsetbegin, offsetend);
            if (checkBoxFast.Checked == false)
                System.Threading.Thread.Sleep(offset);
            mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);

            if (iterate == Convert.ToInt32(numericUpDownIteration.Value) - 1)
            {
                timerClick.Enabled = false;
                buttonStop.PerformClick();
            }
            iterate++;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                if (timerClick.Enabled == false)
                    buttonStart.PerformClick();
                else
                    buttonStop.PerformClick();
            }
            
            base.WndProc(ref m);
        }

        private void checkBoxRand_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRand.Checked == true)
            {
                groupBoxTime.Enabled = false;
                groupBoxRand.Enabled = true;
            }
            else if (checkBoxRand.Checked == false)
            {
                groupBoxTime.Enabled = true;
                groupBoxRand.Enabled = false;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string help = "Enabling fast clicks will make the time between left-down and left-up click events one millisecond. It is considerably faster, but not human-like." + Environment.NewLine + Environment.NewLine + "To view the difference, set the time to 5 milliseconds. Then, watch the difference in click speed when fast click is enabled and when it is disabled.";
            MessageBox.Show(help);
        }

        private void checkBoxFast_CheckedChanged(object sender, EventArgs e)
        {

        }

    }
}

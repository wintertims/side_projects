using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace WindowsFormsApplication1
{
    public partial class WaterMouseClickSimple : Form
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
        int cpuconst = 5000;
        int seconds = 0;
        int minutes = 0;
        int hours = 0;
        int days = 0;


        public WaterMouseClickSimple()
        {
            InitializeComponent();
            numericUpDownRand2.Enabled = false;
            labelDash.Enabled = false;
            // Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            WaterMouseClickSimple.RegisterHotKey(this.Handle, this.GetType().GetHashCode(), 2, (int)'1');

            int tempcpu = 5000;
            int expectedtime = 4;
            int time = 0;
            while ((expectedtime - time) != 0)
            {
                var sw = Stopwatch.StartNew();
                for (int j = 0; j < 3; j++)
                {
                    for (int k = 0; k < tempcpu * (expectedtime); k++)
                    {

                    }
                }
                time = Convert.ToInt32(sw.ElapsedMilliseconds / 3);
                tempcpu += 10000;
            }
            cpuconst = tempcpu;
        }

        public void buttonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Start (Ctrl + 1)")
            {
                Random rnd = new Random();

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
                    timerClick.Interval = Convert.ToInt32(numericUpDownRand1.Value);
                }
                buttonStart.Text = "Stop (Ctrl + 1)";

                iterate = 0;

                numericUpDownIteration.Enabled = false;
                groupBoxRand.Enabled = false;
                checkBoxRand.Enabled = false;
                checkBoxDelay.Enabled = false;
                labelIterations.Enabled = false;
                labelDelay.Text = "";
                labelClicks.Text = "";
                labelTime.Text = "";
                labelSeconds.Text = "";


                timerClock.Enabled = true;
                timerClick.Enabled = true;
            }
            else
            {
                buttonStart.Text = "Start (Ctrl + 1)";
                iterate = 0;

                labelIterations.Enabled = true;
                buttonStart.Enabled = true;
                numericUpDownIteration.Enabled = true;
                checkBoxRand.Enabled = true;
                checkBoxDelay.Enabled = true;
                groupBoxRand.Enabled = true;

                timerClick.Enabled = false;
                timerClock.Enabled = false;
                seconds = 0;
                minutes = 0;
                hours = 0;
                days = 0;
            }
        }

   
        private void timerClick_Tick(object sender, EventArgs e)
        {
            Random rnd = new Random();
            RNGCryptoServiceProvider rngCsp = new RNGCryptoServiceProvider();
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
            if (checkBoxDelay.Checked == false)
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN | MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            }
            else
            {
                mouse_event(MOUSEEVENTF_LEFTDOWN, X, Y, 0, 0);
                var bytes = new byte[2];
                rngCsp.GetBytes(bytes);
                int pause = (Convert.ToInt32(bytes[0]) % 112) + 47;
                rngCsp.Dispose();
                labelDelay.Text = Convert.ToString(pause);
                Debug.WriteLine(pause + " " + cpuconst);
                for (int k = 0; k < pause * cpuconst; k++)
                {
                }
                mouse_event(MOUSEEVENTF_LEFTUP, X, Y, 0, 0);
            }


            if (iterate == Convert.ToInt32(numericUpDownIteration.Value) - 1)
            {
                timerClick.Enabled = false;
                buttonStart.PerformClick();
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
                    buttonStart.PerformClick();
            }
            
            base.WndProc(ref m);
        }

        private void checkBoxRand_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRand.Checked == true)
            {
                numericUpDownRand2.Enabled = true;
                labelDash.Enabled = true;
            }
            else
            {
                numericUpDownRand2.Enabled = false;
                labelDash.Enabled = false;
            }
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            string help = "Enabling fast clicks will make the time between left-down and left-up click events one millisecond. It is considerably faster, but not human-like." + Environment.NewLine + Environment.NewLine + "To view the difference, set the time to 5 milliseconds. Then, watch the difference in click speed when fast click is enabled and when it is disabled.";
            MessageBox.Show(help);
        }

        private void timerClock_Tick(object sender, EventArgs e)
        {
            string second;
            string minute;
            string hour;
            string day;

            seconds++;
            labelSeconds.Text = Convert.ToString(seconds);

            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }

            if (minutes == 60)
            {
                hours++;
                minutes = 0;
                seconds = 0;
            }

            if (hours == 24)
            {
                days++;
                hours = 0;
                minutes = 0;
                seconds = 0;
            }

            if (seconds < 10)
                second = "0" + Convert.ToString(seconds);
            else
                second = Convert.ToString(seconds);
            if (minutes < 10)
                minute = "0" + Convert.ToString(minutes);
            else
                minute = Convert.ToString(minutes);
            if (hours < 10)
                hour = "0" + Convert.ToString(hours);
            else
                hour = Convert.ToString(hours);
            if (days < 10)
                day = "0" + Convert.ToString(days);
            else
                day = Convert.ToString(days);
                

            labelSeconds.Text = day + ":" + hour + ":" + minute +  ":" + second;
        }
    }
}

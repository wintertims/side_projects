using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorClicker
{
    public partial class ColorClicker : Form
    {
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd,
         int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);


        [StructLayout(LayoutKind.Sequential)]
        struct CURSORINFO
        {
            public Int32 cbSize;
            public Int32 flags;
            public IntPtr hCursor;
            public POINTAPI ptScreenPos;
        }

        [StructLayout(LayoutKind.Sequential)]
        struct POINTAPI
        {
            public int x;
            public int y;
        }

        [DllImport("user32.dll")]
        static extern bool GetCursorInfo(out CURSORINFO pci);

        [DllImport("user32.dll")]
        static extern bool DrawIcon(IntPtr hDC, int X, int Y, IntPtr hIcon);

        const Int32 CURSOR_SHOWING = 0x00000001;

        List<Color> setList = new List<Color>();




        #region Control Methods
        public ColorClicker()
        {
            InitializeComponent();

            //fsModifiers -  Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            //this.GetType().GetHashCode()----replace this with second param for unique random hotkey nums
            ColorClicker.RegisterHotKey(this.Handle, 1, 2, 49);
            ColorClicker.RegisterHotKey(this.Handle, 2, 2, 50);

            buttonPlay.BackColor = Color.SeaGreen;
            buttonPlay.ForeColor = Color.White;
            buttonColorize.BackColor = Color.SeaGreen;
            buttonColorize.ForeColor = Color.White;
            log("Color Clicker", Color.SteelBlue);
            log("By: Your Mom", Color.SteelBlue);
            log("November 21, 2016", Color.SteelBlue);
            log("", Color.DarkCyan);
        }

        private void buttonColorize_Click(object sender, EventArgs e)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            Bitmap myBitmap = CaptureScreen(true);
            setList.Clear();

            
            int pixelToGetX = x + (int)numericUpDownXOffset.Value;
            int pixelToGetY = y + (int)numericUpDownYOffset.Value;

            setList.Add(myBitmap.GetPixel(pixelToGetX-1, pixelToGetY-1));
            setList.Add(myBitmap.GetPixel(pixelToGetX, pixelToGetY-1));
            setList.Add(myBitmap.GetPixel(pixelToGetX+1, pixelToGetY-1));
            setList.Add(myBitmap.GetPixel(pixelToGetX-1, pixelToGetY));
            setList.Add(myBitmap.GetPixel(pixelToGetX, pixelToGetY));
            setList.Add(myBitmap.GetPixel(pixelToGetX+1, pixelToGetY));
            setList.Add(myBitmap.GetPixel(pixelToGetX-1, pixelToGetY+1));
            setList.Add(myBitmap.GetPixel(pixelToGetX, pixelToGetY+1));
            setList.Add(myBitmap.GetPixel(pixelToGetX+1, pixelToGetY+1));
            
            log("Set cursor colors:", Color.Purple);
            foreach (Color pixel in setList)
            {
                log(Convert.ToString(pixel), Color.DarkOrange);
            }

            myBitmap.Dispose();

        }
        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (buttonPlay.Text == "Play")
            {
                
                SecureRandom rnd = new SecureRandom();
                buttonPlay.Text = "Stop";
                backgroundWorkerPlay.WorkerSupportsCancellation = true;
                WinApi.TimeBeginPeriod(1);
                backgroundWorkerPlay.RunWorkerAsync();
                buttonPlay.BackColor = Color.Black;
                groupBox1.Enabled = false;
                buttonColorize.Enabled = false;
                buttonColorize.BackColor = DefaultBackColor;
                buttonClearLog.Enabled = false;
            }
            else
            {
                WinApi.TimeEndPeriod(1);
                buttonPlay.Text = "Play";
                backgroundWorkerPlay.CancelAsync();
                backgroundWorkerPlay.Dispose();
                groupBox1.Enabled = true;
                buttonPlay.BackColor = Color.SeaGreen;
                buttonColorize.Enabled = true;
                buttonColorize.BackColor = Color.SeaGreen;
                buttonClearLog.Enabled = true;
            }
            richTextBoxLog.Focus();
            
        }
        private void buttonDisplayHotkeys_Click(object sender, EventArgs e)
        {
            log("---------- Hotkeys ----------", Color.Crimson);
            log("Ctrl + 1 : Play/Stop", Color.Blue);
            log("Ctrl + 2 : Record/Stop", Color.Blue);
        }
        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
            log("Log cleared.", Color.Black);
        }

        private void numericUpDownDelayBeforeClickMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownDelayBeforeClickMax.Minimum = numericUpDownDelayBeforeClickMin.Value + 1;
        }
        private void numericUpDownBeforeOffsetMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownBeforeOffsetMax.Minimum = numericUpDownBeforeOffsetMin.Value + 1;
        }
        private void numericUpDownDelayAfterClickMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownDelayAfterClickMax.Minimum = numericUpDownDelayAfterClickMin.Value + 1;
        }

        private void richTextBoxLog_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            // scroll it automatically
            richTextBoxLog.ScrollToCaret();
        }
        #endregion
        

        #region Other Methods
        public static Bitmap CaptureScreen(bool CaptureMouse)
        {
            Bitmap result = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height, PixelFormat.Format24bppRgb);

            try
            {
                using (Graphics g = Graphics.FromImage(result))
                {
                    g.CopyFromScreen(0, 0, 0, 0, Screen.PrimaryScreen.Bounds.Size, CopyPixelOperation.SourceCopy);

                    if (CaptureMouse)
                    {
                        CURSORINFO pci;
                        pci.cbSize = System.Runtime.InteropServices.Marshal.SizeOf(typeof(CURSORINFO));

                        if (GetCursorInfo(out pci))
                        {
                            if (pci.flags == CURSOR_SHOWING)
                            {
                                DrawIcon(g.GetHdc(), pci.ptScreenPos.x, pci.ptScreenPos.y, pci.hCursor);
                                g.ReleaseHdc();


                            }
                        }

                    }
                    g.Dispose();
                }
                return result;
            }
            catch
            {
                result = null;
                return result;
            }
        }

        //Hotkey class
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0312)
            {
                int hotkeyid = m.WParam.ToInt32();
                //Hotkey to play/stop program
                if (hotkeyid == 1)
                {
                    buttonPlay.PerformClick();
                }
                //Hotkey to record
                else if (hotkeyid == 2)
                {
                    buttonColorize.PerformClick();
                }
            }
            base.WndProc(ref m);
        }

        public void intervalSleep(int timeToSleep)
        {
            int remainder = timeToSleep % 30;
            Thread.Sleep(remainder);
            for (int s = 0; s < timeToSleep / 30; s++)
            {
                if (backgroundWorkerPlay.CancellationPending == true)
                    break;
                Thread.Sleep(30);
            }
        }

        public bool checkDiscrepancy (Color current, Color set)
        {
            int discrepancy = (int)numericUpDownDiscrepancy.Value;
            if ((current.R <= set.R + discrepancy) && (current.R >= set.R - discrepancy))
            {
                if ((current.G <= set.G + discrepancy) && (current.G >= set.G - discrepancy))
                {
                    if ((current.B <= set.B + discrepancy) && (current.B >= set.B - discrepancy))
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool checkMatch()
        {
            List<Color> unsetList = new List<Color>();

            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            Bitmap myBitmap = CaptureScreen(true);
            

            int pixelToGetX = x + (int)numericUpDownXOffset.Value;
            int pixelToGetY = y + (int)numericUpDownYOffset.Value;

            try { unsetList.Add(myBitmap.GetPixel(pixelToGetX - 1, pixelToGetY - 1)); } catch { }
            try { unsetList.Add(myBitmap.GetPixel(pixelToGetX, pixelToGetY - 1)); } catch { }
            try { unsetList.Add(myBitmap.GetPixel(pixelToGetX + 1, pixelToGetY - 1)); } catch { }

            try { unsetList.Add(myBitmap.GetPixel(pixelToGetX - 1, pixelToGetY)); } catch { }
            try { unsetList.Add(myBitmap.GetPixel(pixelToGetX, pixelToGetY)); } catch { }
            try { unsetList.Add(myBitmap.GetPixel(pixelToGetX + 1, pixelToGetY)); } catch { }

            try { unsetList.Add(myBitmap.GetPixel(pixelToGetX - 1, pixelToGetY + 1)); } catch { }
            try { unsetList.Add(myBitmap.GetPixel(pixelToGetX, pixelToGetY + 1)); } catch { }
            try { unsetList.Add(myBitmap.GetPixel(pixelToGetX + 1, pixelToGetY + 1)); } catch { }
            
            
            

            int count = 0;
            if (setList.Count > 0 && unsetList.Count > 0 && unsetList.Count == setList.Count)
            {
                if (checkDiscrepancy(unsetList[0], setList[0])) count++;
                if (checkDiscrepancy(unsetList[1], setList[1])) count++;
                if (checkDiscrepancy(unsetList[2], setList[2])) count++;
                if (checkDiscrepancy(unsetList[3], setList[3])) count++;
                if (checkDiscrepancy(unsetList[4], setList[4])) count++;
                if (checkDiscrepancy(unsetList[5], setList[5])) count++;
                if (checkDiscrepancy(unsetList[6], setList[6])) count++;
                if (checkDiscrepancy(unsetList[7], setList[7])) count++;
                if (checkDiscrepancy(unsetList[8], setList[8])) count++;
            }


            myBitmap.Dispose();
            unsetList.Clear();
            if (count >= (int)numericUpDownPixels.Value)
            {
                return true;
            }
            return false;
        }
        
        private void backgroundWorkerPlay_DoWork(object sender, DoWorkEventArgs e)
        {
            SecureRandom rnd = new SecureRandom();

            int iterations = (int)numericUpDownClicksToPerform.Value;
            if (iterations == 0) iterations = 50000;
            int counter = 0;
            int searchCounter = 34;


            while (counter < iterations)
            {
                if (backgroundWorkerPlay.CancellationPending == true) break;
                Thread.Sleep(30);
                if (backgroundWorkerPlay.CancellationPending == true) break;
                if (checkMatch()==true)
                {
                    counter++;
                    if (backgroundWorkerPlay.CancellationPending == true) break;
                    this.BeginInvoke((Action)(() =>
                    {
                        log("Match! Clicking...", Color.DimGray);
                    }));
                    //wait before interval
                    if (backgroundWorkerPlay.CancellationPending == true) break;
                    intervalSleep(rnd.Next((int)numericUpDownDelayBeforeClickMin.Value, (int)numericUpDownDelayBeforeClickMax.Value));
                    if (backgroundWorkerPlay.CancellationPending == true) break;
                    //wait before offset
                    if (backgroundWorkerPlay.CancellationPending == true) break;
                    int offset = rnd.Next(0, 100);
                    if (offset == 10 || offset == 20 || offset == 30)
                    {
                        if (backgroundWorkerPlay.CancellationPending == true) break;
                        this.BeginInvoke((Action)(() =>
                        {
                            log("Waiting for offset...", Color.DimGray);
                        }));
                        if (backgroundWorkerPlay.CancellationPending == true) break;
                        intervalSleep(rnd.Next((int)numericUpDownBeforeOffsetMin.Value, (int)numericUpDownBeforeOffsetMax.Value));
                    }
                    if (backgroundWorkerPlay.CancellationPending == true) break;
                    //clickdown
                    mouse_event(MOUSEEVENTF_LEFTDOWN, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                    //click offset
                    if (backgroundWorkerPlay.CancellationPending == true) break;
                    intervalSleep(rnd.Next(45, 160));
                    if (backgroundWorkerPlay.CancellationPending == true) break;
                    //clickup
                    mouse_event(MOUSEEVENTF_LEFTUP, (uint)Cursor.Position.X, (uint)Cursor.Position.Y, 0, 0);
                    //wait for after interval
                    if (backgroundWorkerPlay.CancellationPending == true) break;
                    if (counter != iterations) intervalSleep(rnd.Next((int)numericUpDownDelayAfterClickMin.Value, (int)numericUpDownDelayAfterClickMax.Value));
                    if (backgroundWorkerPlay.CancellationPending == true) break;

                }
                else
                {
                    searchCounter++;
                    if (backgroundWorkerPlay.CancellationPending == true) break;
                    if (searchCounter == 35)
                    {
                        this.BeginInvoke((Action)(() =>
                        {
                            log("Searching...", Color.DimGray);
                        }));
                        searchCounter = 0;
                    }
                }
                if (backgroundWorkerPlay.CancellationPending == true) break;
                if (iterations == 50000) counter--;
            }

            this.BeginInvoke((Action)(() =>
            {
                WinApi.TimeEndPeriod(1);
                buttonPlay.Text = "Play";
                backgroundWorkerPlay.CancelAsync();
                backgroundWorkerPlay.Dispose();
                groupBox1.Enabled = true;
                buttonPlay.BackColor = Color.SeaGreen;
                buttonColorize.Enabled = true;
                buttonColorize.BackColor = Color.SeaGreen;
                buttonClearLog.Enabled = true;
            }));

        }

        public void log (string msg, Color color)
        {
            richTextBoxLog.AppendText(DateTime.Now.ToString(@"hh\:mm\:ss") + " # ", Color.Black);
            richTextBoxLog.AppendText(msg + Environment.NewLine, color);
        }
        #endregion
    }

    public class SecureRandom : RandomNumberGenerator
    {
        private readonly RandomNumberGenerator rng = new RNGCryptoServiceProvider();


        public int Next()
        {
            var data = new byte[sizeof(int)];
            rng.GetBytes(data);
            return BitConverter.ToInt32(data, 0) & (int.MaxValue - 1);
        }

        public int Next(int maxValue)
        {
            return Next(0, maxValue);
        }

        public int Next(int minValue, int maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException();
            }
            return (int)Math.Floor((minValue + ((double)maxValue - minValue) * NextDouble()));
        }

        public double NextDouble()
        {
            var data = new byte[sizeof(uint)];
            rng.GetBytes(data);
            var randUint = BitConverter.ToUInt32(data, 0);
            return randUint / (uint.MaxValue + 1.0);
        }

        public double NextDouble(double maxValue)
        {
            return NextDouble(0, maxValue);
        }

        public double NextDouble(double minValue, double maxValue)
        {
            if (minValue > maxValue)
            {
                throw new ArgumentOutOfRangeException();
            }
            return (double)(minValue + ((double)maxValue - minValue) * NextDouble());
        }

        public override void GetBytes(byte[] data)
        {
            rng.GetBytes(data);
        }

        public override void GetNonZeroBytes(byte[] data)
        {
            rng.GetNonZeroBytes(data);
        }
    }
    public static class WinApi
    {
        /// <summary>TimeBeginPeriod(). See the Windows API documentation for details.</summary>

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"), SuppressUnmanagedCodeSecurity]
        [DllImport("winmm.dll", EntryPoint = "timeBeginPeriod", SetLastError = true)]

        public static extern uint TimeBeginPeriod(uint uMilliseconds);

        /// <summary>TimeEndPeriod(). See the Windows API documentation for details.</summary>

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Interoperability", "CA1401:PInvokesShouldNotBeVisible"), System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2118:ReviewSuppressUnmanagedCodeSecurityUsage"), SuppressUnmanagedCodeSecurity]
        [DllImport("winmm.dll", EntryPoint = "timeEndPeriod", SetLastError = true)]

        public static extern uint TimeEndPeriod(uint uMilliseconds);
    }
    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }
    }
}

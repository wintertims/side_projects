using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecordPlayer
{
    public partial class RecordPlayer : Form
    {

        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd,
         int id, int fsModifiers, int vlc);

        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //Mouse codes to simulate mouse events
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, int cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int MOUSEEVENTF_WHEEL = 0x0800;
        private const int WHEEL_DELTA = 120;

        //Key codes to simulate key stroke events
        [DllImport("user32.dll", SetLastError = true)]
        static extern void keybd_event(byte bVk, byte bScan, int dwFlags, int dwExtraInfo);

        public const int KEYEVENTF_KEYDOWN = 0x0001; //Key down flag
        public const int KEYEVENTF_KEYUP = 0x0002; //Key up flag
        public const int VK_RCONTROL = 0xA3; //Right Control key code

       
        int RECORDINGSTATE = 0;
        int TEMP_NUMBER = 0;

        int HOTKEYTEMP_ID = 1;
        int HOTKEYTEMP_SPEC = 0;
        int HOTKEYTEMP_NORMAL = 0;


        int HOTKEY1_ID = 1;
        int HOTKEY1_SPEC = 0;
        int HOTKEY1_NORMAL = 0;

        int HOTKEY2_ID = 2;
        int HOTKEY2_SPEC = 0;
        int HOTKEY2_NORMAL = 0;

        Stopwatch sw = new Stopwatch();
        List<List<Record>> masterList = new List<List<Record>>();
        List<Record> newRecord = new List<Record>();



        #region globalMouseHook

        // Handle to the global low-level mouse hook procedure
        private IntPtr hGlobalLLMouseHook = IntPtr.Zero;
        private HookProc globalLLMouseHookCallback = null;

        private bool SetGlobalLLMouseHook()
        {
            // Create an instance of HookProc.
            globalLLMouseHookCallback = new HookProc(this.LowLevelMouseProc);

            hGlobalLLMouseHook = NativeMethods.SetWindowsHookEx(
                HookType.WH_MOUSE_LL,  // Must be LL for the global hook
                globalLLMouseHookCallback,
                // Get the handle of the current module
                IntPtr.Zero,
                // The hook procedure is associated with all existing threads running 
                // in the same desktop as the calling thread.
                0);
            return hGlobalLLMouseHook != IntPtr.Zero;
        }

        private bool RemoveGlobalLLMouseHook()
        {
            if (hGlobalLLMouseHook != IntPtr.Zero)
            {
                // Unhook the low-level mouse hook
                if (!NativeMethods.UnhookWindowsHookEx(hGlobalLLMouseHook))
                    return false;

                hGlobalLLMouseHook = IntPtr.Zero;
            }
            return true;
        }

        public int LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                // Marshal the MSLLHOOKSTRUCT data from the callback lParam
                MSLLHOOKSTRUCT mouseLLHookStruct = (MSLLHOOKSTRUCT)
                    Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));

                // Get the mouse WM from the wParam parameter
                MouseMessage wmMouse = (MouseMessage)wParam;

                // Display the current mouse coordinates and the message
                //String log = String.Format("X = {0} Y = {1}  ({2})", mouseLLHookStruct.pt.x, mouseLLHookStruct.pt.y, wmMouse);
                //logText(log);


                if (mouseLLHookStruct.mouseData != 0)
                    addEventToRecord(Cursor.Position.X, Cursor.Position.Y, mouseLLHookStruct.mouseData, Convert.ToString(wmMouse), 0, "", sw.Elapsed.ToString());
                else
                    addEventToRecord(Cursor.Position.X, Cursor.Position.Y, wParam.ToInt32(), Convert.ToString(wmMouse), 0, "", sw.Elapsed.ToString());

            }

            // Pass the hook information to the next hook procedure in chain
            return NativeMethods.CallNextHookEx(hGlobalLLMouseHook, nCode, wParam, lParam);
        }
        #endregion

        #region globalKeysHook
        // Handle to the global low-level keyboard hook procedure
        private IntPtr hGlobalLLKeyboardHook = IntPtr.Zero;
        private HookProc globalLLKeyboardHookCallback = null;
        
        private bool SetGlobalLLKeyboardHook()
        {
            // Create an instance of HookProc.
            globalLLKeyboardHookCallback = new HookProc(this.LowLevelKeyboardProc);


            hGlobalLLKeyboardHook = NativeMethods.SetWindowsHookEx(
                HookType.WH_KEYBOARD_LL,  // Must be LL for the global hook
                globalLLKeyboardHookCallback,
                // Get the handle of the current module
               IntPtr.Zero,
                // The hook procedure is associated with all existing threads running 
                // in the same desktop as the calling thread.
                0);
            return hGlobalLLKeyboardHook != IntPtr.Zero;
        }
        
        private bool RemoveGlobalLLKeyboardHook()
        {
            if (hGlobalLLKeyboardHook != IntPtr.Zero)
            {
                // Unhook the mouse hook
                if (!NativeMethods.UnhookWindowsHookEx(hGlobalLLKeyboardHook))
                    return false;

                hGlobalLLKeyboardHook = IntPtr.Zero;
            }
            return true;
        }
        
        public int LowLevelKeyboardProc(int nCode, IntPtr wParam, IntPtr lParam)
        {
            if (nCode >= 0)
            {
                // Marshal the KeyboardHookStruct data from the callback lParam
                KBDLLHOOKSTRUCT keyboardLLHookStruct = (KBDLLHOOKSTRUCT)
                    Marshal.PtrToStructure(lParam, typeof(KBDLLHOOKSTRUCT));

                // Get the virtual key code from KBDLLHOOKSTRUCT.vkCode
                // http://msdn.microsoft.com/en-us/library/dd375731.aspx
                Keys vkCode = (Keys)keyboardLLHookStruct.vkCode;

                // Get the keyboard WM from the wParam parameter
                KeyboardMessage wmKeyboard = (KeyboardMessage)wParam;


                // Display the current mouse coordinates and the message
                //String log = String.Format("Virtual-Key code: {0}  ({1})",keyboardLLHookStruct.vkCode, wmKeyboard);
                //logText(log,Color.Blue);

                if (textBoxPlayStopHotkey.Focused == true)
                {
                    string myKey = vkCode.ToString();
                    if (keyboardLLHookStruct.vkCode > 47 && keyboardLLHookStruct.vkCode < 59) myKey = myKey.Substring(1, myKey.Length - 1);

                    if (Convert.ToString(wmKeyboard) == "WM_KEYUP" && keyboardLLHookStruct.vkCode > 47 && keyboardLLHookStruct.vkCode < 91)
                    {
                        HOTKEYTEMP_ID = 1;
                        HOTKEYTEMP_NORMAL = keyboardLLHookStruct.vkCode;

                        try { UnregisterHotKey(this.Handle, 1); } catch { logText("Could not unregister hotkey.", Color.Red); }
                        if ((ModifierKeys & Keys.Control) == Keys.Control)
                        {
                            textBoxPlayStopHotkey.Text = "CTRL + " + myKey;
                            HOTKEYTEMP_SPEC = 2;
                            
                        }
                        else if ((ModifierKeys & Keys.Shift) == Keys.Shift)
                        {
                            textBoxPlayStopHotkey.Text = "SHIFT + " + myKey;
                            HOTKEYTEMP_SPEC = 4;
                        }
                        else
                        {
                            textBoxPlayStopHotkey.Text = "" + myKey;
                        }
                        textBoxPlayStopHotkey.Text.ToUpper();
                    }
                }
                else if (textBoxRecordStopHotkey.Focused == true)
                {
                    if (Convert.ToString(wmKeyboard) == "WM_KEYUP" && keyboardLLHookStruct.vkCode > 47 && keyboardLLHookStruct.vkCode < 91)
                    {
                        HOTKEYTEMP_ID = 2;
                        HOTKEYTEMP_NORMAL = keyboardLLHookStruct.vkCode;
                        string myKey = vkCode.ToString();
                        if (keyboardLLHookStruct.vkCode > 47 && keyboardLLHookStruct.vkCode < 59) myKey = myKey.Substring(1, myKey.Length - 1);

                        try { UnregisterHotKey(this.Handle, 2); } catch { logText("Could not unregister hotkey.", Color.Red); }
                        if ((ModifierKeys & Keys.Control) == Keys.Control)
                        {
                            textBoxRecordStopHotkey.Text = "CTRL + " + myKey;
                            HOTKEYTEMP_SPEC = 2;

                        }
                        else if ((ModifierKeys & Keys.Shift) == Keys.Shift)
                        {
                            textBoxRecordStopHotkey.Text = "SHIFT + " + myKey;
                            HOTKEYTEMP_SPEC = 4;
                        }
                        else
                        {
                            textBoxRecordStopHotkey.Text = "" + myKey;
                        }
                        textBoxRecordStopHotkey.Text.ToUpper();
                    }
                }
                else
                {
                    addEventToRecord(Cursor.Position.X, Cursor.Position.Y, 0, "", keyboardLLHookStruct.vkCode, Convert.ToString(wmKeyboard), sw.Elapsed.ToString());
                }
            }


            // Pass the hook information to the next hook procedure in chain
            return NativeMethods.CallNextHookEx(hGlobalLLKeyboardHook, nCode, wParam, lParam);
        }
        #endregion



        #region Form Component Methods

        public RecordPlayer()
        {
            InitializeComponent();
            logText("Low-Level Record Player", Color.SteelBlue);
            logText("By: Tim Parsons", Color.SteelBlue);
            logText("November, 15, 2016", Color.SteelBlue);
            buttonPlay.BackColor = Color.LimeGreen;
            buttonPlay.ForeColor = Color.White;
            buttonRecord.BackColor = Color.Red;
            buttonRecord.ForeColor = Color.White;

            
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            if (listViewRecords.Items.Count != 0)
            {
                logText("", Color.Black);
                logText("Playing record(s).", Color.DarkGreen);
               
                whenRecordingOrPlaying();
                backgroundWorkerPlayBack.WorkerSupportsCancellation = true;
                WinApi.TimeBeginPeriod(1);
                backgroundWorkerPlayBack.RunWorkerAsync();
            }
        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            if (buttonRecord.Text == "Record")
            {
                //Set recording state
                RECORDINGSTATE = 1;
                logText("Recording new record.", Color.Red);
                //Set sleep times to be 1000Hz or 1ms resolution
                WinApi.TimeBeginPeriod(1);
                //Disable buttons because recording
                whenRecordingOrPlaying();
                //Start Stopwatch
                sw.Start();
                //Clear List
                newRecord.Clear();
                addEventToRecord(Cursor.Position.X, Cursor.Position.Y, 0, "", 0, "", sw.Elapsed.ToString());

                SetGlobalLLMouseHook();
                SetGlobalLLKeyboardHook();
            }
            else
            {
                notRecordingOrPlaying();
                try { WinApi.TimeEndPeriod(1); } catch { }
                if (RECORDINGSTATE == 1)
                {
                    logText("Stopped recording new record.", Color.Red);
                    //Remove the last mouse down and mouse up events if playback wasn't cancelled by hotkeys.
                    if (newRecord[newRecord.Count - 1].mouseCode!=0)
                        newRecord.RemoveAt(newRecord.Count - 1);
                    if (newRecord[newRecord.Count - 1].mouseCode != 0)
                        newRecord.RemoveAt(newRecord.Count - 1);

                    addEventToRecord(Cursor.Position.X, Cursor.Position.Y, 0, "", 0, "", sw.Elapsed.ToString());
                    sw.Stop();
                    sw.Reset();

                    RemoveGlobalLLMouseHook();
                    RemoveGlobalLLKeyboardHook();


                    List<Record> oldList = new List<Record>();
                    foreach (Record record in newRecord)
                    {
                        oldList.Add(record);
                    }

                    masterList.Add(oldList);
                    listViewRecords.Items.AddWithTextAndSubItems("tempRecord_" + TEMP_NUMBER++);
                    newRecord.Clear();

                    if (listViewRecords.SelectedItems.Count>0) listViewRecords.SelectedItems[0].Selected = false;
                    if (listViewRecords.Items.Count>0)listViewRecords.Items[listViewRecords.Items.Count - 1].Selected = true;

                }
                else
                {
                    backgroundWorkerPlayBack.CancelAsync();
                    backgroundWorkerPlayBack.Dispose();
                }
                RECORDINGSTATE = 0;
            }

        }

        private void richTextBoxLog_TextChanged(object sender, EventArgs e)
        {
            // set the current caret position to the end
            richTextBoxLog.SelectionStart = richTextBoxLog.Text.Length;
            // scroll it automatically
            richTextBoxLog.ScrollToCaret();
        }

        private void buttonClearLog_Click(object sender, EventArgs e)
        {
            richTextBoxLog.Clear();
            logText("Text box cleared.", Color.Black);
            // Display the strength of them all.
            foreach (Record record in newRecord)
            {
                //logText("X: " + Convert.ToString(record.X));
                //logText("Y: " + Convert.ToString(record.Y));
                //logText("mouseCode: " + Convert.ToString(record.mouseCode));
                //logText("mouseMsg: " + record.mouseMsg);
                //logText("keyCode: " + Convert.ToString(record.keyCode));
                //logText("keyMsg: " + record.keyMsg);
                //logText("Time: " + Convert.ToString(record.eventTime));
            }
        }

        private void numericUpDownIterations_Enter(object sender, EventArgs e)
        {
            toolTip.Show("If value is zero, the playback will go on forever.", numericUpDownIterations);
        }

        private void buttonOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialogSaveFolder.ShowDialog() == DialogResult.OK)
            {
                textBoxSavePath.Text = folderBrowserDialogSaveFolder.SelectedPath;
            }
        }
        
        private void buttonAddRecord_Click(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Open Record File";
            theDialog.Filter = "Record Files (.RPRECORD) |*.RPRECORD";
            theDialog.InitialDirectory = textBoxSavePath.Text;
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = theDialog.OpenFile()) != null)
                    {
                        const Int32 BufferSize = 128;
                        List<Record> addedRecord = new List<Record>();
                        using (var fileStream = File.OpenRead(theDialog.FileName))
                        using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true, BufferSize))
                        {
                            String line;
                            while ((line = streamReader.ReadLine()) != null)
                            {
                                string[] ssize = line.Split(null);
                                this.BeginInvoke((Action)(() =>
                                {
                                    addedRecord.Add(new Record(Convert.ToInt32(ssize[0]), Convert.ToInt32(ssize[1]), Convert.ToInt32(ssize[2]), ssize[3], Convert.ToInt32(ssize[4]), ssize[5], ssize[6]));
                                }));
                            }
                            listViewRecords.Items.AddWithTextAndSubItems(Path.GetFileNameWithoutExtension(theDialog.SafeFileName));
                            masterList.Add(addedRecord);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void buttonSaveRecord_Click(object sender, EventArgs e)
        {
            if (listViewRecords.SelectedItems.Count > 0)
            {
                int index = listViewRecords.Items.IndexOf(listViewRecords.SelectedItems[0]);
                string path = textBoxSavePath.Text + @"\" + listViewRecords.SelectedItems[0].SubItems[0].Text + ".RPRECORD";
                List<Record> selectedList = masterList[index];
               
                foreach (Record record in selectedList)
                {
                    using (StreamWriter sw = File.AppendText(path))
                    {
                        sw.WriteLine(record.X + " " + record.Y + " " + record.mouseCode + " " + record.mouseMsg + " " + record.keyCode + " " + record.keyMsg + " " + record.eventTime);
                    }
                }
            }
        }

        private void buttonRemoveRecord_Click(object sender, EventArgs e)
        {
            if (listViewRecords.SelectedItems.Count > 0)
            {
                int index = listViewRecords.Items.IndexOf(listViewRecords.SelectedItems[0]);
                listViewRecords.SelectedItems[0].Remove();
                masterList.RemoveAt(index);
                if (listViewRecords.Items.Count>0) listViewRecords.Items[listViewRecords.Items.Count - 1].Selected = true;
            }
        }

        private void buttonRemoveAllRecords_Click(object sender, EventArgs e)
        {
            listViewRecords.Items.Clear(); ;
            masterList.Clear();
        }

        private void buttonMoveRecordUp_Click(object sender, EventArgs e)
        {

            if (listViewRecords.SelectedItems.Count > 0)
            {
                int tempIndex = listViewRecords.Items.IndexOf(listViewRecords.SelectedItems[0]);
                if (tempIndex > 0)
                {
                    var tempItem = masterList[tempIndex];
                    Debug.WriteLine(masterList.Count);
                    masterList.RemoveAt(tempIndex);
                    Debug.WriteLine(masterList.Count);

                    if (tempIndex > 0) masterList.Insert(tempIndex - 1, tempItem);
                }
                foreach (ListViewItem item in listViewRecords.SelectedItems)
                {
                    if (item.Index > 0)
                    {
                        int index = item.Index - 1;
                        listViewRecords.Items.RemoveAt(item.Index);
                        listViewRecords.Items.Insert(index, item);
                    }
                }
            }

        }

        private void buttonMoveRecordDown_Click(object sender, EventArgs e)
        {
            if (listViewRecords.SelectedItems.Count > 0)
            {
                int tempIndex = listViewRecords.Items.IndexOf(listViewRecords.SelectedItems[0]);
                if (tempIndex < listViewRecords.Items.Count - 1)
                {
                    Debug.WriteLine("???");
                    var tempItem = masterList[tempIndex];
                    masterList.RemoveAt(tempIndex);
                    masterList.Insert(tempIndex + 1, tempItem);
                }

                foreach (ListViewItem item in listViewRecords.SelectedItems)
                {
                    if (listViewRecords.Items.Count > 0 && item.Index < listViewRecords.Items.Count - 1)
                    {
                        int index = item.Index + 1;
                        listViewRecords.Items.RemoveAt(item.Index);
                        listViewRecords.Items.Insert(index, item);
                    }
                }
            }
        }

        private void numericUpDownAddDelayToEvents_ValueChanged(object sender, EventArgs e)
        {
            logText("Events longer than " + numericUpDownAddDelayToEvents.Value + " msec will now be delayed.", Color.DarkCyan);
        }
        private void numericUpDownDelayRecordsMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownDelayRecordsMax.Minimum = numericUpDownDelayRecordsMin.Value + 1;
        }
        private void numericUpDownDelayPlaybacksMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownDelayPlaybacksMax.Minimum = numericUpDownDelayPlaybacksMin.Value + 1;
        }
        private void numericUpDownMouseMovementSpeedMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownMouseMovementSpeedMax.Minimum = numericUpDownMouseMovementSpeedMin.Value + (decimal)0.1;
        }
        private void numericUpDownMouseClickSpeedMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownMouseClickSpeedMax.Minimum = numericUpDownMouseClickSpeedMin.Value + (decimal)0.1;
        }
        private void numericUpDownKeyClickSpeedMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownKeyClickSpeedMax.Minimum = numericUpDownKeyClickSpeedMin.Value + (decimal)0.1;
        }
        private void numericUpDownAddDelayToEventMin_ValueChanged(object sender, EventArgs e)
        {
            numericUpDownAddDelayToEventMax.Minimum = numericUpDownAddDelayToEventMin.Value + 1;
        }
        private void checkBoxDelayRecords_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDelayRecords.Checked == true)
            {
                logText("There will now be a delay between records.", Color.DarkCyan);
                numericUpDownDelayRecordsMin.Enabled = true;
                numericUpDownDelayRecordsMax.Enabled = true;
            }
            else
            {
                logText("There will NOT be a delay between records.", Color.DarkCyan);
                numericUpDownDelayRecordsMin.Enabled = false;
                numericUpDownDelayRecordsMax.Enabled = false;
            }
        }
        private void checkBoxDelayPlaybacks_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDelayPlaybacks.Checked == true)
            {
                logText("There will now be a delay between playbacks.", Color.DarkCyan);
                numericUpDownDelayPlaybacksMin.Enabled = true;
                numericUpDownDelayPlaybacksMax.Enabled = true;
            }
            else
            {
                logText("There will NOT be a delay between playbacks.", Color.DarkCyan);
                numericUpDownDelayPlaybacksMin.Enabled = false;
                numericUpDownDelayPlaybacksMax.Enabled = false;
            }
        }
        private void checkBoxChangeMouseMovementSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChangeMouseMovementSpeed.Checked == true)
            {
                logText("Mouse movement speeds will now be scaled.", Color.DarkMagenta);
                numericUpDownMouseMovementSpeedMin.Enabled = true;
                numericUpDownMouseMovementSpeedMax.Enabled = true;
            }
            else
            {
                logText("Mouse movement speeds will NOT be scaled.", Color.DarkMagenta);
                numericUpDownMouseMovementSpeedMin.Enabled = false;
                numericUpDownMouseMovementSpeedMax.Enabled = false;
            }
        }
        private void checkBoxChangeMouseClickSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChangeMouseClickSpeed.Checked == true)
            {
                logText("Mouse click speeds will now be scaled.", Color.DarkMagenta);
                numericUpDownMouseClickSpeedMin.Enabled = true;
                numericUpDownMouseClickSpeedMax.Enabled = true;
            }
            else
            {
                logText("Mouse click speeds will NOT be scaled.", Color.DarkMagenta);
                numericUpDownMouseClickSpeedMin.Enabled = false;
                numericUpDownMouseClickSpeedMax.Enabled = false;
            }
        }
        private void checkBoxChangeKeyClickSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxChangeKeyClickSpeed.Checked == true)
            {
                logText("Key click speeds will now be scaled.", Color.DarkMagenta);
                numericUpDownKeyClickSpeedMin.Enabled = true;
                numericUpDownKeyClickSpeedMax.Enabled = true;
            }
            else
            {
                logText("Key click speeds will NOT be scaled.", Color.DarkMagenta);
                numericUpDownKeyClickSpeedMin.Enabled = false;
                numericUpDownKeyClickSpeedMax.Enabled = false;
            }
        }
        private void checkBoxRandomOrder_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRandomOrder.Checked == true)
                logText("Records will now be played in a random order.", Color.DarkGoldenrod);
            else
                logText("Records will now be played in order.", Color.DarkGoldenrod);
        }
        private void checkBoxOffByOne_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxOffByOne.Checked == true)
                logText("Records will now be affected by randomness.", Color.DarkGoldenrod);
            else
                logText("Records will NOT be affected by randomness.", Color.DarkGoldenrod);
        }
        private void checkBoxAddDelayToEvents_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAddDelayToEvents.Checked == true)
            {
                logText("Events longer than " + numericUpDownAddDelayToEvents.Value + " msec will now be delayed.", Color.DarkCyan);
                numericUpDownAddDelayToEventMin.Enabled = true;
                numericUpDownAddDelayToEventMax.Enabled = true;
                numericUpDownAddDelayToEvents.Enabled = true;
                label15.Enabled = true;
                label18.Enabled = true;
                label19.Enabled = true;
            }
            else
            {
                logText("Events longer than " + numericUpDownAddDelayToEvents.Value + " msec will NOT be delayed.", Color.DarkCyan);
                numericUpDownAddDelayToEventMin.Enabled = false;
                numericUpDownAddDelayToEventMax.Enabled = false;
                numericUpDownAddDelayToEvents.Enabled = false;
                label15.Enabled = false;
                label18.Enabled = false;
                label19.Enabled = false;
            }
        }
        private void RecordPlayer_SizeChanged(object sender, EventArgs e)
        {
            richTextBoxLog.Width = ClientRectangle.Width - 168;
            richTextBoxLog.Height = ClientRectangle.Height - 158;
            listViewRecords.Location = new Point(ClientRectangle.Width - 157, listViewRecords.Location.Y);
            listViewRecords.Height = ClientRectangle.Height - 238;
            buttonMoveRecordUp.Location = new Point(ClientRectangle.Width - 157, ClientRectangle.Height - 88);
            buttonMoveRecordDown.Location = new Point(ClientRectangle.Width - 157, ClientRectangle.Height - 59);
            buttonRemoveAllRecords.Location = new Point(ClientRectangle.Width - 157, ClientRectangle.Height - 30);
            buttonAddRecord.Location = new Point(ClientRectangle.Width - 78, ClientRectangle.Height - 88);
            buttonSaveRecord.Location = new Point(ClientRectangle.Width - 78, ClientRectangle.Height - 59);
            buttonRemoveRecord.Location = new Point(ClientRectangle.Width - 78, ClientRectangle.Height - 30);
            tabControlSettings.Location = new Point(ClientRectangle.Width - 353, tabControlSettings.Location.Y);

        }





        #endregion

        #region Functionality Methods
        public void whenRecordingOrPlaying()
        {
            buttonPlay.ForeColor = default(Color);
            buttonPlay.BackColor = default(Color);
            buttonRecord.BackColor = Color.Black;
            buttonRecord.Text = "Stop";
            buttonPlay.Enabled = false;
            buttonClearLog.Enabled = false;
            buttonAddRecord.Enabled = false;
            buttonSaveRecord.Enabled = false;
            buttonMoveRecordUp.Enabled = false;
            buttonMoveRecordDown.Enabled = false;
            buttonRemoveRecord.Enabled = false;
            buttonRemoveAllRecords.Enabled = false;
            listViewRecords.Enabled = false;
            tabControlSettings.Enabled = false;

            buttonRecord.Refresh();
            buttonPlay.Refresh();
            buttonClearLog.Refresh();
            listViewRecords.Refresh();
            tabControlSettings.Refresh();
            buttonAddRecord.Refresh();
            buttonSaveRecord.Refresh();
            buttonMoveRecordUp.Refresh();
            buttonMoveRecordDown.Refresh();
            buttonRemoveRecord.Refresh();
            buttonRemoveAllRecords.Refresh();
        }

        public void notRecordingOrPlaying()
        {
            try { WinApi.TimeEndPeriod(1); } catch { }
            buttonPlay.BackColor = Color.LimeGreen;
            buttonPlay.ForeColor = Color.White;
            buttonRecord.BackColor = Color.Red;
            buttonPlay.ForeColor = Color.White;
            buttonRecord.Text = "Record";
            buttonPlay.Enabled = true;
            buttonClearLog.Enabled = true;
            listViewRecords.Enabled = true;
            tabControlSettings.Enabled = true;
            buttonAddRecord.Enabled = true;
            buttonSaveRecord.Enabled = true;
            buttonMoveRecordUp.Enabled = true;
            buttonMoveRecordDown.Enabled = true;
            buttonRemoveRecord.Enabled = true;
            buttonRemoveAllRecords.Enabled = true;
        }

        public void logText(string text, Color color)
        {
            richTextBoxLog.AppendText(DateTime.Now.ToString(@"hh\:mm\:ss") + " # ", Color.Black);
            richTextBoxLog.AppendText(text + Environment.NewLine, color);
        }
        
        public void addEventToRecord(int X, int Y, int mouseCodeVal, string mouseMsg, int keyCodeVal, string keyMsg, string time)
        {
            this.BeginInvoke((Action)(() =>
            {
                newRecord.Add(new Record(X, Y, mouseCodeVal, mouseMsg, keyCodeVal, keyMsg, time));
            }));
        }

        public void playBackEvent(Record record, int sleep)
        {
            //if keyboard input
            if (record.mouseCode == 0 && record.mouseMsg == "" && checkBoxTrackKeyboard.Checked==true)
            {
                switch (record.keyMsg)
                {
                    case "WM_KEYDOWN":
                        if (record.keyCode < 165 && record.keyCode > 159)
                            keybd_event((byte)record.keyCode, 0x9d, 0, 0);
                        else if (record.keyCode < 160)
                            keybd_event((byte)record.keyCode, 0, KEYEVENTF_KEYDOWN, 0);
                        break;
                    case "WM_KEYUP":
                        if (record.keyCode < 165 && record.keyCode > 159)
                            keybd_event((byte)record.keyCode, 0x9d, KEYEVENTF_KEYUP, 0);
                        else if (record.keyCode < 160)
                            keybd_event((byte)record.keyCode, 0, KEYEVENTF_KEYUP, 0);
                        break;
                }
                
            }
            if (record.keyCode == 0 && record.keyMsg == "" && checkBoxTrackMouse.Checked == true)
            {
                uint x = (uint)record.X;
                uint y = (uint)record.Y;
                
                if (checkBoxOffByOne.Checked==true && sleep < 9)
                {
                    SecureRandom coordinateAddition = new SecureRandom();
                    int rand = coordinateAddition.Next(150);

                    if (rand == 10) { x=x+1; }
                    if (rand == 20) { x=x-1; }
                    if (rand == 30) { y=y+1; }
                    if (rand == 40) { y=y-1; }
                }


                switch (record.mouseCode)
                {
                    case 512:
                        System.Windows.Forms.Cursor.Position = new System.Drawing.Point((int)x, (int)y);
                        break;
                    case 513:
                        mouse_event(MOUSEEVENTF_LEFTDOWN, x, y, 0, 0);
                        break;
                    case 514:
                        mouse_event(MOUSEEVENTF_LEFTUP, x, y, 0, 0);
                        break;
                    case 516:
                        mouse_event(MOUSEEVENTF_RIGHTDOWN, x, y, 0, 0);
                        break;
                    case 517:
                        mouse_event(MOUSEEVENTF_RIGHTUP, x, y, 0, 0);
                        break;
                    case 7864320:
                        mouse_event(MOUSEEVENTF_WHEEL, x, y, WHEEL_DELTA, 0);
                        break;
                    case -7864320:
                        mouse_event(MOUSEEVENTF_WHEEL, x, y, -WHEEL_DELTA, 0);
                        break;
                }

            }
        }
        
        public void intervalSleep(int timeToSleep)
        {
            int remainder = timeToSleep % 30;
            for (int s = 0; s < timeToSleep / 30; s++)
            {
                if (backgroundWorkerPlayBack.CancellationPending == true)
                    break;
                Thread.Sleep(30);
            }
            Thread.Sleep(remainder);
        }

        public int sleepRateChanger(Record currentRecord, int sleep)
        {
            SecureRandom rnd = new SecureRandom();
            if (checkBoxChangeMouseMovementSpeed.Checked == true && currentRecord.mouseCode == 512)
            {
                double rate = rnd.NextDouble((double)numericUpDownMouseMovementSpeedMin.Value, (double)numericUpDownMouseMovementSpeedMax.Value);
                return sleep = (int)(((double)sleep) / rate) + 1;
            }
            else if (checkBoxChangeMouseClickSpeed.Checked == true && currentRecord.mouseCode > 0 && currentRecord.mouseCode != 512)
            {
                double rate = rnd.NextDouble((double)numericUpDownMouseClickSpeedMin.Value, (double)numericUpDownMouseClickSpeedMax.Value);
                return sleep = (int)(((double)sleep) / rate) + 1;
            }
            else if (checkBoxChangeKeyClickSpeed.Checked == true && currentRecord.mouseCode == 0)
            {
                double rate = rnd.NextDouble((double)numericUpDownKeyClickSpeedMin.Value, (double)numericUpDownKeyClickSpeedMax.Value);
                return sleep = (int)(((double)sleep) / rate) + 1;
            }
            return sleep;
        }

    

        private void backgroundWorkerPlayBack_DoWork(object sender, DoWorkEventArgs e)
        {

            SecureRandom rnd = new SecureRandom();
            int iterations = Convert.ToInt32(numericUpDownIterations.Value);
            
            //if infinite loop 
            if (iterations <= 0) iterations = 100000000;


            //initialize timer to end...
            Stopwatch stopwatch = new Stopwatch();
            if (radioButtonTime.Checked == true)
            {
                iterations = Int32.MaxValue;
                stopwatch.Start();
            }
            


            for (int j = 0; j < iterations; j++)
            {
                int counter = 0;
                for (int k = 0; k < masterList.Count; k++)
                {
                    if (radioButtonTime.Checked == true && stopwatch.ElapsedMilliseconds >= Convert.ToDouble(numericUpDownTime.Value)*60000)
                    {
                        if (buttonPlay.Enabled == true)
                        {
                            Invoke(new Action(() =>
                            {
                                buttonPlay.PerformClick();
                            }));
                        }
                        else
                        {
                            Invoke(new Action(() =>
                            {
                                buttonRecord.PerformClick();
                            }));
                        }
                    }

                    //random record order 
                    if (counter == masterList.Count)
                        break;
                    counter++;

                    if (checkBoxRandomOrder.Checked == true)
                        k = rnd.Next(masterList.Count);

               
                    for (int i = 1; i < masterList[k].Count - 1; i++)
                    {
                        Record currentRecord = masterList[k][i - 1];
                        int sleep = Convert.ToInt32(TimeSpan.Parse(masterList[k][i].eventTime).TotalMilliseconds) - Convert.ToInt32(TimeSpan.Parse(masterList[k][i - 1].eventTime).TotalMilliseconds);
                        playBackEvent(currentRecord, sleep);
                        sleep = sleepRateChanger(currentRecord, sleep);

                        if (checkBoxAddDelayToEvents.Checked==true)
                        {
                            if (sleep>(int)numericUpDownAddDelayToEvents.Value)
                            {
                                int eventDelay = rnd.Next((int)numericUpDownAddDelayToEventMin.Value, (int)numericUpDownAddDelayToEventMax.Value);
                                Debug.WriteLine("Sleeping for: " + eventDelay + " msec.");
                                intervalSleep(eventDelay);
                            }
                        }



                        if (sleep > 30)
                            intervalSleep(sleep);
                        else 
                            Thread.Sleep(sleep);

                        if (backgroundWorkerPlayBack.CancellationPending == true)
                            break;
                    }
                    //Delay records
                    if (checkBoxDelayRecords.Checked == true)
                    {
                        intervalSleep(rnd.Next((int)numericUpDownDelayRecordsMin.Value, (int)numericUpDownDelayRecordsMax.Value));
                    }
                    if (backgroundWorkerPlayBack.CancellationPending == true)
                        break;

                }
                //Delay playbacks
                if (checkBoxDelayPlaybacks.Checked == true)
                {
                    intervalSleep(rnd.Next((int)numericUpDownDelayPlaybacksMin.Value, (int)numericUpDownDelayPlaybacksMax.Value));
                }
                if (backgroundWorkerPlayBack.CancellationPending == true)
                    break;

                this.BeginInvoke((Action)(() =>
                {
                    logText("Record #" + j + " finished.", Color.DimGray);
                }));
            }
            this.BeginInvoke((Action)(() =>
            {
                logText("Playback finished.", Color.DarkGreen);
                logText("", Color.Black);
                notRecordingOrPlaying();
            }));
            
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
                    if (buttonPlay.Enabled == true)
                    {
                        buttonPlay.PerformClick();
                    }
                    else
                    {
                        buttonRecord.PerformClick();
                    }
                }
                //Hotkey to record
                else if (hotkeyid == 2)
                {
                    buttonRecord.PerformClick();
                }
            }
            base.WndProc(ref m);
        }



        #endregion
        

        private void textBoxPlayStopHotkey_Enter(object sender, EventArgs e)
        {
            SetGlobalLLKeyboardHook();
        }

        private void textBoxPlayStopHotkey_Leave(object sender, EventArgs e)
        {
            RemoveGlobalLLKeyboardHook();
            //fsModifiers -  Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            //this.GetType().GetHashCode()----replace this with second param for unique random hotkey nums
            if (textBoxPlayStopHotkey.Text != textBoxRecordStopHotkey.Text)
            {
                if ((HOTKEYTEMP_NORMAL == HOTKEY2_NORMAL) && (HOTKEYTEMP_SPEC == HOTKEY2_SPEC))
                {
                    logText("Sorry, but two hotkeys may not be the same value.", Color.Purple);
                }
                else
                {
                    try
                    {
                        RecordPlayer.RegisterHotKey(this.Handle, HOTKEYTEMP_ID, HOTKEYTEMP_SPEC, HOTKEYTEMP_NORMAL);
                        logText("Global hotkey \"" + textBoxPlayStopHotkey.Text + "\" set for Playing/Stopping records.", Color.DarkOrchid);
                        HOTKEY1_NORMAL = HOTKEYTEMP_NORMAL;
                        HOTKEY1_SPEC = HOTKEYTEMP_SPEC;
                    }
                    catch (Exception f)
                    {
                        logText("Could not set global hotkey for Playing/Stopping Records.", Color.Red);
                        logText("Reason: " + f, Color.Red);
                    }
                }
            }
        }

      

        private void textBoxRecordStopHotkey_Enter(object sender, EventArgs e)
        {
            SetGlobalLLKeyboardHook();
        }

        private void textBoxRecordStopHotkey_Leave(object sender, EventArgs e)
        {
            RemoveGlobalLLKeyboardHook();
            //fsModifiers -  Alt = 1, Ctrl = 2, Shift = 4, Win = 8
            //this.GetType().GetHashCode()----replace this with second param for unique random hotkey nums
            if (textBoxPlayStopHotkey.Text != textBoxRecordStopHotkey.Text)
            {
                if ((HOTKEY1_NORMAL == HOTKEYTEMP_NORMAL) && (HOTKEY1_SPEC == HOTKEYTEMP_SPEC))
                {
                    logText("Sorry, but two hotkeys may not be the same value.", Color.Purple);
                }
                else
                {
                    try
                    {
                        RecordPlayer.RegisterHotKey(this.Handle, HOTKEYTEMP_ID, HOTKEYTEMP_SPEC, HOTKEYTEMP_NORMAL);
                        logText(
                            "Global hotkey \"" + textBoxRecordStopHotkey.Text +
                            "\" set for Recording/Stopping records.", Color.DarkOrchid);
                        HOTKEY2_NORMAL = HOTKEYTEMP_NORMAL;
                        HOTKEY2_SPEC = HOTKEYTEMP_SPEC;
                    }
                    catch (Exception f)
                    {
                        logText("Could not set global hotkey for Recording/Stopping Records.", Color.Red);
                        logText("Reason: " + f, Color.Red);
                    }
                }
            }
        }

       
    }




    #region Other Stuff
    public class Record
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int mouseCode { get; set; }
        public string mouseMsg { get; set; }
        public int keyCode { get; set; }
        public string keyMsg { get; set; }
        public string eventTime { get; set; }


        public Record(int Xcoord, int Ycoord, int mouseCodeVal, string mouseMsgNow, int keyCodeVal, string keyMsgNow, string now)
        {
            X = Xcoord;
            Y = Ycoord;
            mouseCode = mouseCodeVal;
            mouseMsg = mouseMsgNow;
            keyCode = keyCodeVal;
            keyMsg = keyMsgNow;
            eventTime = now;
        }
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

    internal delegate int HookProc(int nCode, IntPtr wParam, IntPtr lParam);

    internal class NativeMethod
    {
        [DllImport("kernel32.dll")]
        internal static extern uint GetCurrentThreadId();
        
        [DllImport("kernel32.dll")]
        internal static extern uint GetCurrentProcessId();
    }

    internal class NativeMethods
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SetWindowsHookEx(HookType hookType,
            HookProc callback, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int CallNextHookEx(IntPtr hhk, int nCode,
            IntPtr wParam, IntPtr lParam);
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

    public class Win32
    {
        [DllImport("User32.Dll")]
        public static extern long SetCursorPos(int x, int y);

        [DllImport("User32.Dll")]
        public static extern bool ClientToScreen(IntPtr hWnd, ref POINT point);

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT
        {
            public int x;
            public int y;
        }
    }

    internal static class HookCodes
    {
        public const int HC_ACTION = 0;
        public const int HC_GETNEXT = 1;
        public const int HC_SKIP = 2;
        public const int HC_NOREMOVE = 3;
        public const int HC_NOREM = HC_NOREMOVE;
        public const int HC_SYSMODALON = 4;
        public const int HC_SYSMODALOFF = 5;
    }

    internal enum HookType
    {
        WH_KEYBOARD = 2,
        WH_MOUSE = 7,
        WH_KEYBOARD_LL = 13,
        WH_MOUSE_LL = 14
    }

    [StructLayout(LayoutKind.Sequential)]
    internal class POINT
    {
        public int x;
        public int y;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    internal struct MOUSEHOOKSTRUCT
    {
        public POINT pt;        // The x and y coordinates in screen coordinates
        public int hwnd;        // Handle to the window that'll receive the mouse message
        public int wHitTestCode;
        public int dwExtraInfo;
    }
    
    [StructLayout(LayoutKind.Sequential)]
    internal struct MSLLHOOKSTRUCT
    {
        public POINT pt;        // The x and y coordinates in screen coordinates. 
        public int mouseData;   // The mouse wheel and button info.
        public int flags;
        public int time;        // Specifies the time stamp for this message. 
        public IntPtr dwExtraInfo;
    }

    internal enum MouseMessage
    {
        WM_MOUSEMOVE = 0x0200,
        WM_LBUTTONDOWN = 0x0201,
        WM_LBUTTONUP = 0x0202,
        WM_LBUTTONDBLCLK = 0x0203,
        WM_RBUTTONDOWN = 0x0204,
        WM_RBUTTONUP = 0x0205,
        WM_RBUTTONDBLCLK = 0x0206,
        WM_MBUTTONDOWN = 0x0207,
        WM_MBUTTONUP = 0x0208,
        WM_MBUTTONDBLCLK = 0x0209,

        WM_MOUSEWHEEL = 0x020A,
        WM_MOUSEHWHEEL = 0x020E,

        WM_NCMOUSEMOVE = 0x00A0,
        WM_NCLBUTTONDOWN = 0x00A1,
        WM_NCLBUTTONUP = 0x00A2,
        WM_NCLBUTTONDBLCLK = 0x00A3,
        WM_NCRBUTTONDOWN = 0x00A4,
        WM_NCRBUTTONUP = 0x00A5,
        WM_NCRBUTTONDBLCLK = 0x00A6,
        WM_NCMBUTTONDOWN = 0x00A7,
        WM_NCMBUTTONUP = 0x00A8,
        WM_NCMBUTTONDBLCLK = 0x00A9
    }
    
    [StructLayout(LayoutKind.Sequential)]
    internal struct KBDLLHOOKSTRUCT
    {
        public int vkCode;      // Specifies a virtual-key code
        public int scanCode;    // Specifies a hardware scan code for the key
        public int flags;
        public int time;        // Specifies the time stamp for this message
        public int dwExtraInfo;
    }

    internal enum KeyboardMessage
    {
        WM_KEYDOWN = 0x0100,
        WM_KEYUP = 0x0101,
        WM_SYSKEYDOWN = 0x0104,
        WM_SYSKEYUP = 0x0105
    }

   

    internal static class ListViewItemCollectionExtender
    {
        internal static void AddWithTextAndSubItems(
                                       this ListView.ListViewItemCollection col,
                                       string text, params string[] subItems)
        {
            var item = new ListViewItem(text);
            foreach (var subItem in subItems)
            {
                item.SubItems.Add(subItem);
            }
            col.Add(item);
        }
    }

    //static class Extensions
    //{
    //    public static IList<T> Clone<T>(this IList<T> listToClone) where T : ICloneable
    //    {
    //        return listToClone.Select(item => (T)item.Clone()).ToList();
    //    }
    //}

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
    #endregion
}

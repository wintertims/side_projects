namespace RecordPlayer
{
    partial class RecordPlayer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.listViewRecords = new System.Windows.Forms.ListView();
            this.columnHeaderRecordName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numericUpDownIterations = new System.Windows.Forms.NumericUpDown();
            this.backgroundWorkerPlayBack = new System.ComponentModel.BackgroundWorker();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.buttonRemoveRecord = new System.Windows.Forms.Button();
            this.buttonAddRecord = new System.Windows.Forms.Button();
            this.buttonMoveRecordUp = new System.Windows.Forms.Button();
            this.buttonMoveRecordDown = new System.Windows.Forms.Button();
            this.buttonOpenFolder = new System.Windows.Forms.Button();
            this.textBoxSavePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.folderBrowserDialogSaveFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.buttonSaveRecord = new System.Windows.Forms.Button();
            this.tabControlSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.radioButtonTime = new System.Windows.Forms.RadioButton();
            this.radioButtonPlaybacks = new System.Windows.Forms.RadioButton();
            this.numericUpDownTime = new System.Windows.Forms.NumericUpDown();
            this.checkBoxTrackMouse = new System.Windows.Forms.CheckBox();
            this.checkBoxTrackKeyboard = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPlayStopHotkey = new System.Windows.Forms.TextBox();
            this.textBoxRecordStopHotkey = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownKeyClickSpeedMax = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numericUpDownMouseClickSpeedMax = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownKeyClickSpeedMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMouseClickSpeedMin = new System.Windows.Forms.NumericUpDown();
            this.checkBoxChangeKeyClickSpeed = new System.Windows.Forms.CheckBox();
            this.checkBoxChangeMouseClickSpeed = new System.Windows.Forms.CheckBox();
            this.checkBoxChangeMouseMovementSpeed = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownMouseMovementSpeedMin = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownMouseMovementSpeedMax = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDownAddDelayToEventMax = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownAddDelayToEventMin = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownAddDelayToEvents = new System.Windows.Forms.NumericUpDown();
            this.checkBoxAddDelayToEvents = new System.Windows.Forms.CheckBox();
            this.numericUpDownDelayPlaybacksMax = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownDelayPlaybacksMin = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownDelayRecordsMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDelayRecordsMin = new System.Windows.Forms.NumericUpDown();
            this.checkBoxDelayPlaybacks = new System.Windows.Forms.CheckBox();
            this.checkBoxDelayRecords = new System.Windows.Forms.CheckBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.checkBoxOffByOne = new System.Windows.Forms.CheckBox();
            this.checkBoxRandomOrder = new System.Windows.Forms.CheckBox();
            this.buttonRemoveAllRecords = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).BeginInit();
            this.tabControlSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyClickSpeedMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMouseClickSpeedMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyClickSpeedMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMouseClickSpeedMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMouseMovementSpeedMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMouseMovementSpeedMax)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddDelayToEventMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddDelayToEventMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddDelayToEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayPlaybacksMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayPlaybacksMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayRecordsMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayRecordsMin)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(12, 64);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(104, 47);
            this.buttonRecord.TabIndex = 0;
            this.buttonRecord.Text = "Record";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(12, 12);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(104, 47);
            this.buttonPlay.TabIndex = 1;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(12, 171);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(378, 266);
            this.richTextBoxLog.TabIndex = 2;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(12, 138);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(104, 23);
            this.buttonClearLog.TabIndex = 4;
            this.buttonClearLog.Text = "Clear Log";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // listViewRecords
            // 
            this.listViewRecords.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderRecordName});
            this.listViewRecords.FullRowSelect = true;
            this.listViewRecords.HideSelection = false;
            this.listViewRecords.Location = new System.Drawing.Point(396, 171);
            this.listViewRecords.Name = "listViewRecords";
            this.listViewRecords.Size = new System.Drawing.Size(152, 181);
            this.listViewRecords.TabIndex = 5;
            this.listViewRecords.UseCompatibleStateImageBehavior = false;
            this.listViewRecords.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderRecordName
            // 
            this.columnHeaderRecordName.Text = "Record";
            this.columnHeaderRecordName.Width = 115;
            // 
            // numericUpDownIterations
            // 
            this.numericUpDownIterations.Location = new System.Drawing.Point(355, 74);
            this.numericUpDownIterations.Maximum = new decimal(new int[] {
            500000,
            0,
            0,
            0});
            this.numericUpDownIterations.Name = "numericUpDownIterations";
            this.numericUpDownIterations.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownIterations.TabIndex = 6;
            this.numericUpDownIterations.Enter += new System.EventHandler(this.numericUpDownIterations_Enter);
            // 
            // backgroundWorkerPlayBack
            // 
            this.backgroundWorkerPlayBack.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPlayBack_DoWork);
            // 
            // buttonRemoveRecord
            // 
            this.buttonRemoveRecord.Location = new System.Drawing.Point(475, 414);
            this.buttonRemoveRecord.Name = "buttonRemoveRecord";
            this.buttonRemoveRecord.Size = new System.Drawing.Size(73, 23);
            this.buttonRemoveRecord.TabIndex = 8;
            this.buttonRemoveRecord.Text = "Remove";
            this.buttonRemoveRecord.UseVisualStyleBackColor = true;
            this.buttonRemoveRecord.Click += new System.EventHandler(this.buttonRemoveRecord_Click);
            // 
            // buttonAddRecord
            // 
            this.buttonAddRecord.Location = new System.Drawing.Point(475, 356);
            this.buttonAddRecord.Name = "buttonAddRecord";
            this.buttonAddRecord.Size = new System.Drawing.Size(73, 23);
            this.buttonAddRecord.TabIndex = 9;
            this.buttonAddRecord.Text = "Add";
            this.buttonAddRecord.UseVisualStyleBackColor = true;
            this.buttonAddRecord.Click += new System.EventHandler(this.buttonAddRecord_Click);
            // 
            // buttonMoveRecordUp
            // 
            this.buttonMoveRecordUp.Location = new System.Drawing.Point(396, 356);
            this.buttonMoveRecordUp.Name = "buttonMoveRecordUp";
            this.buttonMoveRecordUp.Size = new System.Drawing.Size(73, 23);
            this.buttonMoveRecordUp.TabIndex = 10;
            this.buttonMoveRecordUp.Text = "↑ Up";
            this.buttonMoveRecordUp.UseVisualStyleBackColor = true;
            this.buttonMoveRecordUp.Click += new System.EventHandler(this.buttonMoveRecordUp_Click);
            // 
            // buttonMoveRecordDown
            // 
            this.buttonMoveRecordDown.Location = new System.Drawing.Point(396, 385);
            this.buttonMoveRecordDown.Name = "buttonMoveRecordDown";
            this.buttonMoveRecordDown.Size = new System.Drawing.Size(73, 23);
            this.buttonMoveRecordDown.TabIndex = 11;
            this.buttonMoveRecordDown.Text = "↓ Down";
            this.buttonMoveRecordDown.UseVisualStyleBackColor = true;
            this.buttonMoveRecordDown.Click += new System.EventHandler(this.buttonMoveRecordDown_Click);
            // 
            // buttonOpenFolder
            // 
            this.buttonOpenFolder.Location = new System.Drawing.Point(379, 4);
            this.buttonOpenFolder.Name = "buttonOpenFolder";
            this.buttonOpenFolder.Size = new System.Drawing.Size(25, 23);
            this.buttonOpenFolder.TabIndex = 10;
            this.buttonOpenFolder.Text = "...";
            this.buttonOpenFolder.UseVisualStyleBackColor = true;
            this.buttonOpenFolder.Click += new System.EventHandler(this.buttonOpenFolder_Click);
            // 
            // textBoxSavePath
            // 
            this.textBoxSavePath.Location = new System.Drawing.Point(141, 6);
            this.textBoxSavePath.Name = "textBoxSavePath";
            this.textBoxSavePath.ReadOnly = true;
            this.textBoxSavePath.Size = new System.Drawing.Size(228, 20);
            this.textBoxSavePath.TabIndex = 9;
            this.textBoxSavePath.Text = "C:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Directory to Save Records: ";
            // 
            // folderBrowserDialogSaveFolder
            // 
            this.folderBrowserDialogSaveFolder.Description = "Select a folder to save your records in.";
            this.folderBrowserDialogSaveFolder.SelectedPath = "C:\\";
            // 
            // buttonSaveRecord
            // 
            this.buttonSaveRecord.Location = new System.Drawing.Point(475, 385);
            this.buttonSaveRecord.Name = "buttonSaveRecord";
            this.buttonSaveRecord.Size = new System.Drawing.Size(73, 23);
            this.buttonSaveRecord.TabIndex = 13;
            this.buttonSaveRecord.Text = "Save";
            this.buttonSaveRecord.UseVisualStyleBackColor = true;
            this.buttonSaveRecord.Click += new System.EventHandler(this.buttonSaveRecord_Click);
            // 
            // tabControlSettings
            // 
            this.tabControlSettings.Controls.Add(this.tabPage1);
            this.tabControlSettings.Controls.Add(this.tabPage3);
            this.tabControlSettings.Controls.Add(this.tabPage2);
            this.tabControlSettings.Controls.Add(this.tabPage4);
            this.tabControlSettings.Location = new System.Drawing.Point(122, 12);
            this.tabControlSettings.Name = "tabControlSettings";
            this.tabControlSettings.SelectedIndex = 0;
            this.tabControlSettings.Size = new System.Drawing.Size(426, 153);
            this.tabControlSettings.TabIndex = 14;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.radioButtonTime);
            this.tabPage1.Controls.Add(this.radioButtonPlaybacks);
            this.tabPage1.Controls.Add(this.numericUpDownTime);
            this.tabPage1.Controls.Add(this.checkBoxTrackMouse);
            this.tabPage1.Controls.Add(this.checkBoxTrackKeyboard);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.textBoxSavePath);
            this.tabPage1.Controls.Add(this.numericUpDownIterations);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.buttonOpenFolder);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 127);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main Settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // radioButtonTime
            // 
            this.radioButtonTime.AutoSize = true;
            this.radioButtonTime.Location = new System.Drawing.Point(262, 102);
            this.radioButtonTime.Name = "radioButtonTime";
            this.radioButtonTime.Size = new System.Drawing.Size(81, 17);
            this.radioButtonTime.TabIndex = 17;
            this.radioButtonTime.Text = "Time (mins):";
            this.radioButtonTime.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlaybacks
            // 
            this.radioButtonPlaybacks.AutoSize = true;
            this.radioButtonPlaybacks.Checked = true;
            this.radioButtonPlaybacks.Location = new System.Drawing.Point(262, 74);
            this.radioButtonPlaybacks.Name = "radioButtonPlaybacks";
            this.radioButtonPlaybacks.Size = new System.Drawing.Size(77, 17);
            this.radioButtonPlaybacks.TabIndex = 16;
            this.radioButtonPlaybacks.TabStop = true;
            this.radioButtonPlaybacks.Text = "Playbacks:";
            this.radioButtonPlaybacks.UseVisualStyleBackColor = true;
            // 
            // numericUpDownTime
            // 
            this.numericUpDownTime.DecimalPlaces = 1;
            this.numericUpDownTime.Location = new System.Drawing.Point(355, 102);
            this.numericUpDownTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownTime.Name = "numericUpDownTime";
            this.numericUpDownTime.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownTime.TabIndex = 15;
            // 
            // checkBoxTrackMouse
            // 
            this.checkBoxTrackMouse.AutoSize = true;
            this.checkBoxTrackMouse.Checked = true;
            this.checkBoxTrackMouse.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTrackMouse.Location = new System.Drawing.Point(262, 51);
            this.checkBoxTrackMouse.Name = "checkBoxTrackMouse";
            this.checkBoxTrackMouse.Size = new System.Drawing.Size(96, 17);
            this.checkBoxTrackMouse.TabIndex = 13;
            this.checkBoxTrackMouse.Text = "Record Mouse";
            this.checkBoxTrackMouse.UseVisualStyleBackColor = true;
            // 
            // checkBoxTrackKeyboard
            // 
            this.checkBoxTrackKeyboard.AutoSize = true;
            this.checkBoxTrackKeyboard.Checked = true;
            this.checkBoxTrackKeyboard.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTrackKeyboard.Location = new System.Drawing.Point(262, 32);
            this.checkBoxTrackKeyboard.Name = "checkBoxTrackKeyboard";
            this.checkBoxTrackKeyboard.Size = new System.Drawing.Size(109, 17);
            this.checkBoxTrackKeyboard.TabIndex = 12;
            this.checkBoxTrackKeyboard.Text = "Record Keyboard";
            this.checkBoxTrackKeyboard.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPlayStopHotkey);
            this.groupBox1.Controls.Add(this.textBoxRecordStopHotkey);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Location = new System.Drawing.Point(3, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(209, 69);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Hotkeys";
            // 
            // textBoxPlayStopHotkey
            // 
            this.textBoxPlayStopHotkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxPlayStopHotkey.Location = new System.Drawing.Point(81, 18);
            this.textBoxPlayStopHotkey.MaxLength = 1;
            this.textBoxPlayStopHotkey.Name = "textBoxPlayStopHotkey";
            this.textBoxPlayStopHotkey.Size = new System.Drawing.Size(111, 20);
            this.textBoxPlayStopHotkey.TabIndex = 3;
            this.textBoxPlayStopHotkey.Enter += new System.EventHandler(this.textBoxPlayStopHotkey_Enter);
            this.textBoxPlayStopHotkey.Leave += new System.EventHandler(this.textBoxPlayStopHotkey_Leave);
            // 
            // textBoxRecordStopHotkey
            // 
            this.textBoxRecordStopHotkey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxRecordStopHotkey.Location = new System.Drawing.Point(81, 43);
            this.textBoxRecordStopHotkey.Name = "textBoxRecordStopHotkey";
            this.textBoxRecordStopHotkey.Size = new System.Drawing.Size(111, 20);
            this.textBoxRecordStopHotkey.TabIndex = 2;
            this.textBoxRecordStopHotkey.Enter += new System.EventHandler(this.textBoxRecordStopHotkey_Enter);
            this.textBoxRecordStopHotkey.Leave += new System.EventHandler(this.textBoxRecordStopHotkey_Leave);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 46);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 1;
            this.label21.Text = "Record/Stop";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(6, 21);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 13);
            this.label20.TabIndex = 0;
            this.label20.Text = "Play/Stop";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.numericUpDownKeyClickSpeedMax);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.numericUpDownMouseClickSpeedMax);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.numericUpDownKeyClickSpeedMin);
            this.tabPage3.Controls.Add(this.numericUpDownMouseClickSpeedMin);
            this.tabPage3.Controls.Add(this.checkBoxChangeKeyClickSpeed);
            this.tabPage3.Controls.Add(this.checkBoxChangeMouseClickSpeed);
            this.tabPage3.Controls.Add(this.checkBoxChangeMouseMovementSpeed);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.numericUpDownMouseMovementSpeedMin);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.numericUpDownMouseMovementSpeedMax);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(418, 127);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Speed Settings";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(302, 54);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(12, 13);
            this.label13.TabIndex = 29;
            this.label13.Text = "x";
            // 
            // numericUpDownKeyClickSpeedMax
            // 
            this.numericUpDownKeyClickSpeedMax.DecimalPlaces = 1;
            this.numericUpDownKeyClickSpeedMax.Enabled = false;
            this.numericUpDownKeyClickSpeedMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownKeyClickSpeedMax.Location = new System.Drawing.Point(259, 52);
            this.numericUpDownKeyClickSpeedMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKeyClickSpeedMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownKeyClickSpeedMax.Name = "numericUpDownKeyClickSpeedMax";
            this.numericUpDownKeyClickSpeedMax.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownKeyClickSpeedMax.TabIndex = 28;
            this.numericUpDownKeyClickSpeedMax.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(302, 30);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "x";
            // 
            // numericUpDownMouseClickSpeedMax
            // 
            this.numericUpDownMouseClickSpeedMax.DecimalPlaces = 1;
            this.numericUpDownMouseClickSpeedMax.Enabled = false;
            this.numericUpDownMouseClickSpeedMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMouseClickSpeedMax.Location = new System.Drawing.Point(259, 28);
            this.numericUpDownMouseClickSpeedMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMouseClickSpeedMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMouseClickSpeedMax.Name = "numericUpDownMouseClickSpeedMax";
            this.numericUpDownMouseClickSpeedMax.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownMouseClickSpeedMax.TabIndex = 26;
            this.numericUpDownMouseClickSpeedMax.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(237, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "to";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "to";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(12, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "x";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(216, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "x";
            // 
            // numericUpDownKeyClickSpeedMin
            // 
            this.numericUpDownKeyClickSpeedMin.DecimalPlaces = 1;
            this.numericUpDownKeyClickSpeedMin.Enabled = false;
            this.numericUpDownKeyClickSpeedMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownKeyClickSpeedMin.Location = new System.Drawing.Point(173, 52);
            this.numericUpDownKeyClickSpeedMin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownKeyClickSpeedMin.Name = "numericUpDownKeyClickSpeedMin";
            this.numericUpDownKeyClickSpeedMin.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownKeyClickSpeedMin.TabIndex = 21;
            this.numericUpDownKeyClickSpeedMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDownKeyClickSpeedMin.ValueChanged += new System.EventHandler(this.numericUpDownKeyClickSpeedMin_ValueChanged);
            // 
            // numericUpDownMouseClickSpeedMin
            // 
            this.numericUpDownMouseClickSpeedMin.DecimalPlaces = 1;
            this.numericUpDownMouseClickSpeedMin.Enabled = false;
            this.numericUpDownMouseClickSpeedMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMouseClickSpeedMin.Location = new System.Drawing.Point(173, 28);
            this.numericUpDownMouseClickSpeedMin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMouseClickSpeedMin.Name = "numericUpDownMouseClickSpeedMin";
            this.numericUpDownMouseClickSpeedMin.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownMouseClickSpeedMin.TabIndex = 20;
            this.numericUpDownMouseClickSpeedMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDownMouseClickSpeedMin.ValueChanged += new System.EventHandler(this.numericUpDownMouseClickSpeedMin_ValueChanged);
            // 
            // checkBoxChangeKeyClickSpeed
            // 
            this.checkBoxChangeKeyClickSpeed.AutoSize = true;
            this.checkBoxChangeKeyClickSpeed.Location = new System.Drawing.Point(3, 53);
            this.checkBoxChangeKeyClickSpeed.Name = "checkBoxChangeKeyClickSpeed";
            this.checkBoxChangeKeyClickSpeed.Size = new System.Drawing.Size(144, 17);
            this.checkBoxChangeKeyClickSpeed.TabIndex = 19;
            this.checkBoxChangeKeyClickSpeed.Text = "Change Key Click Speed";
            this.checkBoxChangeKeyClickSpeed.UseVisualStyleBackColor = true;
            this.checkBoxChangeKeyClickSpeed.CheckedChanged += new System.EventHandler(this.checkBoxChangeKeyClickSpeed_CheckedChanged);
            // 
            // checkBoxChangeMouseClickSpeed
            // 
            this.checkBoxChangeMouseClickSpeed.AutoSize = true;
            this.checkBoxChangeMouseClickSpeed.Location = new System.Drawing.Point(3, 29);
            this.checkBoxChangeMouseClickSpeed.Name = "checkBoxChangeMouseClickSpeed";
            this.checkBoxChangeMouseClickSpeed.Size = new System.Drawing.Size(158, 17);
            this.checkBoxChangeMouseClickSpeed.TabIndex = 18;
            this.checkBoxChangeMouseClickSpeed.Text = "Change Mouse Click Speed";
            this.checkBoxChangeMouseClickSpeed.UseVisualStyleBackColor = true;
            this.checkBoxChangeMouseClickSpeed.CheckedChanged += new System.EventHandler(this.checkBoxChangeMouseClickSpeed_CheckedChanged);
            // 
            // checkBoxChangeMouseMovementSpeed
            // 
            this.checkBoxChangeMouseMovementSpeed.AutoSize = true;
            this.checkBoxChangeMouseMovementSpeed.Location = new System.Drawing.Point(3, 6);
            this.checkBoxChangeMouseMovementSpeed.Name = "checkBoxChangeMouseMovementSpeed";
            this.checkBoxChangeMouseMovementSpeed.Size = new System.Drawing.Size(150, 17);
            this.checkBoxChangeMouseMovementSpeed.TabIndex = 17;
            this.checkBoxChangeMouseMovementSpeed.Text = "Change Movement Speed";
            this.checkBoxChangeMouseMovementSpeed.UseVisualStyleBackColor = true;
            this.checkBoxChangeMouseMovementSpeed.CheckedChanged += new System.EventHandler(this.checkBoxChangeMouseMovementSpeed_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(302, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "x";
            // 
            // numericUpDownMouseMovementSpeedMin
            // 
            this.numericUpDownMouseMovementSpeedMin.DecimalPlaces = 1;
            this.numericUpDownMouseMovementSpeedMin.Enabled = false;
            this.numericUpDownMouseMovementSpeedMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMouseMovementSpeedMin.Location = new System.Drawing.Point(173, 5);
            this.numericUpDownMouseMovementSpeedMin.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMouseMovementSpeedMin.Name = "numericUpDownMouseMovementSpeedMin";
            this.numericUpDownMouseMovementSpeedMin.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownMouseMovementSpeedMin.TabIndex = 12;
            this.numericUpDownMouseMovementSpeedMin.Value = new decimal(new int[] {
            10,
            0,
            0,
            65536});
            this.numericUpDownMouseMovementSpeedMin.ValueChanged += new System.EventHandler(this.numericUpDownMouseMovementSpeedMin_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(216, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "x";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "to";
            // 
            // numericUpDownMouseMovementSpeedMax
            // 
            this.numericUpDownMouseMovementSpeedMax.DecimalPlaces = 1;
            this.numericUpDownMouseMovementSpeedMax.Enabled = false;
            this.numericUpDownMouseMovementSpeedMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMouseMovementSpeedMax.Location = new System.Drawing.Point(259, 5);
            this.numericUpDownMouseMovementSpeedMax.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMouseMovementSpeedMax.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMouseMovementSpeedMax.Name = "numericUpDownMouseMovementSpeedMax";
            this.numericUpDownMouseMovementSpeedMax.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownMouseMovementSpeedMax.TabIndex = 15;
            this.numericUpDownMouseMovementSpeedMax.Value = new decimal(new int[] {
            11,
            0,
            0,
            65536});
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.numericUpDownAddDelayToEventMax);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.numericUpDownAddDelayToEventMin);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.numericUpDownAddDelayToEvents);
            this.tabPage2.Controls.Add(this.checkBoxAddDelayToEvents);
            this.tabPage2.Controls.Add(this.numericUpDownDelayPlaybacksMax);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.numericUpDownDelayPlaybacksMin);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.numericUpDownDelayRecordsMax);
            this.tabPage2.Controls.Add(this.numericUpDownDelayRecordsMin);
            this.tabPage2.Controls.Add(this.checkBoxDelayPlaybacks);
            this.tabPage2.Controls.Add(this.checkBoxDelayRecords);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 127);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Delay Settings";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Enabled = false;
            this.label19.Location = new System.Drawing.Point(51, 80);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(78, 13);
            this.label19.TabIndex = 17;
            this.label19.Text = "Specify Delay: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Enabled = false;
            this.label18.Location = new System.Drawing.Point(284, 82);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 13);
            this.label18.TabIndex = 16;
            this.label18.Text = "msec";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(284, 30);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 15;
            this.label17.Text = "msec";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(284, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 14;
            this.label16.Text = "msec";
            // 
            // numericUpDownAddDelayToEventMax
            // 
            this.numericUpDownAddDelayToEventMax.Enabled = false;
            this.numericUpDownAddDelayToEventMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAddDelayToEventMax.Location = new System.Drawing.Point(221, 78);
            this.numericUpDownAddDelayToEventMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownAddDelayToEventMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownAddDelayToEventMax.Name = "numericUpDownAddDelayToEventMax";
            this.numericUpDownAddDelayToEventMax.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownAddDelayToEventMax.TabIndex = 13;
            this.numericUpDownAddDelayToEventMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(199, 80);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 13);
            this.label15.TabIndex = 12;
            this.label15.Text = "to";
            // 
            // numericUpDownAddDelayToEventMin
            // 
            this.numericUpDownAddDelayToEventMin.Enabled = false;
            this.numericUpDownAddDelayToEventMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAddDelayToEventMin.Location = new System.Drawing.Point(135, 78);
            this.numericUpDownAddDelayToEventMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownAddDelayToEventMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAddDelayToEventMin.Name = "numericUpDownAddDelayToEventMin";
            this.numericUpDownAddDelayToEventMin.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownAddDelayToEventMin.TabIndex = 11;
            this.numericUpDownAddDelayToEventMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAddDelayToEventMin.ValueChanged += new System.EventHandler(this.numericUpDownAddDelayToEventMin_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(284, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(32, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "msec";
            // 
            // numericUpDownAddDelayToEvents
            // 
            this.numericUpDownAddDelayToEvents.Enabled = false;
            this.numericUpDownAddDelayToEvents.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAddDelayToEvents.Location = new System.Drawing.Point(221, 52);
            this.numericUpDownAddDelayToEvents.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDownAddDelayToEvents.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAddDelayToEvents.Name = "numericUpDownAddDelayToEvents";
            this.numericUpDownAddDelayToEvents.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownAddDelayToEvents.TabIndex = 9;
            this.numericUpDownAddDelayToEvents.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAddDelayToEvents.ValueChanged += new System.EventHandler(this.numericUpDownAddDelayToEvents_ValueChanged);
            // 
            // checkBoxAddDelayToEvents
            // 
            this.checkBoxAddDelayToEvents.AutoSize = true;
            this.checkBoxAddDelayToEvents.Location = new System.Drawing.Point(3, 53);
            this.checkBoxAddDelayToEvents.Name = "checkBoxAddDelayToEvents";
            this.checkBoxAddDelayToEvents.Size = new System.Drawing.Size(187, 17);
            this.checkBoxAddDelayToEvents.TabIndex = 8;
            this.checkBoxAddDelayToEvents.Text = "Add Delay to Events Longer Than";
            this.checkBoxAddDelayToEvents.UseVisualStyleBackColor = true;
            this.checkBoxAddDelayToEvents.CheckedChanged += new System.EventHandler(this.checkBoxAddDelayToEvents_CheckedChanged);
            // 
            // numericUpDownDelayPlaybacksMax
            // 
            this.numericUpDownDelayPlaybacksMax.Enabled = false;
            this.numericUpDownDelayPlaybacksMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDelayPlaybacksMax.Location = new System.Drawing.Point(221, 28);
            this.numericUpDownDelayPlaybacksMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownDelayPlaybacksMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDelayPlaybacksMax.Name = "numericUpDownDelayPlaybacksMax";
            this.numericUpDownDelayPlaybacksMax.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownDelayPlaybacksMax.TabIndex = 7;
            this.numericUpDownDelayPlaybacksMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "to";
            // 
            // numericUpDownDelayPlaybacksMin
            // 
            this.numericUpDownDelayPlaybacksMin.Enabled = false;
            this.numericUpDownDelayPlaybacksMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDelayPlaybacksMin.Location = new System.Drawing.Point(135, 28);
            this.numericUpDownDelayPlaybacksMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownDelayPlaybacksMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelayPlaybacksMin.Name = "numericUpDownDelayPlaybacksMin";
            this.numericUpDownDelayPlaybacksMin.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownDelayPlaybacksMin.TabIndex = 5;
            this.numericUpDownDelayPlaybacksMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelayPlaybacksMin.ValueChanged += new System.EventHandler(this.numericUpDownDelayPlaybacksMin_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(199, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "to";
            // 
            // numericUpDownDelayRecordsMax
            // 
            this.numericUpDownDelayRecordsMax.Enabled = false;
            this.numericUpDownDelayRecordsMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDelayRecordsMax.Location = new System.Drawing.Point(221, 5);
            this.numericUpDownDelayRecordsMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownDelayRecordsMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDelayRecordsMax.Name = "numericUpDownDelayRecordsMax";
            this.numericUpDownDelayRecordsMax.Size = new System.Drawing.Size(57, 20);
            this.numericUpDownDelayRecordsMax.TabIndex = 3;
            this.numericUpDownDelayRecordsMax.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // numericUpDownDelayRecordsMin
            // 
            this.numericUpDownDelayRecordsMin.Enabled = false;
            this.numericUpDownDelayRecordsMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDelayRecordsMin.Location = new System.Drawing.Point(135, 5);
            this.numericUpDownDelayRecordsMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownDelayRecordsMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelayRecordsMin.Name = "numericUpDownDelayRecordsMin";
            this.numericUpDownDelayRecordsMin.Size = new System.Drawing.Size(55, 20);
            this.numericUpDownDelayRecordsMin.TabIndex = 2;
            this.numericUpDownDelayRecordsMin.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelayRecordsMin.ValueChanged += new System.EventHandler(this.numericUpDownDelayRecordsMin_ValueChanged);
            // 
            // checkBoxDelayPlaybacks
            // 
            this.checkBoxDelayPlaybacks.AutoSize = true;
            this.checkBoxDelayPlaybacks.Location = new System.Drawing.Point(3, 29);
            this.checkBoxDelayPlaybacks.Name = "checkBoxDelayPlaybacks";
            this.checkBoxDelayPlaybacks.Size = new System.Drawing.Size(105, 17);
            this.checkBoxDelayPlaybacks.TabIndex = 1;
            this.checkBoxDelayPlaybacks.Text = "Delay Playbacks";
            this.checkBoxDelayPlaybacks.UseVisualStyleBackColor = true;
            this.checkBoxDelayPlaybacks.CheckedChanged += new System.EventHandler(this.checkBoxDelayPlaybacks_CheckedChanged);
            // 
            // checkBoxDelayRecords
            // 
            this.checkBoxDelayRecords.AutoSize = true;
            this.checkBoxDelayRecords.Location = new System.Drawing.Point(3, 6);
            this.checkBoxDelayRecords.Name = "checkBoxDelayRecords";
            this.checkBoxDelayRecords.Size = new System.Drawing.Size(96, 17);
            this.checkBoxDelayRecords.TabIndex = 0;
            this.checkBoxDelayRecords.Text = "Delay Records";
            this.checkBoxDelayRecords.UseVisualStyleBackColor = true;
            this.checkBoxDelayRecords.CheckedChanged += new System.EventHandler(this.checkBoxDelayRecords_CheckedChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.checkBoxOffByOne);
            this.tabPage4.Controls.Add(this.checkBoxRandomOrder);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(418, 127);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Additional Settings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // checkBoxOffByOne
            // 
            this.checkBoxOffByOne.AutoSize = true;
            this.checkBoxOffByOne.Location = new System.Drawing.Point(3, 6);
            this.checkBoxOffByOne.Name = "checkBoxOffByOne";
            this.checkBoxOffByOne.Size = new System.Drawing.Size(149, 17);
            this.checkBoxOffByOne.TabIndex = 12;
            this.checkBoxOffByOne.Text = "Off-By-One Mouse Events";
            this.checkBoxOffByOne.UseVisualStyleBackColor = true;
            this.checkBoxOffByOne.CheckedChanged += new System.EventHandler(this.checkBoxOffByOne_CheckedChanged);
            // 
            // checkBoxRandomOrder
            // 
            this.checkBoxRandomOrder.AutoSize = true;
            this.checkBoxRandomOrder.Location = new System.Drawing.Point(3, 29);
            this.checkBoxRandomOrder.Name = "checkBoxRandomOrder";
            this.checkBoxRandomOrder.Size = new System.Drawing.Size(172, 17);
            this.checkBoxRandomOrder.TabIndex = 11;
            this.checkBoxRandomOrder.Text = "Play Records in Random Order";
            this.checkBoxRandomOrder.UseVisualStyleBackColor = true;
            this.checkBoxRandomOrder.CheckedChanged += new System.EventHandler(this.checkBoxRandomOrder_CheckedChanged);
            // 
            // buttonRemoveAllRecords
            // 
            this.buttonRemoveAllRecords.Location = new System.Drawing.Point(396, 414);
            this.buttonRemoveAllRecords.Name = "buttonRemoveAllRecords";
            this.buttonRemoveAllRecords.Size = new System.Drawing.Size(73, 23);
            this.buttonRemoveAllRecords.TabIndex = 15;
            this.buttonRemoveAllRecords.Text = "Remove All";
            this.buttonRemoveAllRecords.UseVisualStyleBackColor = true;
            this.buttonRemoveAllRecords.Click += new System.EventHandler(this.buttonRemoveAllRecords_Click);
            // 
            // RecordPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 449);
            this.Controls.Add(this.buttonRemoveAllRecords);
            this.Controls.Add(this.tabControlSettings);
            this.Controls.Add(this.buttonSaveRecord);
            this.Controls.Add(this.buttonMoveRecordDown);
            this.Controls.Add(this.buttonMoveRecordUp);
            this.Controls.Add(this.buttonAddRecord);
            this.Controls.Add(this.buttonRemoveRecord);
            this.Controls.Add(this.listViewRecords);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonRecord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 800);
            this.MinimumSize = new System.Drawing.Size(491, 456);
            this.Name = "RecordPlayer";
            this.Text = "Record Player";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIterations)).EndInit();
            this.tabControlSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTime)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyClickSpeedMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMouseClickSpeedMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownKeyClickSpeedMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMouseClickSpeedMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMouseMovementSpeedMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMouseMovementSpeedMax)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddDelayToEventMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddDelayToEventMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAddDelayToEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayPlaybacksMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayPlaybacksMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayRecordsMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayRecordsMin)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.ListView listViewRecords;
        private System.Windows.Forms.NumericUpDown numericUpDownIterations;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPlayBack;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Button buttonRemoveRecord;
        private System.Windows.Forms.Button buttonAddRecord;
        private System.Windows.Forms.Button buttonMoveRecordUp;
        private System.Windows.Forms.Button buttonMoveRecordDown;
        private System.Windows.Forms.Button buttonOpenFolder;
        private System.Windows.Forms.TextBox textBoxSavePath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogSaveFolder;
        private System.Windows.Forms.Button buttonSaveRecord;
        private System.Windows.Forms.ColumnHeader columnHeaderRecordName;
        private System.Windows.Forms.TabControl tabControlSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDelayRecordsMax;
        private System.Windows.Forms.NumericUpDown numericUpDownDelayRecordsMin;
        private System.Windows.Forms.CheckBox checkBoxDelayPlaybacks;
        private System.Windows.Forms.CheckBox checkBoxDelayRecords;
        private System.Windows.Forms.NumericUpDown numericUpDownDelayPlaybacksMax;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownDelayPlaybacksMin;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownKeyClickSpeedMax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown numericUpDownMouseClickSpeedMax;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownKeyClickSpeedMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMouseClickSpeedMin;
        private System.Windows.Forms.CheckBox checkBoxChangeKeyClickSpeed;
        private System.Windows.Forms.CheckBox checkBoxChangeMouseClickSpeed;
        private System.Windows.Forms.CheckBox checkBoxChangeMouseMovementSpeed;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownMouseMovementSpeedMin;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownMouseMovementSpeedMax;
        private System.Windows.Forms.CheckBox checkBoxRandomOrder;
        private System.Windows.Forms.CheckBox checkBoxOffByOne;
        private System.Windows.Forms.Button buttonRemoveAllRecords;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownAddDelayToEvents;
        private System.Windows.Forms.CheckBox checkBoxAddDelayToEvents;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDownAddDelayToEventMax;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownAddDelayToEventMin;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxPlayStopHotkey;
        private System.Windows.Forms.TextBox textBoxRecordStopHotkey;
        private System.Windows.Forms.CheckBox checkBoxTrackMouse;
        private System.Windows.Forms.CheckBox checkBoxTrackKeyboard;
        private System.Windows.Forms.RadioButton radioButtonTime;
        private System.Windows.Forms.RadioButton radioButtonPlaybacks;
        private System.Windows.Forms.NumericUpDown numericUpDownTime;
    }
}


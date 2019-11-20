namespace ColorClicker
{
    partial class ColorClicker
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownClicksToPerform = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.buttonDisplayHotkeys = new System.Windows.Forms.Button();
            this.numericUpDownPixels = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.numericUpDownDiscrepancy = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.numericUpDownBeforeOffsetMax = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.numericUpDownBeforeOffsetMin = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numericUpDownDelayAfterClickMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDelayBeforeClickMax = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDelayAfterClickMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownDelayBeforeClickMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownYOffset = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownXOffset = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerGetColor = new System.Windows.Forms.Timer(this.components);
            this.buttonPlay = new System.Windows.Forms.Button();
            this.backgroundWorkerPlay = new System.ComponentModel.BackgroundWorker();
            this.buttonColorize = new System.Windows.Forms.Button();
            this.richTextBoxLog = new System.Windows.Forms.RichTextBox();
            this.buttonClearLog = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClicksToPerform)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPixels)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscrepancy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeforeOffsetMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeforeOffsetMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayAfterClickMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayBeforeClickMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayAfterClickMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayBeforeClickMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXOffset)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownClicksToPerform);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.buttonDisplayHotkeys);
            this.groupBox1.Controls.Add(this.numericUpDownPixels);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.numericUpDownDiscrepancy);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.numericUpDownBeforeOffsetMax);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.numericUpDownBeforeOffsetMin);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericUpDownDelayAfterClickMax);
            this.groupBox1.Controls.Add(this.numericUpDownDelayBeforeClickMax);
            this.groupBox1.Controls.Add(this.numericUpDownDelayAfterClickMin);
            this.groupBox1.Controls.Add(this.numericUpDownDelayBeforeClickMin);
            this.groupBox1.Controls.Add(this.numericUpDownYOffset);
            this.groupBox1.Controls.Add(this.numericUpDownXOffset);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(325, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Settings";
            // 
            // numericUpDownClicksToPerform
            // 
            this.numericUpDownClicksToPerform.Location = new System.Drawing.Point(104, 20);
            this.numericUpDownClicksToPerform.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numericUpDownClicksToPerform.Name = "numericUpDownClicksToPerform";
            this.numericUpDownClicksToPerform.Size = new System.Drawing.Size(51, 20);
            this.numericUpDownClicksToPerform.TabIndex = 28;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(92, 13);
            this.label17.TabIndex = 27;
            this.label17.Text = "Clicks to Perform: ";
            // 
            // buttonDisplayHotkeys
            // 
            this.buttonDisplayHotkeys.Location = new System.Drawing.Point(198, 15);
            this.buttonDisplayHotkeys.Name = "buttonDisplayHotkeys";
            this.buttonDisplayHotkeys.Size = new System.Drawing.Size(71, 26);
            this.buttonDisplayHotkeys.TabIndex = 15;
            this.buttonDisplayHotkeys.Text = "Hotkeys";
            this.buttonDisplayHotkeys.UseVisualStyleBackColor = true;
            this.buttonDisplayHotkeys.Click += new System.EventHandler(this.buttonDisplayHotkeys_Click);
            // 
            // numericUpDownPixels
            // 
            this.numericUpDownPixels.Location = new System.Drawing.Point(120, 113);
            this.numericUpDownPixels.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.numericUpDownPixels.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownPixels.Name = "numericUpDownPixels";
            this.numericUpDownPixels.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownPixels.TabIndex = 26;
            this.numericUpDownPixels.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 115);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 13);
            this.label16.TabIndex = 25;
            this.label16.Text = "Pixels to Be Correct:";
            // 
            // numericUpDownDiscrepancy
            // 
            this.numericUpDownDiscrepancy.Location = new System.Drawing.Point(120, 140);
            this.numericUpDownDiscrepancy.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.numericUpDownDiscrepancy.Name = "numericUpDownDiscrepancy";
            this.numericUpDownDiscrepancy.Size = new System.Drawing.Size(50, 20);
            this.numericUpDownDiscrepancy.TabIndex = 23;
            this.numericUpDownDiscrepancy.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(16, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "to";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(101, 142);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(13, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "±";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(233, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 19;
            this.label13.Text = "msec";
            // 
            // numericUpDownBeforeOffsetMax
            // 
            this.numericUpDownBeforeOffsetMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownBeforeOffsetMax.Location = new System.Drawing.Point(178, 207);
            this.numericUpDownBeforeOffsetMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownBeforeOffsetMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownBeforeOffsetMax.Name = "numericUpDownBeforeOffsetMax";
            this.numericUpDownBeforeOffsetMax.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownBeforeOffsetMax.TabIndex = 18;
            this.numericUpDownBeforeOffsetMax.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 142);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Color Discrepancy: ";
            // 
            // numericUpDownBeforeOffsetMin
            // 
            this.numericUpDownBeforeOffsetMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownBeforeOffsetMin.Location = new System.Drawing.Point(106, 207);
            this.numericUpDownBeforeOffsetMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownBeforeOffsetMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBeforeOffsetMin.Name = "numericUpDownBeforeOffsetMin";
            this.numericUpDownBeforeOffsetMin.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownBeforeOffsetMin.TabIndex = 17;
            this.numericUpDownBeforeOffsetMin.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownBeforeOffsetMin.ValueChanged += new System.EventHandler(this.numericUpDownBeforeOffsetMin_ValueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 209);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 13);
            this.label11.TabIndex = 16;
            this.label11.Text = "Offset Before Click:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(156, 237);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 15;
            this.label10.Text = "to";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(156, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "to";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(109, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "px";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(109, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "px";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(233, 237);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "msec";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "msec";
            // 
            // numericUpDownDelayAfterClickMax
            // 
            this.numericUpDownDelayAfterClickMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDelayAfterClickMax.Location = new System.Drawing.Point(178, 235);
            this.numericUpDownDelayAfterClickMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownDelayAfterClickMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDelayAfterClickMax.Name = "numericUpDownDelayAfterClickMax";
            this.numericUpDownDelayAfterClickMax.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownDelayAfterClickMax.TabIndex = 9;
            this.numericUpDownDelayAfterClickMax.Value = new decimal(new int[] {
            6300,
            0,
            0,
            0});
            // 
            // numericUpDownDelayBeforeClickMax
            // 
            this.numericUpDownDelayBeforeClickMax.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDelayBeforeClickMax.Location = new System.Drawing.Point(178, 179);
            this.numericUpDownDelayBeforeClickMax.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownDelayBeforeClickMax.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownDelayBeforeClickMax.Name = "numericUpDownDelayBeforeClickMax";
            this.numericUpDownDelayBeforeClickMax.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownDelayBeforeClickMax.TabIndex = 8;
            this.numericUpDownDelayBeforeClickMax.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // numericUpDownDelayAfterClickMin
            // 
            this.numericUpDownDelayAfterClickMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDelayAfterClickMin.Location = new System.Drawing.Point(106, 235);
            this.numericUpDownDelayAfterClickMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownDelayAfterClickMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelayAfterClickMin.Name = "numericUpDownDelayAfterClickMin";
            this.numericUpDownDelayAfterClickMin.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownDelayAfterClickMin.TabIndex = 7;
            this.numericUpDownDelayAfterClickMin.Value = new decimal(new int[] {
            6000,
            0,
            0,
            0});
            this.numericUpDownDelayAfterClickMin.ValueChanged += new System.EventHandler(this.numericUpDownDelayAfterClickMin_ValueChanged);
            // 
            // numericUpDownDelayBeforeClickMin
            // 
            this.numericUpDownDelayBeforeClickMin.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownDelayBeforeClickMin.Location = new System.Drawing.Point(106, 179);
            this.numericUpDownDelayBeforeClickMin.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.numericUpDownDelayBeforeClickMin.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDelayBeforeClickMin.Name = "numericUpDownDelayBeforeClickMin";
            this.numericUpDownDelayBeforeClickMin.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownDelayBeforeClickMin.TabIndex = 6;
            this.numericUpDownDelayBeforeClickMin.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.numericUpDownDelayBeforeClickMin.ValueChanged += new System.EventHandler(this.numericUpDownDelayBeforeClickMin_ValueChanged);
            // 
            // numericUpDownYOffset
            // 
            this.numericUpDownYOffset.Location = new System.Drawing.Point(59, 80);
            this.numericUpDownYOffset.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDownYOffset.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            -2147483648});
            this.numericUpDownYOffset.Name = "numericUpDownYOffset";
            this.numericUpDownYOffset.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownYOffset.TabIndex = 5;
            this.numericUpDownYOffset.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // numericUpDownXOffset
            // 
            this.numericUpDownXOffset.Location = new System.Drawing.Point(59, 58);
            this.numericUpDownXOffset.Maximum = new decimal(new int[] {
            4000,
            0,
            0,
            0});
            this.numericUpDownXOffset.Minimum = new decimal(new int[] {
            4000,
            0,
            0,
            -2147483648});
            this.numericUpDownXOffset.Name = "numericUpDownXOffset";
            this.numericUpDownXOffset.Size = new System.Drawing.Size(49, 20);
            this.numericUpDownXOffset.TabIndex = 4;
            this.numericUpDownXOffset.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Delay After Click:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Delay Before Click:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y Offset:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "X Offset:";
            // 
            // timerGetColor
            // 
            this.timerGetColor.Interval = 25;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(12, 11);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(94, 42);
            this.buttonPlay.TabIndex = 12;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // backgroundWorkerPlay
            // 
            this.backgroundWorkerPlay.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorkerPlay_DoWork);
            // 
            // buttonColorize
            // 
            this.buttonColorize.Location = new System.Drawing.Point(112, 11);
            this.buttonColorize.Name = "buttonColorize";
            this.buttonColorize.Size = new System.Drawing.Size(98, 42);
            this.buttonColorize.TabIndex = 11;
            this.buttonColorize.Text = "Get Cursor Colors";
            this.buttonColorize.UseVisualStyleBackColor = true;
            this.buttonColorize.Click += new System.EventHandler(this.buttonColorize_Click);
            // 
            // richTextBoxLog
            // 
            this.richTextBoxLog.Location = new System.Drawing.Point(12, 60);
            this.richTextBoxLog.Name = "richTextBoxLog";
            this.richTextBoxLog.ReadOnly = true;
            this.richTextBoxLog.Size = new System.Drawing.Size(307, 229);
            this.richTextBoxLog.TabIndex = 13;
            this.richTextBoxLog.Text = "";
            this.richTextBoxLog.TextChanged += new System.EventHandler(this.richTextBoxLog_TextChanged);
            // 
            // buttonClearLog
            // 
            this.buttonClearLog.Location = new System.Drawing.Point(251, 27);
            this.buttonClearLog.Name = "buttonClearLog";
            this.buttonClearLog.Size = new System.Drawing.Size(68, 26);
            this.buttonClearLog.TabIndex = 14;
            this.buttonClearLog.Text = "Clear Log";
            this.buttonClearLog.UseVisualStyleBackColor = true;
            this.buttonClearLog.Click += new System.EventHandler(this.buttonClearLog_Click);
            // 
            // ColorClicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 300);
            this.Controls.Add(this.buttonClearLog);
            this.Controls.Add(this.richTextBoxLog);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.buttonColorize);
            this.Controls.Add(this.groupBox1);
            this.Name = "ColorClicker";
            this.Text = "Color Clicker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownClicksToPerform)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPixels)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDiscrepancy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeforeOffsetMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeforeOffsetMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayAfterClickMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayBeforeClickMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayAfterClickMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDelayBeforeClickMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownYOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownXOffset)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericUpDownDelayAfterClickMax;
        private System.Windows.Forms.NumericUpDown numericUpDownDelayBeforeClickMax;
        private System.Windows.Forms.NumericUpDown numericUpDownDelayAfterClickMin;
        private System.Windows.Forms.NumericUpDown numericUpDownDelayBeforeClickMin;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Timer timerGetColor;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.NumericUpDown numericUpDownDiscrepancy;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numericUpDownBeforeOffsetMax;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown numericUpDownBeforeOffsetMin;
        private System.Windows.Forms.Label label11;
        private System.ComponentModel.BackgroundWorker backgroundWorkerPlay;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numericUpDownPixels;
        private System.Windows.Forms.Button buttonColorize;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownYOffset;
        private System.Windows.Forms.NumericUpDown numericUpDownXOffset;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDisplayHotkeys;
        private System.Windows.Forms.RichTextBox richTextBoxLog;
        private System.Windows.Forms.Button buttonClearLog;
        private System.Windows.Forms.NumericUpDown numericUpDownClicksToPerform;
        private System.Windows.Forms.Label label17;
    }
}


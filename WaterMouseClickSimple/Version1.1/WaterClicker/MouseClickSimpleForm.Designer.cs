namespace WindowsFormsApplication1
{
    partial class WaterMouseClickSimple
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
            this.buttonStart = new System.Windows.Forms.Button();
            this.numericUpDownIteration = new System.Windows.Forms.NumericUpDown();
            this.labelIterations = new System.Windows.Forms.Label();
            this.timerClick = new System.Windows.Forms.Timer(this.components);
            this.checkBoxRand = new System.Windows.Forms.CheckBox();
            this.numericUpDownRand1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownRand2 = new System.Windows.Forms.NumericUpDown();
            this.labelDash = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.groupBoxRand = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelClicks = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDelay = new System.Windows.Forms.Label();
            this.checkBoxDelay = new System.Windows.Forms.CheckBox();
            this.timerClock = new System.Windows.Forms.Timer(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.labelSeconds = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand2)).BeginInit();
            this.groupBoxRand.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(101, 58);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start (Ctrl + 1)";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // numericUpDownIteration
            // 
            this.numericUpDownIteration.Location = new System.Drawing.Point(12, 84);
            this.numericUpDownIteration.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownIteration.Name = "numericUpDownIteration";
            this.numericUpDownIteration.Size = new System.Drawing.Size(46, 20);
            this.numericUpDownIteration.TabIndex = 4;
            // 
            // labelIterations
            // 
            this.labelIterations.AutoSize = true;
            this.labelIterations.Location = new System.Drawing.Point(64, 91);
            this.labelIterations.Name = "labelIterations";
            this.labelIterations.Size = new System.Drawing.Size(49, 13);
            this.labelIterations.TabIndex = 5;
            this.labelIterations.Text = "iterations";
            // 
            // timerClick
            // 
            this.timerClick.Tick += new System.EventHandler(this.timerClick_Tick);
            // 
            // checkBoxRand
            // 
            this.checkBoxRand.AutoSize = true;
            this.checkBoxRand.Location = new System.Drawing.Point(12, 128);
            this.checkBoxRand.Name = "checkBoxRand";
            this.checkBoxRand.Size = new System.Drawing.Size(84, 17);
            this.checkBoxRand.TabIndex = 6;
            this.checkBoxRand.Text = "Time Range";
            this.checkBoxRand.UseVisualStyleBackColor = true;
            this.checkBoxRand.CheckedChanged += new System.EventHandler(this.checkBoxRand_CheckedChanged);
            // 
            // numericUpDownRand1
            // 
            this.numericUpDownRand1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRand1.Location = new System.Drawing.Point(13, 26);
            this.numericUpDownRand1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownRand1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownRand1.Name = "numericUpDownRand1";
            this.numericUpDownRand1.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownRand1.TabIndex = 8;
            this.numericUpDownRand1.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // numericUpDownRand2
            // 
            this.numericUpDownRand2.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRand2.Location = new System.Drawing.Point(91, 26);
            this.numericUpDownRand2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownRand2.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownRand2.Name = "numericUpDownRand2";
            this.numericUpDownRand2.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownRand2.TabIndex = 10;
            this.numericUpDownRand2.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // labelDash
            // 
            this.labelDash.AutoSize = true;
            this.labelDash.Location = new System.Drawing.Point(74, 28);
            this.labelDash.Name = "labelDash";
            this.labelDash.Size = new System.Drawing.Size(10, 13);
            this.labelDash.TabIndex = 11;
            this.labelDash.Text = "-";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Click Time (msec):";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(224, 104);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 13);
            this.labelTime.TabIndex = 13;
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBoxRand
            // 
            this.groupBoxRand.Controls.Add(this.numericUpDownRand1);
            this.groupBoxRand.Controls.Add(this.numericUpDownRand2);
            this.groupBoxRand.Controls.Add(this.labelDash);
            this.groupBoxRand.Location = new System.Drawing.Point(128, 12);
            this.groupBoxRand.Name = "groupBoxRand";
            this.groupBoxRand.Size = new System.Drawing.Size(155, 58);
            this.groupBoxRand.TabIndex = 17;
            this.groupBoxRand.TabStop = false;
            this.groupBoxRand.Text = "Time (msec)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(125, 129);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Clicks:";
            // 
            // labelClicks
            // 
            this.labelClicks.AutoSize = true;
            this.labelClicks.Location = new System.Drawing.Point(224, 129);
            this.labelClicks.Name = "labelClicks";
            this.labelClicks.Size = new System.Drawing.Size(0, 13);
            this.labelClicks.TabIndex = 19;
            this.labelClicks.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(125, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Click Event Delay:";
            // 
            // labelDelay
            // 
            this.labelDelay.AutoSize = true;
            this.labelDelay.Location = new System.Drawing.Point(224, 79);
            this.labelDelay.Name = "labelDelay";
            this.labelDelay.Size = new System.Drawing.Size(0, 13);
            this.labelDelay.TabIndex = 25;
            this.labelDelay.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // checkBoxDelay
            // 
            this.checkBoxDelay.AutoSize = true;
            this.checkBoxDelay.Location = new System.Drawing.Point(12, 153);
            this.checkBoxDelay.Name = "checkBoxDelay";
            this.checkBoxDelay.Size = new System.Drawing.Size(79, 17);
            this.checkBoxDelay.TabIndex = 26;
            this.checkBoxDelay.Text = "Click Delay";
            this.checkBoxDelay.UseVisualStyleBackColor = true;
            // 
            // timerClock
            // 
            this.timerClock.Interval = 1000;
            this.timerClock.Tick += new System.EventHandler(this.timerClock_Tick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(125, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Duration:";
            // 
            // labelSeconds
            // 
            this.labelSeconds.AutoSize = true;
            this.labelSeconds.Location = new System.Drawing.Point(224, 154);
            this.labelSeconds.Name = "labelSeconds";
            this.labelSeconds.Size = new System.Drawing.Size(0, 13);
            this.labelSeconds.TabIndex = 29;
            this.labelSeconds.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // WaterMouseClickSimple
            // 
            this.AccessibleDescription = "";
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 175);
            this.Controls.Add(this.labelSeconds);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBoxDelay);
            this.Controls.Add(this.labelDelay);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelClicks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxRand);
            this.Controls.Add(this.groupBoxRand);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelIterations);
            this.Controls.Add(this.numericUpDownIteration);
            this.Controls.Add(this.buttonStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "WaterMouseClickSimple";
            this.Text = "WaterMouseClickSimple";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand2)).EndInit();
            this.groupBoxRand.ResumeLayout(false);
            this.groupBoxRand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.NumericUpDown numericUpDownIteration;
        private System.Windows.Forms.Label labelIterations;
        private System.Windows.Forms.Timer timerClick;
        private System.Windows.Forms.CheckBox checkBoxRand;
        private System.Windows.Forms.NumericUpDown numericUpDownRand1;
        private System.Windows.Forms.NumericUpDown numericUpDownRand2;
        private System.Windows.Forms.Label labelDash;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.GroupBox groupBoxRand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelClicks;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDelay;
        private System.Windows.Forms.CheckBox checkBoxDelay;
        private System.Windows.Forms.Timer timerClock;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelSeconds;
    }
}


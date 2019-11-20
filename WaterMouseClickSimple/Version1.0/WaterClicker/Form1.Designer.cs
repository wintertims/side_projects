namespace WindowsFormsApplication1
{
    partial class WaterClicker
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
            this.buttonStop = new System.Windows.Forms.Button();
            this.numericUpDownMsec = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownIteration = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.timerClick = new System.Windows.Forms.Timer(this.components);
            this.checkBoxRand = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownRand1 = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownRand2 = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.groupBoxTime = new System.Windows.Forms.GroupBox();
            this.groupBoxRand = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.labelClicks = new System.Windows.Forms.Label();
            this.checkBoxFast = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMsec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteration)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand2)).BeginInit();
            this.groupBoxTime.SuspendLayout();
            this.groupBoxRand.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(12, 12);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(101, 32);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start (Ctrl + 1)";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonStop.Location = new System.Drawing.Point(12, 54);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(101, 32);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop (Ctrl + 1)";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // numericUpDownMsec
            // 
            this.numericUpDownMsec.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownMsec.Location = new System.Drawing.Point(17, 19);
            this.numericUpDownMsec.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownMsec.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMsec.Name = "numericUpDownMsec";
            this.numericUpDownMsec.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownMsec.TabIndex = 2;
            this.numericUpDownMsec.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "msec";
            // 
            // numericUpDownIteration
            // 
            this.numericUpDownIteration.Location = new System.Drawing.Point(12, 107);
            this.numericUpDownIteration.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownIteration.Name = "numericUpDownIteration";
            this.numericUpDownIteration.Size = new System.Drawing.Size(53, 20);
            this.numericUpDownIteration.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "iterations";
            // 
            // timerClick
            // 
            this.timerClick.Tick += new System.EventHandler(this.timerClick_Tick);
            // 
            // checkBoxRand
            // 
            this.checkBoxRand.AutoSize = true;
            this.checkBoxRand.Location = new System.Drawing.Point(172, 65);
            this.checkBoxRand.Name = "checkBoxRand";
            this.checkBoxRand.Size = new System.Drawing.Size(72, 17);
            this.checkBoxRand.TabIndex = 6;
            this.checkBoxRand.Text = "Random?";
            this.checkBoxRand.UseVisualStyleBackColor = true;
            this.checkBoxRand.CheckedChanged += new System.EventHandler(this.checkBoxRand_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Between";
            // 
            // numericUpDownRand1
            // 
            this.numericUpDownRand1.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRand1.Location = new System.Drawing.Point(55, 19);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "and";
            // 
            // numericUpDownRand2
            // 
            this.numericUpDownRand2.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownRand2.Location = new System.Drawing.Point(55, 41);
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(114, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "msec";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Click Time(msec):";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(117, 146);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 13);
            this.labelTime.TabIndex = 13;
            // 
            // buttonHelp
            // 
            this.buttonHelp.Location = new System.Drawing.Point(251, 167);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(17, 20);
            this.buttonHelp.TabIndex = 15;
            this.buttonHelp.Text = "?";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // groupBoxTime
            // 
            this.groupBoxTime.Controls.Add(this.numericUpDownMsec);
            this.groupBoxTime.Controls.Add(this.label1);
            this.groupBoxTime.Location = new System.Drawing.Point(172, 12);
            this.groupBoxTime.Name = "groupBoxTime";
            this.groupBoxTime.Size = new System.Drawing.Size(113, 45);
            this.groupBoxTime.TabIndex = 16;
            this.groupBoxTime.TabStop = false;
            this.groupBoxTime.Text = "Time";
            // 
            // groupBoxRand
            // 
            this.groupBoxRand.Controls.Add(this.label3);
            this.groupBoxRand.Controls.Add(this.numericUpDownRand1);
            this.groupBoxRand.Controls.Add(this.label4);
            this.groupBoxRand.Controls.Add(this.numericUpDownRand2);
            this.groupBoxRand.Controls.Add(this.label5);
            this.groupBoxRand.Location = new System.Drawing.Point(172, 88);
            this.groupBoxRand.Name = "groupBoxRand";
            this.groupBoxRand.Size = new System.Drawing.Size(148, 71);
            this.groupBoxRand.TabIndex = 17;
            this.groupBoxRand.TabStop = false;
            this.groupBoxRand.Text = "Time (Randomized)";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Clicks:";
            // 
            // labelClicks
            // 
            this.labelClicks.AutoSize = true;
            this.labelClicks.Location = new System.Drawing.Point(117, 171);
            this.labelClicks.Name = "labelClicks";
            this.labelClicks.Size = new System.Drawing.Size(0, 13);
            this.labelClicks.TabIndex = 19;
            // 
            // checkBoxFast
            // 
            this.checkBoxFast.AutoSize = true;
            this.checkBoxFast.Location = new System.Drawing.Point(172, 170);
            this.checkBoxFast.Name = "checkBoxFast";
            this.checkBoxFast.Size = new System.Drawing.Size(77, 17);
            this.checkBoxFast.TabIndex = 20;
            this.checkBoxFast.Text = "Fast Clicks";
            this.checkBoxFast.UseVisualStyleBackColor = true;
            this.checkBoxFast.CheckedChanged += new System.EventHandler(this.checkBoxFast_CheckedChanged);
            // 
            // WaterClicker
            // 
            this.AccessibleDescription = "a";
            this.AccessibleName = "a";
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonStop;
            this.ClientSize = new System.Drawing.Size(325, 191);
            this.Controls.Add(this.checkBoxFast);
            this.Controls.Add(this.labelClicks);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.checkBoxRand);
            this.Controls.Add(this.groupBoxRand);
            this.Controls.Add(this.groupBoxTime);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDownIteration);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "WaterClicker";
            this.Text = "WaterClicker";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMsec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIteration)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownRand2)).EndInit();
            this.groupBoxTime.ResumeLayout(false);
            this.groupBoxTime.PerformLayout();
            this.groupBoxRand.ResumeLayout(false);
            this.groupBoxRand.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.NumericUpDown numericUpDownMsec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownIteration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timerClick;
        private System.Windows.Forms.CheckBox checkBoxRand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownRand1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownRand2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBoxTime;
        private System.Windows.Forms.GroupBox groupBoxRand;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelClicks;
        private System.Windows.Forms.CheckBox checkBoxFast;
    }
}


using System.IO.Ports;

namespace Co2Regulation
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelStatus = new System.Windows.Forms.Label();
            this.chartseconds = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.LabAverage = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.serialPortArduino = new System.IO.Ports.SerialPort(this.components);
            this.numericUpDownppm = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labelmax = new System.Windows.Forms.Label();
            this.labelmin = new System.Windows.Forms.Label();
            this.labelarduino = new System.Windows.Forms.Label();
            this.LabelArduinoSet = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.setupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setupToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.chartseconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownppm)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(16, 49);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(75, 23);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(97, 49);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(75, 23);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "CO2 concentration (ppm)";
            // 
            // label2
            // 
            this.label2.AutoEllipsis = true;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 73);
            this.label2.TabIndex = 8;
            this.label2.Text = "0000";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // LabelStatus
            // 
            this.LabelStatus.AutoSize = true;
            this.LabelStatus.Location = new System.Drawing.Point(76, 86);
            this.LabelStatus.Name = "LabelStatus";
            this.LabelStatus.Size = new System.Drawing.Size(35, 13);
            this.LabelStatus.TabIndex = 9;
            this.LabelStatus.Text = "status";
            // 
            // chartseconds
            // 
            this.chartseconds.BackColor = System.Drawing.Color.Transparent;
            this.chartseconds.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.chartseconds.BackSecondaryColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chartseconds.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartseconds.Legends.Add(legend1);
            this.chartseconds.Location = new System.Drawing.Point(301, 10);
            this.chartseconds.Name = "chartseconds";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartseconds.Series.Add(series1);
            this.chartseconds.Size = new System.Drawing.Size(291, 300);
            this.chartseconds.TabIndex = 10;
            this.chartseconds.Text = "chartseconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(347, 373);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Average 30 readings";
            // 
            // LabAverage
            // 
            this.LabAverage.AutoSize = true;
            this.LabAverage.Location = new System.Drawing.Point(471, 373);
            this.LabAverage.Name = "LabAverage";
            this.LabAverage.Size = new System.Drawing.Size(40, 13);
            this.LabAverage.TabIndex = 13;
            this.LabAverage.Text = "-----------";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(79, 223);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Desired ppm in chamber";
            // 
            // numericUpDownppm
            // 
            this.numericUpDownppm.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownppm.Increment = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownppm.Location = new System.Drawing.Point(80, 239);
            this.numericUpDownppm.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.numericUpDownppm.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.numericUpDownppm.Name = "numericUpDownppm";
            this.numericUpDownppm.Size = new System.Drawing.Size(120, 38);
            this.numericUpDownppm.TabIndex = 25;
            this.numericUpDownppm.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(429, 335);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 29;
            this.label10.Text = "ppm MAX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(350, 335);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "ppm MIN";
            // 
            // labelmax
            // 
            this.labelmax.AutoSize = true;
            this.labelmax.Location = new System.Drawing.Point(429, 348);
            this.labelmax.Name = "labelmax";
            this.labelmax.Size = new System.Drawing.Size(25, 13);
            this.labelmax.TabIndex = 31;
            this.labelmax.Text = "------";
            // 
            // labelmin
            // 
            this.labelmin.AutoSize = true;
            this.labelmin.Location = new System.Drawing.Point(350, 348);
            this.labelmin.Name = "labelmin";
            this.labelmin.Size = new System.Drawing.Size(25, 13);
            this.labelmin.TabIndex = 32;
            this.labelmin.Text = "------";
            // 
            // labelarduino
            // 
            this.labelarduino.AutoSize = true;
            this.labelarduino.Location = new System.Drawing.Point(22, 373);
            this.labelarduino.Name = "labelarduino";
            this.labelarduino.Size = new System.Drawing.Size(133, 13);
            this.labelarduino.TabIndex = 37;
            this.labelarduino.Text = "Arduino control (max 4095)";
            // 
            // LabelArduinoSet
            // 
            this.LabelArduinoSet.AutoSize = true;
            this.LabelArduinoSet.Location = new System.Drawing.Point(22, 392);
            this.LabelArduinoSet.Name = "LabelArduinoSet";
            this.LabelArduinoSet.Size = new System.Drawing.Size(25, 13);
            this.LabelArduinoSet.TabIndex = 38;
            this.LabelArduinoSet.Text = "------";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(178, 49);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 39;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(604, 24);
            this.menuStrip1.TabIndex = 47;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // setupToolStripMenuItem
            // 
            this.setupToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setupToolStripMenuItem1,
            this.aboutToolStripMenuItem,
            this.programToolStripMenuItem});
            this.setupToolStripMenuItem.Name = "setupToolStripMenuItem";
            this.setupToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.setupToolStripMenuItem.Text = "Menu";
            // 
            // setupToolStripMenuItem1
            // 
            this.setupToolStripMenuItem1.Name = "setupToolStripMenuItem1";
            this.setupToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.setupToolStripMenuItem1.Text = "Setup";
            this.setupToolStripMenuItem1.Click += new System.EventHandler(this.setupToolStripMenuItem1_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.programToolStripMenuItem.Text = "Program";
            this.programToolStripMenuItem.Click += new System.EventHandler(this.programToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 431);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.LabelArduinoSet);
            this.Controls.Add(this.labelarduino);
            this.Controls.Add(this.labelmin);
            this.Controls.Add(this.labelmax);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numericUpDownppm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.LabAverage);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chartseconds);
            this.Controls.Add(this.LabelStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonStop);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CO2 control";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chartseconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownppm)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonStop;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelStatus;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartseconds;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabAverage;
        private System.Windows.Forms.Label label7;
     // private SerialDataReceivedEventHandler serialPortArduino_DataReceived;
     private SerialPort serialPortArduino;
        private System.Windows.Forms.NumericUpDown numericUpDownppm;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label labelmax;
        private System.Windows.Forms.Label labelmin;
        private System.Windows.Forms.Label labelarduino;
        private System.Windows.Forms.Label LabelArduinoSet;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setupToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
    }
}


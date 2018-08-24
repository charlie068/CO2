namespace Co2Regulation
{
    partial class Fsettings
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fileminset = new System.Windows.Forms.NumericUpDown();
            this.labelfile = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CheckTimeupdown = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.maxflow = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.pointsongraph = new System.Windows.Forms.NumericUpDown();
            this.bok = new System.Windows.Forms.Button();
            this.bcancel = new System.Windows.Forms.Button();
            this.radioExp = new System.Windows.Forms.RadioButton();
            this.radiolinear = new System.Windows.Forms.RadioButton();
            this.numupdownOffset = new System.Windows.Forms.NumericUpDown();
            this.labelOffset = new System.Windows.Forms.Label();
            this.numericUpDownmulti = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.fileminset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckTimeupdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxflow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsongraph)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownOffset)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmulti)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 56);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(292, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Arduino Port COM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "CO2 Probe COM";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(12, 96);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(292, 21);
            this.comboBox2.TabIndex = 18;
            // 
            // fileminset
            // 
            this.fileminset.Location = new System.Drawing.Point(167, 170);
            this.fileminset.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.fileminset.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.fileminset.Name = "fileminset";
            this.fileminset.Size = new System.Drawing.Size(120, 20);
            this.fileminset.TabIndex = 38;
            this.fileminset.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // labelfile
            // 
            this.labelfile.AutoSize = true;
            this.labelfile.Location = new System.Drawing.Point(164, 155);
            this.labelfile.Name = "labelfile";
            this.labelfile.Size = new System.Drawing.Size(124, 13);
            this.labelfile.TabIndex = 37;
            this.labelfile.Text = "Writing to file every x min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 148);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Checking Time (sec)";
            // 
            // CheckTimeupdown
            // 
            this.CheckTimeupdown.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CheckTimeupdown.Location = new System.Drawing.Point(14, 171);
            this.CheckTimeupdown.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.CheckTimeupdown.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.CheckTimeupdown.Name = "CheckTimeupdown";
            this.CheckTimeupdown.Size = new System.Drawing.Size(67, 20);
            this.CheckTimeupdown.TabIndex = 35;
            this.CheckTimeupdown.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(15, 209);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 13);
            this.label13.TabIndex = 47;
            this.label13.Text = "Max Flow (0-4095)";
            // 
            // maxflow
            // 
            this.maxflow.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.maxflow.Location = new System.Drawing.Point(17, 229);
            this.maxflow.Maximum = new decimal(new int[] {
            4095,
            0,
            0,
            0});
            this.maxflow.Name = "maxflow";
            this.maxflow.Size = new System.Drawing.Size(120, 20);
            this.maxflow.TabIndex = 46;
            this.maxflow.Value = new decimal(new int[] {
            2000,
            0,
            0,
            0});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(164, 213);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(82, 13);
            this.label12.TabIndex = 49;
            this.label12.Text = "points on Graph";
            // 
            // pointsongraph
            // 
            this.pointsongraph.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pointsongraph.Location = new System.Drawing.Point(167, 229);
            this.pointsongraph.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.pointsongraph.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.pointsongraph.Name = "pointsongraph";
            this.pointsongraph.Size = new System.Drawing.Size(51, 20);
            this.pointsongraph.TabIndex = 48;
            this.pointsongraph.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // bok
            // 
            this.bok.Location = new System.Drawing.Point(324, 12);
            this.bok.Name = "bok";
            this.bok.Size = new System.Drawing.Size(75, 23);
            this.bok.TabIndex = 50;
            this.bok.Text = "OK";
            this.bok.UseVisualStyleBackColor = true;
            this.bok.Click += new System.EventHandler(this.bok_Click);
            // 
            // bcancel
            // 
            this.bcancel.Location = new System.Drawing.Point(324, 42);
            this.bcancel.Name = "bcancel";
            this.bcancel.Size = new System.Drawing.Size(75, 23);
            this.bcancel.TabIndex = 51;
            this.bcancel.Text = "Cancel";
            this.bcancel.UseVisualStyleBackColor = true;
            this.bcancel.Click += new System.EventHandler(this.bcancel_Click);
            // 
            // radioExp
            // 
            this.radioExp.AutoSize = true;
            this.radioExp.Checked = true;
            this.radioExp.Location = new System.Drawing.Point(15, 268);
            this.radioExp.Name = "radioExp";
            this.radioExp.Size = new System.Drawing.Size(42, 17);
            this.radioExp.TabIndex = 57;
            this.radioExp.TabStop = true;
            this.radioExp.Text = "exp";
            this.radioExp.UseVisualStyleBackColor = true;
            this.radioExp.CheckedChanged += new System.EventHandler(this.radioExp_CheckedChanged);
            // 
            // radiolinear
            // 
            this.radiolinear.AutoSize = true;
            this.radiolinear.Location = new System.Drawing.Point(69, 268);
            this.radiolinear.Name = "radiolinear";
            this.radiolinear.Size = new System.Drawing.Size(50, 17);
            this.radiolinear.TabIndex = 56;
            this.radiolinear.Text = "linear";
            this.radiolinear.UseVisualStyleBackColor = true;
            this.radiolinear.CheckedChanged += new System.EventHandler(this.radiolinear_CheckedChanged);
            // 
            // numupdownOffset
            // 
            this.numupdownOffset.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numupdownOffset.Location = new System.Drawing.Point(18, 357);
            this.numupdownOffset.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numupdownOffset.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numupdownOffset.Name = "numupdownOffset";
            this.numupdownOffset.Size = new System.Drawing.Size(120, 20);
            this.numupdownOffset.TabIndex = 55;
            // 
            // labelOffset
            // 
            this.labelOffset.AutoSize = true;
            this.labelOffset.Location = new System.Drawing.Point(18, 336);
            this.labelOffset.Name = "labelOffset";
            this.labelOffset.Size = new System.Drawing.Size(35, 13);
            this.labelOffset.TabIndex = 54;
            this.labelOffset.Text = "Offset";
            // 
            // numericUpDownmulti
            // 
            this.numericUpDownmulti.DecimalPlaces = 6;
            this.numericUpDownmulti.Increment = new decimal(new int[] {
            1,
            0,
            0,
            196608});
            this.numericUpDownmulti.Location = new System.Drawing.Point(18, 312);
            this.numericUpDownmulti.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownmulti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            393216});
            this.numericUpDownmulti.Name = "numericUpDownmulti";
            this.numericUpDownmulti.Size = new System.Drawing.Size(120, 20);
            this.numericUpDownmulti.TabIndex = 53;
            this.numericUpDownmulti.Tag = "";
            this.numericUpDownmulti.Value = new decimal(new int[] {
            5,
            0,
            0,
            196608});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 298);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Multiplyier";
            // 
            // Fsettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 419);
            this.Controls.Add(this.radioExp);
            this.Controls.Add(this.radiolinear);
            this.Controls.Add(this.numupdownOffset);
            this.Controls.Add(this.labelOffset);
            this.Controls.Add(this.numericUpDownmulti);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.bcancel);
            this.Controls.Add(this.bok);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pointsongraph);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.maxflow);
            this.Controls.Add(this.fileminset);
            this.Controls.Add(this.labelfile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CheckTimeupdown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Fsettings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Fsettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fileminset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CheckTimeupdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maxflow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pointsongraph)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numupdownOffset)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownmulti)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.NumericUpDown fileminset;
        private System.Windows.Forms.Label labelfile;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown CheckTimeupdown;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown maxflow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown pointsongraph;
        private System.Windows.Forms.Button bok;
        private System.Windows.Forms.Button bcancel;
        private System.Windows.Forms.RadioButton radioExp;
        private System.Windows.Forms.RadioButton radiolinear;
        private System.Windows.Forms.NumericUpDown numupdownOffset;
        private System.Windows.Forms.Label labelOffset;
        private System.Windows.Forms.NumericUpDown numericUpDownmulti;
        private System.Windows.Forms.Label label9;
    }
}
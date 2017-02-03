namespace Air_Ballistic_Calc
{
    partial class ABMDCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMDCForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClickValue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.InfoView = new System.Windows.Forms.CheckBox();
            this.tbMRAD = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.clkDst = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.MRAD_Value = new System.Windows.Forms.TextBox();
            this.TotalClicks = new System.Windows.Forms.TextBox();
            this.MOA_Value = new System.Windows.Forms.TextBox();
            this.Sdvig_mm_value = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb7 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tb6 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tb5 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tb4 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.ShootingDistanceValue = new Air_Ballistic_Calc.ScrolledUpDownTextBox();
            this.ShootedZeroValue = new Air_Ballistic_Calc.ScrolledUpDownTextBox();
            this.ScopeAboveValue = new Air_Ballistic_Calc.ScrolledUpDownTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(312, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 336);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота прицела над стволом (мм):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дистанция пристрелки (м):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Расчетная дистанция (м):";
            // 
            // ClickValue
            // 
            this.ClickValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClickValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ClickValue.Location = new System.Drawing.Point(206, 121);
            this.ClickValue.Name = "ClickValue";
            this.ClickValue.Size = new System.Drawing.Size(93, 20);
            this.ClickValue.TabIndex = 7;
            this.ClickValue.Text = "0.238777459";
            this.ClickValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ClickValue.TextChanged += new System.EventHandler(this.ClickValue_TextChanged);
            this.ClickValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 123);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(156, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Цена деления 1 клика (MOA):";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(316, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // InfoView
            // 
            this.InfoView.AutoSize = true;
            this.InfoView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InfoView.Location = new System.Drawing.Point(575, 6);
            this.InfoView.Name = "InfoView";
            this.InfoView.Size = new System.Drawing.Size(70, 17);
            this.InfoView.TabIndex = 18;
            this.InfoView.Text = "Размеры";
            this.InfoView.UseVisualStyleBackColor = true;
            this.InfoView.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tbMRAD
            // 
            this.tbMRAD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tbMRAD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbMRAD.Location = new System.Drawing.Point(206, 140);
            this.tbMRAD.Name = "tbMRAD";
            this.tbMRAD.Size = new System.Drawing.Size(93, 20);
            this.tbMRAD.TabIndex = 8;
            this.tbMRAD.Text = "0";
            this.tbMRAD.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbMRAD.TextChanged += new System.EventHandler(this.tbMRAD_TextChanged);
            this.tbMRAD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 142);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(164, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Цена деления 1 клика (MRAD):";
            // 
            // clkDst
            // 
            this.clkDst.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clkDst.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.clkDst.Location = new System.Drawing.Point(206, 64);
            this.clkDst.Name = "clkDst";
            this.clkDst.Size = new System.Drawing.Size(93, 20);
            this.clkDst.TabIndex = 4;
            this.clkDst.Text = "91.44";
            this.clkDst.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clkDst.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(7, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "Расстояние цены деления клика (м):";
            // 
            // tb2
            // 
            this.tb2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb2.Location = new System.Drawing.Point(206, 102);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(93, 20);
            this.tb2.TabIndex = 6;
            this.tb2.Text = "0";
            this.tb2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb2.TextChanged += new System.EventHandler(this.tb2_TextChanged);
            this.tb2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 104);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(148, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Цена деления 1 клика (мм):";
            // 
            // tb1
            // 
            this.tb1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb1.Location = new System.Drawing.Point(206, 83);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(93, 20);
            this.tb1.TabIndex = 5;
            this.tb1.Text = "0";
            this.tb1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tb1.TextChanged += new System.EventHandler(this.tb1_TextChanged);
            this.tb1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(160, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Цена деления 1 клика (дюйм):";
            // 
            // MRAD_Value
            // 
            this.MRAD_Value.BackColor = System.Drawing.SystemColors.Control;
            this.MRAD_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MRAD_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MRAD_Value.ForeColor = System.Drawing.Color.Green;
            this.MRAD_Value.Location = new System.Drawing.Point(206, 323);
            this.MRAD_Value.Name = "MRAD_Value";
            this.MRAD_Value.ReadOnly = true;
            this.MRAD_Value.Size = new System.Drawing.Size(93, 20);
            this.MRAD_Value.TabIndex = 17;
            this.MRAD_Value.Text = "{0}";
            this.MRAD_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalClicks
            // 
            this.TotalClicks.BackColor = System.Drawing.SystemColors.Control;
            this.TotalClicks.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TotalClicks.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TotalClicks.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.TotalClicks.Location = new System.Drawing.Point(206, 304);
            this.TotalClicks.Name = "TotalClicks";
            this.TotalClicks.ReadOnly = true;
            this.TotalClicks.Size = new System.Drawing.Size(93, 20);
            this.TotalClicks.TabIndex = 16;
            this.TotalClicks.Text = "{0}";
            this.TotalClicks.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // MOA_Value
            // 
            this.MOA_Value.BackColor = System.Drawing.SystemColors.Control;
            this.MOA_Value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MOA_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MOA_Value.ForeColor = System.Drawing.Color.Red;
            this.MOA_Value.Location = new System.Drawing.Point(206, 285);
            this.MOA_Value.Name = "MOA_Value";
            this.MOA_Value.ReadOnly = true;
            this.MOA_Value.Size = new System.Drawing.Size(93, 20);
            this.MOA_Value.TabIndex = 15;
            this.MOA_Value.Text = "{0}";
            this.MOA_Value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // Sdvig_mm_value
            // 
            this.Sdvig_mm_value.BackColor = System.Drawing.SystemColors.Control;
            this.Sdvig_mm_value.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Sdvig_mm_value.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sdvig_mm_value.ForeColor = System.Drawing.Color.Blue;
            this.Sdvig_mm_value.Location = new System.Drawing.Point(206, 266);
            this.Sdvig_mm_value.Name = "Sdvig_mm_value";
            this.Sdvig_mm_value.ReadOnly = true;
            this.Sdvig_mm_value.Size = new System.Drawing.Size(93, 20);
            this.Sdvig_mm_value.TabIndex = 14;
            this.Sdvig_mm_value.Text = "{0}";
            this.Sdvig_mm_value.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 47;
            this.label6.Text = "Сдвиг (MRAD):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Кликов в ноль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 45;
            this.label5.Text = "Сдвиг (MOA):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Сдвиг (мм):";
            // 
            // tb7
            // 
            this.tb7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb7.Location = new System.Drawing.Point(206, 247);
            this.tb7.Name = "tb7";
            this.tb7.ReadOnly = true;
            this.tb7.Size = new System.Drawing.Size(93, 20);
            this.tb7.TabIndex = 13;
            this.tb7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(164, 13);
            this.label14.TabIndex = 42;
            this.label14.Text = "Цена деления 1 клика (MRAD):";
            // 
            // tb6
            // 
            this.tb6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb6.Location = new System.Drawing.Point(206, 228);
            this.tb6.Name = "tb6";
            this.tb6.ReadOnly = true;
            this.tb6.Size = new System.Drawing.Size(93, 20);
            this.tb6.TabIndex = 12;
            this.tb6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 230);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(156, 13);
            this.label15.TabIndex = 40;
            this.label15.Text = "Цена деления 1 клика (MOA):";
            // 
            // tb3
            // 
            this.tb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb3.Location = new System.Drawing.Point(206, 171);
            this.tb3.Name = "tb3";
            this.tb3.ReadOnly = true;
            this.tb3.Size = new System.Drawing.Size(93, 20);
            this.tb3.TabIndex = 9;
            this.tb3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 173);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(151, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Прицельное расстояние (м):";
            // 
            // tb5
            // 
            this.tb5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb5.Location = new System.Drawing.Point(206, 209);
            this.tb5.Name = "tb5";
            this.tb5.ReadOnly = true;
            this.tb5.Size = new System.Drawing.Size(93, 20);
            this.tb5.TabIndex = 11;
            this.tb5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 211);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(148, 13);
            this.label17.TabIndex = 36;
            this.label17.Text = "Цена деления 1 клика (мм):";
            // 
            // tb4
            // 
            this.tb4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb4.Location = new System.Drawing.Point(206, 190);
            this.tb4.Name = "tb4";
            this.tb4.ReadOnly = true;
            this.tb4.Size = new System.Drawing.Size(93, 20);
            this.tb4.TabIndex = 10;
            this.tb4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 192);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(160, 13);
            this.label18.TabIndex = 34;
            this.label18.Text = "Цена деления 1 клика (дюйм):";
            // 
            // ShootingDistanceValue
            // 
            this.ShootingDistanceValue.BackColor = System.Drawing.SystemColors.Window;
            this.ShootingDistanceValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShootingDistanceValue.Location = new System.Drawing.Point(206, 45);
            this.ShootingDistanceValue.Name = "ShootingDistanceValue";
            this.ShootingDistanceValue.Size = new System.Drawing.Size(93, 20);
            this.ShootingDistanceValue.TabIndex = 3;
            this.ShootingDistanceValue.Text = "30";
            this.ShootingDistanceValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ShootingDistanceValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // ShootedZeroValue
            // 
            this.ShootedZeroValue.BackColor = System.Drawing.SystemColors.Window;
            this.ShootedZeroValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ShootedZeroValue.Location = new System.Drawing.Point(206, 26);
            this.ShootedZeroValue.Name = "ShootedZeroValue";
            this.ShootedZeroValue.Size = new System.Drawing.Size(93, 20);
            this.ShootedZeroValue.TabIndex = 2;
            this.ShootedZeroValue.Text = "0";
            this.ShootedZeroValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ShootedZeroValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // ScopeAboveValue
            // 
            this.ScopeAboveValue.BackColor = System.Drawing.SystemColors.Window;
            this.ScopeAboveValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ScopeAboveValue.Location = new System.Drawing.Point(206, 7);
            this.ScopeAboveValue.Name = "ScopeAboveValue";
            this.ScopeAboveValue.Size = new System.Drawing.Size(93, 20);
            this.ScopeAboveValue.TabIndex = 1;
            this.ScopeAboveValue.Text = "50";
            this.ScopeAboveValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ScopeAboveValue.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // ABMDCForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 351);
            this.Controls.Add(this.MRAD_Value);
            this.Controls.Add(this.TotalClicks);
            this.Controls.Add(this.MOA_Value);
            this.Controls.Add(this.Sdvig_mm_value);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb7);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.tb6);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.tb3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.tb5);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tb4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tbMRAD);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.clkDst);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ShootingDistanceValue);
            this.Controls.Add(this.ClickValue);
            this.Controls.Add(this.ShootedZeroValue);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.InfoView);
            this.Controls.Add(this.ScopeAboveValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ABMDCForm";
            this.Text = "Air Ballistic Mil-Dot Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ABCForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ScrolledUpDownTextBox ScopeAboveValue;
        private ScrolledUpDownTextBox ShootedZeroValue;
        private ScrolledUpDownTextBox ShootingDistanceValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ClickValue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox InfoView;
        private System.Windows.Forms.TextBox tbMRAD;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox clkDst;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox MRAD_Value;
        private System.Windows.Forms.TextBox TotalClicks;
        private System.Windows.Forms.TextBox MOA_Value;
        private System.Windows.Forms.TextBox Sdvig_mm_value;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb7;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tb5;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb4;
        private System.Windows.Forms.Label label18;
    }
}


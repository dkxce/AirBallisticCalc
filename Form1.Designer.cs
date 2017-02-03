namespace Air_Ballistic_Calc
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.eH = new System.Windows.Forms.TextBox();
            this.eL = new System.Windows.Forms.TextBox();
            this.eD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.eC = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.vMM = new System.Windows.Forms.Label();
            this.vMOA = new System.Windows.Forms.Label();
            this.vMRAD = new System.Windows.Forms.Label();
            this.vCL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 110);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(336, 336);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Высота прицела над стволом (мм):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дистанция пристрелки (м):";
            // 
            // eH
            // 
            this.eH.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eH.Location = new System.Drawing.Point(284, 7);
            this.eH.Name = "eH";
            this.eH.Size = new System.Drawing.Size(64, 20);
            this.eH.TabIndex = 3;
            this.eH.Text = "50";
            this.eH.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // eL
            // 
            this.eL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eL.Location = new System.Drawing.Point(284, 32);
            this.eL.Name = "eL";
            this.eL.Size = new System.Drawing.Size(64, 20);
            this.eL.TabIndex = 4;
            this.eL.Text = "60";
            this.eL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // eD
            // 
            this.eD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eD.Location = new System.Drawing.Point(284, 58);
            this.eD.Name = "eD";
            this.eD.Size = new System.Drawing.Size(64, 20);
            this.eD.TabIndex = 6;
            this.eD.Text = "30";
            this.eD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Расчетная дистанция (м):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 462);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "mm:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 489);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "MOA:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(173, 489);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "MRAD:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(173, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Клики:";
            // 
            // eC
            // 
            this.eC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.eC.Location = new System.Drawing.Point(284, 84);
            this.eC.Name = "eC";
            this.eC.Size = new System.Drawing.Size(64, 20);
            this.eC.TabIndex = 12;
            this.eC.Text = "0.25";
            this.eC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.eH_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "1 click = (MOA):";
            // 
            // vMM
            // 
            this.vMM.AutoSize = true;
            this.vMM.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vMM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.vMM.Location = new System.Drawing.Point(91, 462);
            this.vMM.Name = "vMM";
            this.vMM.Size = new System.Drawing.Size(24, 13);
            this.vMM.TabIndex = 13;
            this.vMM.Text = "{0}";
            // 
            // vMOA
            // 
            this.vMOA.AutoSize = true;
            this.vMOA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vMOA.ForeColor = System.Drawing.Color.Red;
            this.vMOA.Location = new System.Drawing.Point(91, 489);
            this.vMOA.Name = "vMOA";
            this.vMOA.Size = new System.Drawing.Size(24, 13);
            this.vMOA.TabIndex = 14;
            this.vMOA.Text = "{0}";
            // 
            // vMRAD
            // 
            this.vMRAD.AutoSize = true;
            this.vMRAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vMRAD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.vMRAD.Location = new System.Drawing.Point(264, 489);
            this.vMRAD.Name = "vMRAD";
            this.vMRAD.Size = new System.Drawing.Size(24, 13);
            this.vMRAD.TabIndex = 16;
            this.vMRAD.Text = "{0}";
            // 
            // vCL
            // 
            this.vCL.AutoSize = true;
            this.vCL.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.vCL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.vCL.Location = new System.Drawing.Point(264, 462);
            this.vCL.Name = "vCL";
            this.vCL.Size = new System.Drawing.Size(24, 13);
            this.vCL.TabIndex = 15;
            this.vCL.Text = "{0}";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(140, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 515);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.vMRAD);
            this.Controls.Add(this.vCL);
            this.Controls.Add(this.vMOA);
            this.Controls.Add(this.vMM);
            this.Controls.Add(this.eC);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.eD);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.eL);
            this.Controls.Add(this.eH);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Air Ballistic Calc";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox eH;
        private System.Windows.Forms.TextBox eL;
        private System.Windows.Forms.TextBox eD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox eC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label vMM;
        private System.Windows.Forms.Label vMOA;
        private System.Windows.Forms.Label vMRAD;
        private System.Windows.Forms.Label vCL;
        private System.Windows.Forms.Button button1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Air_Ballistic_Calc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double milsc = 24;

            Bitmap bmp = (Bitmap)global::Air_Ballistic_Calc.Properties.Resources.Scope.Clone();

            double _eH = double.Parse(eH.Text);
            double _eL = double.Parse(eL.Text);
            double _eD = double.Parse(eD.Text);
            double _eC = 0;
            if (!double.TryParse(eC.Text, out _eC))
                _eC = double.Parse(eC.Text.Replace(".", ","));
            
            double tan = _eH / _eL;
            double _ch = _eH - tan * _eD;

            vMM.Text = _ch.ToString("0.0").Replace(",", "."); 

            double _cMRAD = _ch / _eD;

            vMRAD.Text = _cMRAD.ToString("0.000").Replace(",", "."); ;

            double _cMOA = _cMRAD * 3.4377;

            vMOA.Text = _cMOA.ToString("0.000").Replace(",", "."); ;

            double _cCL = _cMOA / _eC;

            vCL.Text = _cCL.ToString("0.0").Replace(",",".");

            Bitmap lok = (Bitmap)global::Air_Ballistic_Calc.Properties.Resources.Lock;
            Graphics g = Graphics.FromImage(bmp);
            try
            {
                g.DrawImage(lok, new Point(153, 153 - (int)Math.Round(_cMRAD * milsc)));
            }
            catch { };
            g.DrawImage((Bitmap)global::Air_Ballistic_Calc.Properties.Resources.CLR, new Point(0, 0));
            g.Dispose();

            pictureBox1.Image = bmp;

            double tmp_MIL = -2;
            double HM = 1 / (tmp_MIL / _eH + 1 / _eL);
            Text = HM.ToString("0.000");
        }

        private void eH_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void eH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) button1_Click(sender, null);
        }
    }
}
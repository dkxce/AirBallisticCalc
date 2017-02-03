using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Win32;

namespace Air_Ballistic_Calc
{
    public partial class ABMDCForm : Form
    {
        private System.Globalization.CultureInfo ci;
        private System.Globalization.NumberFormatInfo ni;

        public ABMDCForm()
        {
            ci = System.Globalization.CultureInfo.InstalledUICulture;
            ni = (System.Globalization.NumberFormatInfo)ci.NumberFormat.Clone();
            ni.NumberDecimalSeparator = ".";

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {            
            try
            {
                RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\ABMDCFormData", false);
                ScopeAboveValue.Text = (string)reg.GetValue("ScopeAbove");
                ShootedZeroValue.Text = (string)reg.GetValue("ShootedZeroValue");
                ShootingDistanceValue.Text = (string)reg.GetValue("ShootingDistanceValue");
                ClickValue.Text = (string)reg.GetValue("ClickValue");
                InfoView.Checked = (string)reg.GetValue("InfoView") == "True";
                clkDst.Text = (string)reg.GetValue("ClickDistance");
                reg.Close();
            }
            catch { };

            ClickValueLoad();
            button1_Click(sender, e);
        }        
        private Font f = new Font("Arial", 10);
        private Brush br = new SolidBrush(Color.Maroon);
        private Brush bb = new SolidBrush(Color.Navy);

        private void button1_Click(object sender, EventArgs e)
        {
            const double milsc = 24;
            
            Bitmap bmp = (Bitmap)(InfoView.Checked ? global::Air_Ballistic_Calc.Properties.Resources.ScopeD.Clone() : global::Air_Ballistic_Calc.Properties.Resources.Scope.Clone());

            if (ScopeAboveValue.Text == "") ScopeAboveValue.Text = "0";
            if (ShootedZeroValue.Text == "") ShootedZeroValue.Text = "0";
            if (ShootingDistanceValue.Text == "") ShootingDistanceValue.Text = "0";
            if (ClickValue.Text == "") ClickValue.Text = "0";

            double _ScopeAbove = double.Parse(ScopeAboveValue.Text, ni);
            double _ShootedZeroDist = double.Parse(ShootedZeroValue.Text, ni);
            if (_ShootedZeroDist == 0) _ShootedZeroDist = double.MaxValue;
            double _ShootingDist = double.Parse(ShootingDistanceValue.Text, ni);
            double _ClickValue = double.Parse(ClickValue.Text, ni);
            
            double tan = _ScopeAbove / _ShootedZeroDist;
            double sdvig = _ScopeAbove - tan * _ShootingDist;
            double mil = sdvig / _ShootingDist;
            double moa = mil * 3.4377;
            double clicks_count = moa / _ClickValue;

            Sdvig_mm_value.Text = sdvig.ToString("0.0", ni);
            MRAD_Value.Text = mil.ToString("0.000", ni);            
            MOA_Value.Text = moa.ToString("0.000", ni);            
            TotalClicks.Text = clicks_count.ToString("0.0").Replace(",",".");

            Bitmap lok = (Bitmap)global::Air_Ballistic_Calc.Properties.Resources.Lock;
            Graphics g = Graphics.FromImage(bmp);
            try
            {
                g.DrawImage(lok, new Point(153, 153 - (int)Math.Round(mil * milsc)));
            }
            catch { };
            g.DrawImage((Bitmap)global::Air_Ballistic_Calc.Properties.Resources.CLR, new Point(0, 0));            

            for (int n = -5; n < 6; n++ )
            {
                if (n == 0) n++;
                double mrd = _ScopeAbove / (n + tan);
                if ((mrd > 0) && (!double.IsInfinity(mrd)))
                {
                    string str = mrd.ToString("0.0",ni);
                    int tw = (int)g.MeasureString(str, f).Width;

                    int no = Math.Abs(n);
                    if (mrd > _ShootedZeroDist)
                    {
                        no *= -1;
                        g.DrawString(str, f, bb, new PointF((float)156 - tw, (float)(163 - Math.Round(no * milsc))));
                    }
                    else
                    {
                        g.DrawString(str, f, br, new PointF((float)176, (float)(163 - Math.Round(no * milsc))));
                    };
                };
            };

            g.Dispose();
            pictureBox1.Image = bmp;

            // CALC OTHER //
            
            tb3.Text = _ShootingDist.ToString(ni);

            double tmp = double.Parse(tb1.Text, ni) / double.Parse(clkDst.Text, ni) * _ShootingDist;
            tb4.Text = tmp.ToString(ni);
            tmp = tmp * 25.4;
            tb5.Text = tmp.ToString(ni);
            tmp = tmp / 25.4 / 1.047;
            tb6.Text = tmp.ToString(ni);
            tmp = tmp / 3.4377;
            tb7.Text = tmp.ToString(ni);
        }

        private void eH_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.PageDown) || (e.KeyCode == Keys.PageUp) || (e.KeyCode == Keys.Down) || (e.KeyCode == Keys.Up)) 
                button1_Click(sender, null);            
        }

        private void ABCForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Registry.CurrentUser.CreateSubKey(@"SOFTWARE\ABMDCFormData");
            RegistryKey reg = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\ABMDCFormData", true);
            reg.SetValue("ScopeAbove", ScopeAboveValue.Text);
            reg.SetValue("ShootedZeroValue", ShootedZeroValue.Text);
            reg.SetValue("ShootingDistanceValue", ShootingDistanceValue.Text);
            reg.SetValue("ClickValue", ClickValue.Text);
            reg.SetValue("InfoView", InfoView.Checked);
            reg.SetValue("ClickDistance", clkDst.Text);
            reg.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            if (!tb1.Focused) return;

            double _ClickValue = 0;
            try
            {
                _ClickValue = double.Parse(tb1.Text, ni);
            }
            catch { };
            ClickValue.Text = (_ClickValue / 1.047).ToString(ni);
            tb2.Text = (_ClickValue * 25.4).ToString(ni);
            tbMRAD.Text = (_ClickValue / 1.047 / 3.4377).ToString(ni);
        }

        private void tb2_TextChanged(object sender, EventArgs e)
        {
            if (!tb2.Focused) return;
            
            double _ClickValue = 0;
            try
            {
                _ClickValue = double.Parse(tb2.Text, ni);
            }
            catch { };
            ClickValue.Text = (_ClickValue / 25.4 / 1.047).ToString(ni);
            tb1.Text = (_ClickValue / 25.4).ToString(ni);
            tbMRAD.Text = (_ClickValue / 25.4 / 1.047 / 3.4377).ToString(ni);
        }

        private void ClickValue_TextChanged(object sender, EventArgs e)
        {
            if (!ClickValue.Focused) return;
            ClickValueLoad();
        }

        private void ClickValueLoad()
        {
            double _ClickValue = 0;
            try
            {
                _ClickValue = double.Parse(ClickValue.Text, ni);
            }
            catch { };
            tb1.Text = (_ClickValue * 1.047).ToString(ni);
            tb2.Text = (_ClickValue * 1.047 * 25.4).ToString(ni);
            tbMRAD.Text = (_ClickValue / 3.4377).ToString(ni);
        }

        private void tbMRAD_TextChanged(object sender, EventArgs e)
        {
            if (!tbMRAD.Focused) return;

            double _ClickValue = 0;
            try
            {
                _ClickValue = double.Parse(tbMRAD.Text, ni);
            }
            catch { };
            ClickValue.Text = (_ClickValue * 3.4377).ToString(ni);
            tb1.Text = (_ClickValue * 3.4377 * 1.047).ToString(ni);
            tb2.Text = (_ClickValue * 3.4377 * 1.047 * 25.4).ToString(ni);
        }
    }
}
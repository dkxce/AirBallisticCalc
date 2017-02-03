using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Air_Ballistic_Calc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new ABMDCForm());
        }
    }

    public class ScrolledUpDownTextBox : TextBox
    {
        private const int WM_HSCROLL = 0x114;
        private const int WM_VSCROLL = 0x115;
        private const int WM_MOUSEWHEEL = 0x20A;

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            
            if (m.Msg == WM_VSCROLL || m.Msg == WM_HSCROLL || m.Msg == WM_MOUSEWHEEL)
            {
                if (m.WParam.ToInt32() > 0)
                {
                    this.OnKeyDown(new KeyEventArgs(Keys.Up));
                }
                else
                {
                    this.OnKeyDown(new KeyEventArgs(Keys.Down)); 
                };
            };
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {            
            System.Globalization.CultureInfo ci = System.Globalization.CultureInfo.InstalledUICulture;
            System.Globalization.NumberFormatInfo ni = (System.Globalization.NumberFormatInfo)ci.NumberFormat.Clone();
            ni.NumberDecimalSeparator = ".";

            if (e.KeyCode == Keys.Down)
            {
                double d = double.Parse(this.Text, ni);
                d -= 1;
                if (d < 0) d = 0;
                this.Text = d.ToString(ni);
            };
            if (e.KeyCode == Keys.Up)
            {
                double d = double.Parse(this.Text, ni);
                d += 1;                
                this.Text = d.ToString(ni);
            };
            if (e.KeyCode == Keys.PageDown)
            {
                double d = double.Parse(this.Text, ni);
                d -= 5;
                if (d < 0) d = 0;
                this.Text = d.ToString(ni);
            };
            if (e.KeyCode == Keys.PageUp)
            {
                double d = double.Parse(this.Text, ni);
                d += 5;
                this.Text = d.ToString(ni);
            };

            base.OnKeyDown(e);
        }

    }
}
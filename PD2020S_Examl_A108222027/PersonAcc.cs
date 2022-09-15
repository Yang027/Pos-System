using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD2020S_Examl_A108222027
{
    public partial class PersonAcc : Form
    {
        UserControl us;
        UserControl rec;
        string filename = string.Empty;
        Account nowacc;
        bool _darkmode;
        public PersonAcc(string FN, Account nowAccount)
        {
            InitializeComponent();
            this.CenterToScreen();
            tmrtime.Start();
            _darkmode = true;
            us = new selfmanage(FN, nowAccount);
            us.Location = new Point(132, 35);
            this.Controls.Add(us);
            filename = FN;
            nowacc = nowAccount;
        }

        private void btnproductmanagement_Click(object sender, EventArgs e)
        {
            us.BringToFront();
            pnlaccount.Visible = true;
            pnlrec.Visible = false;
        }
        private void btnsalerec_Click(object sender, EventArgs e)
        {
            rec = new ability(filename, nowacc);
            if (ability.rec == true)
            {
                rec.Location = new Point(132, 35);
                this.Controls.Add(rec);
                rec.BringToFront(); pnlrec.Visible = true;
                pnlaccount.Visible = false;
            }
            else
            {
                us.BringToFront();
                pnlaccount.Visible = true;
                pnlrec.Visible = false;
            }
        }

        private void tmrtime_Tick(object sender, EventArgs e)
        {
            DateTime ss = new DateTime();
            ss = DateTime.Now;
            lbltime.Text = ss.ToShortTimeString();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void moving(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, Win32.WM_STSSCOMMAND, Win32.SC_MOVE + Win32.HTPCAPTION, 0);
        }

        private void btnminizm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

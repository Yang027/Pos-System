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
    public partial class empolyeesystem : Form
    {
        UserControl emp; string accountFile = Application.StartupPath + "//..//..//data//account.bin";
        public empolyeesystem(Account account)
        {
            InitializeComponent();
            emp = new empolyeemanagement(account);
            tmrtime.Start();
            this.CenterToScreen();
            emp.Location = new Point(0, 36);
            this.Controls.Add(emp);
            emp.BringToFront();

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

        private void save(object sender, FormClosingEventArgs e)
        {
            RWaccount.binarysaveAcc(accountFile, empolyeemanagement.accountlist);
        }

        private void moving(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, Win32.WM_STSSCOMMAND, Win32.SC_MOVE + Win32.HTPCAPTION, 0);
        }
    }
}

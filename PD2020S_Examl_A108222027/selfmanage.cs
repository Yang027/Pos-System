using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD2020S_Examl_A108222027
{
    public partial class selfmanage : UserControl
    {
        List<Account> accountlist = new List<Account>();
        Account nowaccount;
        string accountfilepath = Application.StartupPath + "..//..//..//data//account.bin";
        public selfmanage(string FN, Account nowAccount)
        {
            InitializeComponent(); initalsetting(FN, nowAccount);
        }
        void initalsetting(string FN, Account acc)
        {
            tbxacc.FocusTextColor = tbxcheckpass.FocusTextColor = tbxname.FocusTextColor = tbxpass.FocusTextColor = Color.White;
            tbxacc.UnfocusTextColor = tbxcheckpass.UnfocusTextColor = tbxname.UnfocusTextColor = tbxpass.UnfocusTextColor = Color.White;
            tbxacc.Text = acc.account;
            tbxpass.Text = acc.password.ToString();
            tbxcheckpass.Text = acc.password.ToString();
            tbxname.Text = acc.Name;
            nowaccount = new Account(acc);
            // accountlist = RWaccount.readaccount();
            accountlist = RWaccount.readbinaryAcc(accountfilepath);
            for (int i = 0; i < accountlist.Count; i++)
            {
                if (accountlist[i].account.Equals(tbxacc.Text))
                {
                    index = i;
                }
            }
            pbxhead.Image = accountlist[index].Head;
        }
        int index = -1;
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (CheckData.checkData(tbxpass.Text) == true && tbxcheckpass.Text.Equals(tbxpass.Text) && tbxpass.Text != null)
            {
                accountlist[index].password = tbxpass.Text;
                accountlist[index].Name = tbxname.Text;
                RWaccount.binarysaveAcc(accountfilepath, accountlist);
                MessageBox.Show("Update successfully!");
            }
            else { MessageBox.Show("兩次密碼輸入格式不正確!"); }
        }

        private void pbxhead_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxhead.Image = new Bitmap(ofd.FileName);
                pbxhead.SizeMode = PictureBoxSizeMode.StretchImage;
                accountlist[index].Head = (Bitmap)pbxhead.Image;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            accountlist[index].Head = null;
            pbxhead.Image = accountlist[index].Head;
        }
    }
}

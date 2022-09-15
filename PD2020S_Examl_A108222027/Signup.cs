using PD2020S_Examl_A108222027.Properties;
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
    public partial class Signup : Form
    {
        string accountFile = Application.StartupPath + "..//..//..//data//account.bin"; List<Account> accountList;
        bool accok;
        bool passok;
        bool checkok;
        bool nameok;
        public Signup()
        {
            InitializeComponent();
            this.CenterToScreen();
            this.AutoSize = true;
            this.FormBorderStyle = FormBorderStyle.None;
            // accountList = RWaccount.readaccount(); 
            accountList = RWaccount.readbinaryAcc(accountFile);
            pbxaccount.Visible = pbxcheck.Visible = pbxname.Visible = pbxpassword.Visible = false;
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void checkacc(object sender, EventArgs e)
        {
            pbxaccount.Visible = pbxcheck.Visible = pbxname.Visible = pbxpassword.Visible = true;
            bool repeat = false;
            if (tbxacc.Text != tbxacc.BottomUnFocus)
            {
                pbxaccount.Visible = true;
                foreach (Account acc in accountList)
                {
                    if (acc.account == tbxacc.Text)
                    {

                        repeat = true;
                        break;
                    }
                }
                if (repeat == true)
                {
                    pbxaccount.Image = imlist.Images[1];
                    accok = false;
                    lblwarnac.Visible = true;
                    lblwarnac.Text = "賬號重複！";
                }
                else
                {
                    if (CheckData.checkData(tbxacc.Text) == true)
                    {
                        pbxaccount.Image = imlist.Images[0];
                        lblwarnac.Visible = false;
                        accok = true;
                    }
                    else
                    {
                        pbxaccount.Image = imlist.Images[1];
                        lblwarnac.Visible = true;
                        lblwarnac.Text = "賬號有非法字元或未滿4位";
                        accok = false; //break?
                    }
                }

            }
            if (tbxpass.Text != tbxpass.BottomUnFocus)
            {
                if (CheckData.checkData(tbxpass.Text) == true)
                {
                    pbxpassword.Image = imlist.Images[0];
                    lblwarmpas.Visible = false;
                    passok = true;
                }
                else
                {
                    pbxpassword.Image = imlist.Images[1];
                    lblwarmpas.Visible = true;
                    lblwarmpas.Text = "密碼有非法字元或未滿4位";
                    passok = false;
                }
            }
            if (tbxcheckpass.Text != tbxcheckpass.BottomUnFocus)
            {
                if (CheckData.checkData(tbxpass.Text) == true && tbxpass.Text == tbxcheckpass.Text.Trim())
                {
                    pbxcheck.Image = imlist.Images[0];
                    checkok = true;
                    lblwarmcheck.Visible = false;
                }
                else
                {
                    pbxcheck.Image = imlist.Images[1];
                    checkok = false;
                    lblwarmcheck.Text = "兩次密碼輸入不一樣！";
                    lblwarmcheck.Visible = true;
                }

            }
            if (tbxname.Text != tbxname.BottomUnFocus)
            {
                if (tbxname.Text.Trim() != "" && CheckData.checkData(tbxname.Text) == true)
                {
                    pbxname.Image = imlist.Images[0];
                    nameok = true;
                    lblwarmname.Visible = false;
                }
                else
                {
                    pbxname.Image = imlist.Images[1];
                    lblwarmname.Text = "名字有非法字元！";
                    lblwarmname.Visible = true;
                    nameok = false;
                }
            }
        }
        Account acc;
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            if (accok == true && passok == true && checkok == true && nameok && tbxacc.Text != tbxacc.BottomUnFocus)
            {
                acc = new Account(tbxacc.Text, tbxpass.Text, AccountLevel.Guest, tbxname.Text);
                acc.Head = (Bitmap)pbxhead.Image;
                accountList.Add(acc);
                RWaccount.binarysaveAcc(accountFile, accountList);
                MessageBox.Show("註冊成功！");
                this.Close();
            }
            else { MessageBox.Show("填寫資料有誤！"); }
        }

        private void pbxheadselect_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxhead.Image = new Bitmap(ofd.FileName);
                pbxhead.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            pbxhead.Image = Resources.headd;
        }

        private void moving(object sender, MouseEventArgs e)
        {
            Win32.ReleaseCapture();
            Win32.SendMessage(this.Handle, Win32.WM_STSSCOMMAND, Win32.SC_MOVE + Win32.HTPCAPTION, 0);
        }
    }
}

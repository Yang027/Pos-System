//Date:2020/5/4
//Author:Yang
//Project:Pos_MainEntrance
using MySql.Data.MySqlClient;
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
    public partial class frmMainEntrance : Form
    {
        List<Account> accountList;//= null;
        public static Account nowAccount { get; set; }//= null;b 
        string accountFile = Application.StartupPath + "..//..//..//data//account.bin";
        RoundedButton employeemanagement = new RoundedButton();
        RoundedButton Accountmaintance = new RoundedButton();
        RoundedButton ordering = new RoundedButton();
        RoundedButton storemanagement = new RoundedButton();
        public static AccountLevel nowlevel { get; set; }
        /// <summary>
        /// define database varible
        //string dbUser = "root";
        //string dbPassword = "";
        //string dbName = "db2021f_pos4finalproject";
        /// </summary>

        public frmMainEntrance()
        {
            InitializeComponent();

            tbxaccount.FocusTextColor = tbxpassword.FocusTextColor = Color.Black;
            initalSetting();
            adjust_image();
            roundbutton_inital();
            tbxaccount.Text = "Account";
            tbxpassword.Text = "Password";
            // dbConnect(dbUser, dbPassword, dbName);
        }
        void initalSetting()
        {
            StartPosition = FormStartPosition.CenterScreen;
            pbxlogo.Visible = true;
            storemanagement.Enabled = Accountmaintance.Enabled = lblsignout.Enabled =
             ordering.Enabled = employeemanagement.Enabled = Accountmaintance.Visible = employeemanagement.Visible = storemanagement.Visible = ordering.Visible = false;
            pbxacc.Visible = pbxpass.Visible = tbxaccount.Visible = tbxpassword.Visible = btnsubmit.Visible = true;
            tbxaccount.Text = tbxpassword.Text = "";
            lblviewmenu.Visible = lblviewmenu.Enabled = true;
            lbl.Visible = true;
            lblsignup.Visible = true;
            this.BackColor = Color.White;
            this.BackgroundImage = null;
            btnminizm.Visible = true;
            lblsignout.Visible = false;
            pbxblack.Visible = true;
            lbluser.Visible = false;
            btnexit.Visible = true;
            int index = -1;
            pbxuser.Visible = false;
            pbxuser.Image = null;
            try
            {
                do
                {
                    index++;
                } while (accountList[index].account != frmMainEntrance.nowAccount.account);
                accountList[index].logout = DateTime.Now.ToString();
                // RWaccount.binarysaveAcc(accountFile, accountList);
            }
            catch { Application.Exit(); }
            accountList = null; nowAccount = null;
        }
        void adjust_image()
        {
            try
            {
                pbxlogo.BackColor = Color.FromArgb(255, 195, 14, 14);
                storemanagement.Font = ordering.Font = employeemanagement.Font = Accountmaintance.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei UI"), 10.0F);
            }
            catch (Exception ee) { MessageBox.Show("" + ee); }
        }
        void roundbutton_inital()
        {
            Accountmaintance.Text = "賬號管理";
            Accountmaintance.Click += new EventHandler(btnaccountmaintence_Click);
            Accountmaintance.Location = new Point(50, 2);
            Accountmaintance.Size = new Size(140, 80);
            Accountmaintance.Cursor = Cursors.Hand;
            var ac = Resources.ResourceManager.GetObject("selfacc");
            Accountmaintance.BackgroundImage = (Image)ac;
            Accountmaintance.BackColor = Color.Transparent;
            Accountmaintance.BackgroundImageLayout = ImageLayout.Zoom;
            Accountmaintance.BackColor = Color.Transparent;
            Accountmaintance.TextAlign = ContentAlignment.BottomCenter;
            this.Controls.Add(Accountmaintance);

            employeemanagement.Text = "員工管理";
            employeemanagement.Click += new EventHandler(btnemployee_Click);
            employeemanagement.Location = new Point(50, 102);
            employeemanagement.Size = new Size(140, 80);
            employeemanagement.Cursor = Cursors.Hand;
            employeemanagement.BackColor = Color.Transparent;
            var ep = Resources.ResourceManager.GetObject("employeeman");
            employeemanagement.BackgroundImage = (Bitmap)ep;
            employeemanagement.BackgroundImageLayout = ImageLayout.Zoom;
            employeemanagement.TextAlign = ContentAlignment.BottomCenter;
            employeemanagement.BackColor = Color.Transparent;
            this.Controls.Add(employeemanagement);

            ordering.Text = "點餐系統";
            ordering.Click += new EventHandler(btnorder_Click);
            ordering.Location = new Point(50, 200);
            ordering.Size = new Size(140, 80);
            ordering.Cursor = Cursors.Hand;
            ordering.BackColor = Color.Transparent;
            var od = Resources.ResourceManager.GetObject("ordernormal");
            ordering.BackgroundImage = (Image)od;
            ordering.BackgroundImageLayout = ImageLayout.Zoom;
            ordering.TextAlign = ContentAlignment.BottomCenter;
            ordering.BackColor = Color.Transparent;
            this.Controls.Add(ordering);
            //size(200,120)
            storemanagement.Text = "店鋪管理";
            storemanagement.Click += new EventHandler(btnmanage_Click);
            storemanagement.Location = new Point(50, 296);
            storemanagement.Size = new Size(140, 80);
            storemanagement.Cursor = Cursors.Hand;
            storemanagement.BackColor = Color.Transparent;
            var sm = Resources.ResourceManager.GetObject("storemanage");
            storemanagement.BackgroundImage = (Image)sm;
            storemanagement.BackgroundImageLayout = ImageLayout.Zoom;
            storemanagement.BackColor = Color.Transparent;
            storemanagement.TextAlign = ContentAlignment.BottomCenter;
            this.Controls.Add(storemanagement);
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            submit();
        }
        //送出密碼的動作method
        Account acc = null;
        void submit()
        {
            if (tbxaccount.Text != "")
            {
                if (accountList == null)
                {
                    accountList = new List<Account>();
                    //accountList= RWaccount.readaccount();
                    accountList = RWaccount.readbinaryAcc(accountFile);
                }
                if (CheckData.checkAccount(accountList, tbxaccount.Text.Trim(), tbxpassword.Text, out acc))
                {
                    nowAccount = acc;
                    Accountmaintance.Visible = employeemanagement.Visible = storemanagement.Visible = ordering.Visible = true;
                    switch (nowAccount.level)
                    {
                        case AccountLevel.Admin:
                            storemanagement.Enabled = true;
                            Accountmaintance.Enabled = true;
                            ordering.Enabled = true;
                            employeemanagement.Enabled = true;
                            break;
                        case AccountLevel.Owner:
                            storemanagement.Enabled = false;
                            storemanagement.Visible = false;
                            Accountmaintance.Enabled = true;
                            ordering.Enabled = true;
                            employeemanagement.Enabled = true;
                            break;
                        case AccountLevel.Worker:
                            storemanagement.Enabled = false;
                            Accountmaintance.Enabled = true;
                            storemanagement.Visible = false;
                            ordering.Enabled = true;
                            employeemanagement.Visible = false;
                            employeemanagement.Enabled = false;
                            break;
                        case AccountLevel.Guest:
                            employeemanagement.Visible = false;
                            storemanagement.Visible = false;
                            storemanagement.Enabled = false;
                            Accountmaintance.Enabled = true;
                            ordering.Enabled = true;
                            employeemanagement.Enabled = false;
                            break;
                    }
                    nowlevel = nowAccount.level;
                    pbxacc.Visible = pbxpass.Visible = tbxaccount.Visible = tbxpassword.Visible = btnsubmit.Visible = false;
                    lblsignout.Enabled = true;
                    Accountmaintance.Focus();
                    lblsignout.Visible = true;
                    lblviewmenu.Visible = lblviewmenu.Enabled = false;
                    pbxlogo.Visible = false;
                    btnminizm.Visible = false;
                    pbxblack.Visible = false;
                    lblsignup.Visible = false;
                    this.BackgroundImageLayout = ImageLayout.Center;
                    var im = Resources.shutterstock_1036017343;
                    this.BackgroundImage = (Image)im;
                    lbluser.Text = nowAccount.Name;
                    lbluser.ForeColor = Color.Blue;
                    lbluser.Font = new Font(new FontFamily("Microsoft JhengHei UI"), 12.0F);
                    lbluser.BackColor = Color.Transparent;
                    lbluser.Visible = true; pbxuser.Visible = true;
                    lbl.Visible = false;
                    btnexit.Visible = false;
                    lbltipp.Visible = false;
                    int index = -1;
                    do
                    { index++; }
                    while (accountList[index].account != nowAccount.account);
                    accountList[index].login = DateTime.Now.ToString();
                    RWaccount.binarysaveAcc("..//..//data//account.bin", accountList);
                    pbxuser.Image = (Image)accountList[index].Head;
                    pbxuser.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbxuser.Size = new Size(30, 30);
                    pbxuser.Location = new Point(lbluser.Location.X - 30, 0);
                    pbxuser.BackColor = Color.Transparent;
                }
                else
                {
                    bool flag = true;
                    foreach (var a in accountList)
                    {
                        if (tbxaccount.Text.Trim() == a.account)
                        { flag = false; break; }
                    }
                    if (flag == true)
                    {
                        MessageBox.Show("賬號錯誤");
                    }
                    else { MessageBox.Show("密碼錯誤"); tbxpassword.Text = ""; }
                }
            }
            else { MessageBox.Show("賬號不能為空！"); }
        }
        private void btnaccountmaintence_Click(object sender, EventArgs e)
        {
            //人員修改密碼
            //frmAccountMaintence ss = new frmAccountMaintence(accountFile, nowAccount);
            // ss.ShowDialog();
            PersonAcc pa = new PersonAcc(accountFile, nowAccount); pa.ShowDialog();
            //修改完密碼更新狀態
            List<Account> tempaccount = new List<Account>();
            //  tempaccount = RWaccount.readbinaryAcc(accountFile);
            for (int i = 0; i < tempaccount.Count; i++)
            {
                if (tempaccount[i].account.Equals(nowAccount.account))
                {
                    nowAccount = tempaccount[i];
                    pbxuser.Image = tempaccount[i].Head;
                    lbluser.Text = tempaccount[i].Name;
                }
            }
        }
        private void btnemployee_Click(object sender, EventArgs e)
        {
            empolyeesystem ee = new empolyeesystem(nowAccount);
            // frmAccountManagement ss = new frmAccountManagement(accountFile);
            ee.ShowDialog();
        }
        private void lblsignout_Click(object sender, EventArgs e)
        {
            //accountList = RWaccount.readaccount();
            accountList = RWaccount.readbinaryAcc(accountFile);
            int index = -1;
            do
            {
                index++;
            } while (accountList[index].account != nowAccount.account);
            accountList[index].logout = DateTime.Now.ToString();
            RWaccount.binarysaveAcc(accountFile, accountList); 
            initalSetting();
        }
        private void btnorder_Click(object sender, EventArgs e)
        {
            order_select os = new order_select(nowAccount);
            os.ShowDialog();
        }
        private void datetime_Tick(object sender, EventArgs e)
        {
            DateTime ss = new DateTime();
            ss = DateTime.Now;
            lblsignup.Text = ss.ToLocalTime().ToString();
        }
        private void btnmanage_Click(object sender, EventArgs e)
        {
            //StoreMangement ss = new StoreMangement();
            //ss.ShowDialog();
            StoreManage ss = new StoreManage();
            ss.ShowDialog();
        }
        List<object> ob = new List<object>();
        private void lbllogin_Click(object sender, EventArgs e)
        {
            Signup ss = new Signup();
            ss.ShowDialog();
        }
        private void lblviewmenu_Click(object sender, EventArgs e)
        {
            Browser_menu bb = new Browser_menu();
            bb.ShowDialog();
        }
        private void enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                submit();
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
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
        private void showicon(object sender, EventArgs e)
        {
            try
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    notifyIcon1.Visible = false;
                }
                else if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Hide();
                    notifyIcon1.Visible = true;
                }
            }
            catch (Exception ee) { MessageBox.Show(ee.Message); }
        }
        private void showtip(object sender, MouseEventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void showapp(object sender, EventArgs e)
        {
            showtip(null, null);
        }

        private void closeapp(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

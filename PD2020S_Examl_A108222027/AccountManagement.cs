//Date:2020/5/4
//Author:Yang
//Project:Pos_AccountManagement
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
    public partial class frmAccountManagement : Form
    {
        //only admin can  modify the level of employee
        List<Account> accountlist;
        string accountFile = "";
        int selectindex;
        int index;
        string FilePath = Application.StartupPath + "..//..//..//data//account.bin";
        List<Transaction> bill = new List<Transaction>();
        DataGridViewRowCollection row;
        public frmAccountManagement(string FN)
        {
            InitializeComponent();
            initalsetting(FN);
            row = dgvaccount.Rows; adjust_image();
            this.CenterToScreen();
        }
        void initalsetting(string FN)
        {
            accountFile = FN;
            //RWaccount.readAccount(accountFile, out accountlist);
            accountlist = RWaccount.readbinaryAcc(accountFile);
            cbxlevel.SelectedIndex = 2;
            display();
        }
        void adjust_image()
        {
            try
            {
                pbxlogo.BackColor = Color.FromArgb(255, 195, 14, 14);
            }
            catch (Exception ee) { MessageBox.Show("" + ee); }
        }
        void display()
        {
            lbxAccountlist.Items.Clear();
            for (int i = 0; i < accountlist.Count; i++)
            {
                lbxAccountlist.Items.Add($"{accountlist[i].account},{accountlist[i].password},{accountlist[i].level},{accountlist[i].Name} ");
            }
        }
        bool checklegal(string temp)
        {
            bool flag = true;
            if (temp.Length >= 4 && temp.Length < 12)
            {
                foreach (var p in temp)
                {
                    if (!char.IsLetterOrDigit(p))
                    {
                        flag = false; break;
                    }
                }
            }
            return flag;
        }
        private void btninsert_Click_1(object sender, EventArgs e)
        {
            bool checkuniq = false;
            string[] temp = new string[accountlist.Count];
            for (int i = 0; i < accountlist.Count; i++)
            {
                temp[i] = accountlist[i].account;
            }
            foreach (var ss in temp)
            {
                if (tbxacc.Text == ss)
                { checkuniq = true; break; }
            }
            if (checkuniq == false)
            {
                if (checklegal(tbxpss.Text.Trim()))
                {
                    accountlist.Add(new Account(tbxacc.Text, tbxpss.Text, (AccountLevel)Enum.Parse(typeof(AccountLevel), cbxlevel.Items[cbxlevel.SelectedIndex].ToString(), false), tbxname.Text));
                    tbxacc.Text = tbxpss.Text = tbxname.Text = "";
                    display();
                }
                else { MessageBox.Show(@"密碼必須4位以上，不能有非法資源(ex:.,#/\?><)"); }
            }

            else
            {
                MessageBox.Show("名字重複了！");
            }
        }
        private void btnModify_Click_1(object sender, EventArgs e)
        {
            if (checklegal(tbxpss.Text) == true && tbxpss.Text != null)
            {
                try
                {
                    accountlist[lbxAccountlist.SelectedIndex].account = tbxacc.Text;
                    accountlist[lbxAccountlist.SelectedIndex].Name = tbxname.Text;
                    accountlist[lbxAccountlist.SelectedIndex].password = tbxpss.Text;
                    accountlist[lbxAccountlist.SelectedIndex].level = (AccountLevel)Enum.Parse(typeof(AccountLevel), cbxlevel.Items[cbxlevel.SelectedIndex].ToString(), false);
                    display();
                }
                catch (Exception ee) { MessageBox.Show("" + ee); }
            }
            else { MessageBox.Show(@"密碼必須4位以上，不能有非法資源(ex:.,#/\?><)"); }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (RWaccount.binarysaveAcc(FilePath, accountlist) == true)
            { RWaccount.binarysaveAcc(FilePath, accountlist); MessageBox.Show("save Successful"); }
            else { MessageBox.Show("Error!"); }
        }
        private void btndelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                accountlist.Remove(accountlist[selectindex]); display();
            }
            catch { }
            tbxacc.Text = tbxname.Text = tbxpss.Text = "";
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void itemchange(object sender, EventArgs e)
        {
            try
            {
                int index = int.Parse(lbxAccountlist.SelectedIndex.ToString());
                selectindex = int.Parse(lbxAccountlist.SelectedIndex.ToString());
                string[] temp = lbxAccountlist.Items[index].ToString().Split(',');
                tbxacc.Text = temp[0];
                tbxpss.Text = temp[1];
                cbxlevel.Text = temp[2];
                tbxname.Text = temp[3];
            }
            catch { }
        }
        private void load(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 1:
                    dgvaccount.Columns.Clear();
                    dgvaccount.Columns.Add("", "Account");
                    dgvaccount.Columns.Add("", "Password");
                    dgvaccount.Columns.Add("", "Level");
                    dgvaccount.Columns.Add("", "Name");
                    dgvaccount.RowHeadersVisible = false;
                    dgvaccount.Columns[0].Width = 110;
                    dgvaccount.Columns[1].Width = 50;
                    dgvaccount.Columns[2].Width = 70;
                    dgvaccount.Columns[3].Width = 100;
                    if (tabControl1.SelectedIndex == 1)
                    {
                        for (int i = 0; i < accountlist.Count; i++)
                        {
                            row.Add(new object[] { accountlist[i].account, accountlist[i].password, accountlist[i].level, accountlist[i].Name });//,new object[] { pInfo[cbxchoice.SelectedIndex].item[i].price });//,{pInfo[cbxchoice.SelectedIndex].item[i].price}" }        
                        }
                    }
                    dgvaccount.ClearSelection(); break;
                case 2:
                    page3(); break;
            }
            tbxname.Text = tbxacc.Text = cbxdtpower.Text = tbxpss.Text = "";
        }
        int[] sale;
        void page3()
        {
            bill = IOTransaction.readtranaction(Application.StartupPath + "..//..//..//data//Transaction.bin");
            sale = new int[accountlist.Count];
            for (int i = 0; i < accountlist.Count; i++)
            {
                for (int j = 0; j < bill.Count; j++)
                {
                    if (accountlist[i].Name.Equals(bill[j].cashier))
                    {
                        sale[i] += 1;
                    }
                }
            }
            DataTable dt = new DataTable();
            dt.Columns.Add("員工姓名");
            dt.Columns.Add("售出訂單");
            dt.Columns.Add("上線時間");
            dt.Columns.Add("離線時間");
            dt.Columns.Add("登錄時長");
            TimeSpan ts = new TimeSpan();
            TimeSpan chaju = new TimeSpan();
            for (int i = 0; i < accountlist.Count; i++)
            {
                if (accountlist[i].login != null)
                {
                    try
                    {
                        if (accountlist[i].logout != null)
                        {
                            ts = DateTime.Now - DateTime.Parse(accountlist[i].logout);
                            chaju = DateTime.Parse(accountlist[i].logout) - DateTime.Parse(accountlist[i].login);
                            if (chaju.TotalSeconds > 0)
                            {
                                dt.Rows.Add(accountlist[i].Name, sale[i], accountlist[i].logout, ts.TotalDays > 1 ? ts.TotalDays.ToString("n0") + "天前在線" : ts.TotalMinutes > 60 ? ts.TotalHours.ToString("n0") + "小時前在線" : ts.TotalSeconds > 60 ? ts.TotalMinutes.ToString("n0") + "分鐘前在線" : ts.TotalSeconds.ToString("n0") + "秒前在線", chaju.TotalMinutes > 60 ? "上缐時長" + chaju.TotalHours.ToString("n0") + "小時" : chaju.TotalSeconds > 60 ? "上缐時長" + chaju.TotalMinutes.ToString("n0") + "分鐘" : "上缐時長" + chaju.TotalSeconds.ToString("n0") + "秒");
                            }
                            else
                            {                              
                                dt.Rows.Add(accountlist[i].Name, sale[i], accountlist[i].logout, ts.TotalDays > 1 ? ts.TotalDays.ToString("n0") + "天前在線" : ts.TotalMinutes > 60 ? ts.TotalHours.ToString("n0") + "小時前在線" : ts.TotalSeconds > 60 ? ts.TotalMinutes.ToString("n0") + "分鐘前在線" : ts.TotalSeconds.ToString("n0") + "秒前在線", "Online");
                            }
                        }
                        else
                        {
                            dt.Rows.Add(accountlist[i].Name, sale[i], accountlist[i].logout, ts.TotalDays > 1 ? ts.TotalDays.ToString("n0") + "天前在線" : ts.TotalMinutes > 60 ? ts.TotalHours.ToString("n0") + "小時前在線" : ts.TotalSeconds > 60 ? ts.TotalMinutes.ToString("n0") + "分鐘前在線" : ts.TotalSeconds.ToString("n0") + "秒前在線", "");
                        }
                    }
                    catch { }
                }
                else
                {
                    dt.Rows.Add(accountlist[i].Name, sale[i], "從未登錄", "從未登錄", "從未登錄");
                }
            }
            DataGridView dgv = new DataGridView();
            dgv.DataSource = dt;
            tabPage3.Controls.Add(dgv);
            dgv.Width = 6000;
            dgv.Height = 300;
            dgv.Columns[0].Width = 80;
            dgv.Columns[1].Width = 80;
            dgv.Columns[2].Width = 178;
            dgv.Columns[3].Width = 100;
            dgv.Columns[4].Width = 130;
            dgv.AllowUserToAddRows = dgv.AllowUserToDeleteRows = dgv.AllowUserToOrderColumns = dgv.AllowUserToResizeColumns = dgv.AllowUserToResizeRows = false;
            dgv.ReadOnly = true;
            dgv.BackgroundColor = Color.AliceBlue;
            dgv.RowHeadersVisible = false; dgv.ColumnHeadersHeight = 40;
            dgv.ClearSelection();
        }
        private void select(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tbxdtacc.Text = dgvaccount.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxdtpass.Text = dgvaccount.Rows[e.RowIndex].Cells[1].Value.ToString();
                cbxdtpower.Text = dgvaccount.Rows[e.RowIndex].Cells[2].Value.ToString();
                tbxdtname.Text = dgvaccount.Rows[e.RowIndex].Cells[3].Value.ToString();
                index = e.RowIndex;
            }
            catch { }
        }

        private void btndtinsert_Click(object sender, EventArgs e)
        {
            bool checkuniq = false;
            string[] temp = new string[accountlist.Count];
            for (int i = 0; i < accountlist.Count; i++)
            {
                temp[i] = accountlist[i].account;
            }
            foreach (var ss in temp)
            {
                if (tbxdtacc.Text == ss)
                {
                    checkuniq = true; break;
                }
            }
            if (checkuniq == false)
            {
                if (checklegal(tbxdtpass.Text.Trim()))
                {
                    row.Add(new object[] { tbxdtacc.Text, tbxdtpass.Text, cbxdtpower.SelectedItem.ToString(), tbxdtname.Text });
                    accountlist.Add(new Account(tbxdtacc.Text, tbxdtpass.Text, (AccountLevel)Enum.Parse(typeof(AccountLevel), cbxdtpower.SelectedItem.ToString(), false), tbxdtname.Text));
                    tbxdtacc.Text = tbxdtname.Text = tbxdtpass.Text = "";
                    cbxdtpower.Text = "";
                }
                else { MessageBox.Show(@"密碼必須4位以上，不能有非法資源(ex:.,#/\?><)"); }
            }
            else
            {
                MessageBox.Show("名字重複了！");
            }
        }
        private void btndtdel_Click(object sender, EventArgs e)
        {
            try
            {
                row.Remove(dgvaccount.Rows[index]);
                tbxdtacc.Text = tbxdtname.Text = tbxdtpass.Text = "";
                cbxdtpower.Text = "";
            }
            catch { MessageBox.Show(@"密碼必須4位以上，不能有非法資源(ex:.,#/\?><)"); }
        }
        private void btndtmodif_Click(object sender, EventArgs e)
        {
            dgvaccount.Rows[index].Cells[0].Value = tbxdtacc.Text;
            dgvaccount.Rows[index].Cells[1].Value = tbxdtpass.Text;
            dgvaccount.Rows[index].Cells[2].Value = cbxdtpower.Text;
            dgvaccount.Rows[index].Cells[3].Value = tbxdtname.Text;
            accountlist[index] = new Account(tbxdtacc.Text, tbxdtpass.Text, (AccountLevel)Enum.Parse(typeof(AccountLevel), cbxdtpower.SelectedItem.ToString(), false), tbxdtname.Text);
            tbxdtacc.Text = tbxdtname.Text = tbxdtpass.Text = "";
            cbxdtpower.Text = "";
        }
        private void btndtupdate_Click(object sender, EventArgs e)
        {
            if (RWaccount.binarysaveAcc(FilePath, accountlist) == true)
            {
                RWaccount.binarysaveAcc(FilePath, accountlist); MessageBox.Show("save Successful");
                accountlist = RWaccount.readbinaryAcc(accountFile);
                display();
            }
            else { MessageBox.Show("Error!"); }
        }
    }
}

//Date:2020/5/4
//Author:Yang
//Project:Pos_AccountMaintence
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
    public partial class frmAccountMaintence : Form
    {
        string filepath;
        Account nowaccount;
        bool changepass;
        List<Transaction> bill = new List<Transaction>();
        List<Account> accountlist = new List<Account>();
        string Filepath = Application.StartupPath + "..//..//..//data//Transaction.bin";
        string accountfilepath = Application.StartupPath + "..//..//..//data//account.bin";
        public frmAccountMaintence(string FN, Account nowAccount)
        {
            filepath = "";
            InitializeComponent();
            initalsetting(FN, nowAccount);
            tbxpass.Focus(); adjust_image();
            accountlist = RWaccount.readbinaryAcc(accountfilepath);
            this.CenterToScreen();

        }
        void adjust_image()
        {
            try
            {
                pbxlogo.BackColor = Color.FromArgb(255, 195, 14, 14);
                btnexit.Font = btnupdate.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei UI"), 12.0F);
            }
            catch (Exception ee) { MessageBox.Show("" + ee); }
        }
        void initalsetting(string FN, Account acc)
        {
            changepass = false;
            tbxacc.Text = acc.account;
            tbxlevel.Text = acc.level.ToString();
            tbxpass.Text = acc.password.ToString();
            tbxcheckpass.Text = acc.password.ToString();
            filepath = FN;
            tbxname.Text = acc.Name;
            nowaccount = new Account(acc);
        }
        List<string> temp;
        int judge()
        {
            temp = new List<string>();
            int count = -1;
            for (int i = 0; i < bill.Count; i++)
            {
                if (bill[i].cashier.Equals(nowaccount.Name))
                {
                    temp.Add(bill[i].cashier);                
                }
            }
            count = temp.Count;
            return count;
        }
        void display_transaction()
        {          
            dgvtransaction.Cursor = Cursors.Hand;
            dgvtransaction.Columns.Clear();
            dgvtransaction.Columns.Add("", "Date");
            dgvtransaction.Columns.Add("", "Crashier");
            dgvtransaction.Columns.Add("", "Total");
            for (int i = 0; i < bill.Count; i++)
            {
                if (bill[i].cashier.Equals(nowaccount.Name))
                {      
                    dgvtransaction.Rows.Add(bill[i].now, bill[i].cashier, bill[i].sum);
                }
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBoxButtons messButton = MessageBoxButtons.OKCancel;
            if (changepass ==false)
            {this.Close(); }
            else
            {
                DialogResult dr = MessageBox.Show("Are u sure exit without save?", "Warn!", messButton);
                if (dr == DialogResult.OK)
                {
                    this.Close();
                }
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (CheckData.checkData(tbxpass.Text) == true && tbxcheckpass.Text.Equals(tbxpass.Text) && tbxpass.Text != null)
            {
                for (int i = 0; i < accountlist.Count; i++)
                {       
                    if (accountlist[i].account.Equals(tbxacc.Text))
                    {
                        accountlist[i].password = tbxpass.Text;
                        accountlist[i].level =(AccountLevel)Enum.Parse(typeof(AccountLevel), tbxlevel.Text,false);
                        accountlist[i].Name = tbxname.Text;
                    }
                }
                RWaccount.binarysaveAcc(accountfilepath, accountlist);
                MessageBox.Show("Update successfully!");
                changepass = true;
            }
            else { MessageBox.Show("兩次密碼輸入格式不正確!"); }
            this.Close();
        }
        int transindex;
        private void select(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                transindex = e.RowIndex;
                tbxhang.Text = bill[transindex].Hangout == true ? "外帶" : "內用";
                tbxdate.Text = dgvtransaction.Rows[transindex].Cells[0].Value.ToString();
                tbxsum.Text = dgvtransaction.Rows[transindex].Cells[2].Value.ToString();
                DataTable detail = new DataTable();
                detail.Columns.Add("Item");
                detail.Columns.Add("AddOnitem");
                detail.Columns.Add("Option");
                detail.Columns.Add("price");
                detail.Columns.Add("times");
                detail.Columns.Add("subtotal");
                string op = "";
                string add = "";
                for (int j = 0; j < bill[transindex].details.Count; j++)
                {
                    op = add = "";
                    if (bill[transindex].details[j].add.Count > 0)
                    {
                        for (int i = 0; i < bill[transindex].details[j].add.Count; i++)
                        {
                            add += bill[transindex].details[j].add[i].ToString();
                        }
                    }
                    if (bill[transindex].details[j].op.Count > 0)
                    {
                        for (int i = 0; i < bill[transindex].details[j].op.Count; i++)
                        {
                            op += bill[transindex].details[j].op[i].ToString();
                        }
                    }
                    if (add == "")
                    { add = "未加點"; }
                    if (op == "") { op = "未加點"; }
                    detail.Rows.Add(bill[transindex].details[j].name + " $" + bill[transindex].details[j].price, add, op, bill[transindex].details[j].price, bill[transindex].details[j].time, bill[transindex].details[j].total);
                }
                dgvdetail.DataSource = detail;
                dgvdetail.Columns[0].Width = 150;
                dgvdetail.Columns[1].Width = 130;
                dgvdetail.Columns[2].Width = 110;
                dgvdetail.Columns[3].Width = 50;
                dgvdetail.Columns[4].Width = 30;
                dgvdetail.Columns[5].Width = 80;
                dgvdetail.Height = 200;
                dgvdetail.RowHeadersVisible = false;
            }
            catch { }
        }

        private void change(object sender, EventArgs e)
        {
            bill = new List<Transaction>();
            bill = IOTransaction.readtranaction(Filepath);
            if (judge() > 0)
            {
                display_transaction();
            }
            else
            {
                tabPage2.Controls.Clear();
                Label lbl = new Label();
                lbl.Text = "您尚未有交易記錄！";
                lbl.Font = new Font(new FontFamily("Microsoft JhengHei UI"), 12.0F);
                lbl.AutoSize = true;
                lbl.ForeColor = Color.Gray;
                lbl.Location = new Point(tabPage2.Width / 3, tabPage2.Height / 2);
                tabPage2.Controls.Add(lbl);
            }
        }
    }
}

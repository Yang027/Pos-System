using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PD2020S_Examl_A108222027.Properties;

namespace PD2020S_Examl_A108222027
{
    public partial class adjustemployee : UserControl
    {
        //Admin, Owner, Worker, Guest
        //  (AccountLevel)Enum.Parse(typeof(AccountLevel), contentAccount[2].Trim(), false)
        string accountFile = Application.StartupPath + "//..//..//data//account.bin";
        List<Account> accountlist; int index;
        string initialpath = Application.StartupPath + "..//..//..//data";
        Account lastpage;
        List<Transaction> bill;
        public adjustemployee(Account acc,Account xx)
        {
            lastpage = xx;
            InitializeComponent();
            // accountlist = RWaccount.readaccount();
            accountlist=RWaccount.readbinaryAcc(accountFile);
            tbxacc.Text = acc.account;
            tbxname.Text = acc.Name;
            pbxhead.Image = acc.Head;
            cbxlevel.Items.Clear();
            cbxlevel.Items.Add("Admin");
            cbxlevel.Items.Add("Owner");
            cbxlevel.Items.Add("Worker");
            cbxlevel.Items.Add("Guest");     
            int ind = -1;
            do
            {
                ind++;
            }
            while (cbxlevel.Items[ind].ToString() != acc.level.ToString());
            cbxlevel.SelectedItem = cbxlevel.Items[ind];
            index = -1;
            do
            {
                index++;
            ;
            }
            while (accountlist[index].account !=acc.account); time();
            bill = new List<Transaction>();
            bill = IOTransaction.readtranaction(initialpath + "//Transaction.bin");
            display_transaction();
        }
        private void pbxback_Click_1(object sender, EventArgs e)
        {
            UserControl usc = new empolyeemanagement(lastpage);
            this.Controls.Add(usc);
            usc.BringToFront();
        }
        void display_transaction()
        {
            dgvdetail.Columns.Clear();
            dgvtransaction.Cursor = Cursors.Hand;
            dgvtransaction.Columns.Clear();
            dgvtransaction.Columns.Add("", "Date");
            dgvtransaction.Columns.Add("", "Crashier");
            dgvtransaction.Columns.Add("", "Total");
            dgvtransaction.RowHeadersVisible = false;
            for (int i = 0; i < bill.Count; i++)
            {
                if (bill[i].cashier.Equals(accountlist[index].Name))
                {
                    dgvtransaction.Rows.Add(bill[i].now, bill[i].cashier, bill[i].sum);
                }
            }
            if (dgvtransaction.Rows.Count < 1)
            {
                MessageBox.Show("該員工并未有交易記錄！");
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            bool ok = false;
            if (CheckData.checkData(tbxacc.Text) == true)
            {
                ok = true;
                accountlist[index].account = tbxacc.Text;
            }
            accountlist[index].Name = tbxname.Text;
            accountlist[index].level = (AccountLevel)Enum.Parse(typeof(AccountLevel), cbxlevel.SelectedItem.ToString());
            if (ok == true)
            {
                RWaccount.binarysaveAcc(accountFile, accountlist);
                MessageBox.Show("Update successfully!");
            }
            else { MessageBox.Show("Error Account Format"); }
        }

        private void pbxheadselect_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pbxhead.Image = new Bitmap(ofd.FileName);
                pbxhead.SizeMode = PictureBoxSizeMode.StretchImage;
                accountlist[index].Head = (Bitmap)pbxhead.Image;
            }
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            accountlist[index].Head = null;
            pbxhead.Image = accountlist[index].Head;
        }
        int transindex;
        private void expand(object sender, DataGridViewCellMouseEventArgs e)
        {
            transindex = e.RowIndex;
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
            dgvdetail.Columns[2].Width = 130;
            dgvdetail.Columns[3].Width = 50;
            dgvdetail.Columns[4].Width = 50;
            dgvdetail.Columns[5].Width = 80;
            dgvdetail.Height = 200;
            //dgvdetail.Visible = true;
            //lbldetail.Visible = true;
        }
        void time()
        {
            TimeSpan chaju = new TimeSpan();
            tbxdate.Text = "上次在線時長:";
            if (accountlist[index].login != null)
            {
                try
                {
                    if (accountlist[index].logout != null)
                    {
                        chaju = DateTime.Parse(accountlist[index].logout) - DateTime.Parse(accountlist[index].login);

                        tbxdate.Text += chaju.TotalMinutes > 60 ? "上缐時長" + chaju.TotalHours.ToString("n0") + "小時" : chaju.TotalSeconds > 60 ? "上缐時長" + chaju.TotalMinutes.ToString("n0") + "分鐘" : chaju.TotalSeconds >0? "上缐時長" + chaju.TotalSeconds.ToString("n0") + "秒":"Online";
                    }
                    else
                    {
                        tbxdate.Text += "從未上線";
                    }
                }
                catch { tbxdate.Text += "錯誤退出"; }
            }
            else
            {
                tbxdate.Text += "從未上線";
            }

        }
    }
}

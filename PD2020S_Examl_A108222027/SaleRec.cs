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
    public partial class SaleRec : UserControl
    {
        string initialpath = Application.StartupPath + "..//..//..//data";
        List<Transaction> bill;
        bool query=false;
        public SaleRec()
        {
            InitializeComponent();
            bill = new List<Transaction>();
            bill = IOTransaction.readtranaction(initialpath + "//Transaction.bin");

            //int id = 0;
            //for(int i=0;i<bill.Count;i++)
            //{
            //    bill[i].td_id = id;
            //    id += 1;
            //}
            //IOTransaction.savetransaction(initialpath + "//Transaction.bin", bill); MessageBox.Show("save successfully!");
             display_transaction();
        }
        void display_transaction()
        {
            DateTime range = datetimepick.Value;
            dgvdetail.Columns.Clear();
            dgvdetail.Visible = false;
            lbldetail.Visible = false;
            tbxcashier.Text = tbxdate.Text = tbxhang.Text = tbxsum.Text = "";
            dgvtransaction.Cursor = Cursors.Hand;
            dgvtransaction.Columns.Clear();
            dgvtransaction.Columns.Add("", "Date");
            dgvtransaction.Columns.Add("", "Crashier");
            dgvtransaction.Columns.Add("", "Total");
            if (query == true)
            {
                for (int i = 0; i < bill.Count; i++)
                {
                    if (range.Date.Equals(bill[i].now.Date))
                    {
                        dgvtransaction.Rows.Add(bill[i].now, bill[i].cashier, bill[i].sum);
                    }
                }
            }
            else
            {
                for (int i = 0; i < bill.Count; i++)
                {
                    dgvtransaction.Rows.Add(bill[i].now, bill[i].cashier, bill[i].sum);
                }
            }
            if (dgvtransaction.Rows.Count < 1)
            {
                MessageBox.Show("該日期并未有交易記錄！");
            }
            query = false;
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            if (bill.Count > 0)
            {
                query = true;
                display_transaction();
            }
            else { MessageBox.Show("請先讀取交易記錄"); }
        }

        private void btnall_Click(object sender, EventArgs e)
        {
            display_transaction();
        }
        int transindex;
        private void expand(object sender, DataGridViewCellMouseEventArgs e)
        {
            int index = -1;
            transindex = e.RowIndex;
            do { index++; } while (dgvtransaction.Rows[transindex].Cells[0].Value.ToString() != bill[index].now.ToString());
          //  MessageBox.Show("" + bill[transindex].Hangout);
            tbxhang.Text = bill[index].Hangout == true ? "外帶" : "內用";
            tbxcashier.Text = dgvtransaction.Rows[transindex].Cells[1].Value.ToString();
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
            dgvdetail.Columns[2].Width = 130;
            dgvdetail.Columns[3].Width = 50;
            dgvdetail.Columns[4].Width = 50;
            dgvdetail.Columns[5].Width = 80;
            dgvdetail.Height = 200;
            dgvdetail.Visible = true;
            lbldetail.Visible = true;
        }

        private void cbxhangout_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxhangout.Checked == true)
            {
                DateTime range = datetimepick.Value;
                dgvdetail.Columns.Clear();
                dgvdetail.Visible = false;
                lbldetail.Visible = false;
                tbxcashier.Text = tbxdate.Text = tbxhang.Text = tbxsum.Text = "";
                dgvtransaction.Cursor = Cursors.Hand;
                dgvtransaction.Columns.Clear();
                dgvtransaction.Columns.Add("", "Date");
                dgvtransaction.Columns.Add("", "Crashier");
                dgvtransaction.Columns.Add("", "Total");
                if (query == true)
                {
                    for (int i = 0; i < bill.Count; i++)
                    {
                        if (range.Date.Equals(bill[i].now.Date))
                        {
                            if (bill[i].Hangout == true)
                            {
                                dgvtransaction.Rows.Add(bill[i].now, bill[i].cashier, bill[i].sum);
                            }
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < bill.Count; i++)
                    {
                        if (bill[i].Hangout == true)
                        {
                            dgvtransaction.Rows.Add(bill[i].now, bill[i].cashier, bill[i].sum);
                        }
                    }
                }
                if (dgvtransaction.Rows.Count < 1)
                {
                    MessageBox.Show("該日期并未有交易記錄！");
                }
                query = false;
            }
            else { display_transaction(); }
        }
    }
}

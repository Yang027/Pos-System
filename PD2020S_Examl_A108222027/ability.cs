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
    public partial class ability : UserControl
    {
        public static bool rec { get; set; }
        Account nowaccount;
        List<Transaction> bill = new List<Transaction>();
        List<Account> accountlist = new List<Account>();
        string Filepath = Application.StartupPath + "..//..//..//data//Transaction.bin";
        string accountfilepath = Application.StartupPath + "..//..//..//data//account.bin";
        public ability(string FN, Account nowAccount)
        {
            InitializeComponent();
            rec = true;
            bill = new List<Transaction>();
            nowaccount = nowAccount;
            bill = IOTransaction.readtranaction(Filepath);
            if (judge() > 0)
            {
                display_transaction();
            }
            else
            {                 
                MessageBox.Show("您尚未有交易記錄！");
                this.Controls.Clear();
                rec = false;
            }
            tbxhang.UnfocusTextColor = 
            tbxdate.UnfocusTextColor=tbxsum.UnfocusTextColor=tbxdate.FocusTextColor=tbxhang.FocusTextColor=tbxsum.FocusTextColor= Color.White;
        }
        List<Transaction> trans = new List<Transaction>();
        void display_transaction()
        {
            trans = new List<Transaction>();
            dgvtransaction.Cursor = Cursors.Hand;
            dgvtransaction.Columns.Clear();
            dgvtransaction.Columns.Add("", "Date");
            dgvtransaction.Columns.Add("", "Crashier");
            dgvtransaction.Columns.Add("", "Total"); 
            for (int i = 0; i < bill.Count; i++)
            {
                if (bill[i].cashier==nowaccount.Name)
                {
                    trans.Add(bill[i]);
                }
            }
            foreach(var tt in trans)
            {
                dgvtransaction.Rows.Add(tt.now, tt.cashier, tt.sum);
            }
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
        private void select(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                tbxhang.Text = trans[e.RowIndex].Hangout == true ? "外帶" : "內用";
                tbxdate.Text = dgvtransaction.Rows[e.RowIndex].Cells[0].Value.ToString();
                tbxsum.Text = dgvtransaction.Rows[e.RowIndex].Cells[2].Value.ToString();
                DataTable detail = new DataTable();
                detail.Columns.Add("Item");
                detail.Columns.Add("AddOnitem");
                detail.Columns.Add("Option");
                detail.Columns.Add("price");
                detail.Columns.Add("times");
                detail.Columns.Add("subtotal");
                string op = "";
                string add = "";
                for (int j = 0; j < trans[e.RowIndex].details.Count; j++)
                {
                    op = add = "";
                    if (trans[e.RowIndex].details[j].add.Count > 0)
                    {
                        for (int i = 0; i < trans[e.RowIndex].details[j].add.Count; i++)
                        {
                            add += trans[e.RowIndex].details[j].add[i].ToString();
                        }
                    }
                    if (trans[e.RowIndex].details[j].op.Count > 0)
                    {
                        for (int i = 0; i < trans[e.RowIndex].details[j].op.Count; i++)
                        {
                            op += trans[e.RowIndex].details[j].op[i].ToString();
                        }
                    }
                    if (add == "")
                    { add = "未加點"; }
                    if (op == "") { op = "未加點"; }
                    detail.Rows.Add(trans[e.RowIndex].details[j].name, add, op,trans[e.RowIndex].details[j].price, trans[e.RowIndex].details[j].time, trans[e.RowIndex].details[j].total);
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
            catch(Exception ee) { MessageBox.Show(ee.Message); }
        }
    }
}

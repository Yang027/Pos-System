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
    public partial class buildpath : Form
    {
        string initialldictionary = Application.StartupPath + "..//..//..//data";
        string path = Application.StartupPath + "..//..//..//data//sweetcard.bin";
        List<TransactionDetail> bkdetail;
        List<Transaction> bill = new List<Transaction>();
        SweetCard sw = null;
        public buildpath()
        {
            InitializeComponent();
            bkdetail = new List<TransactionDetail>();
            bill = IOTransaction.readtranaction(initialldictionary + "//Transaction.bin");
            sw = IOSweetCard.readSC(path);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            for(int i=0;i<bill.Count;i++)
            {
                sb.Append(bill[i].ToString() + "\n");
            }
            MessageBox.Show(sb.ToString());
        }
    }
}

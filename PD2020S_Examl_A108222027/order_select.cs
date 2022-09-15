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
    public partial class order_select : Form
    {
        static bool normal;
        Account acc;
        bool exchange;
        public order_select(Account aa)
        {
            InitializeComponent();
            this.CenterToScreen();
            acc = new Account(aa);
            var oo = Resources.ResourceManager.GetObject("orderbreak");
            pbxnormal.Image = (Image)oo;
            exchange =true;
            btnon.Visible = btnon.Enabled = true; btnoff.Visible = btnoff.Enabled = false;
        }
        private void pbxbreakfast_Click(object sender, EventArgs e)
        {
            if (exchange != true)
            {
                judge();
                if (normal == false) { breakfast bb = new breakfast(acc);
                    bb.ShowDialog(); }
                else { pbxbreakfast.Enabled = false; }// MessageBox.Show("還未到該餐點時段!"); }
            }
            else {              
                breakfast bb = new breakfast(acc);
                bb.ShowDialog();
            }
        }
        static void judge()
        {
            DateTime dtlimit_tenoc = Convert.ToDateTime("10:15AM");
            DateTime dtlimit_fouroc = Convert.ToDateTime("04:45AM");
            DateTime dtnow = Convert.ToDateTime(DateTime.Now.ToString("h:mm tt"));
            TimeSpan df1, df2;
            df1 = dtlimit_tenoc - dtnow;
            df2 = dtlimit_fouroc - dtnow;
            if (df2.TotalMinutes <= 0 && df1.TotalMinutes >= 0) { normal = false; }
            else { normal = true; }
        }
        private void pbxnormal_Click(object sender, EventArgs e)
        {
            if (exchange != true)
            {
                judge();
                if (normal == true) { Normaltime oo = new Normaltime(acc); oo.ShowDialog(); }
                else { pbxnormal.Enabled = false; }// MessageBox.Show("還未到該餐點時段!"); }
            }
            else
            {                
                Normaltime oo = new Normaltime(acc); oo.ShowDialog(); }

        }

        private void btnon_Click(object sender, EventArgs e)
        {
            exchange = false;
            btnon.Visible = btnon.Enabled = false; btnoff.Visible = btnoff.Enabled = true;
        }

        private void btnoff_Click(object sender, EventArgs e)
        {
            exchange = true; pbxbreakfast.Enabled = true; pbxnormal.Enabled = true;
            btnon.Visible = btnon.Enabled = true; btnoff.Visible = btnoff.Enabled = false;
        }
    }
}


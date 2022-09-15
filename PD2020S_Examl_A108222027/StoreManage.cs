using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace PD2020S_Examl_A108222027
{
    public partial class StoreManage : Form
    {
        UserControl _salerec = new SaleRec();
        UserControl _productManagement1 = new ProductManagement();
        
        UserControl _anylaze = new Analyze();       
        UserControl _sweetCard = new Sweetcard();
        public StoreManage()
        {
            InitializeComponent();
            tmrtime.Start();
            this.CenterToScreen();
            panel3.Visible = panel4.Visible = panel5.Visible = panel6.Visible = false; panel3.Visible = true;
            Initialsetting();
        }
        void Initialsetting()
        {       
            _productManagement1.Location = new Point(153, 38);  this.Controls.Add(_productManagement1);        
        }
        private void btnproductmanagement_Click(object sender, EventArgs e)//1
        {
            panel3.Visible = panel4.Visible = panel5.Visible = panel6.Visible = false;
            panel3.Visible = true;           
            _productManagement1.BringToFront();    
        }
        private void btnsalerec_Click(object sender, EventArgs e)//2
        {
            _salerec.Location = new Point(153, 38);
            this.Controls.Add(_salerec);
            panel3.Visible = panel4.Visible = panel5.Visible = panel6.Visible = false;
            panel4.Visible = true;
            _salerec.BringToFront(); 
        }
        private void btnsweetcard_Click(object sender, EventArgs e)//3
        {
            _sweetCard.Location = new Point(153, 38);
            this.Controls.Add(_sweetCard);     
            panel3.Visible = panel4.Visible = panel5.Visible = panel6.Visible = false;
            panel5.Visible = true;
            _sweetCard.BringToFront();
        }
        private void btnanaylze_Click(object sender, EventArgs e)//4
        {
            _anylaze.Location = new Point(153, 38);
            this.Controls.Add(_anylaze);
            panel3.Visible = panel4.Visible = panel5.Visible = panel6.Visible = false;
            panel6.Visible = true;
            _anylaze.BringToFront();          
        }

        private void tmrtime_Tick(object sender, EventArgs e)
        {
            DateTime ss = new DateTime();
            ss = DateTime.Now;
            lbltime.Text = ss.ToShortTimeString();
        }
        private void btnclose_Click(object sender, EventArgs e)
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
    }
}

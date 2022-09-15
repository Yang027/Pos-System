using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD2020S_Examl_A108222027
{
    public partial class item_add : Form
    {
        List<PictureBox> pl;
        GroupBox gg;
        Label lbl;
        PictureBox pp;
        List<Label> Lbl;
        CheckBox cbx;
        List<CheckBox> addcb;
        bool flag = false;
        public static bool flagg { get; set; }
        List<CheckBox> opcbx;
        public static Item item { get; set; }
        public static List<AddOnItem> ad { get; set; }
        public static List<Option> op { get; set; }
        public static uint total { get; set; }
        uint time = 0;
        public item_add(Item ii, uint tt)
        {
            InitializeComponent();
            this.CenterToScreen();
            item = ii;
            this.AutoSize = true;
            lblnow.Text = ii.name + ":$" + ii.price * tt;
            initialsetting();
            time = tt;
            flagg = true;
        }
        void initialsetting()
        {
            //add
            if (item.addOnitem.Count > 0)
            {
                flpaddon.Controls.Clear();
                pl = new List<PictureBox>();
                Lbl = new List<Label>();
                addcb = new List<CheckBox>();

                for (int i = 0; i < item.addOnitem.Count; i++)
                {
                    gg = new GroupBox();
                    gg.Size = new Size(155, 150);
                    gg.Location = flpaddon.Location;
                    gg.Visible = true;
                    pp = new PictureBox();
                    pp.BackgroundImage = item.addOnitem[i].add;
                    pp.Size = new Size(155, 100);
                    pp.Location = new Point(gg.Margin.Right / 2);
                    pp.Cursor = Cursors.Hand;
                    pp.Name = "pbx" + i.ToString();
                    pp.BackgroundImageLayout = ImageLayout.Stretch;
                    pl.Add(pp);
                    gg.Controls.Add(pp);
                    lbl = new Label();
                    this.lbl.AutoSize = true;
                    this.lbl.Location = new Point(pp.Location.X, pp.Height + pp.Location.Y + 10);
                    this.lbl.Text = item.addOnitem[i].ToString();//string.Format("{0,-10}", item.moption[i].name + ":$" + item.moption[i].price.ToString());
                    lbl.Enabled = true;
                    this.lbl.Visible = true;
                    this.lbl.ForeColor = Color.Black;
                    lbl.BackColor = Color.Transparent;
                    this.lbl.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei"), 13F);
                    this.gg.Controls.Add(lbl);
                    Lbl.Add(lbl);
                    //nud
                    cbx = new CheckBox();
                    cbx.Text = "";
                    cbx.AutoSize = true;
                    cbx.Location = new Point(lbl.Location.X + 30, lbl.Location.Y);
                    cbx.CheckedChanged += new EventHandler(this.select);
                    addcb.Add(cbx);
                    gg.Controls.Add(cbx);
                    gg.Margin = new Padding(5);
                    flpaddon.Controls.Add(gg);
                    flpaddon.Controls.Add(cbx);
                    flpaddon.Visible = true;
                }
            }
            //option
            if (item.moption.Count > 0)
            {
                flpoption.Controls.Clear();
                pl = new List<PictureBox>();
                Lbl = new List<Label>();
                opcbx = new List<CheckBox>();
                for (int i = 0; i < item.moption.Count; i++)
                {
                    lbl = new Label();
                    this.lbl.AutoSize = true;
                    this.lbl.Location = flpoption.Location;
                    this.lbl.Text = item.moption[i].ToString();
                    lbl.Enabled = true;
                    this.lbl.Visible = true;
                    this.lbl.ForeColor = Color.Black;
                    lbl.BackColor = Color.Transparent;
                    this.lbl.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei"), 13F);
                    Lbl.Add(lbl);
                    //nud
                    cbx = new CheckBox();
                    cbx.Text = "";
                    cbx.AutoSize = true;
                    cbx.Location = new Point(lbl.Location.X + 30, lbl.Location.Y);
                    cbx.MouseClick += new MouseEventHandler(this.optionselect);
                    opcbx.Add(cbx);
                    flpoption.Controls.Add(lbl);
                    flpoption.Controls.Add(cbx);
                    flpoption.Visible = true;
                }
            }
        }
        int index;
        private void select(object sender, EventArgs e)
        {
            index = -1;
            CheckBox pb = (CheckBox)sender;
            if (pb.Checked == true)
            {
                do
                {
                    index++;

                } while (addcb[index] != pb);
                addcb[index].Checked = true;           
            }
            else
            {
                do
                {
                    index++;

                } while (addcb[index] != pb);
                addcb[index].Checked = false;        
            }
            order();
            display();
        }
        void display()
        {
            lblnow.Text = "";
            lblnow.Text = lblnow.Text = item.name + ":$" + item.price * time + "\n";
            if (item.addOnitem.Count > 0)
            {
                string temp = "";
                foreach (var a in ad)
                {
                    temp += a.ToString() + "\n";
                }
                lblnow.AutoSize = true;
                lblnow.MaximumSize = new Size(148, 0);
                lblnow.Text += temp;
            }
            if (item.moption.Count > 0)
            {

                string temp = "";
                foreach (var o in op)
                {
                    temp += o.ToString() + "\n";
                }
                lblnow.Text += temp;
            }
        }
        private void optionselect(object sender, EventArgs e)
        {
            CheckBox cbx = (CheckBox)sender;
            #region 一開始做的蠢方法
            //click event
            //如果原本是true 現在的checked就會是false，反之；
            if (cbx.Checked == true)
            {
                //  MessageBox.Show("here");
                bool flag = false;
                int temp = -1;
                for (int i = 0; i < opcbx.Count; i++)
                {
                    if (opcbx[i].Checked == true && opcbx[i] != cbx) { flag = true; temp = i; break; }
                }
                if (flag == true)
                {
                    opcbx[temp].Checked = false;
                    cbx.Checked = true;
                }
                else { cbx.Checked = true; }
            }
            else
            {
                cbx.Checked = false;
            }
            #endregion       
            order();
            display();
        }
        void order()
        {
            bool add = false;
            bool option = false;
            //total = 0;
            total = item.price * time;
            if (item.addOnitem.Count > 0)
            {
                ad = new List<AddOnItem>();
                for (int i = 0; i < addcb.Count; i++)
                {
                    if (addcb[i].Checked == true)
                    {
                        ad.Add(item.addOnitem[i]); add = true;
                    }
                }
                foreach (var a in ad)
                {
                    total += a.price;
                }
            }
            if (item.moption.Count > 0)
            {
                op = new List<Option>();
                for (int i = 0; i < opcbx.Count; i++)
                {
                    if (opcbx[i].Checked == true)
                    {
                        op.Add(item.moption[i]); option = true;
                    }
                }
                if (op.Count > 0)
                {
                    foreach (var o in op)
                    {
                        total += o.price;
                    }
                }
            }
            if (add == false)
            {
                ad = new List<AddOnItem>();
            }
            if (option == false) { op = new List<Option>(); }
        }
        private void btnorder_Click(object sender, EventArgs e)
        {
            flag = true;
            order();
            btnexit.Visible = false;
            this.Close();
        }
        private void close(object sender, FormClosedEventArgs e)
        {
            if (flag == false)
            {
                op = new List<Option>();
                ad = new List<AddOnItem>();
                item = null; 
            }
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            flagg = false;
            this.Close();
        }
    }
}

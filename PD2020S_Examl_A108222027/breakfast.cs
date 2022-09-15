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
    public partial class breakfast : Form
    {
        PictureBox pp;
        List<PictureBox> pl = new List<PictureBox>();
        List<Category> cc = new List<Category>();
        GroupBox gg;
        Label lbl;//=new Label() ;
        NumericUpDown nud;
        List<NumericUpDown> nd;
        Account acc;
        bool close;
        List<Transaction> bill = new List<Transaction>();
        string initialldictionary = Application.StartupPath + "..//..//..//data";
        public breakfast(Account ac)
        {
            InitializeComponent();
            beforoInitialsettign();
            initalsetting();
            bill = IOTransaction.readtranaction(initialldictionary + "//Transaction.bin");
            acc = new Account(ac);
            tbxcashier.Text = acc.Name;
            tmrchange.Start();
            close = false;
            this.CenterToScreen();
        }
        void beforoInitialsettign()
        {
            cc = RWitem.binaryreader(initialldictionary + "//breakfast.dat");

            cbxchange.Items.Clear();
            foreach (var c in cc)
            {
                cbxchange.Items.Add(c.name);
            }
            cbxchange.SelectedIndex = 0;
            cbxchange.Text = cc[0].name;
        }
        void initalsetting()
        {
            flpanel.Controls.Clear();
            pl = new List<PictureBox>();
            nd = new List<NumericUpDown>();
            for (int i = 0; i < cc[cbxchange.SelectedIndex].item.Count; i++)
            {
                gg = new GroupBox();
                gg.Size = new Size(165, 130);
                gg.Location = flpanel.Location;
                //pbx
                pp = new PictureBox();
                pp.BackgroundImage = cc[cbxchange.SelectedIndex].item[i].item;
                pp.Size = new Size(165, 100);
                pp.Location = new Point(gg.Margin.Right / 2);
                pp.Click += new System.EventHandler(this.Click);
                pp.Cursor = Cursors.Hand;
                pp.Name = "pbx" + i.ToString();
                pp.BackgroundImageLayout = ImageLayout.Stretch;
                pp.BackColor = Color.White;
                pl.Add(pp);
                gg.Controls.Add(pp);
                //lbl
                lbl = new Label();
                this.lbl.AutoSize = true;
                this.lbl.Location = new Point(pp.Location.X, pp.Height + pp.Location.Y + 10);
                this.lbl.Text = string.Format("{0,-10}", cc[cbxchange.SelectedIndex].item[i].name + ":$" + cc[cbxchange.SelectedIndex].item[i].price.ToString());
                lbl.Enabled = true;
                this.lbl.Visible = true;
                this.lbl.ForeColor = Color.Black;
                lbl.BackColor = Color.Transparent;
                this.lbl.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei"), 9F);
                this.gg.Controls.Add(lbl);
                //nud
                nud = new NumericUpDown();
                nud.Location = new Point(pp.Width / 2 + pp.Location.X + 48, pp.Height + pp.Location.Y + 5);
                nud.Width = 50;
                nud.Size = new Size(34, 22);
                nud.Value = 1;
                nd.Add(nud);
                gg.Controls.Add(nud);
                gg.Margin = new Padding(5);
                flpanel.Controls.Add(gg);
            }
        }
        List<TransactionDetail> bkdetail = new List<TransactionDetail>();
        private void Click(object sender, EventArgs e)
        {
            PictureBox px = (PictureBox)sender;
            int index = -1;
            for (int i = 0; i < pl.Count; i++)
            {
                if (pl[i].Equals(px))
                { index = i; }
            }
            if (nd[index].Value != 0)
            {
                if (cc[cbxchange.SelectedIndex].item[index].addOnitem.Count > 0 || cc[cbxchange.SelectedIndex].item[index].moption.Count > 0)
                {
                    item_add ia = new item_add(cc[cbxchange.SelectedIndex].item[index], (uint)nd[index].Value);
                    ia.ShowDialog();
                    if (item_add.item != null)
                    {
                        bkdetail.Add(new TransactionDetail(cc[cbxchange.SelectedIndex].name, item_add.item.name, item_add.item.price, (uint)nd[index].Value, item_add.ad, item_add.op, item_add.total));
                    }
                    display();
                }
                else
                {
                    if (nd[index].Value != 0 && MessageBox.Show("加入下列餐點？" + "\n" + cc[cbxchange.SelectedIndex].item[index].name + "*" + nd[index].Value + "\t:$" + nd[index].Value * cc[cbxchange.SelectedIndex].item[index].price, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bkdetail.Add(new TransactionDetail(cc[cbxchange.SelectedIndex].name, cc[cbxchange.SelectedIndex].item[index].name, cc[cbxchange.SelectedIndex].item[index].price, (uint)nd[index].Value, (uint)nd[index].Value * cc[cbxchange.SelectedIndex].item[index].price));
                        display();
                    }
                    else
                    {
                        if (nd[index].Value == 0)
                        {
                            MessageBox.Show("請至少選擇一個物品");
                        }
                    }
                }
            }
            else { MessageBox.Show("請至少選擇一個物品"); }
        }
        void display()
        {
            string ss = "";
            foreach (var dd in bkdetail)
            {
                ss += dd.name + ":" + dd.price.ToString() + "*" + dd.time.ToString() + ":$" + (dd.time * dd.price).ToString() + "\n";
                if (dd.add.Count > 0 || dd.add != null)
                {
                    foreach (var a in dd.add)
                    {
                        ss += a.ToString() + "\n";
                    }
                }
                if (dd.op.Count > 0 || dd.op != null)
                {
                    foreach (var o in dd.op)
                    {
                        ss += o.ToString() + "\n";
                    }
                }
            }
            lbxshoppingcar1.Items.Add(ss);
            string[] temp = ss.Split('\n');
            lbxshoppingcar1.Items.Clear();
            for (int i = 0; i < temp.Length; i++)
            {
                lbxshoppingcar1.Items.Add(temp[i]);
            }
            nd[index].Value = 1;
        }
        private void cbxchange_SelectedIndexChanged(object sender, EventArgs e)
        {
            initalsetting();
        }
        int index;
        private void select(object sender, EventArgs e)
        {
            try
            {
                index = lbxshoppingcar1.SelectedIndex;
            }
            catch { }
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                bkdetail.Remove(bkdetail[index]);
                lbxshoppingcar1.Items.Clear();
                for (int i = 0; i < bkdetail.Count; i++)
                {
                    lbxshoppingcar1.Items.Add(bkdetail[i].name + "*" + bkdetail[i].time + "\t:$" + bkdetail[i].time * bkdetail[i].price);
                }
            }
            catch { }
        }
        private void tmrchange_Tick(object sender, EventArgs e)
        {
            tbxdate.Text = DateTime.Now.ToShortTimeString();
            Random rr = new Random();
            int rand = rr.Next(0, 8);
            if (DateTime.Now.Second % 5 == 0)
            {
                switch (rand)
                {
                    case 0: pbxadvp.Image = (Image)Resources.ResourceManager.GetObject("bkadv"); break;
                    case 1: pbxadvp.Image = (Image)Resources.ResourceManager.GetObject("bk2"); break;
                    case 2: pbxadvp.Image = (Image)Resources.ResourceManager.GetObject("bk3"); break;
                    case 3: pbxadvp.Image = (Image)Resources.ResourceManager.GetObject("bk10"); break;
                    case 4: pbxadvp.Image = (Image)Resources.ResourceManager.GetObject("Bk5"); break;
                    case 5: pbxadvp.Image = (Image)Resources.ResourceManager.GetObject("bk6"); break;
                    case 6: pbxadvp.Image = (Image)Resources.ResourceManager.GetObject("bk7"); break;
                    case 7: pbxadvp.Image = (Image)Resources.ResourceManager.GetObject("bk8"); break;
                    case 8: pbxadvp.Image = (Image)Resources.ResourceManager.GetObject("bk9"); break;

                }
            }
        }
        bool hang = false;
        private void btnorder_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (var pp in bkdetail)
            {
                total += pp.price * pp.time;
            }
            if (total > 0)
            {
                bill.Add(new Transaction(hang, DateTime.Now, tbxcashier.Text, bkdetail, total,bill[bill.Count-1].td_id));
                //MessageBox.Show(bill[bill.Count - 1].td_id+1 + "");
                if (MessageBox.Show(bill[bill.Count - 1].ToString(), "確認付款？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    bkdetail = new List<TransactionDetail>();
                    lbxshoppingcar1.Items.Clear();
                    cbxhangout.Checked = false;
                    buy = true;
                    close = false;
                }
                else { bill.Remove(bill[bill.Count - 1]); }
            }
            else { MessageBox.Show("請先選擇餐點！"); }
        }
        bool buy = false;
        private void save(object sender, FormClosingEventArgs e)
        {
            //问要不要要不要存档.etc
            if (buy == true)
            {
                if (close == false)
                {
                    if (MessageBox.Show("是否要存檔?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        IOTransaction.savetransaction(initialldictionary + "//Transaction.bin", bill); MessageBox.Show("save successfully!");
                        close = true;
                    }
                    else { close = true; }
                }
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            close = true;
            this.Close();
        }

        private void cbxhangout_CheckedChanged(object sender, EventArgs e)
        {
            hang = cbxhangout.Checked == true ? true : false;
        }

        private void lblrefresh_Click(object sender, EventArgs e)
        {
            bkdetail.Clear(); display();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            if (buy == true)
            {
                if (close == false)
                {
                    if (MessageBox.Show("是否要存檔?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        IOTransaction.savetransaction(initialldictionary + "//Transaction.bin", bill);
                        MessageBox.Show("save successfully!"); close = true;
                    }
                    else { close = true; }
                }
            }
        }
    }
}

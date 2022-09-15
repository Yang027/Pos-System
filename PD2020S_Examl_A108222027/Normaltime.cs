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
    public partial class Normaltime : Form
    {
        PictureBox pp;
        List<PictureBox> pl = new List<PictureBox>();
        List<Category> cc;
        GroupBox gg;
        Label lbl;
        NumericUpDown nud;
        List<NumericUpDown> nd;
        List<Label> sweet;
        List<TransactionDetail> bkdetail;
        List<Transaction> bill = new List<Transaction>();
        Account acc;
        bool discount = false;
        bool dIscount = false;
        bool close;
        bool used = false;
        List<placeB> placeB = new List<placeB>();
        List<placeA> placeA = new List<placeA>();
        SweetCard sw = null;
        bool hang = false;
        string initialldictionary = Application.StartupPath + "..//..//..//data";
        string path = Application.StartupPath + "..//..//..//data//sweetcard.bin";
        public Normaltime(Account ac)
        {
            InitializeComponent();
            this.CenterToScreen();
            tmrchange.Start();
            beforoInitialsettign();
            initalsetting();
            acc = new Account(ac);
            tbxcashier.Text = acc.Name;
            bkdetail = new List<TransactionDetail>();
            bill = IOTransaction.readtranaction(initialldictionary + "//Transaction.bin");
            sw = IOSweetCard.readSC(path);
            placeA = sw.placeAitem;
            placeB = sw.placeBitem;
            close = false;
        }
        bool Discount()
        {
            if (used == false)
            {
                foreach (var dd in bkdetail)
                {
                    if (discount == false)
                    {
                        for (int i = 0; i < placeA.Count; i++)
                        {
                            if (dd.name.Equals(placeA[i].name))
                            { discount = true; break; }
                        }
                    }
                    else { break; }
                }
                return discount;
            }
            else { return false; }
        }
        void beforoInitialsettign()
        {
            cc = RWitem.binaryreader(initialldictionary + "//menu.dat");

            cbxchange.Items.Clear();
            foreach (var c in cc)
            {
                cbxchange.Items.Add(c.name);
            }
            cbxchange.SelectedIndex = 0;
            cbxchange.Text = cc[0].name;
        }
        string name;//= "";
        Bitmap ii;//= null;
        void placeBitem()
        {
            flpanel.Controls.Clear();
            pl = new List<PictureBox>();
            nd = new List<NumericUpDown>();
            sweet = new List<Label>();
            cbxchange.Text = "甜心卡B區商品";
            MessageBox.Show("請選擇甜心卡商品！");
            name = "";
            ii = null;
            foreach (var b in placeB)
            {
                name = b.name;
                ii = b.view;
                gg = new GroupBox();
                gg.Size = new Size(165, 130);
                gg.Location = flpanel.Location;
                //pbx
                pp = new PictureBox();
                pp.BackgroundImage = ii;
                pp.Size = new Size(165, 100);
                pp.Location = new Point(gg.Margin.Right / 2);
                pp.Click += new System.EventHandler(this.SweetClick);
                pp.Cursor = Cursors.Hand;
                pp.BackgroundImageLayout = ImageLayout.Stretch;
                pl.Add(pp);
                gg.Controls.Add(pp);

                lbl = new Label();
                this.lbl.AutoSize = true;
                this.lbl.Location = new Point(pp.Location.X + pp.Width / 2 - 30, pp.Height + pp.Location.Y + 10);
                this.lbl.Text = string.Format("{0,-10}", name);
                lbl.Enabled = true;
                this.lbl.Visible = true;
                this.lbl.ForeColor = Color.Black;
                lbl.BackColor = Color.Transparent;
                this.lbl.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei"), 12F);
                sweet.Add(lbl);
                this.gg.Controls.Add(lbl);
                gg.Margin = new Padding(5);
                flpanel.Controls.Add(gg);
            }
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
                gg.Paint += new PaintEventHandler(this.change);
                gg.Controls.Add(nud);
                gg.Margin = new Padding(5);
                flpanel.Controls.Add(gg);
            }
        }
        private void change(object sender, PaintEventArgs e)
        { e.Graphics.Clear(this.BackColor); }
        private new void SweetClick(object sender, EventArgs e)
        {
            PictureBox px = (PictureBox)sender;
            int index = -1;
            for (int i = 0; i < pl.Count; i++)
            {
                if (pl[i].Equals(px))
                { index = i; }
            }
            if (used == false)
            {
                if (dIscount == true)//sweetcard
                {
                    if (Discount() == true)
                    {
                        if (MessageBox.Show("確定選擇B區的產品？" + "\n" + sweet[index].Text, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            bkdetail.Add(new TransactionDetail("", sweet[index].Text, 0, 1, 0));
                            lbxshoppingcar1.Items.Clear();
                            for (int i = 0; i < bkdetail.Count; i++)
                            {
                                if (bkdetail[i].price != 0)
                                {
                                    display();
                                }
                            }
                            used = true;
                            initalsetting();
                        }
                    }
                }
            }
        }
        void display()
        {
            string ss = "";
            int time = 0;
            foreach (var dd in bkdetail)
            {
                if (time == 0)
                {
                    ss += dd.name + ":" + dd.price.ToString() + "*" + dd.time.ToString() + ":$" + (dd.time * dd.price).ToString() + " "; time += 1;
                }
                else { ss += "\n" + dd.name + ":" + dd.price.ToString() + "*" + dd.time.ToString() + ":$" + (dd.time * dd.price).ToString() + " "; }
                if (dd.add.Count > 0 || dd.add != null)
                {
                    foreach (var a in dd.add)
                    {
                        ss += a.ToString() + " ";
                    }
                }
                if (dd.op.Count > 0 || dd.op != null)
                {
                    foreach (var o in dd.op)
                    {
                        ss += o.ToString() + " ";
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
        }
        int temp = 0;
        private new void Click(object sender, EventArgs e)
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
                temp = 0;
                if (cc[cbxchange.SelectedIndex].item[index].addOnitem.Count > 0 || cc[cbxchange.SelectedIndex].item[index].moption.Count > 0)
                {
                    item_add ia = new item_add(cc[cbxchange.SelectedIndex].item[index], 1);
                    while (nd[index].Value != temp)
                    {
                        if (item_add.flagg == true)
                        {
                            ia.ShowDialog();
                            if (item_add.item != null)
                            {
                                bkdetail.Add(new TransactionDetail(cc[cbxchange.SelectedIndex].name, item_add.item.name, item_add.item.price, 1, item_add.ad, item_add.op, item_add.total)); temp++;
                            }
                            else { break; }
                        }
                        else { break; }
                    }
                    display(); nd[index].Value = 1; temp = 0;
                }
                else
                {
                    if (nd[index].Value != 0 && MessageBox.Show("加入下列餐點？" + "\n" + cc[cbxchange.SelectedIndex].item[index].name + "*" + nd[index].Value + "\t:$" + nd[index].Value * cc[cbxchange.SelectedIndex].item[index].price, "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bkdetail.Add(new TransactionDetail(cc[cbxchange.SelectedIndex].name, cc[cbxchange.SelectedIndex].item[index].name, cc[cbxchange.SelectedIndex].item[index].price, (uint)nd[index].Value, (uint)nd[index].Value * cc[cbxchange.SelectedIndex].item[index].price));
                        display(); nd[index].Value = 1;
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
        private void cbxchange_SelectedIndexChanged(object sender, EventArgs e)
        {
            initalsetting();
        }
        private void tmrchange_Tick(object sender, EventArgs e)
        {
            tbxdate.Text = DateTime.Now.ToShortDateString() + "/" + DateTime.Now.ToShortTimeString();
        }
        private void btnorder_Click(object sender, EventArgs e)
        {
            decimal total = 0;
            foreach (var pp in bkdetail)
            {
                total += pp.total;
            }
            if (total != 0)
            {
                total = 0;
                if (used == false)
                {
                    if (dIscount == true)
                    {
                        if (Discount() == true)
                        {
                            placeBitem();
                        }
                        else { order(); }
                    }
                    else { order(); }
                }
                else
                {
                    order();
                }
            }
            else { MessageBox.Show("請先選擇餐點！"); }
        }
        bool buy = false;
        void order()
        {
            decimal total = 0;
            foreach (var pp in bkdetail)
            {
                total += pp.total;
            }
            bill.Add(new Transaction(hang, DateTime.Now, tbxcashier.Text, bkdetail, total, bill[bill.Count - 1].td_id));
            // MessageBox.Show(bill[bill.Count - 1].td_id + 1 + "");
            if (MessageBox.Show(bill[bill.Count - 1].ToString(), "確認付款？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bkdetail = new List<TransactionDetail>();
                lbxshoppingcar1.Items.Clear();
                cbxchange.SelectedIndex = 0;
                used = false;
                discount = false;
                dIscount = false;
                cbxhangout.Checked = false;
                buy = true;
                cbxdiscount.Checked = false;
                close = false;
            }
            else { bill.Remove(bill[bill.Count - 1]); }
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                bkdetail.Remove(bkdetail[lbxshoppingcar1.SelectedIndex]);
                lbxshoppingcar1.Items.Clear();
                for (int i = 0; i < bkdetail.Count; i++)
                {
                    display();
                }
            }
            catch { }
        }
        private void save(object sender, FormClosingEventArgs e)
        {
            if (buy == true)
            {
                if (close == false)
                {
                    if (MessageBox.Show("是否要存檔?", "確認", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        bool save = IOTransaction.savetransaction(initialldictionary + "//Transaction.bin", bill);
                        if (save == true)
                        { IOTransaction.savetransaction(initialldictionary + "//Transaction.bin", bill); MessageBox.Show("save successfully!"); }
                        else
                        { e.Cancel = save == false; }
                    }
                    else
                    {
                        close = true;
                    }
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
        private void cbxdiscount_CheckedChanged(object sender, EventArgs e)
        {
            dIscount = cbxdiscount.Checked == true ? true : false;
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

                    if (IOTransaction.savetransaction(initialldictionary + "//Transaction.bin", bill) == true)
                    { MessageBox.Show("save successfully!"); close = true; }
                    else { close = true; }
                }
            }
        }
    }
}

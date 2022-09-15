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
    public partial class empolyeemanagement : UserControl
    {
        List<PictureBox> pl;
        Label lbl;
        GroupBox gg;
        PictureBox pp;
        List<Transaction> bill = new List<Transaction>();
        public static List<Account> accountlist { get; set; }
        string accountFile = Application.StartupPath + "//..//..//data//account.bin";
        List<string> lastlogin = new List<string>();
        List<Label> lblist = new List<Label>();
        Account nowaccount;
        public empolyeemanagement(Account account)
        {
            InitializeComponent();
            nowaccount = new Account(account);
            initalsetting();

        }
        void initalsetting()
        {
            // accountlist = RWaccount.readaccount();
            accountlist = RWaccount.readbinaryAcc(accountFile);
            flpanel.Controls.Clear();
            caculate();
            this.Controls.Clear();
            pl = new List<PictureBox>();
            Label l2 = new Label();
            Label ll = new Label();
            lblist = new List<Label>();
            Label title = new Label();
            Label title1 = new Label();
            title.Location = new Point(0, 0);
            title.Text = string.Format("{0,-10}", "員工列表：");
            title.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei"), 12F);
            title.BackColor = Color.Transparent;
            title.ForeColor = Color.White;
            title.AutoSize = false;
            this.Controls.Add(title);

            title1.Location = new Point(title.Location.X, title.Location.Y + 25);
            title1.Text = "現有" + accountlist.Count + "員工";
            title1.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei"), 10F);
            title1.BackColor = Color.Transparent;
            title1.ForeColor = Color.White;
            title1.AutoSize = false;

            this.Controls.Add(title1);

            for (int i = 0; i < accountlist.Count; i++)
            {
                gg = new GroupBox();
                gg.Size = new Size(50, 50);
                gg.Location = flpanel.Location;
                gg.AutoSize = false;
                //  pbx
                pp = new PictureBox();
                pp.BackgroundImage = accountlist[i].Head;
                pp.Size = new Size(50, 50);
                //   pp.Location = new Point(gg.Margin.Right);
                pp.Click += new System.EventHandler(this.Click);
                pp.Cursor = Cursors.Hand;
                pp.Name = "pbx" + i.ToString();
                pp.BackgroundImageLayout = ImageLayout.Stretch;
                pp.BackColor = Color.Transparent;
                pl.Add(pp);
                gg.Controls.Add(pp);
                //lbl
                lbl = new Label();
                this.lbl.AutoSize = true;
                this.lbl.Location = new Point(pp.Location.X, pp.Height + pp.Location.Y + 10);
                this.lbl.Text = string.Format("{0,-10}", accountlist[i].Name);
                lbl.Enabled = true;
                this.lbl.Visible = true;
                this.lbl.ForeColor = Color.White;
                lbl.BackColor = Color.Transparent;
                lbl.TextAlign = ContentAlignment.TopCenter;
                this.lbl.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei"), 9F);
                this.gg.Controls.Add(lbl);

                ll = new Label();
                ll.AutoSize = false;
                ll.Location = new Point(lbl.Location.X, pp.Height + pp.Location.Y + 30);
                // MessageBox.Show("out" + (accountlist[i].logout is null) + "in" + (accountlist[i].login is null));
                ll.Text = lastlogin[i];
                ll.Enabled = true;
                ll.Visible = true;
                ll.ForeColor = Color.White;
                ll.BackColor = Color.Transparent;
                ll.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei"), 9F);
                this.gg.Controls.Add(ll);

                l2 = new Label();
                l2.AutoSize = true;
                l2.Text = "X";
                l2.Location = new Point(ll.Margin.Right);
                l2.Enabled = true;
                l2.Visible = true;
                l2.ForeColor = Color.White;
                l2.BackColor = Color.Transparent;
                l2.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei"), 9F);
                l2.Cursor = Cursors.Hand;
                l2.Click += new System.EventHandler(this.Del);
                lblist.Add(l2);

                gg.Paint += new PaintEventHandler(this.change);
                gg.Cursor = Cursors.Hand;
                gg.AutoSize = true;
                this.Padding = new Padding(25);
                flpanel.Controls.Add(gg);
                flpanel.Controls.Add(l2);
            }
            lbl = new Label();
            this.lbl.AutoSize = true;
            this.lbl.Location = flpanel.Location;
            this.lbl.Text = "+";
            lbl.Enabled = true;
            this.lbl.Visible = true;
            this.lbl.ForeColor = Color.White;
            lbl.Cursor = Cursors.Hand;
            lbl.BackColor = Color.Transparent;
            lbl.Click += new System.EventHandler(this.Signup);
            this.lbl.Font = new System.Drawing.Font(new FontFamily("Microsoft JhengHei"), 39F, FontStyle.Bold);
            flpanel.Controls.Add(lbl);
            this.Controls.Add(flpanel);
        }
        private void Signup(object sender, EventArgs e)
        {
            Signup ss = new Signup();
            ss.ShowDialog();
            initalsetting();
        }
        private void Del(object sender, EventArgs e)
        {
            int index = -1;
            do { index++; } while (lblist[index] != sender);
            if (MessageBox.Show("確定要刪除" + accountlist[index].Name + "嗎?", "確認", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                accountlist.Remove(accountlist[index]);
                lblist.Remove(lblist[index]);
                RWaccount.binarysaveAcc(accountFile, accountlist);
                initalsetting();
            }
        }
        private void Click(object sender, EventArgs e)
        {
            int index = -1;
            do { index++; } while (pl[index] != sender);
            UserControl usc = new adjustemployee(accountlist[index], nowaccount);
            this.Controls.Add(usc);
            usc.BringToFront();
        }
        private void change(object sender, PaintEventArgs e)
        { e.Graphics.Clear(this.BackColor); }
        int[] sale;

        void caculate()
        {
            int tem = 0;
            bill = IOTransaction.readtranaction(Application.StartupPath + "..//..//..//data//Transaction.bin");
            sale = new int[accountlist.Count];
            lastlogin = new List<string>();
            for (int i = 0; i < accountlist.Count; i++)
            {
                for (int j = 0; j < bill.Count; j++)
                {
                    if (accountlist[i].Name.Equals(bill[j].cashier))
                    {
                        sale[i] += 1;
                    }
                }
            }
            TimeSpan ts = new TimeSpan();
            for (int i = 0; i < accountlist.Count; i++)
            {
                if (accountlist[i].account == nowaccount.account)
                {
                    lastlogin.Add("Online");
                }
                else if (accountlist[i].login != "")
                {
                    ts = DateTime.Now - DateTime.Parse(accountlist[i].logout);//duojiu qian zzai xian 
                    lastlogin.Add(ts.TotalDays > 1 ? ts.TotalDays.ToString("n0") + "天前在線" : ts.TotalMinutes > 60 ? ts.TotalHours.ToString("n0") + "小時前在線" : ts.TotalSeconds > 60 ? ts.TotalMinutes.ToString("n0") + "分鐘前在線" : ts.TotalSeconds > 0 ? ts.TotalSeconds.ToString("n0") + "秒前在線" : "Online");
                }
                else
                {
                    lastlogin.Add("從未登錄");//MessageBox.Show("No Login" + i);
                }
            }

        }
    }
}

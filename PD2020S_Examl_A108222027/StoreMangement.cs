//Author:Yang 
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace PD2020S_Examl_A108222027
{
    public enum ChartType { Bar, Line, Pie };
    public partial class StoreMangement : Form
    {
        List<Category> pInfo = new List<Category>();
        List<Item> items = new List<Item>();
        List<int> phone; List<string> name; List<uint> point; List<string> birthday;
        DataGridViewRow cr;
        string initialpath = Application.StartupPath + "..//..//..//data";
        int nindex;
        public StoreMangement()
        {
            StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            tmrtime.Start();
            tabpage2.Text = "Product";
            tabPage3.Text = "SaleRecord";
            tabPage4.Text = "DataGrid";
            phone = new List<int>();
            name = new List<string>();
            point = new List<uint>();
            birthday = new List<string>();
        }
        void display()//item
        {
            cbxitem.Items.Clear(); cbxoption.Items.Clear(); cbxaddtiem.Items.Clear();
            tbxitem.Text = "";
            nudprice.Value = 0;
            for (int i = 0; i < pInfo[cbxchoice.SelectedIndex].item.Count; i++)
            {
                cbxitem.Items.Add(pInfo[cbxchoice.SelectedIndex].item[i].ToString());
            }
        }
        void optiondisplay()//option
        {
            cbxoption.Items.Clear();
            tbxoption.Text = "";
            nudoption.Value = 0;
            if (cbxitem.SelectedItem != null)
            {
                for (int i = 0; i < pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption.Count; i++)
                {
                    cbxoption.Items.Add(pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption[i].ToString());
                }
            }
        }
        void additem_display()//additem
        {
            cbxaddtiem.Items.Clear();
            tbxadditem.Text = "";
            nudtiemsprice.Value = 0;
            if (cbxitem.SelectedItem != null)
            {
                for (int i = 0; i < pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem.Count; i++)
                {
                    cbxaddtiem.Items.Add(pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem[i].ToString());
                }
            }
        }
        bool check(string nn)//item
        {
            bool flag = true;
            for (int i = 0; i < pInfo[cbxchoice.SelectedIndex].item.Count; i++)
            {
                if (pInfo[cbxchoice.SelectedIndex].item[i].name.Equals(nn.Trim()) && tbxitem.Text != "")
                { flag = false; break; }
            }
            return flag;
        }
        bool checkop(string nn)//option
        {
            bool flag = true;
            if (pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption.Count > 0)
            {
                for (int i = 0; i < pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption.Count; i++)
                {
                    if (pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption[i].name.Equals(nn.Trim()) && tbxoption.Text != "")
                    { flag = false; break; }
                }
            }
            else { flag = true; }
            return flag;
        }
        bool checkadd(string nn)//item
        {
            bool flag = true;
            if (pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem.Count > 0)
            {
                for (int i = 0; i < pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem.Count; i++)
                {
                    if (pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem[i].name.Equals(nn.Trim()) && tbxadditem.Text != "")
                    { flag = false; break; }
                }
            }
            else { flag = true; }
            return flag;
        }
        void initialGUIsetting()
        {
            tabControl1.Visible = true;
            tabControl1.SelectedIndex = 1;
            gbxitem.Visible = true;
            btnupdate.Visible = true;
            btndel.Visible = true;
            btninsert.Visible = true;
            cbxchoice.SelectedIndex = 0;
            btnsave.Visible = true;
            pbxaddvi.Visible = pbxopionvi.Visible = pbxview.Visible = true;
        }
        List<Transaction> bill = new List<Transaction>();
        private void btnsave_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex != 3)
            {
                if (pInfo == null) MessageBox.Show("There is no  info. to save!!");
                else
                {
                    sfdsave.InitialDirectory = initialpath;
                    if (sfdsave.ShowDialog() == DialogResult.OK)
                    {
                        switch (tabControl1.SelectedIndex)
                        {

                            case 1://scalerecrod
                                IOTransaction.savetransaction(sfdsave.FileName, bill); MessageBox.Show("Data update successful!"); break;
                            case 3:
                                break;
                            default:
                                if (RWitem.savebinary(sfdsave.FileName, pInfo) == true)
                                {
                                    RWitem.savebinary(sfdsave.FileName, pInfo); MessageBox.Show("Data update successful!");
                                }
                                else { MessageBox.Show("save store information fail.process abort!!"); }
                                break;
                        }
                    }
                }

            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnload_Click(object sender, EventArgs e)
        {
            opdloading.InitialDirectory = initialpath;
            if (opdloading.ShowDialog() == DialogResult.OK)
            {
                switch (tabControl1.SelectedIndex)
                {
                    case 0:
                    case 2:
                        try
                        {
                            pInfo = RWitem.binaryreader(opdloading.FileName);
                            cbxchoice.Text = ""; tbxindex.Text = "";
                            cbxchoice.Items.Clear();
                            cbxitem.Items.Clear();
                            cbxaddtiem.Items.Clear();
                            cbxoption.Items.Clear();
                            cbxdtchoic.Items.Clear();
                            datagridviewinital();
                            GUIsetting.setStoreInfo(pInfo, this, cbxdtchoic);//add to combobox
                            GUIsetting.setStoreInfo(pInfo, this, cbxchoice);//add to combobox
                        }
                        catch { MessageBox.Show("請選擇正確的菜單"); }
                        break;
                    case 1:
                        try
                        {
                            bill = new List<Transaction>();
                            bill = IOTransaction.readtranaction(opdloading.FileName);
                            display_transaction();
                        }
                        catch { MessageBox.Show("請選擇正確的交易資料！"); }
                        break;
                    case 3:
                        //CreateGraph(zedGraphControl1);
                        try
                        {
                            bill = IOTransaction.readtranaction(opdloading.FileName);
                        }
                        catch { MessageBox.Show("請選擇正確的交易資料！"); }
                        break;
                }
            }
        }
        private void btntransactiondel_Click(object sender, EventArgs e)
        {
            try
            {
                bill.Remove(bill[transindex]); display_transaction();
            }
            catch { }
        }
        int transindex;
        private void expand(object sender, DataGridViewCellMouseEventArgs e)
        {
            transindex = e.RowIndex;
            tbxhang.Text = bill[transindex].Hangout == true ? "外帶" : "內用";
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
        bool query = false;
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
        private void tmrtime_Tick(object sender, EventArgs e)
        {
            DateTime ss = new DateTime();
            ss = DateTime.Now;
            lbltime.Text = ss.ToLocalTime().ToString();
        }
        #region gbxItem
        private void btnInsertObject_Click(object sender, EventArgs e)
        {
            if (tbxindex.Text.Trim().Length > 0)
            {
                if (pInfo != null)
                {
                    bool tflag = true;
                    foreach (var tt in pInfo)
                    {
                        if (tbxindex.Text.Trim() == tt.name) { tflag = false; break; }
                    }
                    if (tflag == true)
                    {
                        Category cc = new Category((uint)(pInfo.Count + 1), tbxindex.Text.Trim());
                        pInfo.Add(cc);
                        GUIsetting.setStoreInfo(pInfo, this, cbxchoice);//add to combobox
                        cbxchoice.SelectedIndex = cbxchoice.Items.Count - 1;
                    }
                    else { MessageBox.Show("Category Repeat!"); }
                }
                else
                {
                    Category cc = new Category(1, tbxindex.Text.Trim(), new List<Item>());
                    pInfo.Add(cc);
                    GUIsetting.setStoreInfo(pInfo, this, cbxchoice);//add to combobox
                    initialGUIsetting();
                }
            }
            else { MessageBox.Show("添加的產品類別不能為空！"); }// Category ss=new Category(index,tbxproduct.Text);
        }
        private void cbxchoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                tbxindex.Text = pInfo[cbxchoice.SelectedIndex].name;
                // GUIsetting.setItemInfo(pInfo[cbxchoice.SelectedIndex].item, cbxitem);       
                display();
                optiondisplay();
                additem_display();
                tbxitem.Text = "";
                nudprice.Value = 0;
                tbxadditem.Text = "";
                tbxoption.Text = "";
                nudoption.Value = 0;
                nudtiemsprice.Value = 0; pbxview.Image = null;
                pbxaddvi.Image = null; pbxopionvi.Image = null;
            }
            catch
            {
                tbxindex.Text = pInfo[cbxchoice.SelectedIndex].name; tbxitem.Text = "";
                nudprice.Value = 0;
                tbxadditem.Text = "";
                tbxoption.Text = "";
                nudoption.Value = 0;
                nudtiemsprice.Value = 0; pbxview.Image = null;
            }
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (check(tbxitem.Text) == true)
                {
                    pInfo[cbxchoice.SelectedIndex].item.Add(new Item(0, tbxitem.Text.Trim(), Convert.ToUInt32(nudprice.Value), bb, new List<AddOnItem>(), new List<Option>()));
                    pbxview.Image = null;
                    display();
                }
                else { MessageBox.Show("商品重複"); }
            }
            catch
            {
                MessageBox.Show("請選擇一個類別");
            }
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxitem.Text != "")
                {
                    pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex] = new Item(0, tbxitem.Text.Trim().Trim(), Convert.ToUInt32(nudprice.Value), bb, new List<AddOnItem>(), new List<Option>());
                    pbxview.Image = null;
                    display();
                }
                else { MessageBox.Show("產品類別不能為空！"); }
            }
            catch { MessageBox.Show("請選擇一個類別"); }
        }
        private void enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (tbxindex.Text.Trim().Length > 0)
                {
                    if (pInfo != null)
                    {
                        Category cc = new Category((uint)(pInfo.Count + 1), tbxindex.Text.Trim());
                        pInfo.Add(cc);
                        GUIsetting.setStoreInfo(pInfo, this, cbxchoice);//add to combobox
                        cbxchoice.SelectedIndex = cbxchoice.Items.Count - 1;
                    }
                    else
                    {
                        Category cc = new Category((uint)(pInfo.Count + 1), tbxindex.Text.Trim());
                        pInfo.Add(cc);
                        GUIsetting.setStoreInfo(pInfo, this, cbxchoice);//add to combobox
                        initialGUIsetting();
                    }
                }
                else { MessageBox.Show(""); }// Category ss=new Category(index,tbxproduct.Text);
            }
        }
        private void cbxitem_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxitem.Text = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].name;
            nudprice.Value = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].price;
            pbxview.Image = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].item;
            bb = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].item;
            optiondisplay();
            additem_display();
        }
        private void Enter(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                try
                {
                    if (check(tbxitem.Text) == true)
                    {
                        pInfo[cbxchoice.SelectedIndex].item.Add(new Item((uint)pInfo[cbxdtchoic.SelectedIndex].item.Count - 1, tbxitem.Text.Trim(), Convert.ToUInt32(nudprice.Value), bb, new List<AddOnItem>(), new List<Option>()));
                        display();
                    }
                    else { MessageBox.Show("商品重複"); }
                }
                catch
                {
                    MessageBox.Show("請選擇一個類別");
                }
            }
        }
        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                pInfo[cbxchoice.SelectedIndex].item.Remove(pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex]); pbxview.Image = null;
                display();
            }
            catch { }
        }
        private void btnobjupdate_Click(object sender, EventArgs e)
        {
            if (cbxchoice.Text != "")
            {
                if (tbxindex.Text != null)
                {
                    pInfo[cbxchoice.SelectedIndex].name = tbxindex.Text;
                    cbxchoice.Items[cbxchoice.SelectedIndex] = tbxindex.Text;
                }
                else { MessageBox.Show("商品物件不能沒有名字"); }
            }
            else { MessageBox.Show("選一個物件"); }
        }
        private void btndelate_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbxchoice.SelectedItem != null)
                {
                    pInfo.Remove(pInfo[cbxchoice.SelectedIndex]);
                    cbxchoice.Items.Clear();
                    cbxchoice.Text = "";
                    tbxindex.Text = "";
                    cbxitem.Items.Clear(); for (int i = 0; i < pInfo.Count; i++)
                    {
                        cbxchoice.Items.Add(pInfo[i].name);
                    }
                }
                else { MessageBox.Show("選一個物件"); }
            }
            catch { MessageBox.Show("選一個物件"); }
        }
        #endregion
        //thin;thick;small
        #region gbxoption 
        private void btnoptioninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkop(tbxoption.Text) == true)
                {
                    pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption.Add(new Option(tbxoption.Text.Trim(), Convert.ToUInt32(nudoption.Value), oo));
                    optiondisplay();
                }
                else
                {
                    MessageBox.Show("商品重複");
                }
            }
            catch { MessageBox.Show(""); }
        }
        private void btnoptionupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxoption.Text != "")
                {
                    pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption[cbxoption.SelectedIndex] = (new Option(tbxoption.Text.Trim(), Convert.ToUInt32(nudoption.Value), oo));
                    optiondisplay();
                    pbxopionvi.Image = null;
                }
                else { MessageBox.Show("產品類別不能為空！"); }
            }
            catch { MessageBox.Show("請選擇一個類別"); }
        }

        private void btnoptiondel_Click(object sender, EventArgs e)
        {
            try
            {
                pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption.Remove(pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption[cbxoption.SelectedIndex]);
                optiondisplay();
            }
            catch { }
        }
        private void optionitem(object sender, EventArgs e)
        {
            try
            {
                tbxoption.Text = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption[cbxoption.SelectedIndex].name;
                nudoption.Value = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption[cbxoption.SelectedIndex].price;
                pbxopionvi.Image = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption[cbxoption.SelectedIndex].option;
            }
            catch { }
        }
        #endregion
        //egg cheese bacon etc
        #region gbxaddonitem
        private void btnaddinsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkadd(tbxadditem.Text) == true)
                {
                    pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem.Add(new AddOnItem(tbxadditem.Text.Trim(), Convert.ToUInt32(nudtiemsprice.Value), aa));//[cbxitem.SelectedIndex] = (new AddOnItem(tbxadditem.Text, Convert.ToUInt32(nudtiemsprice.Value)));
                    additem_display();
                }
                else
                {
                    MessageBox.Show("商品重複");
                }
            }
            catch { }
        }
        private void btnaddupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxadditem.Text != "")
                {
                    pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem[cbxaddtiem.SelectedIndex] = (new AddOnItem(tbxadditem.Text.Trim(), Convert.ToUInt32(nudtiemsprice.Value), aa));
                    additem_display();
                    pbxaddvi.Image = null;
                }
                else { MessageBox.Show("產品類別不能為空！"); }
            }
            catch { MessageBox.Show("請選擇一個類別"); }
        }
        private void btnadddel_Click(object sender, EventArgs e)
        {
            try
            {
                pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem.Remove(pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem[cbxaddtiem.SelectedIndex]);
                additem_display();
            }
            catch { }
        }
        private void cbxadditem(object sender, EventArgs e)
        {
            try
            {
                tbxadditem.Text = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem[cbxaddtiem.SelectedIndex].name;
                nudtiemsprice.Value = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem[cbxaddtiem.SelectedIndex].price;
                pbxaddvi.Image = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem[cbxaddtiem.SelectedIndex].add;
            }
            catch { }
        }
        #endregion
        bool dtcheck(string nn)//item
        {
            bool flag = true;
            for (int i = 0; i < pInfo[cbxdtchoic.SelectedIndex].item.Count; i++)
            {
                if (pInfo[cbxdtchoic.SelectedIndex].item[i].name.Equals(nn.Trim()))
                { flag = false; break; }
            }
            return flag;
        }
        bool dtcheckop(string nn)//option
        {
            bool flag = true;
            if (pInfo[cbxdtchoic.SelectedIndex].item[dgvitem.SelectedRows.Count].moption.Count > 0)
            {
                for (int i = 0; i < pInfo[cbxdtchoic.SelectedIndex].item[dgvitem.SelectedRows.Count].moption.Count; i++)
                {
                    if (pInfo[cbxdtchoic.SelectedIndex].item[dgvitem.SelectedRows.Count].moption[i].name.Equals(nn.Trim()))
                    { flag = false; break; }
                }
            }
            else { flag = true; }
            return flag;
        }
        bool dtcheckadd(string nn)//item
        {
            bool flag = true;
            if (pInfo[cbxdtchoic.SelectedIndex].item[dgvitem.SelectedRows.Count].addOnitem.Count > 0)
            {
                for (int i = 0; i < pInfo[cbxdtchoic.SelectedIndex].item[dgvitem.SelectedRows.Count].addOnitem.Count; i++)
                {
                    if (pInfo[cbxdtchoic.SelectedIndex].item[dgvitem.SelectedRows.Count].addOnitem[i].name.Equals(nn.Trim()))
                    { flag = false; break; }
                }
            }
            else { flag = true; }
            return flag;
        }
        private void btndatainsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxdtitem.Text != "" && tbxdtprice.Text != "")
                {
                    bool flag = true;
                    foreach (var p in tbxdtprice.Text)
                    { if (char.IsLetter(p)) { flag = false; break; } }
                    if (flag == true)
                    {
                        if (dtcheck(tbxdtitem.Text.Trim()) == true && dtcheckadd(tbxdtitem.Text) == true && dtcheckop(tbxdtitem.Text) == true)
                        {
                            dgvitem.Rows.Add(new object[] { tbxdtitem.Text.Trim(), tbxdtprice.Text });
                            tbxdtitem.Text = "";
                            tbxdtprice.Text = "";
                            pInfo[cbxdtchoic.SelectedIndex].item.Add(new Item((uint)pInfo[cbxchoice.SelectedIndex].item.Count - 1, tbxdtitem.Text.Trim(), uint.Parse(tbxdtprice.Text), bb, new List<AddOnItem>(), new List<Option>()));
                            cancelalltheselect();
                        }
                        else { MessageBox.Show("Repeat"); }
                    }
                    else { MessageBox.Show("Price should be num"); }
                }
                else { MessageBox.Show("Insert text Can't be null"); }
            }
            catch
            {
                MessageBox.Show("please read the menu first!");
            }
        }
        void datagridviewinital()
        {

            dgvitem.Columns.Clear();
            dgvadd.Columns.Clear();
            dgvoption.Columns.Clear();
            dgvitem.Columns.Add("", "Item");
            dgvitem.Columns.Add("", "Price");
            dgvadd.Columns.Add("", "Add on Item");
            dgvadd.Columns.Add("", "Price");
            dgvoption.Columns.Add("", "Option");
            dgvoption.Columns.Add("", "Price");
            for (int i = 0; i < dgvitem.Columns.Count; i++)
            {
                dgvitem.Columns[i].Width = 140;
            }
            try
            {
                for (int i = 0; i < pInfo[cbxdtchoic.SelectedIndex].item.Count; i++)
                {
                    dgvitem.Rows.Add(new object[] { pInfo[cbxdtchoic.SelectedIndex].item[i].name, pInfo[cbxdtchoic.SelectedIndex].item[i].price });
                }
                cancelalltheselect();
            }
            catch { }
        }
        private void cbxdtchoic_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                datagridviewinital();
            }
            catch { }
        }
        void cancelalltheselect()
        {
            dgvoption.ClearSelection();
            dgvitem.ClearSelection();
            dgvadd.ClearSelection();
        }
        private void btndtdel_Click(object sender, EventArgs e)
        {
            try
            {
                dgvitem.Rows.Remove(dgvitem.Rows[dtindex]);
                tbxdtitem.Text = "";
                tbxdtprice.Text = "";
                pInfo[cbxdtchoic.SelectedIndex].item.Remove(pInfo[cbxdtchoic.SelectedIndex].item[dtindex]);
                datagridviewinital();
            }
            catch
            {
            }
        }
        bool Custuomer_usable(string nn, string pp)//check name and phone
        {
            bool flag = true;
            int tt;
            if (int.TryParse(pp, out tt))
            {
                foreach (var n in name)
                {
                    if (n.Equals(nn))
                    {
                        flag = false; break;
                    }
                }
            }
            else { MessageBox.Show("Error phone format!"); flag = false; }
            return flag;
        }
        static int dtindex = 0;
        private void cellitem(object sender, DataGridViewCellEventArgs e)
        {
            dtindex = e.RowIndex;
            tbxdtitem.Text = dgvitem.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbxdtprice.Text = dgvitem.Rows[e.RowIndex].Cells[1].Value.ToString();
            datagridoptionadd();
        }
        void datagridoptionadd()
        {
            dgvadd.Columns.Clear();
            dgvoption.Columns.Clear();
            dgvadd.Columns.Add("", "Add on Item");
            dgvadd.Columns.Add("", "Price");
            dgvoption.Columns.Add("", "Option");
            dgvoption.Columns.Add("", "Price");
            for (int i = 0; i < dgvadd.Columns.Count; i++)
            {
                dgvadd.Columns[i].Width = 140;
                dgvoption.Columns[i].Width = 140;
            }
            if (pInfo[cbxdtchoic.SelectedIndex].item[dtindex].addOnitem.Count > 0)
            {
                for (int a = 0; a < pInfo[cbxdtchoic.SelectedIndex].item[dtindex].addOnitem.Count; a++)
                {
                    dgvadd.Rows.Add(new object[] { pInfo[cbxdtchoic.SelectedIndex].item[dtindex].addOnitem[a].name, pInfo[cbxdtchoic.SelectedIndex].item[dtindex].addOnitem[a].price });
                }
            }
            if (pInfo[cbxdtchoic.SelectedIndex].item[dtindex].moption.Count > 0)
            {
                for (int o = 0; o < pInfo[cbxdtchoic.SelectedIndex].item[dtindex].moption.Count; o++)
                {
                    dgvoption.Rows.Add(new object[] { pInfo[cbxdtchoic.SelectedIndex].item[dtindex].moption[o].name, pInfo[cbxdtchoic.SelectedIndex].item[dtindex].moption[o].price });
                }
            }
            dgvadd.ClearSelection();
            dgvoption.ClearSelection();
        }
        static int dtaddindex = 0;
        private void celladd(object sender, DataGridViewCellEventArgs e)
        {
            dtaddindex = e.RowIndex;
            tbxdtaddon.Text = dgvadd.Rows[e.RowIndex].Cells[0].Value.ToString(); tbxdtaddprice.Text = dgvadd.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        static int dtoptionindex = 0;
        private void celloption(object sender, DataGridViewCellEventArgs e)
        {
            dtoptionindex = e.RowIndex;
            tbxdtoption.Text = dgvoption.Rows[e.RowIndex].Cells[0].Value.ToString(); tbdtopprice.Text = dgvoption.Rows[e.RowIndex].Cells[1].Value.ToString();
        }
        private void btndtaddinsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxdtaddon.Text != "" && tbxdtaddprice.Text != "")
                {
                    bool flag = true;
                    foreach (var p in tbxdtaddprice.Text)
                    { if (char.IsLetter(p)) { flag = false; break; } }
                    if (flag == true)
                    {
                        if (dtcheckadd(tbxdtaddon.Text))
                        {
                            dgvadd.Rows.Add(new object[] { tbxdtaddon.Text.Trim(), tbxdtaddprice.Text });
                            tbxdtaddon.Text = ""; tbxdtaddprice.Text = "";
                            pInfo[cbxdtchoic.SelectedIndex].item[dtindex].addOnitem.Add(new AddOnItem(tbxdtaddon.Text.Trim(), Convert.ToUInt32(tbxdtaddprice.Text), null));
                            cancelalltheselect();
                            tbxdtaddon.Text = tbxdtaddprice.Text = "";
                        }
                        else { MessageBox.Show("Repeat"); }
                    }
                    else { MessageBox.Show("Price should be num"); }
                }
                else { MessageBox.Show("Insert text Can't be null"); }
            }
            catch
            {
                MessageBox.Show("please read the menu first!");
            }
        }
        private void btndtoptioninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxdtoption.Text != "" && tbdtopprice.Text != "")
                {
                    bool flag = true;
                    foreach (var p in tbdtopprice.Text)
                    { if (char.IsLetter(p)) { flag = false; break; } }
                    if (flag == true)
                    {
                        if (dtcheckadd(tbxdtoption.Text))
                        {
                            dgvoption.Rows.Add(new object[] { tbxdtoption.Text, tbdtopprice.Text });
                            tbxdtaddon.Text = ""; tbxdtaddprice.Text = "";
                            pInfo[cbxdtchoic.SelectedIndex].item[dtindex].moption.Add(new Option(tbxdtoption.Text.Trim(), Convert.ToUInt32(tbdtopprice.Text), null));
                            dgvadd.ClearSelection();
                            dgvitem.ClearSelection();
                            dgvoption.ClearSelection();
                            tbxdtoption.Text = ""; tbdtopprice.Text = "";
                        }
                        else { MessageBox.Show("Repeat"); }
                    }
                    else { MessageBox.Show("Price should be num"); }
                }
                else { MessageBox.Show("Insert text Can't be null"); }
            }
            catch
            {
                MessageBox.Show("please read the menu first!");
            }
        }
        private void btndtaddel_Click(object sender, EventArgs e)
        {
            try
            {
                dgvadd.Rows.Remove(dgvadd.Rows[dtaddindex]);
                tbxdtaddon.Text = tbxdtaddprice.Text = "";
                pInfo[cbxdtchoic.SelectedIndex].item[dtindex].addOnitem.Remove(pInfo[cbxdtchoic.SelectedIndex].item[dtindex].addOnitem[dtaddindex]);
                datagridviewinital();
            }
            catch
            {
            }
        }
        private void btndtoptiondel_Click(object sender, EventArgs e)
        {
            try
            {
                dgvoption.Rows.Remove(dgvoption.Rows[dtoptionindex]);
                tbxdtoption.Text = ""; tbdtopprice.Text = "";
                pInfo[cbxdtchoic.SelectedIndex].item[dtindex].moption.Remove(pInfo[cbxdtchoic.SelectedIndex].item[dtindex].moption[dtoptionindex]);
                datagridviewinital();
            }
            catch
            {
            }
        }
        private void btndtcatinsert_Click(object sender, EventArgs e)
        {
            if (pInfo != null)
            {
                if (tbxdtcat.Text.Trim() != "")
                {
                    bool flag = true;
                    foreach (var dtc in pInfo)
                    {
                        if (tbxdtcat.Text.Trim() == dtc.name)
                        {
                            flag = false; break;
                        }
                    }
                    if (flag == true)
                    {
                        pInfo.Add(new Category((uint)(pInfo.Count + 1), tbxdtcat.Text.Trim(), new List<Item>()));
                        GUIsetting.setStoreInfo(pInfo, this, cbxdtchoic);//add to combobox
                        cbxchoice.SelectedIndex = cbxchoice.Items.Count - 1;
                        tbxdtcat.Text = "";
                    }
                    else { MessageBox.Show("The category name Repeat!"); }

                }
                else { MessageBox.Show("添加的產品類別不能為空！"); }// Category ss=new Category(index,tbxproduct.Text);
            }
            else
            {
                pInfo.Add(new Category(1, tbxdtcat.Text.Trim(), new List<Item>()));
                GUIsetting.setStoreInfo(pInfo, this, cbxdtchoic);//add to combobox
                tbxdtcat.Text = "";
            }
        }

        private void btndtitemmod_Click(object sender, EventArgs e)
        {
            if (tbxdtitem.Text != "" && tbxdtprice.Text != "")
            {
                pInfo[cbxdtchoic.SelectedIndex].item[dtindex].name = tbxdtitem.Text;
                pInfo[cbxdtchoic.SelectedIndex].item[dtindex].price = Convert.ToUInt32(tbxdtprice.Text);
                tbxdtitem.Text = tbxdtprice.Text = "";
                datagridviewinital();
            }
            else { MessageBox.Show("Modify item cant be null!"); }
        }

        private void btndtaddmod_Click(object sender, EventArgs e)
        {
            if (tbxdtaddon.Text != "" && tbxdtaddprice.Text != "")
            {
                pInfo[cbxdtchoic.SelectedIndex].item[dtindex].addOnitem[dtaddindex].name = tbxdtaddon.Text;
                pInfo[cbxdtchoic.SelectedIndex].item[dtindex].addOnitem[dtaddindex].price = Convert.ToUInt32(tbxdtaddprice.Text);
                tbxdtaddon.Text = tbxdtaddprice.Text = "";
                datagridoptionadd();
            }
            else { MessageBox.Show("Modify item cant be null!"); }
        }

        private void btndtopmod_Click(object sender, EventArgs e)
        {
            if (tbxdtoption.Text != "" && tbdtopprice.Text != "")
            {
                pInfo[cbxdtchoic.SelectedIndex].item[dtindex].moption[dtoptionindex].name = tbxdtoption.Text;
                pInfo[cbxdtchoic.SelectedIndex].item[dtindex].moption[dtoptionindex].price = Convert.ToUInt32(tbdtopprice.Text);
                tbxdtoption.Text = tbdtopprice.Text = "";
                datagridoptionadd();
            }
            else { MessageBox.Show("Modify item cant be null!"); }
        }

        private void btndtcatdel_Click(object sender, EventArgs e)
        {
            try
            {
                tbxdtcat.Text = "";
                pInfo.Remove(pInfo[cbxdtchoic.SelectedIndex]);
                GUIsetting.setStoreInfo(pInfo, this, cbxdtchoic);//add to combobox
            }
            catch { MessageBox.Show("At least select an item"); }
        }
        private void btndtcatmod_Click(object sender, EventArgs e)
        {
            try
            {
                pInfo[cbxdtchoic.SelectedIndex].name = tbxdtcat.Text;
                tbxdtcat.Text = ""; GUIsetting.setStoreInfo(pInfo, this, cbxdtchoic);//add to combobox
            }
            catch { MessageBox.Show("At least select an item"); }
        }
        Bitmap bb;
        private void btnpbx_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                bb = new Bitmap(openFileDialog2.FileName);
                pbxview.Image = bb;
                pbxview.Visible = true;
                pbxview.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
        private void bencustdel_Click(object sender, EventArgs e)
        {
            try
            {
                name.Remove(name[nindex]);
                phone.Remove(phone[nindex]);
                birthday.Remove(birthday[nindex]);
                point.Remove(point[nindex]);
            }
            catch { }
        }
        //zedgraph
        //Line chart
        void CreateGraph(ZedGraphControl zed, ChartType type = ChartType.Line)
        {
            GraphPane mypane = zed.GraphPane;
            mypane.Title.FontSpec.Size = 16;
            mypane.XAxis.Title.FontSpec.Size = 16;
            mypane.XAxis.Scale.FontSpec.Size = 16;
            mypane.YAxis.MajorGrid.IsVisible = true;
            mypane.YAxis.Color = Color.Yellow;
            mypane.Chart.Fill = new Fill(Color.LightCyan, Color.LightGoldenrodYellow, -45F);//chart fill
            mypane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), -45F);
            mypane.Legend.Position = ZedGraph.LegendPos.InsideTopRight;
            mypane.Legend.FontSpec.Size = 16;
            switch (type)
            {
                case ChartType.Pie:
                    List<string> categoryname = new List<string>();
                    if (rbtdate.Checked == true)
                    {
                        if (rbxmoney.Checked == true)
                        {
                            List<double> money = new List<double>();
                            mypane.Title.Text = "商品占總營業額比";
                            categoryname.Add(bill[0].details[0].cname);
                            money.Add(0);
                            for (int i = 0; i < bill.Count; i++)
                            {
                                if (bill[i].now.Month == dateTimePicker1.Value.Month && bill[i].now.Year == dateTimePicker1.Value.Year)
                                {
                                    for (int j = 0; j < bill[i].details.Count; j++)
                                    {
                                        bool flag = false; int index = -1;
                                        for (int c = 0; c < categoryname.Count; c++)
                                        {
                                            if (bill[i].details[j].cname == categoryname[c])
                                            {
                                                flag = true; index = c; break;
                                            }
                                        }
                                        if (flag == true)
                                        {
                                            money[index] += (double)bill[i].details[j].price;
                                        }
                                        else
                                        {
                                            if (bill[i].details[j].cname != "")
                                            {
                                                categoryname.Add(bill[i].details[j].cname);
                                                money.Add((double)bill[i].details[j].price);
                                            }
                                        }
                                    }
                                }
                            }
                            string[] temp1 = categoryname.ToArray();
                            double[] temp2 = money.ToArray();
                            mypane.AddPieSlices(temp2, temp1);
                        }
                        else if (rbxnumber.Checked == true)
                        {
                            mypane.Title.Text = "商品占總營業額比";
                            categoryname.Add(bill[0].details[0].cname);
                            List<double> time = new List<double>();
                            time.Add(0);
                            for (int i = 0; i < bill.Count; i++)
                            {
                                if (bill[i].now.Month == dateTimePicker1.Value.Month && bill[i].now.Year == dateTimePicker1.Value.Year)
                                {
                                    for (int j = 0; j < bill[i].details.Count; j++)
                                    {
                                        bool flag = false; int index = -1;
                                        for (int c = 0; c < categoryname.Count; c++)
                                        {
                                            if (bill[i].details[j].cname == categoryname[c])
                                            {
                                                flag = true; index = c; break;
                                            }
                                        }
                                        if (flag == true)
                                        {
                                            time[index] += (double)bill[i].details[j].time;
                                        }
                                        else
                                        {
                                            if (bill[i].details[j].cname != "")
                                            {
                                                categoryname.Add(bill[i].details[j].cname);
                                                time.Add((double)bill[i].details[j].time);
                                            }
                                        }
                                    }
                                }
                            }
                            string[] temp1 = categoryname.ToArray();
                            double[] temp2 = time.ToArray();
                            mypane.AddPieSlices(temp2, temp1);
                        }
                    }
                    else
                    {
                        //category
                    }
                    break;
                case ChartType.Bar:
                    PointPairList plist = new PointPairList();
                    string[] xLabe = new string[bill.Count];
                    if (rbtdate.Checked == true)
                    {
                        mypane.XAxis.Title.Text = "日期";
                        mypane.YAxis.Title.Text = "營銷額";
                        mypane.Title.Text = "月銷量";
                        if (rbxmoney.Checked == true)
                        {
                            BarItem myBar1 = mypane.AddBar("營銷額", Date_sale(out xLabe), Color.Red);
                            for (int i = 0; i < myBar1.Points.Count; i++)
                            {
                                TextObj barLabel = new TextObj(myBar1.Points[i].Y.ToString(), myBar1.Points[i].X, myBar1.Points[i].Y + 30);
                                barLabel.FontSpec.Border.IsVisible = false;
                                barLabel.FontSpec.Border.Color = Color.Transparent;
                                mypane.GraphObjList.Add(barLabel);

                            }
                            mypane.XAxis.Scale.TextLabels = xLabe;
                            myBar1.Label.IsVisible = true;
                        }
                        else
                        {
                            mypane.YAxis.Title.Text = "訂單(筆)";
                            BarItem myBar1 = mypane.AddBar("營銷額", Date_times(out xLabe), Color.Red);
                            for (int i = 0; i < myBar1.Points.Count; i++)
                            {
                                TextObj barLabel = new TextObj(myBar1.Points[i].Y.ToString(), myBar1.Points[i].X, myBar1.Points[i].Y);
                                barLabel.FontSpec.Border.IsVisible = false;
                                barLabel.FontSpec.Border.Color = Color.Transparent;
                                mypane.GraphObjList.Add(barLabel);
                            }
                            mypane.XAxis.Scale.TextLabels = xLabe;
                            myBar1.Label.IsVisible = true;
                        }
                    }
                    else
                    {
                        mypane.Title.Text = "分析圖表";
                        mypane.XAxis.Title.Text = "產品名稱";
                        mypane.YAxis.Title.Text = "營銷額";
                        if (rbxmoney.Checked == true)
                        {
                            BarItem myBar1 = mypane.AddBar("營銷額", Product_sale(out xLabe), Color.Red);
                            for (int i = 0; i < myBar1.Points.Count; i++)
                            {
                                TextObj barLabel = new TextObj(myBar1.Points[i].Y.ToString(), myBar1.Points[i].X, myBar1.Points[i].Y);
                                barLabel.FontSpec.Border.IsVisible = false;
                                barLabel.FontSpec.Border.Color = Color.Transparent;
                                mypane.GraphObjList.Add(barLabel);
                            }
                            mypane.XAxis.Type = AxisType.Text;
                            mypane.XAxis.Scale.TextLabels = xLabe;
                            myBar1.Label.IsVisible = true;
                        }
                        else
                        {
                            BarItem myBar1 = mypane.AddBar("營銷額", Product_time(out xLabe), Color.Red);
                            for (int i = 0; i < myBar1.Points.Count; i++)
                            {
                                TextObj barLabel = new TextObj(myBar1.Points[i].Y.ToString(), myBar1.Points[i].X, myBar1.Points[i].Y);
                                barLabel.FontSpec.Border.IsVisible = false;
                                barLabel.FontSpec.Border.Color = Color.Transparent;
                                mypane.GraphObjList.Add(barLabel);
                            }
                            mypane.XAxis.Type = AxisType.Text;
                            mypane.XAxis.Scale.TextLabels = xLabe;
                            myBar1.Label.IsVisible = true;
                        }
                    }
                    break;
                case ChartType.Line:
                    mypane.Title.Text = "月銷量";
                    string[] xLabel = new string[bill.Count];
                    if (rbtdate.Checked == true)
                    {
                        mypane.XAxis.Title.Text = "日期";
                        mypane.YAxis.Title.Text = "營銷額";
                        if (rbxmoney.Checked == true)
                        {
                            LineItem mycurve = mypane.AddCurve("營銷額", Date_sale(out xLabel), Color.Red, SymbolType.Square);
                            mypane.XAxis.Scale.TextLabels = xLabel;
                        }
                        else
                        {
                            mypane.YAxis.Title.Text = "訂單(筆)";
                            LineItem mycurve = mypane.AddCurve("營銷額", Date_times(out xLabel), Color.Red, SymbolType.Square);
                            mypane.XAxis.Scale.TextLabels = xLabel;
                        }
                    }
                    else
                    {
                        mypane.Title.Text = "分析圖表";
                        mypane.XAxis.Title.Text = "產品名稱";
                        mypane.YAxis.Title.Text = "營銷額";
                        if (rbxmoney.Checked == true)
                        {
                            LineItem mycurve = mypane.AddCurve("營銷額", Product_sale(out xLabel), Color.Red, SymbolType.Square);
                            mypane.XAxis.Scale.TextLabels = xLabel; mypane.XAxis.Type = AxisType.Text;
                        }
                        else
                        {
                            LineItem mycurve = mypane.AddCurve("營銷額", Product_time(out xLabel), Color.Red, SymbolType.Square);
                            mypane.XAxis.Scale.TextLabels = xLabel; mypane.XAxis.Type = AxisType.Text;
                            mypane.XAxis.AxisGap = 50;
                        }
                    }
                    break;
            }
            zed.AxisChange();
            zed.Invalidate();
        }
        ChartType nowChartType = ChartType.Line;
        PointPairList Product_sale(out string[] temp1)
        {
            int x, y1;
            PointPairList plist = new PointPairList();
            List<string> productname = new List<string>();
            List<double> money = new List<double>();
            productname.Add(bill[0].details[0].name);
            money.Add(0);
            for (int i = 1; i < bill.Count; i++)
            {
                for (int j = 1; j < bill[i].details.Count; j++)
                {
                    bool flag = false; int index = -1;
                    for (int c = 0; c < productname.Count; c++)
                    {
                        if (bill[i].details[j].name == productname[c])
                        {
                            flag = true; index = c; break;
                        }
                    }
                    if (flag == true)
                    {
                        money[index] += (double)bill[i].details[j].price * bill[i].details[j].time;
                    }
                    else
                    {
                        if (bill[i].details[j].name != "")
                        {
                            productname.Add(bill[i].details[j].name);
                            money.Add((double)bill[i].details[j].price * bill[i].details[j].time);
                        }
                    }
                }
            }
            temp1 = productname.ToArray();
            double[] temp2 = money.ToArray();
            for (int i = 0; i < temp2.Length; i++)
            {
                y1 = (int)temp2[i];
                plist.Add(i, y1);
            }
            return plist;
        }
        PointPairList Product_time(out string[] temp1)
        {
            int x, y1;
            PointPairList plist = new PointPairList();
            List<string> productname = new List<string>();
            List<uint> time = new List<uint>();
            productname.Add(bill[0].details[0].name);
            time.Add(0);
            for (int i = 1; i < bill.Count; i++)
            {
                for (int j = 1; j < bill[i].details.Count; j++)
                {
                    bool flag = false; int index = -1;
                    for (int c = 0; c < productname.Count; c++)
                    {
                        if (bill[i].details[j].name == productname[c])
                        {
                            flag = true; index = c; break;
                        }
                    }
                    if (flag == true)
                    {
                        time[index] += (uint)(bill[i].details[j].time);
                    }
                    else
                    {
                        if (bill[i].details[j].name != "")
                        {
                            productname.Add(bill[i].details[j].name);
                            time.Add((uint)bill[i].details[j].time);
                        }
                    }
                }
            }
            temp1 = productname.ToArray();
            uint[] temp2 = time.ToArray();
            for (int i = 0; i < temp2.Length; i++)
            {
                y1 = (int)temp2[i];
                plist.Add(i, y1);
            }
            return plist;
        }
        PointPairList Date_sale(out string[] tt)
        {
            int x, y1;
            PointPairList plist = new PointPairList();
            string[] xLabe = new string[bill.Count];
            int day = -1;
            decimal total;
            int i = -1;
            do { i++; }
            while (bill[i].now.ToString("yyyy/MM") != dateTimePicker1.Value.ToString("yyyy/MM"));
            day = bill[i].now.Day;
            total = bill[i].sum;
            for (int j = i + 1; j < bill.Count; j++)
            {
                if (bill[j].now.ToString("yyyy/MM").Equals(dateTimePicker1.Value.ToString("yyyy/MM")))
                {
                    if (day != bill[j].now.Day || j == bill.Count - 1)
                    {
                        x = day;
                        day = bill[j].now.Day;
                        y1 = Convert.ToInt32(total);
                        plist.Add(x, y1);
                        xLabe[j - 1] = total.ToString();
                        total = bill[j].sum;
                    }
                    else { total += bill[j].sum; }
                }
            }
            tt = xLabe;
            return plist;
        }
        PointPairList Date_times(out string[] tt)
        {
            int x, y1;
            PointPairList plist = new PointPairList();
            string[] xLabe = new string[bill.Count];
            int day = -1;
            uint time;
            int i = -1;
            do { i++; }
            while (bill[i].now.ToString("yyyy/MM") != dateTimePicker1.Value.ToString("yyyy/MM"));
            day = bill[i].now.Day;
            time = 1;
            for (int j = i; j < bill.Count; j++)
            {
                if (bill[j].now.ToString("yyyy/MM").Equals(dateTimePicker1.Value.ToString("yyyy/MM")))
                {                 
                    x = day;
                    if (day != bill[j].now.Day || j == bill.Count - 1)
                    {                       
                        y1 = (int)time;
                        xLabe[j] = time.ToString();
                        plist.Add(x, y1);
                        time = 1;
                        day = bill[j].now.Day;
                    }
                    else { time += 1; }
                }
            }
            tt = xLabe;
            return plist;
        }
        private void btnrun_Click(object sender, EventArgs e)
        {
            try
            {
                zedGraphControl1.GraphPane = new GraphPane();
                zedGraphControl1.Visible = true;
                zedGraphControl1.Size = new Size(480, 500);
                CreateGraph(zedGraphControl1, nowChartType);
            }
            catch (Exception ee)
            {
                MessageBox.Show("請先讀取要進行分析的檔案!" + ee);
            }
        }
        private void grapthchart(object sender, EventArgs e)
        {
            rbnproduct.Visible = true;
            rbnproduct.Enabled = true;
            zedGraphControl1.GraphPane = new GraphPane();
            if (rbtbar.Checked)
            {
                nowChartType = ChartType.Bar;
            }
            if (rbtLine.Checked)
            {
                //line.zedgraph
                nowChartType = ChartType.Line;
            }
            if (rbtpie.Checked)
            {
                rbnproduct.Visible = false;
                rbnproduct.Enabled = false;
                nowChartType = ChartType.Pie;
            }
        }
        Bitmap oo; Bitmap aa;
        private void btnoptionp_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                oo = new Bitmap(openFileDialog2.FileName);
                pbxopionvi.Image = oo;
                pbxopionvi.Visible = true;
                pbxopionvi.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void btnaddp_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                aa = new Bitmap(openFileDialog2.FileName);
                pbxaddvi.Image = aa;
                pbxaddvi.Visible = true;
                pbxaddvi.BackgroundImageLayout = ImageLayout.Stretch;
            }
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

        private void datevisible(object sender, EventArgs e)
        {
            dateTimePicker1.Visible = rbtdate.Checked == true ? true : false;
            lbldatetip.Visible = rbtdate.Checked == true ? true : false;
        }
    }
}



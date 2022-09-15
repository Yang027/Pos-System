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
    public partial class ProductManagement : UserControl
    {
        List<Category> pInfo = new List<Category>();
        string initialpath = Application.StartupPath + "..//..//..//data";
        bool repeat = false;
        Image initalview = (Image)Resources.ResourceManager.GetObject("logo4.png");
        public ProductManagement()
        {
            InitializeComponent();
            openFileDialog2.InitialDirectory = Application.StartupPath + "..//..//..//info";
            normaltime();

        }
        void breakfast()
        {
            try
            {
                pInfo = RWitem.binaryreader(initialpath + "//breakfast.dat");
                cbxchoice.Text = ""; tbxindex.Text = "";
                cbxchoice.Items.Clear();
                cbxaddtiem.Items.Clear();
                cbxoption.Items.Clear();
                foreach (var c in pInfo)
                {
                    cbxchoice.Items.Add(c.name);
                }
            }
            catch { MessageBox.Show("請選擇正確的菜單"); }
        }
        void normaltime()
        {
            try
            {
                pInfo = RWitem.binaryreader(initialpath + "//menu.dat");
                cbxchoice.Text = ""; tbxindex.Text = "";
                cbxchoice.Items.Clear();
                cbxaddtiem.Items.Clear();
                cbxoption.Items.Clear();
                foreach (var c in pInfo)
                {
                    cbxchoice.Items.Add(c.name);
                }
            }
            catch { MessageBox.Show("請選擇正確的菜單"); }
        }
        void initialGUIsetting()
        {
            btnupdate.Visible = true;
            btndel.Visible = true;
            btninsert.Visible = true;
            cbxchoice.SelectedIndex = 0;
            pbxaddvi.Visible = pbxitemview.Visible = true;
        }
        private void select(object sender, EventArgs e)
        {
            try
            {
                tbxindex.Text = pInfo[cbxchoice.SelectedIndex].name;
                tbxitem.Text = "";
                nudprice.Value = 0;
                cbxitem.Items.Clear(); display(); optiondisplay();
                cbxitem.Text = "";
                additem_display();
                tbxadditem.Text = "";
                tbxoption.Text = "";
                nudoption.Value = 0;
                nudtiemsprice.Value = 0;
                pbxitemview.Image = (Image)Resources.ResourceManager.GetObject("shu.png");
                pbxaddvi.Image = (Image)Resources.ResourceManager.GetObject("shu.png"); btnupdate.Visible = false;
                pbxviewpicture.Image= (Image)Resources.ResourceManager.GetObject("shu.png");
            }
            catch
            {
                tbxindex.Text = pInfo[cbxchoice.SelectedIndex].name; tbxitem.Text = "";
                nudprice.Value = 0;
                tbxadditem.Text = "";
                tbxoption.Text = "";
                nudoption.Value = 0;
                nudtiemsprice.Value = 0; pbxitemview.Image = null;
            }
        }
        void display()//item
        {
            cbxoption.Items.Clear();
            cbxaddtiem.Items.Clear();
            for (int i = 0; i < pInfo[cbxchoice.SelectedIndex].item.Count; i++)
            {
                cbxitem.Items.Add(pInfo[cbxchoice.SelectedIndex].item[i].name);
            }
        }
        void optiondisplay()//option
        {
            tbxoption.Text = "";
            nudoption.Value = 0;
            cbxoption.Items.Clear();
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
            tbxadditem.Text = "";
            nudtiemsprice.Value = 0;
            cbxaddtiem.Items.Clear();
            if (cbxitem.SelectedItem != null)
            {
                for (int i = 0; i < pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem.Count; i++)
                {
                    cbxaddtiem.Items.Add(pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem[i].ToString());
                }
            }
        }
        Bitmap bb;
        private void itemselect(object sender, EventArgs e)
        {
            tbxitem.Text = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].name;
            nudprice.Value = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].price;
            pbxitemview.Image = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].item;
            pbxviewpicture.Image = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].item;
            bb = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].item;
            tbxadditem.Text = tbxoption.Text = "";
            optiondisplay();
            nudoption.Value = 0;
            nudtiemsprice.Value = 0;
            //  cbxitem.Items.Clear(); display();
            additem_display();
            pbxjudge.Visible = false;
            btnupdate.Visible = true;
        }

        private void optionitem(object sender, EventArgs e)
        {
            try
            {
                tbxoption.Text = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption[cbxoption.SelectedIndex].name;
                nudoption.Value = pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption[cbxoption.SelectedIndex].price;
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
        void viewupdate()
        {
            tbxviewitemname.Text = tbxitem.Text;
            tbxviewitempricfe.Text = nudprice.Value.ToString();
            pbxviewpicture.Image = pbxitemview.Image;
        }
        private void itemupdate(object sender, EventArgs e)
        {
            viewupdate();
        }

        private void update(object sender, EventArgs e)
        {
            viewupdate();
        }
        private void btnoptioninsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkop(tbxoption.Text) == true)
                {
                    pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption.Add(new Option(tbxoption.Text.Trim(), Convert.ToUInt32(nudoption.Value)));
                    optiondisplay();
                }
                else
                {
                    MessageBox.Show("something error!");
                }
            }
            catch (Exception ee) { }
        }
        Bitmap aa;
        private void btnaddinsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkadd(tbxadditem.Text) == true)
                {
                    pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem.Add(new AddOnItem(tbxadditem.Text.Trim(), Convert.ToUInt32(nudtiemsprice.Value), aa));
                    pbxaddvi.Image = initalview;
                    additem_display();
                }
                else
                {
                    MessageBox.Show("something error!");
                }
            }
            catch { }
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
                    if (tbxoption.Text.Trim() == "" || pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption[i].name.Equals(nn.Trim()))
                    { flag = false; break; }
                }
            }
            else { flag = tbxoption.Text.Trim() != "" ? true : false; }
            return flag;
        }
        bool checkadd(string nn)//item
        {
            bool flag = true;
            if (pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem.Count > 0)
            {
                for (int i = 0; i < pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem.Count; i++)
                {
                    if (tbxadditem.Text == "" || pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem[i].name.Equals(nn.Trim()))
                    { flag = false; break; }
                }
            }
            else { flag = tbxadditem.Text.Trim() != "" ? true : false; }
            return flag;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            if (tbxitem.Text != "")
            {
                if (check(tbxitem.Text) == true)
                {
                    //int ttmp = 0;
                    //char target = ' ';
                    //for(char i='a';i<'z'&&ttmp< cbxchoice.SelectedIndex; i++)
                    //{
                    //    target = i;
                    //    ttmp += 1;
                    //}
                    //pInfo[cbxchoice.SelectedIndex].item.Add(new Item(target + (pInfo[cbxchoice.SelectedIndex].item.Count).ToString(), tbxitem.Text.Trim(), Convert.ToUInt32(nudprice.Value), bb, new List<AddOnItem>(), new List<Option>()));
                    pInfo[cbxchoice.SelectedIndex].item.Add(new Item((uint)(pInfo[cbxchoice.SelectedIndex].item.Count-1), tbxitem.Text.Trim(), Convert.ToUInt32(nudprice.Value), bb, new List<AddOnItem>(), new List<Option>()));
                    string temp = tbxitem.Text;
                    cbxitem.Items.Clear(); display(); clear();
                    int index = -1;
                    do { index += 1; } while (cbxitem.Items[index].ToString() != temp);
                    cbxitem.SelectedIndex = index;
                
                }
                else { pbxjudge.Visible = true; pbxjudge.Image = imlist.Images[1]; repeat = true; }
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (tbxitem.Text != "")
            {
                if (check(tbxitem.Text) == true)
                {
                    //update category
                }
                else { pbxjudge.Image = imlist.Images[1]; repeat = true; }
            }
        }

        private void btnpbx_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                bb = new Bitmap(openFileDialog2.FileName);
                pbxitemview.Image = bb;
                pbxitemview.Visible = true;
                pbxviewpicture.Image = bb;
                pbxitemview.BackgroundImageLayout = ImageLayout.Stretch;
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

        private void btnoptionupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxoption.Text != "")
                {
                    pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].moption[cbxoption.SelectedIndex] = (new Option(tbxoption.Text.Trim(), Convert.ToUInt32(nudoption.Value)));
                    optiondisplay();
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

        private void btnaddupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxadditem.Text != "")
                {
                    pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].addOnitem[cbxaddtiem.SelectedIndex] = (new AddOnItem(tbxadditem.Text.Trim(), Convert.ToUInt32(nudtiemsprice.Value), aa));
                    additem_display();
                    pbxaddvi.Image = initalview;
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

        private void btnupdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tbxitem.Text != "")
                {
                    // MessageBox.Show("" + cbxitem.SelectedIndex);
                    pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].name = tbxitem.Text.Trim().Trim();
                    pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex].price = Convert.ToUInt32(nudprice.Value);
                    if (bb != null)
                    {
                        pbxitemview.Image = bb;
                    }
                    else { pbxitemview.Image = initalview; }
                    save();
                    string temp = tbxitem.Text;
                    cbxitem.Items.Clear();
                    display();              
                    additem_display();
                    optiondisplay();
                    int index = -1;
                    do { index += 1; } while (cbxitem.Items[index].ToString() != temp);
                    cbxitem.SelectedIndex = index;
                }
                else { MessageBox.Show("產品類別不能為空！"); }
            }
            catch (Exception ee) { MessageBox.Show("請選擇一個類別" + ee); }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            try
            {
                pInfo[cbxchoice.SelectedIndex].item.Remove(pInfo[cbxchoice.SelectedIndex].item[cbxitem.SelectedIndex]);
                pbxitemview.Image = initalview;
                pbxviewpicture.Image = initalview;
                pbxaddvi.Image = initalview;
                tbxitem.Text = "";
                nudtiemsprice.Value = 0;
                tbxadditem.Text = "";
                tbxoption.Text = "";
                nudprice.Value = 0;
                nudoption.Value = 0;
                cbxitem.Items.Clear();
                display();
                additem_display();
                optiondisplay();
            }
            catch { }
        }
        void save()
        {
            if (rbtbreak.Checked == true)
            {
                RWitem.savebinary(initialpath + "//breakfast.dat", pInfo); 
            }
            else
            {
                RWitem.savebinary(initialpath + "//menu.dat", pInfo);
            }
        }
        private void btnsave_Click(object sender, EventArgs e)
        {
            save(); MessageBox.Show("successfully save");
        }
        void clear()
        {
            cbxitem.Text = "";
            tbxadditem.Text = "";
            tbxindex.Text = "";
            tbxitem.Text = "";
            tbxoption.Text = "";
            tbxviewitemname.Text = "";
            tbxviewitempricfe.Text = "";
            pbxitemview.Image = Resources.logo4;
            pbxaddvi.Image = Resources.logo4;
            pbxjudge.Image = null;
            pbxviewpicture.Image = Resources.logo4; nudoption.Value = nudprice.Value = nudtiemsprice.Value = 0;
        }
        private void rbtbreak_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtbreak.Checked == true)
            {
                breakfast();
                clear();
            }
            else
            {
                normaltime();
                clear();
            }
        }

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
                        cbxchoice.Items.Clear();
                        foreach (var pp in pInfo)
                        {
                            cbxchoice.Items.Add(pp.name);
                        }
                        cbxchoice.SelectedIndex = cbxchoice.Items.Count - 1;
                    }
                    else { MessageBox.Show("Category Repeat!"); }
                }
                else
                {
                    Category cc = new Category(1, tbxindex.Text.Trim(), new List<Item>());
                    pInfo.Add(cc);
                    cbxchoice.Items.Clear();
                    foreach (var pp in pInfo)
                    {
                        cbxchoice.Items.Add(pp.name);
                    }
                    cbxchoice.SelectedIndex = cbxchoice.Items.Count - 1;
                    initialGUIsetting();
                }
            }
            else { MessageBox.Show("添加的產品類別不能為空！"); }
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
                    pbxviewpicture.Image = null;
                    tbxviewitempricfe.Text = "";
                    cbxchoice.Text = "";
                    tbxindex.Text = "";
                    clear();
                    cbxitem.Items.Clear(); for (int i = 0; i < pInfo.Count; i++)
                    {
                        cbxchoice.Items.Add(pInfo[i].name);
                    }
                }
                else { MessageBox.Show("選一個物件"); }
            }
            catch { MessageBox.Show("選一個物件"); }
        }
    }
}

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
    public partial class Sweetcard : UserControl
    {
        // placeB = { "可口可樂", "雪碧", "冰奶茶", "熱奶茶", "冰紅茶(無糖)", "熱紅茶", "薯餅", "特選黑咖啡", "薯條", "蛋捲冰淇淋" }; 
        // placeA = { "特選那堤", "特選卡布奇諾", "熱奶茶", "冰奶茶", "冰阿薩姆鮮奶茶", "特選黑咖啡", "特選重黑咖啡", "冰紅茶(無糖)",
        //"冰綠茶(無糖)", "薯條", "冰炫風(OREO)", "麥克雞塊(10塊)", "麥克雞塊(6塊)", "玉米湯" }
        List<placeA> pa=new List<placeA>();
        List<placeB> pb=new List<placeB>();
        Bitmap AA, BB;
        List<Category>pInfo=new List<Category>();
        SweetCard sw=null;
        Image iniimage = Resources.logo4;
        string path = Application.StartupPath + "..//..//..//data//sweetcard.bin";
        string initialpath = Application.StartupPath + "..//..//..//data//menu.dat";
        public Sweetcard()
        {
            InitializeComponent();
            initalsetting();
        }
        void initalsetting()
        {
            try
            {
                pInfo = RWitem.binaryreader(initialpath);
                sw = IOSweetCard.readSC(path);
                pa = new List<placeA>(); pb = new List<placeB>();
                foreach (var aa in sw.placeAitem)
                {
                    pa.Add(new placeA(aa));
                }
                foreach (var bb in sw.placeBitem)
                {
                    pb.Add(new placeB(bb));
                }
                displayPB();displayPA();
                foreach(var c in pInfo)
                {
                    cbxPAcat.Items.Add(c.name);
                    cbxPBcat.Items.Add(c.name);
                }
            }
            catch(Exception ee)
            {
                MessageBox.Show(ee.Message);
                pa = new List<placeA>();
                pa.Add(new placeA());
                pb = new List<placeB>();
                pb.Add(new placeB());
                sw = new SweetCard(pa, pb);
                IOSweetCard.saveSC(path, sw);
            }
        }
        bool checkrepeata()
        {
            bool flag = true;
            foreach(var a in pa)
            {
                if(tbxplacea.Text==a.name)
                {
                    flag = false;break;
                }
            }
            return flag;
        }
        bool checkrepeatb()
        {
            bool flag = true;
            foreach (var b in pb)
            {
                if (tbxplaceb.Text == b.name)
                {
                    flag = false; break;
                }
            }
            return flag;
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            if (tbxplacea.Text.Trim() != "")
            {
                if (checkrepeata() == true)
                {
                    pa.Add(new placeA(tbxplacea.Text.Trim(), (uint)nudprice.Value, (Bitmap)pbxplaceA.Image));
                    displayPA();
                    tbxplacea.Text = "";
                    pbxplaceA.Image = iniimage;
                }
                else { MessageBox.Show("repeat!"); }
            }
            
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            pa.Remove(pa[PAindex]);
            tbxplacea.Text = "";
            pbxplaceA.Image = iniimage;
            displayPA();
        }
        //--------------placeB
        private void btnbadd_Click(object sender, EventArgs e)
        {
            if (tbxplaceb.Text.Trim() != "")
            {
                if (checkrepeatb() == true)
                {
                    pb.Add(new placeB(tbxplaceb.Text.Trim(), (Bitmap)pbxplaceB.Image));
                    tbxplaceb.Text = "";
                    pbxplaceB.Image = iniimage;
                    displayPB();
                }
                else { MessageBox.Show("Repeat!"); }
            }
           
        }

        private void btnbmod_Click(object sender, EventArgs e)
        {
           
        }

        private void btnbdel_Click(object sender, EventArgs e)
        {
            tbxplaceb.Text = "";
            pbxplaceB.Image = iniimage;
            pb.Remove(pb[PBindex]);
            displayPB();
        }
        void displayPA()
        {
            lbxplaceA.Items.Clear();
            for(int i=0;i<pa.Count;i++)
            {
                lbxplaceA.Items.Add(pa[i].ToString());
            }
        }
        void displayPB()
        {
            lbxplaceB.Items.Clear();
            for (int i = 0; i < pb.Count; i++)
            {
                lbxplaceB.Items.Add(pb[i].name);
            }
        }
        private void btnplaceA_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                AA = new Bitmap(openFileDialog1.FileName);
                pbxplaceA.Image = AA;
            }
        }
        int PAindex, PBindex;
        private void selectA(object sender, EventArgs e)
        {
            PAindex=lbxplaceA.SelectedIndex;
            tbxplacea.Text = pa[PAindex].name;
            pbxplaceA.Image = pa[PAindex].view;
            nudprice.Value = pa[PAindex].money;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw = new SweetCard(pa, pb);
            IOSweetCard.saveSC(path, sw);
            MessageBox.Show("Successfully save");
        }

        private void cbxPAcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxitemA.Items.Clear();
            foreach(var ii in pInfo[cbxPAcat.SelectedIndex].item)
            {
                cbxitemA.Items.Add(ii.name);
            }
            tbxplacea.Text = "";           
            pbxplaceA.Image = iniimage;    
        }

        private void cbxitemA_SelectedIndexChanged(object sender, EventArgs e)
        {            
            tbxplacea.Text = pInfo[cbxPAcat.SelectedIndex].item[cbxitemA.SelectedIndex].name;
            pbxplaceA.SizeMode = PictureBoxSizeMode.Zoom;
            pbxplaceA.Image =(Image)pInfo[cbxPAcat.SelectedIndex].item[cbxitemA.SelectedIndex].item;
            nudprice.Value = pInfo[cbxPAcat.SelectedIndex].item[cbxitemA.SelectedIndex].price;
        }

        private void cbxPBcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxitemB.Items.Clear();
            foreach (var ii in pInfo[cbxPBcat.SelectedIndex].item)
            {
                cbxitemB.Items.Add(ii.name);
            }
            tbxplaceb.Text = "";
            pbxplaceB.Image = iniimage;
        }

        private void cbxitemB_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbxplaceb.Text = pInfo[cbxPBcat.SelectedIndex].item[cbxitemB.SelectedIndex].name;
            pbxplaceB.SizeMode = PictureBoxSizeMode.Zoom;
            pbxplaceB.Image = (Image)pInfo[cbxPBcat.SelectedIndex].item[cbxitemB.SelectedIndex].item;          
        }

        private void selectB(object sender, EventArgs e)
        {
            PBindex = lbxplaceB.SelectedIndex;
            tbxplaceb.Text = pb[PBindex].name;
            pbxplaceB.Image = pb[PBindex].view;
        }
        private void btnplaceB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                BB = new Bitmap(openFileDialog1.FileName);
                pbxplaceB.Image = BB;
            }
        }
    }
}

using MySql.Data.MySqlClient;
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
    public partial class Browser_menu : Form
    {
        List<Category> pInfo = null;
        DataGridView dt = null;
        List<DataGridView> dgv = new List<DataGridView>();
        DataGridViewImageColumn imageColumn;
        string Normaltime_Menu_Path = Application.StartupPath + "..//..//..//data//menu.dat";
        string Breakfasttime_Menu_Path = Application.StartupPath + "..//..//..//data//breakfast.dat";
        public Browser_menu()
        {
            InitializeComponent();
            // ini();
            cbxtimeoffer.SelectedIndex = 0;
        }

        void ini()
        {
            //StringBuilder sb = new StringBuilder();
            pInfo = RWitem.binaryreader(Breakfasttime_Menu_Path);
            HashSet<uint> tt = new HashSet<uint>();
            HashSet<string> ttt = new HashSet<string>();
            int ttmp = 1;
            for (int i = 0; i < pInfo.Count(); i++)
            {
                int tmp = 0;
                while (tt.Contains(pInfo[i].cID))
                {
                    pInfo[i].cID += 1;
                }
                tt.Add(pInfo[i].cID);
                char target = ' ';
                for (char j = 'a'; j < 'z' && tmp < pInfo[i].cID; j++)
                {
                    tmp += 1;
                    target = j;
                }
                for (int j = 0; j < pInfo[i].item.Count; j++)
                {
                    pInfo[i].item[j].mID = (uint)ttmp;
                    pInfo[i].mID = target + "";
                    ttmp += 1;
                }
            }
            RWitem.savebinary(Breakfasttime_Menu_Path, pInfo);

            pInfo = RWitem.binaryreader(Normaltime_Menu_Path);
            for (int i = 0; i < pInfo.Count(); i++)
            {
                int tmp = 0;
                while (tt.Contains(pInfo[i].cID))
                {
                    pInfo[i].cID += 1;
                }
                tt.Add(pInfo[i].cID);
                char target = ' ';
                for (char j = 'a'; j < 'z' && tmp <= pInfo[i].cID; j++)
                {
                    target = j; tmp += 1;
                }
                for (int j = 0; j < pInfo[i].item.Count; j++)
                {
                    pInfo[i].item[j].mID = (uint)ttmp;
                    pInfo[i].mID = target + "";
                    ttmp += 1;
                }
            }
            RWitem.savebinary(Normaltime_Menu_Path, pInfo);
            // MessageBox.Show(sb.ToString());
        }//資料整理
        void initalsetting()
        {
            try
            {
                tbc.Controls.Clear();
                for (int i = 0; i < pInfo.Count; i++)
                {
                    tbc.TabPages.Add(pInfo[i].name);
                    dt = new DataGridView() { Name = "dataGridView_" + i.ToString() };
                    imageColumn = new DataGridViewImageColumn();
                    dt.Columns.Add("", "商品名稱");
                    dt.Columns.Add("", "價格");
                    dt.Columns.Add("", "可增加選項");
                    dt.Columns.Add("", "選擇");
                    dt.Columns.Add(imageColumn);
                    imageColumn.HeaderText = "參考圖片";
                    imageColumn.Width = 150;
                    dt.RowHeadersVisible = false;
                    dt.ColumnHeadersHeight = 40;
                    dt.Width = tabPage1.Width;
                    dt.Height = tabPage1.Height;
                    dt.Columns[0].Width = 150;
                    dt.Columns[1].Width = 60;
                    dt.Columns[2].Width = dt.Columns[3].Width = 150;
                    dt.AllowUserToAddRows = dt.AllowUserToDeleteRows = dt.AllowUserToOrderColumns = dt.AllowUserToResizeColumns = dt.AllowUserToResizeRows = false;
                    dt.AllowUserToResizeColumns = false;
                    dt.ReadOnly = true;
                    dt.MultiSelect = false;
                    dt.Columns[2].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    dt.Columns[3].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                    for (int j = 0; j < pInfo[i].item.Count; j++)
                    {
                        string add = "";
                        string op = "";
                        foreach (var aa in pInfo[i].item[j].addOnitem)
                        {
                            add += aa.name + ":$" + aa.price + "\n";
                        }
                        foreach (var oo in pInfo[i].item[j].moption)
                        {
                            op += oo.name + ":$" + oo.price + "\n";
                        }
                        dt.Rows.Add(pInfo[i].item[j].name, "$" + pInfo[i].item[j].price, add + Environment.NewLine, op + Environment.NewLine, pInfo[i].item[j].item);
                        imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;
                        dt.Rows[j].Height = 80;
                    }
                    dt.AllowUserToAddRows = dt.AllowUserToDeleteRows = dt.AllowUserToOrderColumns = dt.AllowUserToResizeRows = false;
                    dt.ReadOnly = true;
                    tbc.TabPages[i].Controls.Add(dt); dt.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
                    dgv.Add(dt);
                }
            }
            catch (Exception ee) { MessageBox.Show("沒有正確讀檔！" + ee); }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxtimeoffer.SelectedIndex == 1)
            { pInfo = RWitem.binaryreader(Breakfasttime_Menu_Path); initalsetting(); }
            else { pInfo = RWitem.binaryreader(Normaltime_Menu_Path); initalsetting(); }
        }
    }

}



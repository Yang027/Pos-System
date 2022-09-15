using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace PD2020S_Examl_A108222027
{
    public partial class Analyze : UserControl
    {
        List<Category> cc; string initialldictionary = Application.StartupPath + "..//..//..//data";
        public enum ChartType { Bar, Line, Pie };
        List<Transaction> bill = new List<Transaction>();
        string initialpath = Application.StartupPath + "..//..//..//data";
        public Analyze()
        {
            InitializeComponent();
            bill = IOTransaction.readtranaction(initialpath + "//Transaction.bin");
            cc = RWitem.binaryreader(initialldictionary + "//menu.dat");
            zedGraphControl1.GraphPane = new GraphPane();
            zedGraphControl1.Visible = true;
            zedGraphControl1.Size = new Size(480, 500);
            CreateGraph(zedGraphControl1, nowChartType);
            try
            {
                dtpTo.MaxDate = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));
                dtpTo.MinDate = DateTime.Parse(DateTime.Now.ToString("5/1/yyyy"));
                dtpFrom.MaxDate = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));
                dtpFrom.MinDate = DateTime.Parse(DateTime.Now.ToString("5/1/yyyy"));
                dateTimePicker1.MaxDate = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy"));
                dateTimePicker1.MinDate = DateTime.Parse(DateTime.Now.ToString("5/dd/yyyy"));
                dtpFrom.Value = DateTime.Parse(DateTime.Now.ToString("5/24/2020"));
            }
            catch { }
        }

        private void change(object sender, EventArgs e)
        {
            rbnproduct.Visible = true;
            rbnproduct.Enabled = true;
            zedGraphControl1.GraphPane = new GraphPane();
            if (rbtbar.Checked)
            {
                nowChartType = ChartType.Bar;
                dateTimePicker1.Visible = false; groupBox1.Visible = rbtdate.Checked == true ? true : false;
                lbldatetip.Visible = rbtdate.Checked == true ? true : false;
            }
            else if (rbtLine.Checked)
            {
                //line.zedgraph
                nowChartType = ChartType.Line;
                dateTimePicker1.Visible = false; groupBox1.Visible = rbtdate.Checked == true ? true : false;
                lbldatetip.Visible = rbtdate.Checked == true ? true : false;
            }
            else
            {
                rbtdate.Checked = true;
                rbnproduct.Visible = false;
                rbnproduct.Enabled = false;
                nowChartType = ChartType.Pie;
                groupBox1.Visible = false;
                // groupBox1.Visible = rbtdate.Checked == true ? true : false;
                dateTimePicker1.Visible = rbtdate.Checked == true ? true : false;
            }
            try
            {
                zedGraphControl1.GraphPane = new GraphPane();
                zedGraphControl1.Visible = true;
                zedGraphControl1.Size = new Size(480, 480);
                CreateGraph(zedGraphControl1, nowChartType);
            }
            catch (Exception ee)
            {
                MessageBox.Show("請先讀取要進行分析的檔案!" + ee);
            }
        }
        #region Zedgraph Method
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
                            if (myBar1.Points.Count > 0)
                            {
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
                            else { MessageBox.Show("選擇的區段並未有交易記錄"); }
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
                            if (Date_times(out xLabel).Count > 0)
                            {
                                mypane.YAxis.Title.Text = "訂單(筆)";
                                LineItem mycurve = mypane.AddCurve("營銷額", Date_times(out xLabel), Color.Red, SymbolType.Square);
                                mypane.XAxis.Scale.TextLabels = xLabel;
                            }
                            else { MessageBox.Show("選擇的區段並未有交易記錄"); }
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
            List<double> productprice = new List<double>();
            double money = 0;
            for (int i = 0; i < cc.Count; i++)
            {
                for (int j = 0; j < cc[i].item.Count; j++)
                {
                    for (int t = 0; t < bill.Count; t++)
                    {
                        for (int d = 0; d < bill[t].details.Count; d++)
                        {
                            if (cc[i].item[j].name.Equals(bill[t].details[d].name))
                            {
                                money += (double)bill[t].details[d].price * bill[t].details[d].time;
                            }
                        }
                    }
                    if (money > 0)
                    {
                        productname.Add(cc[i].item[j].name);
                        productprice.Add(money);
                        money = 0;

                    }
                }
            }
            temp1 = productname.ToArray();
            double[] temp2 = productprice.ToArray();
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
            uint _time = 0;
            for (int i = 0; i < cc.Count; i++)
            {
                for (int j = 0; j < cc[i].item.Count; j++)
                {
                    for (int t = 0; t < bill.Count; t++)
                    {
                        for (int d = 0; d < bill[t].details.Count; d++)
                        {
                            if (cc[i].item[j].name.Equals(bill[t].details[d].name))
                            {
                                _time += bill[t].details[d].time;
                            }
                        }
                    }
                    if (_time > 0)
                    {
                        productname.Add(cc[i].item[j].name);
                        time.Add(_time);
                        _time = 0;
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
            decimal total = 0;
            int ttt = 0;
            if (dtpFrom.Value.Date <= dtpTo.Value.Date)
            {
                for (int i = 0; i < bill.Count; i++)
                {
                    TimeSpan ts = Convert.ToDateTime(bill[i].now.ToString("yyyy/MM/dd")) - Convert.ToDateTime(dtpFrom.Value.ToString("yyyy/MM/dd"));
                    TimeSpan ts1 = Convert.ToDateTime(bill[i].now.ToString("yyyy/MM/dd")) - Convert.ToDateTime(dtpTo.Value.ToString("yyyy/MM/dd"));
                    if (ts.TotalDays >= 0 && ts1.TotalDays <= 0)
                    {
                        if (ttt == 0)
                        {
                            day = bill[i].now.Day;
                            total = bill[i].sum; ttt += 1;
                        }
                        else
                        {
                            x = day;
                            if (day != bill[i].now.Day)
                            {
                                day = bill[i].now.Day;
                                y1 = Convert.ToInt32(total);
                                plist.Add(x, y1);
                                xLabe[i - 1] = total.ToString();
                                total = bill[i].sum;
                            }
                            else if (i == bill.Count - 1)
                            {
                                total += bill[i].sum;
                                day = bill[i].now.Day;
                                y1 = Convert.ToInt32(total);
                                plist.Add(x, y1); xLabe[i - 1] = total.ToString();
                            }
                            else { total += bill[i].sum; }
                        }
                    }
                }
                tt = xLabe;
                return plist;

            }
            else
            {
                tt = null;
                return plist;
            }
        }
        PointPairList Date_times(out string[] tt)
        {
            int x, y1;
            PointPairList plist = new PointPairList();
            string[] xLabe = new string[bill.Count];
            int day = -1;
            int time = -1;
            int ttt = 0;
            if (dtpFrom.Value.Date <= dtpTo.Value.Date)
            {
                for (int i = 0; i < bill.Count; i++)
                {
                    TimeSpan ts = Convert.ToDateTime(bill[i].now.ToString("yyyy/MM/dd")) - Convert.ToDateTime(dtpFrom.Value.ToString("yyyy/MM/dd"));
                    TimeSpan ts1 = Convert.ToDateTime(bill[i].now.ToString("yyyy/MM/dd")) - Convert.ToDateTime(dtpTo.Value.ToString("yyyy/MM/dd"));
                    if (ts.TotalDays >= 0 && ts1.TotalDays <= 0)
                    {
                        if (ttt == 0)
                        {
                            day = bill[i].now.Day;
                            time = 1; ttt += 1;
                        }
                        else
                        {
                            x = day;
                            if (day != bill[i].now.Day)
                            {
                                y1 = (int)time;
                                xLabe[i] = time.ToString();
                                plist.Add(x, y1);
                                time = 1;
                                day = bill[i].now.Day;
                            }
                            else if (i == bill.Count - 1)
                            {
                                time += 1;
                                day = bill[i].now.Day;
                                y1 = Convert.ToInt32(time);
                                plist.Add(x, y1); xLabe[i - 1] = time.ToString();
                            }
                            else { time += 1; }
                        }
                    }
                }
                tt = xLabe;
                return plist;
            }
            else
            {
                tt = null;
                return plist;
            }
        }
        #endregion

        private void date(object sender, EventArgs e)
        {
            //dateTimePicker1.Visible = rbtdate.Checked == true ? true : false;
            groupBox1.Visible = rbtdate.Checked == true ? true : false;
            lbldatetip.Visible = rbtdate.Checked == true ? true : false;
            show();
        }

        private void sdf(object sender, EventArgs e)
        {
            show();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            show();
        }

        private void dtpFrom_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Month != dtpTo.Value.Month)
            {
                dtpTo.Value = dtpFrom.Value;
            }
            show();
        }
        void show()
        {
            try
            {
                zedGraphControl1.GraphPane = new GraphPane();
                zedGraphControl1.Visible = true;
                zedGraphControl1.Size = new Size(480, 480);
                CreateGraph(zedGraphControl1, nowChartType);
            }
            catch (Exception ee)
            {
                MessageBox.Show("請先讀取要進行分析的檔案!" + ee);
            }
        }
        private void dateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            show();
        }

        private void dtpTo_ValueChanged(object sender, EventArgs e)
        {
            if (dtpFrom.Value.Month != dtpTo.Value.Month)
            {
                dtpFrom.Value = dtpTo.Value;
            }
            show();
        }
    }
}

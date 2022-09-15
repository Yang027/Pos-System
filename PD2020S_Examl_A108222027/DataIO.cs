using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PD2020S_Examl_A108222027.SystemInfo;

namespace PD2020S_Examl_A108222027
{
    public enum AccountLevel { Admin, Owner, Worker, Guest }
    class DataIO
    {
        public static bool savebill(string FN, ListBox lbx)
        {
            bool flag = true;
            StreamWriter sw = new StreamWriter(FN, true);
            string temp = "";
            for (int i = 0; i < lbx.Items.Count; i++)
            {
                temp += lbx.Items[i] + "\n";
            }
            sw.Write(temp);
            sw.Close();
            return flag;
        }
        public static bool saveReport(string filename, List<Transaction> transList)
        {
            bool flag = true;
            string ss = "";
            StreamWriter ww;
            foreach (var tt in transList)
            {
                ss += ("\n" + tt + "\n");
            }
            try
            {
                ww = File.AppendText(filename); //"AppendText"-->若檔案不存在會建立一個新的UTF-8的檔案
                ww.Write(ss);
                ww.Close();
            }
            catch (Exception ee) { flag = false; MessageBox.Show(ee.Message); }
            return flag;
        }//end of saveReport
    }
    //交易記錄IO
    class IOTransaction
    {
        public static bool savetransaction(string Fn, List<Transaction> Tt)
        {
            bool flag = true;
            FileStream output = File.Create(Fn);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(output, Tt);
            output.Close();
            return flag;
            //List<E>     ps:implict 
            //using(stream swb=File.Open(Fn,FileMode.Create))
            //{ foreach()}
        }
        public static List<Transaction> readtranaction(string fn)
        {
            FileStream input = File.OpenRead(fn);
            BinaryFormatter formatter = new BinaryFormatter();
            List<Transaction> cc = formatter.Deserialize(input) as List<Transaction>;
            input.Close();
            return cc;
        }
    }
    class IOSweetCard
    {
        public static bool saveSC(string Fn, SweetCard sc)
        {
            bool flag = true;
            FileStream output = File.Create(Fn);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(output, sc);
            output.Close();
            return flag;
        }
        public static SweetCard readSC(string fn)
        {
            FileStream input = File.OpenRead(fn);
            BinaryFormatter formatter = new BinaryFormatter();
            SweetCard sc = formatter.Deserialize(input) as SweetCard;
            input.Close();
            return sc;
        }

    }
    public class GUIsetting
    {
        public static void setStoreInfo(List<Category> cInfo, Form ff, ComboBox cat)
        {
            cat.Items.Clear();
            foreach (var cc in cInfo)
            {
                if (cc.item != null) { cat.Items.Add(cc.name); }
            }
            cat.Visible = true;
            cat.SelectedIndex = 0;
        }
    }
    public class RWaccount
    {
        //public static List<Account> readaccount()
        //{
        //    MySqlConnection conn = DBConnection.connectMariaDB("127.0.0.1", "3306", "root", "", "db2021f_pos4finalproject");
        //    if (conn == null) MessageBox.Show("Connection fail!!");
        //    else
        //    {
        //        // MessageBox.Show("Connection sucess!!");
        //        string ss = "SELECT * FROM account LIMIT 0,15";
        //        MySqlDataAdapter mda = new MySqlDataAdapter(ss, conn);
        //        DataSet ds = new DataSet();
        //        mda.Fill(ds);
        //        var tt = ds.Tables[0];
        //        List<Account> accountList = new List<Account>();
        //        for (int i = 0; i < tt.Rows.Count; i++)
        //        {
        //            //(string aa, string pp, AccountLevel ll, string nn,
        //            string ac = tt.Rows[i].ItemArray[0].ToString();
        //            string pw = tt.Rows[i].ItemArray[1].ToString();
        //            string name = tt.Rows[i].ItemArray[2].ToString();
        //            string level = tt.Rows[i].ItemArray[3].ToString();
        //            string logintime = tt.Rows[i].ItemArray[4].ToString();
        //            string logouttime = tt.Rows[i].ItemArray[5].ToString();
        //            string head = tt.Rows[i].ItemArray[6].ToString();
        //             MessageBox.Show(head.Length+"");
        //            Account acc = new Account(ac, pw, (AccountLevel)Enum.Parse(typeof(AccountLevel), level), name);

        //            acc.login = logintime;
        //            acc.logout = logouttime;
        //            acc.Head = BM.Base64StringToImage(head);
        //            accountList.Add(acc);
        //        }
        //        conn.Close();
        //        return accountList;
        //    }
        //    return null;
        //}
        public static bool binarysaveAcc(string FN, List<Account> ac)
        {
            bool flag = true;
            FileStream fs = File.Create(FN);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, ac);
            fs.Close();
            return flag;
        }
        public static List<Account> readbinaryAcc(string FN)
        {
            List<Account> ac = new List<Account>();
            FileStream fs = File.OpenRead(FN);
            BinaryFormatter bf = new BinaryFormatter();
            ac = bf.Deserialize(fs) as List<Account>;
            fs.Close();
            return ac;
        }
        public static bool saveAccount(string Fn, List<Account> ac)
        {
            bool flag = true;
            StreamWriter sw = new StreamWriter(Fn);
            foreach (var acc in ac)
            {
                sw.WriteLine(acc.account + "," + acc.password + "," + acc.level + "," + acc.Name);
            }
            sw.Close();
            return flag;
        }

        public static bool readAccount(string FN, out List<Account> aList)
        {
            StreamReader sr;
            bool flag = true;
            string[] numAccount;
            string[] contentAccount;
            aList = new List<Account>();
            Account aa;
            try
            {
                sr = File.OpenText(FN);
                numAccount = sr.ReadToEnd().Split(FileInfo.LINE_SPLITTER);
                for (int i = 0; i < numAccount.Length; i++)
                {
                    contentAccount = numAccount[i].Split(FileInfo.TEXT_SPLITTER);
                    if (contentAccount.Length >= FileInfo.ACCOUNT_ITEM)
                    {
                        aa = new Account(contentAccount[0].Trim(), contentAccount[1].Trim(),
                        (AccountLevel)Enum.Parse(typeof(AccountLevel), contentAccount[2].Trim(), false), contentAccount[3].Trim());
                        aList.Add(aa);
                        MessageBox.Show(aa.account);
                    }
                }
                sr.Close();
            }
            catch (Exception ee)
            {
                MessageBox.Show("" + ee);
                flag = false;
            }
            return flag;
        }
        public static bool saveAccount(string FN, List<string> all)
        {
            bool flag = true;
            try
            {
                StreamWriter ss = new StreamWriter(FN);
                for (int i = 0; i < all.Count; i++)
                {
                    ss.WriteLine(all[i]);
                }
                ss.Close();
            }
            catch (Exception ee)
            { MessageBox.Show("" + ee); flag = false; }

            return flag;
        }
        public static bool saveAccount(string FN, ListBox allac)
        {
            bool flag = true;
            try
            {
                StreamWriter ss = new StreamWriter(FN);
                for (int i = 0; i < allac.Items.Count; i++)
                {
                    ss.WriteLine(allac.Items[i]);
                }
                ss.Close();
            }
            catch (Exception ee)
            { MessageBox.Show("" + ee); flag = false; }

            return flag;
        }
        public static bool readaccount(string FN, out List<string> alldata)
        {
            bool flag = true;
            StreamReader sc;
            string ss;
            alldata = new List<string>();
            try
            {
                sc = File.OpenText(FN);
                while (!sc.EndOfStream)
                {
                    ss = sc.ReadLine().Trim();
                    string[] temp = ss.Split(',');
                    alldata.Add($"{temp[0]},{temp[1]},{temp[2]},{temp[3]}");
                }
                sc.Close();
            }
            catch (Exception ee)
            { MessageBox.Show("" + ee); flag = false; }
            return flag;
        }
    }
    public class RWitem
    {
        protected static string ImgToBase64String(Bitmap bmp)
        {
            try
            {
                //   Bitmap bmp = new Bitmap(Imagefilename);

                MemoryStream ms = new MemoryStream();
                bmp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] arr = new byte[ms.Length];
                ms.Position = 0;
                ms.Read(arr, 0, (int)ms.Length);
                ms.Close();
                return Convert.ToBase64String(arr);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        //base64編碼的字串轉為圖片
        protected static Bitmap Base64StringToImage(string strbase64)
        {
            try
            {
                byte[] arr = Convert.FromBase64String(strbase64);
                MemoryStream ms = new MemoryStream(arr);
                Bitmap bmp = new Bitmap(ms);

                //bmp.Save("test.jpg", System.Drawing.Imaging.ImageFormat.Jpeg);
                //bmp.Save("test.bmp", ImageFormat.Bmp);
                //bmp.Save("test.gif", ImageFormat.Gif);
                //bmp.Save("test.png", ImageFormat.Png);
                ms.Close();
                return bmp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        
        public static List<Category> readtxt(string FN)
        {
            StreamReader sr = new StreamReader(FN);
            #region
            //List<Category> cc = new List<Category>();
            //while (!sr.EndOfStream)
            //{
            //    string str = sr.ReadLine();
            //    string[] sp = str.Split('!');
            //    Item ii = new Item();
            //    ii.mID = (uint)int.Parse(sp[0]);
            //    ii.name = sp[1];
            //    ii.price = (uint)int.Parse(sp[2]);
            //    ii.item = Base64StringToImage(sp[3]);
            //    string[] tadd = sp[4].Split(']');
            //    List<AddOnItem> a = new List<AddOnItem>();
            //    for (int i = 0; i < tadd.Length; i++)
            //    {
            //        string[] add = tadd[i].Split(',');
            //        AddOnItem aa = new AddOnItem();
            //        aa.name = add[0];
            //        aa.price = (uint)int.Parse(add[1]);
            //        aa.add = Base64StringToImage(add[2]);
            //        a.Add(aa);
            //    }

            //    tadd = sp[5].Split('[');
            //    List<Option> o = new List<Option>();
            //    for (int i = 0; i < tadd.Length; i++)
            //    {
            //        string[] add = tadd[i].Split(',');
            //        Option aa = new Option();
            //        aa.name = add[0];
            //        aa.price = (uint)int.Parse(add[1]);
            //        aa.option = Base64StringToImage(add[2]);
            //        o.Add(aa);
            //    }
            //    ii.addOnitem = a;
            //    ii.moption = o;
            //}
            #endregion
            List<Category> cc = new List<Category>();
            StringBuilder sb = new StringBuilder();
            while(!sr.EndOfStream)
            {
                string str=sr.ReadLine();
                //str
            }
            sr.Close();
            return cc;
        }
        public static bool savebinary(string FN, List<Category> ss)
        {
            bool flag = true;
            FileStream output = File.Create(FN);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(output, ss);
            output.Close();
            return flag;
        }
        public static List<Category> binaryreader(string fn)
        {
            FileStream input = File.OpenRead(fn);
            BinaryFormatter formatter = new BinaryFormatter();
            List<Category> cc = formatter.Deserialize(input) as List<Category>;

            input.Close();
            return cc;
        }
    }
}

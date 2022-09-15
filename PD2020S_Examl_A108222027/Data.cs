//Author:Yang 
using PD2020S_Examl_A108222027.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PD2020S_Examl_A108222027
{
    [Serializable]
    public class Account
    {
        private string pAccount;
        private string ppassword;
        private AccountLevel pLeven;
        private string logouttime;
        private string loginttime;
        private Bitmap _head;
        //登录时间和离开的时间
        private string nickname;
        public string account { get { return pAccount; } set { if (CheckData.checkData(value)) pAccount = value; } }
        public string password { get { return ppassword; } set { if (CheckData.checkData(value)) ppassword = value; } }
        public string Name { get { return nickname; } set { nickname = value; } }
        public AccountLevel level { get { return pLeven; } set { pLeven = value; } }
        public string login { get { return loginttime; } set { loginttime = value; } }
        public string logout { get { return logouttime; } set { logouttime = value; } }
        public Bitmap Head { get { return _head = _head is null ? (Bitmap)Resources.headd : _head; } set { _head = value; } }
        public Account(string nn, string pp, AccountLevel ll, string n) { setinfo(nn, pp, ll, n, "", "", null); }
        public Account(Account aa) { setinfo(aa.account, aa.password, aa.level, aa.nickname, "", "", null); }
        void setinfo(string aa, string pp, AccountLevel ll, string nn, string dd, string logii, Bitmap head)
        {
            if ((aa != null) && (aa.Trim().Length > 0)) pAccount = aa;
            else pAccount = "test";
            if ((pp != null) && (pp.Trim().Length > 0)) ppassword = pp;
            else ppassword = "test";
            pLeven = ll; Name = nn;
            if (dd != "")
            { logout = dd; }
            else { logout = ""; }
            if (login != "")
            { login = logii; }
            else { login = ""; }
            Head = head == null ? Resources.headd : head;
        }
        public override string ToString()
        {
            return (pAccount + ", " + password + ", " + pLeven + ", " + Name);
        }
    }
    public class CheckData
    {
        public static bool checkAccount(List<Account> accounts, string account, string pw, out Account nowaccount)
        {
            var vv = from aa in accounts
                     where aa.account == account && aa.password == pw
                     select aa;//level;
            if (vv.Count() > 0)
            {
                nowaccount = new Account((Account)vv.ElementAt(0));
                //  nowaccount = new Account(account,pw,(AccountLevel)(vv.ElementAt(0))
                return true;
            }
            else { nowaccount = null; return false; }
        }
        public static bool checkData(string ss)
        {
            bool flag = false;
            bool letterdigit = false;
            if (ss.Length >= 4 && ss.Length < 12)
            {
                foreach (var temp in ss)
                {
                    // MessageBox.Show(""+temp);
                    if (!char.IsWhiteSpace(temp))
                    {
                        if (char.IsLetterOrDigit(temp) || temp == '_')
                        {
                            letterdigit = true;
                        }
                        else { letterdigit = false; break; }
                    }
                    else { letterdigit = false; break; }
                }
                if (letterdigit == true)
                {
                    flag = true;
                    return flag;
                }
                else { return flag; }
            }
            else { return flag; }
        }
    }
    public class BM
    {
        public static string ImgToBase64String(Bitmap bmp)
        {
            try
            {
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
        public static  Bitmap Base64StringToImage(string strbase64)
        {
            try
            {
                byte[] arr = Convert.FromBase64String(strbase64);
                MemoryStream ms = new MemoryStream(arr);
                Bitmap bmp = new Bitmap(ms);
                ms.Close();
                return bmp;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
    [Serializable]
    public class AddOnItem//egg cheese bacon etc
    {
        private string mName;
        private uint mPrice;
        private Bitmap madd;
        public string name { get { return mName; } set { mName = value; } }
        public uint price { get { return mPrice; } set { mPrice = value; } }
        public Bitmap add { get { return madd; } set { madd = value; } }
        public AddOnItem(AddOnItem aa)
        {
            setInitialInfo(aa.name, aa.price, aa.add);
        }
        public AddOnItem(string nn, uint pp, Bitmap bb)
        {
            setInitialInfo(nn, pp, bb);
        }
        void setInitialInfo(string nn, uint pp, Bitmap bb)
        {
            mName = nn != null ? nn : " ";
            mPrice = pp != 0 ? pp : 0;
            add = bb;
        }
        public AddOnItem()
        { setInitialInfo(" ", 0, null); }
        public override string ToString()
        {
            if (mName != "")
            {
                string ss = "+" + name + "$" + price + " "; return ss;
            }
            else { return ""; }

        }
    }
    [Serializable]
    public class SweetCard
    {
        private List<placeA> _placeAitem;
        private List<placeB> _placeBitem;
        public List<placeA> placeAitem { get { return _placeAitem; } set { _placeAitem = value; } }
        public List<placeB> placeBitem { get { return _placeBitem; } set { _placeBitem = value; } }
        public SweetCard(List<placeA> aa, List<placeB> bb)
        {
            placeAitem = aa;
            placeBitem = bb;
        }
    }
    [Serializable]
    public class placeA
    {
        private string _itemname;
        private uint _money;
        private Bitmap _view;
        public string name { get { return _itemname; } set { _itemname = value; } }
        public uint money { get { return _money; } set { _money = value; } }
        public Bitmap view { get { return _view; } set { _view = value; } }
        public placeA(string name, uint money, Bitmap bb)
        { setinfo(name, money, bb); }
        public placeA()
        {
            setinfo("", 0, null);
        }
        public placeA(placeA pp)
        {
            setinfo(pp.name, pp.money, pp.view);
        }
        void setinfo(string nn, uint mm, Bitmap bb)
        {
            name = nn;
            money = mm;
            view = bb == null ? null : bb;
        }
        public override string ToString()
        {
            return name + ":$" + money.ToString();
        }
    }
    [Serializable]
    public class placeB
    {
        private string _itemname; private Bitmap _view;
        public string name { get { return _itemname; } set { _itemname = value; } }
        public Bitmap view { get { return _view; } set { _view = value; } }
        public placeB(string name, Bitmap bb)
        { setinfo(name, bb); }
        public placeB()
        {
            setinfo("", null);
        }
        public placeB(placeB pp)
        {
            setinfo(pp.name, pp.view);
        }
        void setinfo(string nn, Bitmap bb)
        {
            name = nn;
            view = bb == null ? null : bb;
        }
        public override string ToString()
        {
            return name;
        }
    }
    [Serializable]
    public class Option//thin;thick;small
    {
        private string mname;
        private uint mPrice;
        private Bitmap moption;
        public uint price { get { return mPrice; } set { mPrice = value; } }
        public string name { get { return mname; } set { mname = value; } }
        public Bitmap option { get { return moption; } set { moption = value; } }
        public Option(string nn, uint pp, Bitmap bitmap)
        {
            setInitialInfo(nn, pp, bitmap);
        }
        public Option()
        {
            setInitialInfo(" ", 0, null);
        }
        public Option(Option oo)
        {
            setInitialInfo(oo.name, oo.price, oo.option);
        }
        public Option(string nn, uint pp)
        {
            setInitialInfo(nn, pp, null);
        }
        void setInitialInfo(string nn, uint pp, Bitmap bitmap)
        {
            mname = nn != null ? nn : " ";
            mPrice = pp != 0 ? pp : 0;
            option = bitmap;
        }

        public override string ToString()
        {
            if (mname != "")
            {
                string ss = "+" + name + "$" + price + " ";
                return ss;
            }
            else { return ""; }
        }
    }
    [Serializable]
    public class Category
    {
        private uint mCID;
        private string mName;
        private List<Item> mItem = new List<Item>();//difference kind
        public uint cID { get { return mCID; }/*set need to check*/set { mCID = value; } }
        public string name { get { return mName; } set { mName = value != null && value.Trim().Length > 0 ? value : null; } }
        public List<Item> item { get { return mItem; } set { mItem = value; } }
        private string _mID;
        public string mID { get { return _mID; } set { _mID = value; } }
        public Category()
        { setInitialInfo(1, "Category", new List<Item>()); }
        public Category(uint cc, string nn) { setInitialInfo(cc, nn, new List<Item>()); }
        public Category(uint cc, string nn, List<Item> ii)
        { setInitialInfo(cc, nn, ii); }
        void setInitialInfo(uint cc, string nn, List<Item> iio)
        {
            mCID = cc; mName = nn; item = iio;
            int tmp = 0;
            for (int i = 'a'; i < 'z' && tmp < cc; i++)
            {
                mID = i + "";
                tmp += 1;
            }
        }
    }
    [Serializable]
    public class Item
    {
        private List<AddOnItem> mAddOnItem = new List<AddOnItem>();//add item
        private List<Option> mOption = new List<Option>();//ice etc.
        private Bitmap pitem;
        // private string mCID;
        private string mName; private uint mPrice;
        // public string mID { get { return mCID; } set { mCID = value; } }
        private uint mCID;
        private string _cid;
        public string cid { get { return _cid; } set { _cid = value; } }
        public uint mID { get { return mCID; } set { mCID = value; } }
        public string name { get { return mName; } set { mName = value; } }
        public uint price { get { return mPrice; } set { mPrice = value; } }
        public Bitmap item { get { return pitem; } set { pitem = value; } }
        public List<AddOnItem> addOnitem { get { return mAddOnItem; } set { mAddOnItem = value; } }
        public List<Option> moption { get { return mOption; } set { mOption = value; } }
        public Item() { setInitialInfo(1, "Item", 0, null, new List<AddOnItem>(), new List<Option>()); }//"1"
        public Item(uint cc, string nn, uint pp, Bitmap bb, List<AddOnItem> ad, List<Option> op) { setInitialInfo(cc, nn, pp, bb, ad, op); }
        public Item(string nn, uint pp, Bitmap bb, List<AddOnItem> ad) { setInitialInfo(1, nn, pp, bb, ad, new List<Option>()); }//name=nn;price=pp;
        public Item(string nn, uint pp, Bitmap bb, List<Option> op) { setInitialInfo(1, nn, pp, bb, new List<AddOnItem>(), op); }
        //void setInitialInfo(string cc, string nn, uint pp, Bitmap ii, List<AddOnItem> add, List<Option> op)
        void setInitialInfo(uint cc, string nn, uint pp, Bitmap ii, List<AddOnItem> add, List<Option> op)
        {
            mID = cc;
            name = (nn == null || nn.Trim().Length == 0) ? "Item" : nn;
            item = ii;
            price = pp;
            moption = op;
            addOnitem = add;
            int tmp = 0;
            for (int i = 'a'; i < 'z' && tmp < cc; i++)
            {
                cid = i + "";
                tmp += 1;
            }
        }
        public override string ToString()
        {
            string ss = string.Format("{0,-20}", name) + "\t$" + price + "\n";
            return ss;
        }
    }
    [Serializable]//訂單編號
    public class Transaction//bill rec
    {
        private DateTime tnow;
        private string tcashier;
        private List<TransactionDetail> tdetails;
        private decimal tsum;
        private bool hangout;
        private int _td_id;
        public DateTime now { get { return tnow; } set { tnow = value; } }
        public string cashier { get { return tcashier; } set { tcashier = value; } }
        public List<TransactionDetail> details { get { return tdetails; } set { tdetails = value; } }
        public decimal sum { get { return tsum; } set { tsum = value; } }
        public bool Hangout { get { return hangout; } set { hangout = value; } }
        public int td_id { get { return _td_id; } set { _td_id = value; } }
        public Transaction() { setInfo(false, DateTime.Now, "", new List<TransactionDetail>(), 0, 0); }
        public Transaction(string nn) { setInfo(false, DateTime.Now, nn, new List<TransactionDetail>(), 0, 0); }
        public Transaction(bool hh, DateTime dt, string nn, List<TransactionDetail> dd, decimal total, int id) { setInfo(hh, dt, nn, dd, total, id); }
        void setInfo(bool hh, DateTime dd, string nn, List<TransactionDetail> td, decimal ss, int id)
        {
            Hangout = hh;
            now = dd;
            cashier = nn;
            details = td;
            sum = ss;
            td_id = id + 1;
        }
        public override string ToString()
        {
            string ss = "Shu Macdonload" + "\n";
            ss += now.ToShortTimeString() + " ";
            ss += "Cashier:" + cashier;
            foreach (var dd in details)
            {
                ss += "\n" + dd.name + ":" + dd.price.ToString() + "*" + dd.time.ToString() + ":$" + (dd.time * dd.price).ToString();
                if (dd.add.Count > 0)
                {
                    foreach (var a in dd.add)
                    {
                        ss += "\n" + a.ToString() + " ";
                    }
                }
                if (dd.op.Count > 0)
                {
                    foreach (var o in dd.op)
                    {
                        ss += "\n" + o.ToString() + " ";
                    }
                }
            }
            ss += "\n" + ("Total: " + sum.ToString());
            return ss;
        }
    }
    [Serializable]
    public class TransactionDetail//bill
    {
        private string dcname;//categoryname
        private string dname;//itemname
        private decimal dprice;
        private uint dtimes;
        private List<AddOnItem> daddon = new List<AddOnItem>();
        private List<Option> doption = new List<Option>();
        private uint dtotal;//no need
        public string cname { get { return dcname; } set { dcname = value; } }
        public string name { get { return dname; } set { dname = value; } }
        public decimal price { get { return dprice; } set { dprice = value; } }
        public uint time { get { return dtimes; } set { dtimes = value; } }
        public List<AddOnItem> add { get { return daddon; } set { daddon = value; } }
        public List<Option> op { get { return doption; } set { doption = value; } }
        public uint total { get { return dtotal; } set { dtotal = value; } }
        public TransactionDetail() { setinfo("", "", 0, 0, new List<AddOnItem>(), new List<Option>(), total); }
        public TransactionDetail(string cn, string nn, decimal pp, uint time, uint total) { setinfo(cn, nn, pp, time, new List<AddOnItem>(), new List<Option>(), total); }
        public TransactionDetail(string cn, string nn, decimal pp, uint time, List<AddOnItem> aa, List<Option> oo, uint total)
        { setinfo(cn, nn, pp, time, aa, oo, total); }
        void setinfo(string cn, string nn, decimal pp, uint time, List<AddOnItem> aa, List<Option> oo, uint tt)
        {
            cname = cn;
            price = pp;
            dtimes = time;
            name = nn;
            add = aa;
            op = oo;
            total = tt;
        }
    }
}

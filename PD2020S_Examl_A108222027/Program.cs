using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PD2020S_Examl_A108222027;

namespace PD2020S_Examl_A108222027
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.ApplicationExit += new EventHandler(close);
            Application.Run(new frmMainEntrance());//<----run this one
            // Application.Run(new buildpath());
            //  Application.Run(new StoreManage());

            //Application.Run(new Browser_menu());

            // Application.Run(new StoreManage());
            //Application.Run(new empolyeesystem());
            //List<Account> tem = RWaccount.readbinaryAcc("..//..//data//account.bin");
            // Application.Run(new Normaltime(tem[0]));
        }
        static private void close(object sender, EventArgs args)
        {
            List<Account> tem = RWaccount.readbinaryAcc("..//..//data//account.bin");//RWaccount.readaccount();
            int index = -1;
            try
            {
                do
                {
                    index++;
                }
                while (tem[index].account != frmMainEntrance.nowAccount.account);
                tem[index].logout = DateTime.Now.ToString();
                RWaccount.binarysaveAcc("..//..//data//account.bin", tem);
            }
            catch { Application.Exit(); }
        }
    }
}

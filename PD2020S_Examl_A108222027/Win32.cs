using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
namespace PD2020S_Examl_A108222027
{
    class Win32
    {
        public const int WM_STSSCOMMAND = 0x0112;
        public const int SC_MOVE = 0xF010;
        public const int HTPCAPTION =0x0002;
        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwdn, int wMsg, int mParm, int lParam);
    }
}

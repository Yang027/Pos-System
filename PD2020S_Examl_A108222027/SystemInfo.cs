using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD2020S_Examl_A108222027
{
    class SystemInfo
    {
        public enum AccountLevel { Admin, Owner, Worker,Guest }
    }
    public class FileInfo
    {
        public const char TEXT_SPLITTER = ',';
        public const char LINE_SPLITTER = '\n';
        public const char LEVEL1_SPLITTER = ';';
        public const char LEVEL2_SPLITTER = ':';
        public const int ACCOUNT_ITEM = 4;
    }
}

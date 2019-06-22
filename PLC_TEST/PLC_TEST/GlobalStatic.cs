using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PLC_TEST
{
    class GlobalStatic
    {
        public static string M03_01_ALIVE = "B100";
        public static string M03_01_READY = "B101";
        public static string M03_01_DOING = "B102";
        public static string M03_01_COMPLETE = "B103";
        public static string M03_01_JIG1_OK = "B104";
        public static string M03_01_JIG2_OK = "B105";

        public static string M03_01_ASKING = "B110";

        public static string M03_02_ALIVE = "B1200";
        public static string M03_02_READY = "B1201";
        public static string M03_02_DOING = "B1202";
        public static string M03_02_COMPLETE = "B1203";
        public static string M03_02_JIG1_OK = "B1204";
        public static string M03_02_JIG2_OK = "B1205";

        public static string M03_02_ASKING = "B1300";
    }
}

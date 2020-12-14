using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blade_Monitoring
{
    public class GlobalData
    {
        private static string c_name = "NONE";
        private static string m_name = "NONE";
        private static string h_name = "NONE";

        private static string image_path;

        private static string data_path;

        public static string IMAGE_PATH
        {
            get { return image_path; }
            set { image_path = value; }
        }

        public static string DATA_PATH
        {
            get { return data_path; }
            set { data_path = value; }
        }

        private static List<string> BCR_DATA = new List<string>();

        private static List<Insight_Values> IS_VALUES = new List<Insight_Values>();

        public static object Insight_object = new object();

        public static object bcr_object = new object();

        public static object db_object = new object();

        public static object db_select_object = new object();

        public static object ngList_db_object = new object();

        public static object Blocking_object = new object();

        public static bool Select_Data = false;

        public static bool NGList = false;

        public static bool NG_IMAGE = false;

        // 인사이트 값 받는 곳
        public class Insight_Values
        {
            public string P1;
            public string P2;
            public string P3;
            public string P4;
            public string DAN;
            public string WIDTH1;
            public string WIDTH2;
            public string P1_NOK;
            public string P2_NOK;
            public string P3_NOK;
            public string P4_NOK;
            public string WIDTH1_NOK;
            public string WIDTH2_NOK;
            public string bcr_data;
            public int background_run_index;
        }

        //쿼리 처리하는 bin
        public class query_argument
        {
            public string barcode_name;
            public string start_date;
            public string end_date;
            public bool date_check;
            public bool ng_check;
            public bool total;

            public query_argument(string bar, string s_date, string e_date, bool d_check, bool n_check, bool t)
            {
                barcode_name = bar;
                start_date = s_date;
                end_date = e_date;
                date_check = d_check;
                ng_check = n_check;
                total = t;
            }

            public query_argument(string bar, bool d_check, bool n_check, bool t)
            {
                barcode_name = bar;
                date_check = d_check;
                ng_check = n_check;
                total = t;
            }

            public query_argument(string s_date, string e_date, bool d_check, bool n_check, bool t)
            {
                start_date = s_date;
                end_date = e_date;
                date_check = d_check;
                ng_check = n_check;
                total = t;
            }

            public query_argument(bool d_check, bool n_check, bool t)
            {
                date_check = d_check;
                ng_check = n_check;
                total = t;
            }

        }

        public void ADD_BCR(string str)
        {
            BCR_DATA.Add(str);
        }

        public string GET_BCR_OLD_DATA()
        {
            return BCR_DATA[0];
        }

        public string GET_BCR_DATA_COUNT()
        {
            return BCR_DATA.Count.ToString();
        }

        public void REMOVE_BCR_OLD_DATA()
        {
            BCR_DATA.RemoveAt(0);
        }

        public void ADD_INSIGHT_VALUES(Insight_Values values)
        {
            IS_VALUES.Add(values);
        }

        public Insight_Values GET_IS_OLD_DATA()
        {
            return IS_VALUES[0];
        }

        public void REMOVE_IS_OLD_DATA()
        {
            IS_VALUES.RemoveAt(0);
        }

        public string GET_IS_DATA_COUNT()
        {
            return IS_VALUES.Count.ToString();
        }

        public void Set_cName(string str)
        {
            c_name = str;
        }

        public string Get_cName()
        {
            return c_name;
        }

        public void Set_mName(string str)
        {
            m_name = str;
        }

        public string Get_mName()
        {
            return m_name;
        }

        public void Set_hName(string str)
        {
            h_name = str;
        }

        public string Get_hName()
        {
            return h_name;
        }
    }
}

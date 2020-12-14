using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blade_Monitoring
{
    public class DB_Controller
    {
        // DB 정보이다
        static string server_ip = "localhost";
        static string dbname = "blade_db";
        static string username = "root";
        static string password = "4694";
        // 실제 연결할 DB의 정보를 입력해야 함
        static string ConnectionString =
            string.Format("SERVER={0};DATABASE={1};UID={2};PASSWORD={3};",
                server_ip, dbname, username, password);

        // DB 연결하는 객체
        MySqlConnection select_conn;

        MySqlConnection Blocking_conn;

        // SqlDataReader의 경우에는 커넥션을 가지고 있는데 Adapter는 쿼리가 끝나면 커넥션을 해제한다.
        MySqlDataAdapter adapter;

        // select command
        MySqlCommand select_command;

        MySqlCommand Blocking_command;

        public DB_Controller()
        {
            select_conn = new MySqlConnection(ConnectionString);
            Blocking_conn = new MySqlConnection(ConnectionString);

            if (select_conn.State == ConnectionState.Closed)
            {
                select_conn.Open();
            }

            if (Blocking_conn.State == ConnectionState.Closed)
            {
                Blocking_conn.Open();
            }

            select_command = new MySqlCommand("", select_conn);

            Blocking_command = new MySqlCommand("", Blocking_conn);

            adapter = new MySqlDataAdapter();

        }

        public DataTable[] DB_Show_Graph(string start_date, string end_date)
        {
            DataTable[] dataTables = new DataTable[6];
            string sql = "";
            string[] parameters = { "P1", "P2", "P3", "P4", "WIDTH1", "WIDTH2" };
            try
            {
                for (int i = 0; i < dataTables.Length; i++)
                {
                    dataTables[i] = new DataTable();

                    if (GlobalData.Select_Data)
                    {
                        sql = "SELECT " + parameters[i] + " FROM blade_table where barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) AND TIME BETWEEN '"
                            + start_date + "' AND '" + end_date + "'";
                    }
                    else
                    {
                        sql = "SELECT " + parameters[i] + " FROM blade_table where TIME BETWEEN '"
                            + start_date + "' AND '" + end_date + "'";
                    }
                    

                    select_command.CommandText = sql;

                    adapter.SelectCommand = select_command;

                    adapter.Fill(dataTables[i]);
                 
                }
            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "][" + sql + "]" + DateTime.Now);
            }
            return dataTables;
        }

        public DateTime[] Get_MinMax_Time()
        {
            DateTime[] dateTimes = new DateTime[2];
            string sql = "";

            try
            {
                sql = "SELECT MIN(TIME) min, MAX(TIME) max FROM blade_table";

                select_command.CommandText = sql;

                MySqlDataReader rdr = select_command.ExecuteReader();

                if (rdr == null) 
                {
                    dateTimes[0].AddYears(-100);
                }

                while (rdr.Read())
                {
                    dateTimes[0] = Convert.ToDateTime(rdr["min"]);
                    dateTimes[1] = Convert.ToDateTime(rdr["max"]);
                }

                rdr.Close();

            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "][" + sql + "]" + DateTime.Now);
            }

            return dateTimes;
        }


        public DataTable GET_NGLIST()
        {
            DataTable dt = new DataTable();
            string sql = "";
            try
            {
                if (GlobalData.NGList)
                {
                    sql = "SELECT * FROM nglist_table WHERE barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) ORDER BY last_time desc";
                }
                else
                {
                    sql = "SELECT * FROM nglist_table ORDER BY last_time desc";
                }


                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                lock (GlobalData.db_select_object)
                {

                    select_command.CommandText = sql;

                    adapter.SelectCommand = select_command;

                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "][" + sql + "]" + DateTime.Now);
            }


            return dt;
        }

        public void Delete_NGList()
        {
            string insertQuery = "";

            insertQuery = "DELETE FROM nglist_table";
            try
            {
                select_command.CommandText = insertQuery;
                select_command.ExecuteNonQuery();           
            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "][" + insertQuery + "]" + DateTime.Now);
            }
        }

        public DataTable GET_IMG_PATH()
        {
            DataTable dt = new DataTable();
            string sql = "";
            try
            {
                if (GlobalData.NG_IMAGE)
                {
                    sql = "SELECT * FROM img_table WHERE barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) ORDER BY time desc";
                }
                else
                {
                    sql = "SELECT * FROM img_table ORDER BY time desc";
                }


                select_command.CommandText = sql;

                adapter.SelectCommand = select_command;

                adapter.Fill(dt);

            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "][" + sql + "]" + DateTime.Now);
            }


            return dt;
        }

        public DataTable GET_ChoiceIMGPATH(DateTime startdate, DateTime enddate)
        {
            DataTable dt = new DataTable();
            string sql = "";
            try
            {
                if (GlobalData.NG_IMAGE)
                {
                    sql = "SELECT * FROM img_table WHERE barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) AND TIME BETWEEN '"
                    + string.Format("{0:u}", startdate) + "' AND '" + string.Format("{0:u}", enddate) + "' ORDER BY time desc";
                }
                else
                {
                    sql = "SELECT * FROM img_table WHERE TIME BETWEEN '"
                    + string.Format("{0:u}", startdate) + "' AND '" + string.Format("{0:u}", enddate) + "' ORDER BY time desc";
                }

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                lock (GlobalData.db_select_object)
                {
                    select_command.CommandText = sql;

                    adapter.SelectCommand = select_command;

                    adapter.Fill(dt);
                }

            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "][" + sql + "]" + DateTime.Now);
            }


            return dt;
        }

        public DataTable DB_SELECT(GlobalData.query_argument args)
        {
            DataTable dt = new DataTable();
            string sql = "";
            try
            {
                if (args.total)
                {
                    if (args.ng_check)
                    {
                        if (args.date_check)
                        {
                            if (GlobalData.Select_Data)
                            {
                                sql = "SELECT * FROM blade_table where TIME BETWEEN '"
                            + args.start_date + "' AND '" + args.end_date + "' AND barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) ORDER BY TIME asc, barcode asc";
                            }
                            else
                            {
                                sql = "SELECT * FROM blade_table where TIME BETWEEN '"
                            + args.start_date + "' AND '" + args.end_date + "' ORDER BY TIME asc, barcode asc";
                            }

                        }
                        else
                        {
                            if (GlobalData.Select_Data)
                            {
                                sql = "SELECT * FROM blade_table WHERE barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) ORDER BY TIME asc, barcode asc";
                            }
                            else
                            {
                                sql = "SELECT * FROM blade_table ORDER BY TIME asc, barcode asc";
                            }

                        }
                    }
                    else
                    {
                        if (args.date_check)
                        {
                            if (GlobalData.Select_Data)
                            {
                                sql = "SELECT * FROM blade_table where TIME BETWEEN '"
                            + args.start_date + "' AND '" + args.end_date + "' AND barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) AND ( (DAN != 'ok') OR (P1_NOK != 'ok') OR" +
                            " (P2_NOK != 'ok') OR (P3_NOK != 'ok') OR (P4_NOK != 'ok') OR (WIDTH1_NOK != 'ok') OR (WIDTH2_NOK != 'ok')) ORDER BY TIME asc, barcode asc";
                            }
                            else
                            {
                                sql = "SELECT * FROM blade_table where TIME BETWEEN '"
                            + args.start_date + "' AND '" + args.end_date + "' AND ( (DAN != 'ok') OR (P1_NOK != 'ok') OR" +
                            " (P2_NOK != 'ok') OR (P3_NOK != 'ok') OR (P4_NOK != 'ok') OR (WIDTH1_NOK != 'ok') OR (WIDTH2_NOK != 'ok')) ORDER BY TIME asc, barcode asc";
                            }

                        }
                        else
                        {
                            if (GlobalData.Select_Data)
                            {
                                sql = "SELECT * FROM blade_table WHERE barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) AND ((DAN != 'ok') OR (P1_NOK != 'ok') OR (P2_NOK != 'ok')"
                                + " OR (P3_NOK != 'ok') OR (P4_NOK != 'ok') OR (WIDTH1_NOK != 'ok') OR (WIDTH2_NOK != 'ok')) ORDER BY TIME asc, barcode asc";
                            }
                            else
                            {
                                sql = "SELECT * FROM blade_table WHERE (DAN != 'ok') OR (P1_NOK != 'ok') OR (P2_NOK != 'ok')"
                                + " OR (P3_NOK != 'ok') OR (P4_NOK != 'ok') OR (WIDTH1_NOK != 'ok') OR (WIDTH2_NOK != 'ok') ORDER BY TIME asc, barcode asc";
                            }

                        }
                    }
                }
                else
                {
                    if (args.ng_check)
                    {
                        if (args.date_check)
                        {
                            if (GlobalData.Select_Data)
                            {
                                sql = "SELECT * FROM blade_table where barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) AND (barcode = '" + args.barcode_name
                                    + "' AND TIME BETWEEN '" + args.start_date + "' AND '" + args.end_date + "') ORDER BY TIME asc, barcode asc";
                            }
                            else
                            {
                                sql = "SELECT * FROM blade_table where barcode = '" + args.barcode_name
                                    + "' AND TIME BETWEEN '" + args.start_date + "' AND '" + args.end_date + "' ORDER BY TIME asc, barcode asc";
                            }

                        }
                        else
                        {
                            if (GlobalData.Select_Data)
                            {
                                sql = "SELECT * FROM blade_table where barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) AND barcode = '" + args.barcode_name + "' ORDER BY TIME asc, barcode asc";
                            }
                            else
                            {
                                sql = "SELECT * FROM blade_table where barcode = '" + args.barcode_name + "' ORDER BY TIME asc, barcode asc";
                            }

                        }
                    }
                    else
                    {
                        if (args.date_check)
                        {
                            if (GlobalData.Select_Data)
                            {
                                sql = "SELECT * FROM blade_table where barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) AND barcode = '" + args.barcode_name
                                    + "' AND TIME BETWEEN '" + args.start_date + "' AND '" + args.end_date + "' AND ( (DAN != 'ok') OR (P1_NOK != 'ok') OR" +
                                    " (P2_NOK != 'ok') OR (P3_NOK != 'ok') OR (P4_NOK != 'ok') OR (WIDTH1_NOK != 'ok') OR (WIDTH2_NOK != 'ok')) ORDER BY TIME asc, barcode asc";
                            }
                            else
                            {
                                sql = "SELECT * FROM blade_table where barcode = '" + args.barcode_name
                                    + "' AND TIME BETWEEN '" + args.start_date + "' AND '" + args.end_date + "' AND ( (DAN != 'ok') OR (P1_NOK != 'ok') OR" +
                                    " (P2_NOK != 'ok') OR (P3_NOK != 'ok') OR (P4_NOK != 'ok') OR (WIDTH1_NOK != 'ok') OR (WIDTH2_NOK != 'ok')) ORDER BY TIME asc, barcode asc";
                            }

                        }
                        else
                        {
                            if (GlobalData.Select_Data)
                            {
                                sql = "SELECT * FROM blade_table where barcode NOT IN (SELECT Filtered_barcode as barcode FROM blocking_table) AND barcode = '" + args.barcode_name + "' AND ( (DAN != 'ok') OR (P1_NOK != 'ok')" +
                                " OR (P2_NOK != 'ok') OR (P3_NOK != 'ok') OR (P4_NOK != 'ok') OR (WIDTH1_NOK != 'ok') OR (WIDTH2_NOK != 'ok')) ORDER BY TIME asc, barcode asc";
                            }
                            else
                            {
                                sql = "SELECT * FROM blade_table where barcode = '" + args.barcode_name + "' AND ( (DAN != 'ok') OR (P1_NOK != 'ok')" +
                                " OR (P2_NOK != 'ok') OR (P3_NOK != 'ok') OR (P4_NOK != 'ok') OR (WIDTH1_NOK != 'ok') OR (WIDTH2_NOK != 'ok')) ORDER BY TIME asc, barcode asc";
                            }

                        }
                    }

                }

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                lock (GlobalData.db_select_object)
                {
                    //MySqlCommand cmd = new MySqlCommand(sql, select_conn);
                    ////MySqlDataReader table = cmd.ExecuteReader();

                    //MySqlDataReader rdr = cmd.ExecuteReader();

                    //dt.Load(rdr);
                    //rdr.Close();

                    select_command.CommandText = sql;

                    adapter.SelectCommand = select_command;

                    adapter.Fill(dt);
                }


            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "][" + sql + "]" + DateTime.Now);
            }


            return dt;
        }


        #region Blocking Data

        public void INSERT_BlockingData(string bcr_name)
        {
            string insertQuery = "";
            try
            {
                lock (GlobalData.Blocking_object)
                {
                    insertQuery = "INSERT INTO blocking_table(Filtered_barcode) VALUES('" + bcr_name + "')";
                    Blocking_command.CommandText = insertQuery;
                    Blocking_command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "][" + insertQuery + "]" + DateTime.Now);
            }
        }

        public void Delete_BlockingData(string bcr_name)
        {
            string insertQuery = "";
            try
            {
                lock (GlobalData.Blocking_object)
                {
                    if (bcr_name.Equals("AllData"))
                    {
                        insertQuery = "DELETE FROM blocking_table";
                    }
                    else
                    {
                        insertQuery = "DELETE FROM blocking_table where Filtered_barcode = '" + bcr_name + "'";
                    }

                    Blocking_command.CommandText = insertQuery;
                    Blocking_command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "][" + insertQuery + "]" + DateTime.Now);
            }
        }

        public DataTable Get_BlockingTable()
        {
            DataTable dt = new DataTable();
            string sql = "";
            try
            {
                sql = "SELECT * FROM blocking_table ORDER BY Registration_Date desc";

                //ExecuteReader를 이용하여
                //연결 모드로 데이타 가져오기
                lock (GlobalData.Blocking_object)
                {

                    select_command.CommandText = sql;

                    adapter.SelectCommand = select_command;

                    adapter.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                Log("[" + ex.ToString() + "][" + sql + "]" + DateTime.Now);
            }


            return dt;
        }

        #endregion
        public void Log(String msg)
        {
            DateTime today = DateTime.Now;
            string dir_y = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year;
            string dir_m = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month;

            string FilePath = Directory.GetCurrentDirectory() + @"\Logs\" + today.Year + @"\" + today.Month + @"\" + DateTime.Today.ToString("yyyyMMdd")
                + "_DBC.log";
            string DirPath = Directory.GetCurrentDirectory() + @"\Logs";


            DirectoryInfo di = new DirectoryInfo(DirPath);

            DirectoryInfo di_y = new DirectoryInfo(dir_y);

            DirectoryInfo di_m = new DirectoryInfo(dir_m);

            FileInfo fi = new FileInfo(FilePath);

            try
            {
                if (di.Exists != true) Directory.CreateDirectory(DirPath);
                if (di_y.Exists != true) Directory.CreateDirectory(dir_y);
                if (di_m.Exists != true) Directory.CreateDirectory(dir_m);
                if (fi.Exists != true)
                {
                    using (StreamWriter sw = new StreamWriter(FilePath))
                    {
                        sw.WriteLine(msg);
                        sw.Close();
                    }
                }
                else
                {
                    using (StreamWriter sw = File.AppendText(FilePath))
                    {
                        sw.WriteLine(msg);
                        sw.Close();
                    }
                }
            }
            catch (Exception e)
            {

            }

        }
    }
}

using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnBMCSDL
{
    internal class DatabaseUtils
    {
        public static OracleConnection Conn;
        public static string host;
        public static string port;
        public static string sid;
        public static string user;
        public static string password;

        public static void init(string host, string port, string sid, string user, string password)
        {
            DatabaseUtils.host = host;
            DatabaseUtils.port = port;
            DatabaseUtils.sid = sid;
            DatabaseUtils.user = user;
            DatabaseUtils.password = password;
        }
        public static bool Connect()
        {
            try
            {

                // Chuỗi kết nối mới
                var builder = new OracleConnectionStringBuilder();
                builder["Data Source"] = $"(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={host})(PORT={port}))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME={sid})))";
                builder["User ID"] = user;
                builder["Password"] = password;

                if (!string.IsNullOrEmpty(user) && user.ToUpper() == "SYS")
                    builder["DBA Privilege"] = "SYSDBA";

                Conn = new OracleConnection(builder.ConnectionString);
                Conn.Open();


                return true;
            }
            catch (Exception ex)
            {
                Conn = null;
                return false;
                throw ex;
            }
        }

        public static OracleConnection GetConnection()
        {
            if (Conn == null || Conn.State != System.Data.ConnectionState.Open)
            {
                Connect();
            }
            return Conn;
        }

        public static void CloseConnection()
        {
            try
            {
                if (Conn != null)
                {
                    if (Conn.State != ConnectionState.Closed)
                        Conn.Close();   // 🔸 chỉ đóng connection hiện tại

                    Conn.Dispose();     // 🔸 giải phóng resource
                    Conn = null;        // 🔸 cho phép tạo connection mới sau này
                    Console.WriteLine("Kết nối đã được đóng và giải phóng.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi khi đóng kết nối: " + ex.Message);
            }
        }




        public static bool checkConnection()
        {
            if (Conn.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            return false;
        }

    }
}

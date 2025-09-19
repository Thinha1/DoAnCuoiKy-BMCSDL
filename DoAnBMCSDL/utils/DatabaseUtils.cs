using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OracleConnect
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
            string consys = "";
            try
            {
                if (user.ToUpper().Equals("SYS"))
                    {
                    consys = ";DBA Privilege=SYSDBA;";
                    }
                
                //Connection String
                string connectionString = $"Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST={host})(PORT={port}))(CONNECT_DATA=(SERVER=DEDICATED)(SID={sid})));" +
                    $"User ID={user};Password={password}" + consys;
                //Run connect
                Conn = new OracleConnection(connectionString);
                Conn.Open();
                return true;
            }
            catch(Exception ex)
            {
                return false;
            }
        }

        public static OracleConnection GetConnection()
        {
            if (Conn == null)
            {
                Connect();
            }
            return Conn;
        }

        public static void CloseConnection()
        {
            if(Conn != null)
            {
                Conn.Close();
            }    
        }

        public static bool checkConnection()
        {
            if(Conn.State == System.Data.ConnectionState.Open)
            {
                return true;
            }
            return false;
        }
            
    }
}

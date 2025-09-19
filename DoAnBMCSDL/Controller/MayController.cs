using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using OracleConnect.Model;
namespace OracleConnect.Controller
{
    public class MayController
    {

        internal List<May> GetAllMay()
        {
            List<May> list = new List<May>();
            string query = "SELECT MaMay, Loai, TrangThai from thinh.MAY";
            DataTable dt = new DataTable();
            using (OracleConnection conn = DatabaseUtils.GetConnection())
            using (OracleCommand cmd = new OracleCommand(query, conn))
            {
                using (OracleDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        May m = new May()
                        {
                            MaMay = reader["MAMAY"].ToString(),
                            Loai = reader["LOAI"].ToString(),
                            TrangThai = reader["TRANGTHAI"].ToString()

                        };
                        list.Add(m);
                    }
                }
            }
            return list;
        }
    }
}

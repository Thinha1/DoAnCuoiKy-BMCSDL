using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using DoAnBMCSDL.Model;
namespace DoAnBMCSDL.Controller
{
    public class MayController
    {
        private static OracleConnection Conn;
        internal List<May> GetAllMay()
        {
            List<May> list = new List<May>();
            string query = "SELECT MaMay, Loai, TrangThai, NGUOITAO, NGAYTAO FROM thinh.MAY";

            //Connection tinh
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();

            using (var cmd = new OracleCommand(query, Conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new May
                    {
                        MaMay = reader["MAMAY"].ToString(),
                        Loai = reader["LOAI"].ToString(),
                        TrangThai = reader["TRANGTHAI"].ToString(),
                        NguoiTao = reader["NGUOITAO"].ToString(),
                        NgayTao = reader.GetDateTime(reader.GetOrdinal("NGAYTAO"))
                    });
                }
            }
            return list;
        }

    }
}

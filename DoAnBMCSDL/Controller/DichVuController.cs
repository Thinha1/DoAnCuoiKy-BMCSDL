using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnBMCSDL.Model;
using Oracle.ManagedDataAccess.Client;

namespace DoAnBMCSDL.Controller
{
    internal class DichVuController
    {
        private static OracleConnection Conn;
        public List<DichVu> getAllDichVu()
        {
            List<DichVu> list = new List<DichVu>();
            string query = "SELECT MaDV, TenDV, DonGia, NguoiTao, NgayTao, NguoiSua, NgaySua from thinh.DICHVU";
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();
            OracleCommand omd = new OracleCommand(query, Conn);

            using (var cmd = new OracleCommand(query, Conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new DichVu
                    {
                        MaDV = reader["MaDV"].ToString(),
                        TenDV = reader["TenDV"].ToString(),
                        DonGia = float.Parse(reader["DonGia"].ToString()),
                        NguoiTao = reader["NguoiTao"].ToString(),
                        NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao")),
                        NguoiSua = reader["NguoiSua"].ToString(),
                        NgaySua = reader.IsDBNull(reader.GetOrdinal("NgaySua")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("NgaySua"))
                    });
                }
            }
            return list;
        }

        public bool InsertDV(string tendv, float dongia)
        {
            try
            {
                return true;
            }catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

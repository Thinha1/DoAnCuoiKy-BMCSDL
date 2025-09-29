using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnBMCSDL.Model;
using Oracle.ManagedDataAccess.Client;
using OracleConnect;
using OracleConnect.Model;

namespace DoAnBMCSDL.Controller
{
    internal class KhachHangController
    {
        private static OracleConnection Conn;

        internal List<KhachHang> getAllKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            string query = "SELECT MaKH, HoTen, SoDienThoai, CCCD, SoDu, NGUOITAO, NGAYTAO FROM thinh.KhachHang";

            //Connection tinh
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();

            using (var cmd = new OracleCommand(query, Conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new KhachHang
                    {
                        MaKH = reader["MaKH"].ToString(),
                        TenKH = reader["HoTen"].ToString(),
                        SoDienThoai = reader["SoDienThoai"].ToString(),
                        CCCD = reader["CCCD"].ToString(),
                        SoDu = float.Parse(reader["SoDu"].ToString()),
                        NguoiTao = reader["NguoiTao"].ToString(),
                        NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao"))
                    });
                }
            }
            return list;
        }
        internal bool insertKhachHang(string ten, string sdt, string cccd, string mk)
        {
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();

            try
            {
                using (OracleCommand omd = new OracleCommand("thinh.P_Them_KhachHang", Conn))
                {
                    omd.CommandType = System.Data.CommandType.StoredProcedure;
                    omd.Parameters.Add("p_tenkh", ten);
                    omd.Parameters.Add("p_sdt", sdt);
                    omd.Parameters.Add("p_cccd", cccd);
                    omd.Parameters.Add("p_mk", mk);
                    omd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex) 
            {
                throw ex;
                return false;
            }
        }
    }
}

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

        //Get all khách hàng
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

        //Get qua id
        internal KhachHang getKhacHangById(string id)
        {
            KhachHang kh = new KhachHang();
            string query = "SELECT MaKH, HoTen, SoDienThoai, CCCD, SoDu FROM thinh.KhachHang WHERE MaKH = :id";

            //Connection tinh
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();

            using (var cmd = new OracleCommand(query, Conn))
            {
                cmd.Parameters.Add(new OracleParameter("id", id));
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        kh.MaKH = reader["MaKH"].ToString();
                        kh.TenKH = reader["HoTen"].ToString();
                        kh.SoDienThoai = reader["SoDienThoai"].ToString();
                        kh.CCCD = reader["CCCD"].ToString();
                        kh.SoDu = float.Parse(reader["SoDu"].ToString());
                    }
                }
            }
            return kh;
        }

        //Update khách hàng
        internal bool updateKhachHang(KhachHang khach)
        {
            return true;
        }

        //Xoá khách hàng
        public bool deleteKhachHangById(string id)
        {
            string query = "DELETE FROM thinh.KhachHang WHERE MaKH = :id";
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();
            try
            {
                using (var omd = new OracleCommand(query, Conn))
                {
                    omd.Parameters.Add(new OracleParameter("id", id));
                    omd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        internal bool insertKhachHang(string ten, string sdt, string cccd, float sodu, string mk)
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
                    omd.Parameters.Add("p_sodu", OracleDbType.Decimal).Value = sodu;
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

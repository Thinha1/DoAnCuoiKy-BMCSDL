using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnBMCSDL.Model;
using Oracle.ManagedDataAccess.Client;
using DoAnBMCSDL;
using DoAnBMCSDL.Model;
using DoAnBMCSDL.utils.Encrytion;

namespace DoAnBMCSDL.Controller
{
    internal class KhachHangController
    {
        private static OracleConnection Conn;
        DESDB dESDB = new DESDB(DatabaseUtils.GetConnection());

        //Get all khách hàng
        internal List<KhachHang> getAllKhachHang()
        {
            List<KhachHang> list = new List<KhachHang>();
            string query = "SELECT MaKH, HoTen, SoDienThoai, Email, CCCD, SoDu, NGUOITAO, NGAYTAO, NGUOISUA, NGAYSUA FROM thinh.KhachHang";

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
                        Email = reader["Email"].ToString(),
                        SoDu = float.Parse(reader["SoDu"].ToString()),
                        NguoiTao = reader["NguoiTao"].ToString(),
                        NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao")),
                        NguoiSua = reader["NguoiSua"].ToString(),
                        NgaySua = reader.IsDBNull(reader.GetOrdinal("NgaySua")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("NgaySua"))
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
        internal bool updateKhachHang(KhachHang kh)
        {
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();

            try
            {
                using (OracleCommand omd = new OracleCommand("thinh.P_CapNhat_KhachHang", Conn))
                {
                    omd.CommandType = CommandType.StoredProcedure;
                    omd.Parameters.Add("p_makh", kh.MaKH);
                    omd.Parameters.Add("p_tenkh", kh.TenKH);
                    omd.Parameters.Add("p_sdt", kh.SoDienThoai);
                    omd.Parameters.Add("p_cccd", kh.CCCD);
                    omd.Parameters.Add("p_email", kh.Email);
                    omd.Parameters.Add("p_sodu", OracleDbType.Decimal).Value = kh.SoDu;
                    if(!string.IsNullOrWhiteSpace(kh.MatKhau)){
                    omd.Parameters.Add("p_mk", kh.MatKhau);
                    }
                    else
                    {
                        omd.Parameters.Add("p_mk", DBNull.Value);
                    }
                        omd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal bool InsertKhachHang(string ten, string sdt, string email, string cccd, float sodu, string mk)
        {
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();

            try
            {
                using (OracleCommand omd = new OracleCommand("thinh.P_Them_KhachHang", Conn))
                {
                    omd.CommandType = CommandType.StoredProcedure;
                    omd.Parameters.Add("p_tenkh", ten);
                    omd.Parameters.Add("p_sdt", sdt);
                    omd.Parameters.Add("p_cccd", cccd);
                    omd.Parameters.Add("p_email", email);
                    omd.Parameters.Add("p_sodu", OracleDbType.Decimal).Value = sodu;
                    omd.Parameters.Add("p_mk", mk);
                    omd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //Xoá khách hàng
        public bool DeleteKhachHangById(string id)
        {
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();
            try
            {
                using (var omd = new OracleCommand("thinh.P_XOA_KHACHHANG", Conn))
                {
                    omd.CommandType = CommandType.StoredProcedure;
                    omd.Parameters.Add(new OracleParameter("p_makh", id));
                    omd.ExecuteNonQuery();
                    return true;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}

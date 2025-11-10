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
    internal class HoaDonController
    {
        private static OracleConnection Conn;
        public List<HoaDon> getAllHoaDon()
        {
            List<HoaDon> list = new List<HoaDon>();
            string query = "SELECT * from thinh.HoaDon";
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();
            OracleCommand omd = new OracleCommand(query, Conn);

            using (var cmd = new OracleCommand(query, Conn))
            using (var reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    list.Add(new HoaDon
                    {
                        MaHD = reader["MaHD"].ToString(),
                        MaMay = reader["MaMay"].ToString(),
                        MaKH = reader["MaKH"].ToString(),
                        ThoiGianBatDau = reader.GetDateTime(reader.GetOrdinal("ThoiGianBatDau")),
                        ThoiGianKetThuc = reader.GetDateTime(reader.GetOrdinal("ThoiGianKetThuc")),
                        TongTien = float.Parse(reader["TongTien"].ToString()),
                        NguoiTao = reader["NguoiTao"].ToString(),
                        NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao")),
                        NguoiSua = reader["NguoiSua"].ToString(),
                        NgaySua = reader.IsDBNull(reader.GetOrdinal("NgaySua")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("NgaySua"))
                    });
                }
            }
            return list;
        }

        public List<ChiTietHoaDon> getAllChiTietHoaDon(string maHD)
        {
            List<ChiTietHoaDon> list = new List<ChiTietHoaDon>();
            string query = "SELECT * from thinh.ChiTietHoaDon_DV where MaHD = :hd";
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();
            OracleCommand omd = new OracleCommand(query, Conn);

            using (var cmd = new OracleCommand(query, Conn))
            {
                cmd.Parameters.Add(new OracleParameter("hd", maHD));
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        list.Add(new ChiTietHoaDon
                        {
                            MaDV = reader["MaDV"].ToString(),
                            SoLuong = int.Parse(reader["SoLuong"].ToString()),
                            ThanhTien = float.Parse(reader["ThanhTien"].ToString()),
                            NguoiTao = reader["NguoiTao"].ToString(),
                            NgayTao = reader.GetDateTime(reader.GetOrdinal("NgayTao")),
                            NguoiSua = reader["NguoiSua"].ToString(),
                            NgaySua = reader.IsDBNull(reader.GetOrdinal("NgaySua")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("NgaySua"))
                        });
                    }
                }
            }
            return list;
        }
    }
}

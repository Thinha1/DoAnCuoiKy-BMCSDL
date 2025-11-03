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
            string query = "SELECT MaMay, Loai, TrangThai, NGUOITAO, NGAYTAO, NGUOISUA, NGAYSUA FROM thinh.MAY";

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
                        NgayTao = reader.GetDateTime(reader.GetOrdinal("NGAYTAO")),
                        NguoiSua = reader["NGUOISUA"].ToString(),
                        NgaySua = reader.IsDBNull(reader.GetOrdinal("NGAYSUA")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("NGAYSUA"))
                    });
                }
            }
            return list;
        }

        public bool InsertMay(string loai, string trangThai)
        {
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();

            try
            {
                using (OracleCommand omd = new OracleCommand("thinh.P_Them_May", Conn))
                {
                    omd.CommandType = CommandType.StoredProcedure;
                    omd.Parameters.Add("p_loai", loai);
                    omd.Parameters.Add("p_trangthai", trangThai);
                    omd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool UpdateMay(May m)
        {
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();

            try
            {
                using (OracleCommand omd = new OracleCommand("thinh.P_SuaMay", Conn))
                {
                    omd.CommandType = CommandType.StoredProcedure;
                    omd.Parameters.Add("p_MaMay", m.MaMay);
                    omd.Parameters.Add("p_Loai", m.Loai);
                    omd.Parameters.Add("p_TrangThai", m.TrangThai);
                    omd.ExecuteNonQuery();
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteMayById(string id)
        {
            Conn = DatabaseUtils.GetConnection();
            if (Conn.State != ConnectionState.Open)

                Conn.Open();
            try
            {
                using (var omd = new OracleCommand("thinh.P_XOA_MAY", Conn))
                {
                    omd.CommandType = CommandType.StoredProcedure;
                    omd.Parameters.Add(new OracleParameter("p_mamay", id));
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace DoAnBMCSDL.utils.Encrytion
{
    internal class DESDB
    {
        OracleConnection conn;

        public DESDB(OracleConnection conn)
        {
            this.conn = conn;
        }
        public byte[] encryptDES(string plaintext, string priKey)
        {
            try
            {
                string chuongtrinhcon = "thinh.DES.encrypt";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = chuongtrinhcon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                OracleParameter result = new OracleParameter("result", OracleDbType.Raw, 500);
                result.Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.Parameters.Add(result);

                OracleParameter str = new OracleParameter("p_plaintext", OracleDbType.Varchar2, 100);
                str.Direction = System.Data.ParameterDirection.Input;
                str.Value = plaintext;
                cmd.Parameters.Add(str);

                OracleParameter key = new OracleParameter("prikey", OracleDbType.Varchar2);
                key.Direction = System.Data.ParameterDirection.Input;
                key.Value = priKey;
                cmd.Parameters.Add(key);

                cmd.ExecuteNonQuery();
                if (result.Value != DBNull.Value)
                {
                    OracleBinary ret = (OracleBinary)result.Value;
                    return (byte[])ret.Value;
                }
                else return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public string decryptDES(byte[] encrypted, string priKey)
        {
            try
            {
                string chuongtrinhcon = "thinh.DES.decrypt";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = chuongtrinhcon;
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                OracleParameter result = new OracleParameter("result", OracleDbType.Varchar2, 100);
                result.Direction = System.Data.ParameterDirection.ReturnValue;
                cmd.Parameters.Add(result);

                OracleParameter str = new OracleParameter("p_encryptedText", OracleDbType.Raw);
                str.Direction = System.Data.ParameterDirection.Input;
                str.Value = encrypted;
                cmd.Parameters.Add(str);

                OracleParameter key = new OracleParameter("prikey", OracleDbType.Varchar2);
                key.Direction = System.Data.ParameterDirection.Input;
                key.Value = priKey;
                cmd.Parameters.Add(key);

                cmd.ExecuteNonQuery();
                if (result.Value != DBNull.Value)
                {
                    return result.Value.ToString();
                }
                else return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

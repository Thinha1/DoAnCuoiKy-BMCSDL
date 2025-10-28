using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DoAnBMCSDL.utils.Encrytion
{
    internal class EncryptionFunc
    {
        private static OracleConnection conn;

        public static void initConnection(OracleConnection oracleConnection)
        {
            if(oracleConnection != null)
            {
                conn = oracleConnection;
            }
        }
        public string encryptCipher_Func(string msg, int key)
        {
            try
            {
                string function = "thinh.F_ENCRYPTCAESARCIPHER";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = function;

                OracleParameter result = new OracleParameter("result", OracleDbType.Varchar2, 100);
                result.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(result);

                OracleParameter message = new OracleParameter("str", OracleDbType.NVarchar2, 100);
                message.Value = msg;
                message.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(message);

                OracleParameter k = new OracleParameter("k", OracleDbType.Int32);
                k.Direction = ParameterDirection.Input;
                k.Value = key;
                cmd.Parameters.Add(k);

                if(conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }

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
            return null;
        }

        public string decryptCipher_Func(string msg, int key)
        {
            try
            {
                string function = "thinh.F_DECRYPTCAESARCIPHER";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = function;

                OracleParameter result = new OracleParameter("result", OracleDbType.NVarchar2, 100);
                result.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(result);

                OracleParameter message = new OracleParameter("str", OracleDbType.Varchar2, 100);
                message.Value = msg;
                message.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(message);

                OracleParameter k = new OracleParameter("k", OracleDbType.Int32);
                k.Direction = ParameterDirection.Input;
                k.Value = key;
                cmd.Parameters.Add(k);

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
            return null;
        }

        public string encryptMultiply_Func(string msg, int key)
        {
            try
            {
                string function = "thinh.F_ENCRYPTMULTIPLYCIPHER";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = function;

                OracleParameter result = new OracleParameter("result", OracleDbType.NVarchar2, 100);
                result.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(result);

                OracleParameter message = new OracleParameter("str", OracleDbType.Varchar2, 100);
                message.Value = msg;
                message.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(message);

                OracleParameter k = new OracleParameter("k", OracleDbType.Int32);
                k.Direction = ParameterDirection.Input;
                k.Value = key;
                cmd.Parameters.Add(k);

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

        public string decryptMultiply_Func(string msg, int key)
        {
            try
            {
                string function = "thinh.F_DECRYPTMUTIPLYCIPHER";
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = function;

                OracleParameter result = new OracleParameter("result", OracleDbType.Varchar2, 100);
                result.Direction = ParameterDirection.ReturnValue;
                cmd.Parameters.Add(result);

                OracleParameter message = new OracleParameter("str", OracleDbType.Varchar2, 100);
                message.Value = msg;
                message.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(message);

                OracleParameter k = new OracleParameter("k", OracleDbType.Int32);
                k.Direction = ParameterDirection.Input;
                k.Value = key;
                cmd.Parameters.Add(k);

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

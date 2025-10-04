using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace DoAnBMCSDL
{
    internal class Test
    {

        public static string host;
        public static string port;
        public static string sid;
        public static string username;
        public static string password;
        static void Main(String[] args)
        {
            LoginForm form = new LoginForm();
            form.ShowDialog();
        }
    }
}

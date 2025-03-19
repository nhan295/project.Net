using System;
using Microsoft.Data.SqlClient;

namespace Project.NET
{
    internal class clsConnectDB
    {
        public static SqlConnection conn;

        public static bool OpenConnection()
        {
            try
            {
                conn = new SqlConnection("Server=KIN; Database=Project.Net; Integrated Security=True; TrustServerCertificate=True;");

                conn.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public static bool CloseConnection()
        {
            try
            {
                conn.Close();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
    }
}

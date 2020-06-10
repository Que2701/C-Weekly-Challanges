using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class ConnectionFactory
    {
        private static volatile IDbConnection iDbConnection = null;
        private static object syncRoot = new object();

        public static IDbConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DapperDemoDB"].ConnectionString;

            if (iDbConnection == null)
            {
                lock (syncRoot)
                {
                    if (iDbConnection == null)
                    {
                        iDbConnection = new SqlConnection(connectionString);
                    }
                }
            }
            return iDbConnection;
        }
        public static void CloseDbConnection()
        {
            iDbConnection.Close();
        }
    }
}

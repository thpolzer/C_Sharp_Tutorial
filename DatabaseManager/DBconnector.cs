using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace DatabaseManager
{
    class DBconnector
    {

        public static MySqlConnection createConnection()
        {
            // documentation see: https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-connection.html
            MySqlConnection conn = null;
            string connectionString = "server=localhost;database=test;uid=testuser;pwd=testuser;";
            conn = new MySqlConnection(connectionString);

            try
            {
                conn.Open();
                //Console.WriteLine("Connection successful");
                //Console.ReadKey();
                //conn.Close();
                return conn;
            }
            catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                return null;
            }

        }
    }
}

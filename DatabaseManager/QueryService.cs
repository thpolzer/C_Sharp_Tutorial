using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DatabaseManager.model;

namespace DatabaseManager
{
    class QueryService
    {
        public static List<Employee> dbQuery (MySqlConnection conn, String sql)
        {
            // documentation see: https://dev.mysql.com/doc/connector-net/en/connector-net-tutorials-sql-command.html

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rdr = cmd.ExecuteReader();
                List<Employee> employees = new List<Employee>();
                while (rdr.Read())
                {
                    Employee employee = new Employee( System.Convert.ToInt32(rdr[0]), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString(), System.Convert.ToDouble(rdr[4]), System.Convert.ToInt32(rdr[5]));
                    employees.Add(employee);
                }
                return employees;
            } catch (MySql.Data.MySqlClient.MySqlException ex)
            {
                Console.WriteLine(ex.ToString());
                Console.ReadKey();
                return null;
            }
            

            

        }
    }
}

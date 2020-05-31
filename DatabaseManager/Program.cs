using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using DatabaseManager.model;

namespace DatabaseManager
{
    class Program
    {
        static void Main(string[] args)
        {
            MySqlConnection connection = DBconnector.createConnection();
            String query = "SELECT * FROM employee";
            List<Employee> employees = QueryService.dbQuery(connection, query);

            foreach (Employee e in employees)
            {
                Console.WriteLine(e.name + " ---" + e.salary);
                Console.ReadKey();
            }

            connection.Close();
            
        }
    }
}

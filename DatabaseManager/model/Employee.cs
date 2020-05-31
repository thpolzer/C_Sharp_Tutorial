using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseManager.model
{
    class Employee
    {
        public int id { get; set; }
        public String name { get; set; }
        public String firstname { get; set; }
        public String birthdate { get; set; }
        public double salary { get; set; }
        public int department_id { get; set; }

        public Employee(int id, String name, String firstname, String birthdate, double salary, int department_id)
        {
            this.id = id;
            this.name = name;
            this.firstname = firstname;
            this.birthdate = birthdate;
            this.salary = salary;
            this.department_id = department_id;
        }



            
        
    }
}

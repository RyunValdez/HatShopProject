using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    public enum EmployeeType
    {
        Manager, //1
        Salesman, //2
        Returnrep  //3
    }

    public class Employee
    {
        public string Employee_ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public EmployeeType Title { get; set; }

        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }

    }
}

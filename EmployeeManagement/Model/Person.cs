using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace EmployeeManagement.Model
{
    public class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime? Birthday { get; set; }

        public Person(string firstname, string lastname, DateTime? birthday)
        {
            Firstname = firstname;
            Lastname = lastname;
            Birthday = birthday;
        }

        public Person()
        {

        }
    }
}

using System;

namespace EmployeeManagement.Model
{
    public class Trainee : Employee
    {
        private const double DEFAULT_SALARY = 500;

        public Trainee(string firstname, string lastname, DateTime? birthday, DateTime? entryday,
                int insuranceid, double salary = DEFAULT_SALARY)
            : base(firstname, lastname, birthday, entryday, insuranceid, salary)
        {
            //Firstname = firstname;
        }

        public Trainee()
        {

        }
    }
}

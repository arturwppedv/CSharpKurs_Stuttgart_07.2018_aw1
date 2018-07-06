using System;

namespace EmployeeManagement.Model
{
    public class Developer : Employee
    {
        private const double DEFAULT_SALARY = 1500;        

        public Developer(string firstname, string lastname, DateTime? birthday, DateTime? entryday,
                int insuranceid, double salary = DEFAULT_SALARY)
            : base(firstname, lastname, birthday, entryday, insuranceid, salary)
        {

        }

        public Developer()
        {

        }
    }
}

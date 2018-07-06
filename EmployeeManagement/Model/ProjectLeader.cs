using System;

namespace EmployeeManagement.Model
{
    public class ProjectLeader : Employee
    {
        private const double DEFAULT_SALARY = 2500;

        public ProjectLeader(string firstname, string lastname, DateTime? birthday, DateTime? entryday,
                int insuranceid, double salary = DEFAULT_SALARY)
            : base(firstname, lastname, birthday, entryday, insuranceid, salary)
        {

        }

        public override void IncreaseSalary()
        {
            //Erst wird die normale Funktionalität ausgeführt (Gehalt um 2% erhöhen)
            base.IncreaseSalary();

            //Danach wird das Gehalt nochmal um 200 erhöht (Bonus)
            Salary += 200;
        }

        public ProjectLeader()
        {

        }
    }
}

using System;
using SQLite;
using EmployeeManagement.Constants;

namespace EmployeeManagement.Model
{
    public class Employee : Person
    {   
        [PrimaryKey, AutoIncrement]
        public Guid EmployeeId { get; set; }
        public int InsuranceId { get; set; }
        public double Salary { get; set; }
        public DateTime? EntryDate { get; set; }
        public int VacationDaysPerYear { get; set; }

        public Employee(string firstname, string lastname, DateTime? birthday,
                        DateTime? entryday, int insuranceid, double salary)
            : base(firstname, lastname, birthday)
        {
            InsuranceId = insuranceid;
            Salary = salary;
            EntryDate = entryday;

            //Jeder Mitarbeiter hat dieselbe Anzahl an Urlaubstagen
            VacationDaysPerYear = Defaults.VACATION;
        }

        public Employee()
        {

        }

        public virtual void IncreaseSalary()
        {
            Salary = Salary * Defaults.INCREASE_SALARY_PERCENT;
        }
    }
}

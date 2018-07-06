using System;
using SQLite;
namespace EmployeeManagement.Model
{
    public class Vacation
    {

        [PrimaryKey, AutoIncrement]
        public Guid Id { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

        public int Days { get; set; }

        public Guid EmployeeId { get; set; }    //Verbindung zu dem Urlaubsnehmer über PK

        [Ignore]    //Soll nicht in der Datenbank aufgenommen werden
        public Employee Vacationers { get; set; }   //Der, der den Urlaub in Anspruch nimmt

        public Vacation(DateTime startDate, DateTime endDate, Guid employeeId)
        {
            StartDate = startDate;
            EndDate = endDate;
            EmployeeId = employeeId;

            Days = (endDate - startDate).Days;

        }

        public Vacation()
        {

        }

    }
}

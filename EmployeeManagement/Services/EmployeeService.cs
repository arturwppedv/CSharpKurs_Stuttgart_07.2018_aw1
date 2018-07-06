using EmployeeManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeManagement.Services
{
    public class EmployeeService
    {
        DatabaseService dbService = new DatabaseService();

        public void InsertEmployee(Employee employee)
        {

            if (employee is Trainee)
                dbService.Add((employee as Trainee));
            else if (employee is Developer)
                dbService.Add((employee as Developer));
            else
                dbService.Add((employee as ProjectLeader));
        }

        public void InsertVacation(Employee employee, DateTime startDate, DateTime endDate)
        {
            Vacation vacation = new Vacation(startDate, endDate, employee.EmployeeId);
            dbService.Add(vacation);
        }

        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();

            //Lädt alle Trainees aus der Tabelle und fügt sie der Employees-Liste hinzu
            foreach (Trainee trainee in dbService.GetAllTrainees())
            {
                employees.Add(trainee);
            }

            //Lädt alle Developer aus der Tabelle und fügt diese in die Employees-Liste hinzu
            foreach (Developer developer in dbService.GetAllDevelopers())
            {
                employees.Add(developer);
            }

            //Lädt alle ProjectLeader aus der Tabelle und fügt sie in die Employees-Liste hinzu
            foreach (ProjectLeader projectLeader in dbService.GetAllProjectLeaders())
            {
                employees.Add(projectLeader);
            }

            return employees;
        }

        public List<Vacation> GetVacations()
        {
            return dbService.GetAllVacations();
        }

        public List<Vacation> GetEmployeesVacation(Guid employeeId)
        {
            return dbService.GetVacationOfEmployee(employeeId);
        }

        public void DeleteEmployee(Employee employee)
        {            

            if (employee is Trainee)
                dbService.DeleteTrainee((employee as Trainee).EmployeeId);
            else if (employee is Developer)
                dbService.DeleteDeveloper((employee as Developer).EmployeeId);
            else
                dbService.DeleteProjectLeader((employee as ProjectLeader).EmployeeId);
        }

        public void UpdateEmployee(Employee employee)
        {
            if (employee is Trainee)
                dbService.UpdateTrainee((employee as Trainee));
            else if (employee is Developer)
                dbService.UpdateDeveloper((employee as Developer));
            else
                dbService.UpdateProjectLeader((employee as ProjectLeader));
        }

    }
}

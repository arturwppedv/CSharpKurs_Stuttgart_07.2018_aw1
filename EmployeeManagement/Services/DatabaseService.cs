using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmployeeManagement.Model;
using SQLite;

namespace EmployeeManagement.Services
{
    public class DatabaseService
    {
        SQLiteConnection con;

        public DatabaseService()
        {
            con = new SQLiteConnection("db.sqlite");
            CreateTables();
        }

        //--------------------------------------------------------------

        private void CreateTables()
        {
            con.CreateTable<Trainee>();
            con.CreateTable<Developer>();
            con.CreateTable<ProjectLeader>();
            con.CreateTable<Vacation>();
        }

        //-----------------------------------------------------------------

        public void Add(Trainee trainee)
        {
            con.Insert(trainee);
        }

        public void Add(Developer developer)
        {
            con.Insert(developer);
        }

        public void Add(ProjectLeader projectLeader)
        {
            con.Insert(projectLeader);
        }

        public void Add(Vacation vacation)
        {
            con.Insert(vacation);
        }


        //-------------------------------------------------------------------

        public Trainee GetTrainee(Guid id)
        {
            Trainee trainee = con.Get<Trainee>(id);
            return trainee;
        }

        public Developer GetDeveloper(Guid id)
        {
            Developer developer = con.Get<Developer>(id);
            return developer;
        }

        public ProjectLeader GetProjectLeader(Guid id)
        {
            ProjectLeader projectLeader = con.Get<ProjectLeader>(id);
            return projectLeader;
        }

        public List<Vacation> GetVacationOfEmployee(Guid employeeId)
        {
            List<Vacation> vacations = con.Table<Vacation>().Where(x => x.EmployeeId == employeeId).ToList();
            return vacations;
        }

        //-------------------------------------------------------------------------------

        public List<Trainee> GetAllTrainees()
        {
            List<Trainee> trainees = con.Table<Trainee>().ToList();
            return trainees;
        }

        public List<Developer> GetAllDevelopers()
        {
            List<Developer> developers = con.Table<Developer>().ToList();
            return developers;
        }

        public List<ProjectLeader> GetAllProjectLeaders()
        {
            List<ProjectLeader> projectLeaders = con.Table<ProjectLeader>().ToList();
            return projectLeaders;
        }

        public List<Vacation> GetAllVacations()
        {
            List<Vacation> vacations = con.Table<Vacation>().ToList();
            return vacations;
        }

        //---------------------------------------------------------------------------------------------

        public void DeleteTrainee(Guid id)
        {
            con.Delete<Trainee>(id);
        }

        public void DeleteDeveloper(Guid id)
        {
            con.Delete<Developer>(id);
        }

        public void DeleteProjectLeader(Guid id)
        {
            con.Delete<ProjectLeader>(id);
        }

        public void DeleteVacation(Guid id)
        {
            con.Delete<Vacation>(id);
        }

        //---------------------------------------------------------------------------------------

        public void DeleteAllTrainees()
        {
            con.DeleteAll<Trainee>();
        }

        public void DeleteAllDeveloper()
        {
            con.DeleteAll<Developer>();
        }

        public void DeleteAllProjectLeader()
        {
            con.DeleteAll<ProjectLeader>();
        }

        public void DeleteAllVacations()
        {
            con.DeleteAll<Vacation>();
        }


        //-------------------------------------------------------------

        public void UpdateTrainee(Trainee trainee)
        {
            con.Update(trainee);
        }

        public void UpdateDeveloper(Developer developer)
        {
            con.Update(developer);
        }

        public void UpdateProjectLeader(ProjectLeader projectLeader)
        {
            con.Update(projectLeader);
        }

        public void UpdateVacation(Vacation vacation)
        {
            con.Update(vacation);
        }
    }
}
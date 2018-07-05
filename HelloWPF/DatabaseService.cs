using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace HelloWPF
{
    public class DatabaseService
    {
        SQLiteConnection con;

        public DatabaseService()
        {
            con = new SQLiteConnection("db.sqlite");
            CreateTables();
        }

        private void CreateTables()
        {
            con.CreateTable<Person>();
        }

        public void Insert(Person neuePerson)
        {
            con.Insert(neuePerson);
        }

        public List<Person> GetPeople()
        {
            return con.Table<Person>().ToList();
        }
    }
}

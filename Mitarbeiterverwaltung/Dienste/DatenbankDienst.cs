using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Mitarbeiterverwaltung.Model;

namespace Mitarbeiterverwaltung.Dienste
{
    internal class DatenbankDienst
    {
        private SQLiteConnection _Con;

        public DatenbankDienst()
        {
            _Con = new SQLiteConnection("Mitarbeiter.sqlite");
            CreateTables();
        }

        private void CreateTables()
        {
            _Con.CreateTable<Azubi>();
            _Con.CreateTable<Entwickler>();
            _Con.CreateTable<Projektleiter>();
        }

        public void Insert(object obj)
        {
            _Con.Insert(obj);
        }

        public List<T> Get<T>() where T:new()
        {
            return _Con.Table<T>().ToList();
        }

        public void Update(object obj)
        {
            _Con.Update(obj);
        }

        public void Delete(object obj)
        {
            _Con.Delete(obj);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace HelloWPF
{
    //[Table("PersonenListe")]
    public class Person
    {
        [PrimaryKey, AutoIncrement]
        public Guid Id { get; set; }
       
        public string Vorname { get; set; }
        public string Nachname { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mitarbeiterverwaltung.Konstanten;
using SQLite;

namespace Mitarbeiterverwaltung.Model
{
    public class Mitarbeiter : Person
    {        
        [PrimaryKey, AutoIncrement]
        public Guid MitarbeiterId { get; set; }
        public double Gehalt { get; set; }
        public DateTime Eintrittsdatum { get; set; }
        public bool Gekuendigt { get; set; }
        public Werte.MitarbeiterTyp Typ { get; set; }

        public Mitarbeiter(string vorname, string nachname, DateTime geburtsdatum, 
                            DateTime eintrittsdatum, double gehalt)
            : base(vorname, nachname, geburtsdatum)
        {
            Gehalt = gehalt;
            Eintrittsdatum = eintrittsdatum;
            Gekuendigt = false;
        }

        public Mitarbeiter()
        {

        }

        public virtual void GehaltErhoehen()
        {
            Gehalt *= Werte.GEHALT_ERHOEHUNG_MULTIPLIKATOR;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mitarbeiterverwaltung.Konstanten;

namespace Mitarbeiterverwaltung.Model
{
    public class Entwickler : Mitarbeiter
    {       
        public Entwickler(string vorname, string nachname, DateTime geburtsdatum,
                            DateTime eintrittsdatum, double gehalt = Werte.GRUNDGEHALT_ENTWICKLER)
            : base(vorname, nachname, geburtsdatum, eintrittsdatum, gehalt)
        {
            Typ = Werte.MitarbeiterTyp.Entwickler;
        }

        public Entwickler()
        {
            Typ = Werte.MitarbeiterTyp.Entwickler;
        }
    }
}

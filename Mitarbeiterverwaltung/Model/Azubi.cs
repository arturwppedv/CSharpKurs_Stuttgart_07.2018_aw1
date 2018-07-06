using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mitarbeiterverwaltung.Konstanten;

namespace Mitarbeiterverwaltung.Model
{
    public class Azubi : Mitarbeiter
    {
        public Azubi(string vorname, string nachname, DateTime geburtsdatum,
                            DateTime eintrittsdatum, double gehalt = Werte.GRUNDGEHALT_AZUBI)
            : base(vorname, nachname, geburtsdatum, eintrittsdatum, gehalt)
        {
            Typ = Werte.MitarbeiterTyp.Azubi;
        }

        public Azubi()
        {
            Typ = Werte.MitarbeiterTyp.Azubi;
        }
    }
}

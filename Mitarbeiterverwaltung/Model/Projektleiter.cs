using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mitarbeiterverwaltung.Konstanten;

namespace Mitarbeiterverwaltung.Model
{
    public class Projektleiter : Mitarbeiter
    {

        public Projektleiter(string vorname, string nachname, DateTime geburtsdatum,
                            DateTime eintrittsdatum, double gehalt = Werte.GRUNDGEHALT_PROJEKTLEITER)
            : base(vorname, nachname, geburtsdatum, eintrittsdatum, gehalt)
        {
            Typ = Werte.MitarbeiterTyp.Projektleiter;
        }

        public Projektleiter()
        {
            Typ = Werte.MitarbeiterTyp.Projektleiter;
        }

        public override void GehaltErhoehen()
        {
            base.GehaltErhoehen();
            Gehalt += 100;
        }
    }
}

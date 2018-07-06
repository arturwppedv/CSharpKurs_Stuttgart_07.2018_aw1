using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mitarbeiterverwaltung.Model;

namespace Mitarbeiterverwaltung.Dienste
{
    public class MitarbeiterDienst
    {
        private DatenbankDienst _DbDienst = new DatenbankDienst();

        public void MitarbeiterAnlegen(Mitarbeiter mitarbeiter)
        {
            if (mitarbeiter is Azubi)
            {
                _DbDienst.Insert(mitarbeiter as Azubi);
            }
            else if (mitarbeiter is Entwickler)
            {
                _DbDienst.Insert(mitarbeiter as Entwickler);
            }
            else
            {
                _DbDienst.Insert(mitarbeiter as Projektleiter);
            }
        }

        public List<Mitarbeiter> GetMitarbeiter()
        {
            List<Mitarbeiter> mitarbeiterListe = new List<Mitarbeiter>();

            foreach (Azubi azubi in _DbDienst.Get<Azubi>())
            {
                if (!azubi.Gekuendigt)
                    mitarbeiterListe.Add(azubi);
            }

            foreach (Entwickler entwickler in _DbDienst.Get<Entwickler>())
            {
                if (!entwickler.Gekuendigt)
                    mitarbeiterListe.Add(entwickler);
            }

            foreach (Projektleiter projektleiter in _DbDienst.Get<Projektleiter>())
            {
                if (!projektleiter.Gekuendigt)
                    mitarbeiterListe.Add(projektleiter);
            }

            return mitarbeiterListe.OrderBy(x => x.Nachname).ToList();  //ASC
        }

        public void Kuendigen(Mitarbeiter mitarbeiter)
        {
            mitarbeiter.Gekuendigt = true;

            if (mitarbeiter is Azubi)
            {
                _DbDienst.Update(mitarbeiter as Azubi);
            }
            else if (mitarbeiter is Entwickler)
            {
                _DbDienst.Update(mitarbeiter as Entwickler);
            }
            else
            {
                _DbDienst.Update(mitarbeiter as Projektleiter);
            }
        }

        public void Aktualisieren(Mitarbeiter mitarbeiter)
        {
            if (mitarbeiter is Azubi)
            {
                _DbDienst.Update(mitarbeiter as Azubi);
            }
            else if (mitarbeiter is Entwickler)
            {
                _DbDienst.Update(mitarbeiter as Entwickler);
            }
            else
            {
                _DbDienst.Update(mitarbeiter as Projektleiter);
            }
        }
    }
}

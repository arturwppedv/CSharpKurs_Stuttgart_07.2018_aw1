using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Dozent : Mensch
    {
        public override string Vorname { get; set; }
        public override string Nachname { get; set; }


        public Dozent(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        public override void Vorstellen()
        {
            Console.WriteLine($"Ich heiße {Vorname} {Nachname} und bin Dozent");
        }
    }
}

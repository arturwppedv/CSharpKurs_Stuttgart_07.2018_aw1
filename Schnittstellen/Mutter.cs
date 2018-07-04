using Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    public class Mutter : Person, IMutter
    {
        public Mutter(string vorname, string nachname, int alter, string madechenname) : base(vorname, nachname, alter)
        {
            Weiblich = true;
            Maedchenname = madechenname;
            Kinder = new List<Kind>();
        }

        public bool Weiblich { get; set; }
        public string Maedchenname { get; set; }
        public List<Kind> Kinder { get; set; }

        public void Gebaehren()
        {
            Console.WriteLine("Kind wird geboren...");
        }

        public override string ToString()
        {
            return $"Ich heiße {Vorname} {Nachname} und bin eine Mutter";
        }
    }
}

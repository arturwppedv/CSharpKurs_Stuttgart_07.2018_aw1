using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen;

namespace Schnittstellen
{
    public class Vater : Person, IVater
    {
        public Vater(string vorname, string nachname, int alter, bool zeugungsfaehig) : base(vorname, nachname, alter)
        {
            Maennlich = true;
            Zeugungsfaehig = zeugungsfaehig;
            Kinder = new List<Kind>();
        }

        public bool Zeugungsfaehig { get; set; }
        public bool Maennlich { get; set; }
        public List<Kind> Kinder { get; set; }

        public void Jagen()
        {
            Console.WriteLine("Jagen wird eingeleitet...");
        }

        public override string ToString()
        {
            return $"Ich heiße {Vorname} {Nachname} und bin ein Vater";
        }
    }
}

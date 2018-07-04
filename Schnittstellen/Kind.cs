using Klassen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    public class Kind : Person, IMutter, IVater
    {
        public Kind(string vorname, string nachname, int alter, 
            bool zeugungsfaehig = false, bool maennlich = false, bool weiblich = false) : base(vorname, nachname, alter)
        {
            Maedchenname = "";
            Zeugungsfaehig = zeugungsfaehig;
            Maennlich = maennlich;
            Weiblich = weiblich;
        }

        public bool Zeugungsfaehig { get; set; }
        public bool Maennlich { get; set; }
        public bool Weiblich { get; set; }
        public string Maedchenname { get; set; }
        public int Spielkammeraden { get; set; }

        public void Gebaehren()
        {
            //Wenn das Kind weiblich ist (Weiblich == true)
            if(Weiblich)
                Console.WriteLine("Das Kind bekommt ein Kind...");
        }

        public void Jagen()
        {
            //Wenn das Kind männlich ist (Maennlich == true)
            if(Maennlich)
                Console.WriteLine("Das Kind geht jagen...");
        }

        public override string ToString()
        {
            return $"Ich heiße {Vorname} {Nachname} und bin ein Kind";
        }
    }
}

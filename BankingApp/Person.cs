using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Person
    {
        public string Vorname { get; set; }
        public string Nachname { get; set; }
        public List<Konto> Konten { get; set; }

        public Person(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
            Konten = new List<Konto>();
        }

        public Person()
        {
            Konten = new List<Konto>();
        }

        public override string ToString()
        {
            return $"{Vorname} {Nachname}";
        }
    }
}

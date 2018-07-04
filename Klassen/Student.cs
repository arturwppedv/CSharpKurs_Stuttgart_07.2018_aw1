using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Student :  Person
    {
        public int MatrikelNr { get; set; }

        public Student(string vorn, int alt, string nachn, int matrknr) : base(vorn, nachn, alt)
        {
            MatrikelNr = matrknr;
        }

        public override void SagDeinenNamen()
        {
            Console.WriteLine($"Ich heiße {Vorname} {Nachname} und bin {Alter} Jahre alt und meine MatrikNr lautet {MatrikelNr}");
        }
    }
}

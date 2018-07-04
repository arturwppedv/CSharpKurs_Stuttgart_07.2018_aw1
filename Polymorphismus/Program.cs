using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klassen;
using Schnittstellen;

namespace Polymorphismus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Die Eltern
            Vater Klaus = new Vater("Klaus", "Mustermann", 54, true);
            Mutter Maria = new Mutter("Maria", "Mustermann", 45, "Weber");

            //Deren Kinder
            Kind Alex = new Kind("Alex", "Mustermann", 7, false, true, false);
            Kind Jana = new Kind("Jana", "Mustermann", 20, true, false, true);

            List<Vater> väter = new List<Vater>();
            List<Person> familie = new List<Person>();
            List<IVater> vaters = new List<IVater>();   //<=> zu der Liste väter, zusätzlich 
                                                        //können, aber die Kinder in die Liste
                                                        //eintreten

            vaters.Add(Klaus);
            vaters.Add(Alex);
            vaters.Add(Jana);
            //vaters.Add(Maria);    //Geht nicht, da Mutter nicht von IVater ableitet

            familie.Add(Klaus);
            familie.Add(Maria);
            familie.Add(Alex);
            familie.Add(Jana);
            //väter.Add(Maria);

            //Überprüfen, welcher Datentyp die Person wirklich ist
            foreach(Person person in familie)
            {                
                if (person is Kind)
                    (person as Kind).Spielkammeraden = 4;

                Console.WriteLine(person);
                if (person is Kind)
                    Console.WriteLine("Kind");
                else if (person is Vater)
                    Console.WriteLine("Vater");
                else if (person is Mutter)
                    Console.WriteLine("Mutter");
            }

            Console.ReadKey();
        }
    }
}

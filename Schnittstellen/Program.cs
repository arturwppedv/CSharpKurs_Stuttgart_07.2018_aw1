using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
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

            //Vater weiss nun welche Kinder seine sind
            Klaus.Kinder.Add(Alex);
            Klaus.Kinder.Add(Jana);

            //Mutter weiss nun welche Kinder ihre sind
            Maria.Kinder.Add(Alex);
            Maria.Kinder.Add(Jana);

            //double x = 123.455;

            foreach(Kind child in Klaus.Kinder)
            {
                Console.WriteLine(child);
            }

            //Console.WriteLine(Alex);
            //Console.WriteLine(Alex.ToString());
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Für Snippets:
            //https://msdn.microsoft.com/de-de/library/z41h7fat.aspx

            //Strg + K + C =  Zeile Kommentieren
            //Strg + K + U = Kommentar rückgängig machen
            //cw ->Tab->Tab = Console.WriteLine(); schreiben

            Console.WriteLine("Hello World");
            //Console.WriteLine();

            string einlesen = Console.ReadLine();
            Console.WriteLine($"1: Hallo {einlesen}");
            Console.WriteLine("2: Hallo " + einlesen );
            Console.WriteLine(string.Format("3: Hallo {0}", einlesen));
            string s = string.Format("Hallo {0}, und {2}, mit {1}", "Hans", "Franz");
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}

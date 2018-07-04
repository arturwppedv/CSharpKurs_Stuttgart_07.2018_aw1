using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lottozahlen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            int[] lottozahlen = new int[6];
            int[] eingabezahlen = new int[6];
            int richtige = 0;

            //Zufallszahlen generieren
            for (int i = 0; i < lottozahlen.Length; i++)
            {
                int zufallszahl = generator.Next(1, 49);

                if (lottozahlen.Contains(zufallszahl))
                {
                    i--;
                    continue;
                }

                lottozahlen[i] = zufallszahl;
            }

            Console.WriteLine("Willkommen beim Lotto!!!");

            //Benutzereingaben werden abgefragt und gespeichert
            for (int i = 0; i < eingabezahlen.Length; i++)
            {
                //Wenn ein Duplikat eingegeben wird, wird die Abfrage an der letzten
                //Stelle wiederholt
                Console.WriteLine($"{i + 1}. Zahl:");
                try
                {
                    int eingabe = Convert.ToInt32(Console.ReadLine());

                    //Wenn die Eingabe in dem EingabeArray vorhanden ist oder die Eingabe
                    //entweder < 1 oder > 49 ist, wird nicht vom EingabeArray akzeptiert
                    if (eingabezahlen.Contains(eingabe) || (eingabe < 1 || eingabe > 49))
                    {
                        i--;
                        continue;
                    }
                    eingabezahlen[i] = eingabe;
                }
                catch(FormatException)
                {
                    i--;
                }

            }

            Console.WriteLine("\r\nGezogene Zahlen:");


            //Array sortieren
            Array.Sort(lottozahlen);

            //Lottozahlen, die gezogen wurden, werden angezeigt
            foreach (int zahl in lottozahlen)
            {
                Console.Write(zahl);
                Console.Write("  ");
                Debug.WriteLine("Debug___");
            }

            //Es wird gezählt wie viele Richtige man getippt hat
            for (int i = 0; i < eingabezahlen.Length; i++)
            {
                if (lottozahlen.Contains(eingabezahlen[i]))
                    richtige++;
            }

            //Und die Anzahl der Richtigen ausgegeben
            Console.WriteLine($"\r\nDavon richtige: {richtige}");

            Console.ReadKey();
        }
    }
}

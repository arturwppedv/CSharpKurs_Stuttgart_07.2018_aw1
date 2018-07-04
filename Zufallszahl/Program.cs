using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zufallszahl
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int zufallszahl = random.Next(1, 5);
            int versuche = 0;


            while (true)
            {
                try
                {
                    Console.WriteLine("Geben Sie eine Zufallszahl zwischen 1 und 5 ein");
                    int zahl = Convert.ToInt32(Console.ReadLine());

                    if (zahl > zufallszahl)
                    {
                        Console.WriteLine("Zahl ist größer");
                        versuche++;
                        continue;   //springt zum Anfang der Schleife
                    }
                    else if (zahl < zufallszahl)
                    {
                        Console.WriteLine("Zahl ist kleiner");
                        versuche++;
                    }
                    else
                    {
                        Console.WriteLine("Getroffen");
                        versuche++;
                        break;  //Bricht aus der Schleife heraus
                    }
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Falsches Format");
                    //Console.WriteLine(ex.StackTrace);
                }
                catch (NullReferenceException)
                {

                }
                //Finally ist optional
                finally
                {
                    Console.WriteLine("Finally");
                }
            }

            Console.WriteLine($"Beendet. Du hast {versuche} Versuch(e) gebraucht");
            Console.ReadKey();

            ////So liest man einen char vom ReadKey() aus
            //ConsoleKeyInfo rk = Console.ReadKey();
            //char key = rk.KeyChar;

            //Console.WriteLine(key);
            //Console.ReadKey();
        }
    }
}

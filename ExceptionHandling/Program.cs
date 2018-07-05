using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    public class NummerNichtVerfügbarException : Exception
    {
        public string EingabeZahl { get; set; }

        public NummerNichtVerfügbarException(string msg, string eingabezahl) : base(msg)
        {
            EingabeZahl = eingabezahl;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Geben Sie eine Nummer ein:");
                string nummer = Console.ReadLine();

                try
                {
                    if (Convert.ToInt32(nummer) == 12345)
                        throw new NummerNichtVerfügbarException("Die Nummer 12345 ist nicht verfügbar", nummer);

                    else if (Convert.ToInt32(nummer) == -1)
                        break;

                    Console.WriteLine($"{nummer} ist verfügbar");
                }
                catch (NummerNichtVerfügbarException ex)
                {
                    Console.WriteLine(ex.Message + " " + "Eingabe war: " + ex.EingabeZahl);
                }
                catch(FormatException)
                {
                    Console.WriteLine("Keine Zahl eingegeben");
                }
            }
        }
    }
}

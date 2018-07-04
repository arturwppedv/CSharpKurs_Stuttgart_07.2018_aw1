using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konvertierung
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s = string.Format(new System.Globalization.CultureInfo("de-de"), "{0:0,0}", "123,456.78");
            string s = "123,456.78";
            //double d = double.Parse(s);
            //double d = Convert.ToDouble(s);
            int zahl = 12345;

            double zahl2 = 1234.56789;
            int z2 = (int)zahl2;    //Cast zu Int
            int z3 = Convert.ToInt32(zahl2);    //Umwandlung/Parse zum Int

            //konvertierung eine Zahl in ein String mit Angabe der Darstellung
            string nConvert = string.Format("{0:0.00}, {1:0.000}", zahl2, zahl2);
            string nummer = zahl.ToString();    //Umwandlung zum String

            double z4 = 123.456;
            int z5 = (int)z4;
            double math = Math.Round(z4, 4);    //Rundet automatisch ab oder auf
                                                //Ab .6 => Auf | bis .5 => ab
            double math2 = Math.Ceiling(z4);    //Rundet auf
            double math3 = Math.Floor(z4);      //Rundet ab

            Console.WriteLine($"Zahl(int): {zahl}");
            Console.WriteLine($"Zahl(double): {zahl2}");
            Console.WriteLine($"Zahl(d->i): {z2}");
            Console.WriteLine($"Zahl(d->i Convert): {z3}");
            Console.WriteLine($"Zahl(string von int): {nummer}");

            Console.WriteLine(z4);
            Console.WriteLine(z5);
            Console.WriteLine(math);
            Console.WriteLine(math2);
            Console.WriteLine(math3);
            Console.WriteLine(nConvert);



            Console.ReadKey();

        }
    }
}

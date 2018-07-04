using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MatheOperationen;

namespace Funktionen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Grundrechenarten grundrechenarten = new Grundrechenarten();   //Nur wenn nicht static

            double[] zahlen = new double[] { 1, 2, 3, 4, 5 };

            double add = Grundrechenarten.Addition(zahlen);

            //oder
            double add2 = Grundrechenarten.Addition(1, 2, 3, 4, 5);

            double sub = Grundrechenarten.Subtraktion(100, 50, 40);

            double subErgebnis, addErgebnis, multErgebnis, divErgebnis;
            double referenz = 50;

            Grundrechenarten.Multiplikation(10, 10, ref referenz);

            Console.WriteLine(referenz);

            Grundrechenarten.BerechneAlles(out addErgebnis, out subErgebnis, out multErgebnis, out divErgebnis,
                                                100, 10);

            Console.WriteLine(addErgebnis);
            Console.WriteLine(subErgebnis);
            Console.WriteLine(multErgebnis);
            Console.WriteLine(divErgebnis);

            //Console.WriteLine(sub);
            Console.ReadKey();


            //int Addition(int z1, int z2)
            //{
            //    return z1 + z2;
            //}
        }
    }
}

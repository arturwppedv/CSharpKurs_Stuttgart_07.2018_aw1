using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] zahlen = new int[] { 1, 2, 40, 5, 7, 8 };
            int[] andereZahlen;
            int[,,] mehrdim = new int[10, 5, 4];

            

            //Ausgabe Vorwährts
            //for (int i = 0; i < zahlen.Length; i++)
            //{
            //    //zahlen[i] = 1;
            //    Console.WriteLine(zahlen[i]);
            //}

            int variable = 43;
            andereZahlen = new int[variable];

            //Ausgabe Rückwährts
            //for (int i = zahlen.Length - 1; i >= 0; i--)
            //{
            //    Console.WriteLine(zahlen[i]);
            //}

            //Dient 
            foreach (int zahl in zahlen)
            {
                //zahl = 1; //Das geht nicht
                Console.WriteLine(zahl);
            }

            Console.WriteLine(zahlen.Max());    //Der maximale Wert eines numerischen Arrays
            Console.WriteLine(zahlen.Min());    //Der maximale Wert in einem numerischen Arrays
            Console.WriteLine(zahlen.First());  //Das erste Element in einem Array
            Console.WriteLine(zahlen.Last());   //Das letzte Element in einem Array

            Console.ReadKey();
        }
    }
}

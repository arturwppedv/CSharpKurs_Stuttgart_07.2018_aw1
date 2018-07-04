using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheOperationen
{
    public static class Grundrechenarten
    {
        //public static double Addition(double a, double b)
        //{
        //    return a + b;
        //}

        //public static double Addition(double a, double b, double c)
        //{
        //    return a + b + c;
        //}

        //Funktion mit dynamischer Parameterliste
        public static double Addition(params double[] summanden)
        {
            double summe = 0;
            for (int i = 0; i < summanden.Length; i++)
            {
                summe += summanden[i];
            }

            return summe;
        }

        //c ist ein optionaler Parameter
        public static double Subtraktion(double a, double b, double c = 10)
        {
            return a - b - c;
        }

        public static double Division(double a, double b)
        {
            if (b == 0)
                b = 1;

            return a / b;
        }

        public static double Multiplikation(double a, double b, ref double c)
        {
            double e = a * b + c;
            c += 10;
            return a * b;
        }

        public static void BerechneAlles(out double add, out double sub, out double mult, out double div, double zahl1, double zahl2)
        {            
            add = zahl1 + zahl2;
            sub = zahl1 - zahl2;
            mult = zahl1 * zahl2;
            div = zahl1 / zahl2;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        //Liste von Methoden-Referenzen
        //Methoden sollen wie folgt aussehen:
        //Kein RÜckgabewert und ein Prameter vom Typen Integer
        public delegate void MyDelegate(int x);
        public delegate int RueckDelegate();

        static void Main(string[] args)
        {
            //MyDelegate wird erzeugt und die Methode "LichtAn" wird hineingelegt
            MyDelegate myDelegate = new MyDelegate(LichtAn);
            myDelegate += HeizungAn;

            RueckDelegate rueckDelegate = new RueckDelegate(Rueckgabe);
            rueckDelegate += Rueckgabe1;
            rueckDelegate += Rueckgabe2;

            myDelegate.Invoke(5);
            myDelegate(5);  //Es geht auch ohne Invoke. Ohne Parameter darf man die Klammern nicht vergessen

            //Man erhält immer nur den Rückgabewert der letzten Methode,
            //da die RÜckgabewerte der vorherigen auch immer in x geschrieben werden.
            //Der Wert wird immer wieder überschrieben
            int x = rueckDelegate.Invoke();
            Console.WriteLine("x: " + x);





            //Delegate Klassen, die schon existieren
            //Action: gar keinen Rückgabewert, kann aber Parameter enhalten
            //Predicate: Bool als Rückgabewert und muss mind. 1 Parameter enthalten
            //Func: Hat immer einen Rückgabewert=>immer letzte angegebene Datentyp und davor
            //sind es Parameter

            //Datentypen(Parameter oder Rückgabewert von Func) werden generisch angegeben
            //Max. 16 Parameter erlaubt

            Action action = new Action(Action1);
            Action<int, string> action2 = new Action<int, string>(Action2);

            Predicate<string> predicate = new Predicate<string>(Pred1);

            Func<string> func = new Func<string>(Func1);
            Func<int, double, double> func2 = new Func<int, double, double>(Func2);
            func2 += Func3;





            //Anonyme Methode Variante 1
            action2 += delegate (int e, string s)
            {
                //Hier kommt die Funktionalität rein
                Console.WriteLine("Anonym1: " + e + " " + s);
            };

            //Anonyme Methode Variante 2
            action2 += (zahl, text) =>
            {
                //Hier kommt die Funktionalität rein
                Console.WriteLine("Anonym2: " + zahl + " " + text);
            };



            double r = func2(10, 5);
            Console.WriteLine("r: " + r);

            action2(10, "ist keine Primzahl");

            Console.ReadKey();

            //MyDelegate myDelegate2 = null;
            //myDelegate2 += LichtAn;

            double Func3(int d, double k)
            { return d / k * 2; }

            double Func2(int d, double k)
            { return d * k / 2; }

            string Func1()
            { return "hallo"; }

            bool Pred1(string h)
                { return true; }

            void Action1()
            {

            }

            void Action2(int z, string s)
            { }

            void LichtAn(int zimmerNr)
            {
                Console.WriteLine($"Licht ist in Zimmer {zimmerNr} eingeschaltet worden");
            }

            void HeizungAn(int hNr)
            {
                Console.WriteLine($"Heizung {hNr} ist eingeschaltet worden");
            }

            int Rueckgabe()
            {
                return 2;
            }

            int Rueckgabe1()
            {
                return 5;
            }

            int Rueckgabe2()
            {
                return 20;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Schnittstellen;
using Klassen;

namespace Clonen
{
    class Program
    {
        static void Main(string[] args)
        {
            //Die Klasse Person liegt im Projekt "Klassen"


            Person Max = new Person("Max", "Mustermann", 23);

            //Die Daten von Max werden nicht kopiert.
            //Es wird nur die Referenz von Max in Max2 gespeichert.
            //Max1 und Max2 ist dann dasselbe Objekt
            Person Max2 = Max;

            //Bei primitiven Datentypen (Int, String, Double, etc) wird nicht die
            //Referenz zugewiesen, sondern da wird der Wert tatsächlich kopiert
            Person Max4 = new Person("Maximilian", "Mustermann", 33);
            Max4.Vorname = Max.Vorname;           

            //Werte von Max werden in Max3 kopiert, mit dem Kopierkonstruktor
            //Person Max3 = new Person(Max);

            //Werte von Max werden geklont und Max3 ist dieser Klon
            Person Max3 = Max.Clone() as Person;

            Console.WriteLine($"Max1: {Max.Vorname}");
            Console.WriteLine($"Max2: {Max2.Vorname}");
            Console.WriteLine($"Max3: {Max3.Vorname}");
            Console.WriteLine($"Max4: {Max4.Vorname}");

            //Verändert man von einem der Personen einen Wert,
            //so ändert sich bei beiden der Wert,
            //da beide auf demselben Objekt im RAM arbeiten
            Max2.Vorname = "Frederik";

            Max4.Vorname = "Carlo";

            Max3.Vorname = "Heinz";

            Console.WriteLine("Nach Veränderung:");
            Console.WriteLine($"Max1: {Max.Vorname}");
            Console.WriteLine($"Max2: {Max2.Vorname}");
            Console.WriteLine($"Max3: {Max3.Vorname}");
            Console.WriteLine($"Max4: {Max4.Vorname}");

            Console.ReadKey();
        }
    }
}

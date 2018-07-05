using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public class Person : ICloneable
    {
        //Properties / Eigenschaften

        //prop->tab->tab
        public string Vorname { get; set; } //Auto Getter und Setter
        public string Nachname { get; set; }

        //Member-Variable
        //propfull->tab->tab
        private int _Alter;

        //Getter und Setter ausgeschrieben
        //Value ist der Wert, der gesetzt werden soll
        public int Alter
        {
            get
            {
                return _Alter;
            }

            set
            {
                if (value > 0)
                    _Alter = value;
                else
                    _Alter = 1;
            }
        }

        //Konstruktor: Name immer gleich des Klassennamens, setzt den Startzustand des Objektes
        //ctor->tab->tab
        public Person(string vorname, string nachname, int alter)
        {
            Vorname = vorname;
            Nachname = nachname;
            Alter = alter;
        }

        //Kopierkonstruktor
        //Jede Property muss einzelnt zugewiesen werden
        //Der Parameter ist die Person, von der man die Werte kopieren möchte.
        //Die Person, die diesen Konstruktor aufruft, ist die neue Person, die
        //die Werte von der anderen Person kopieren möchte
        public Person(Person p)
        {
            Vorname = p.Vorname;
            Nachname = p.Nachname;
            Alter = p.Alter;
        }

        //virtual = ist überschreibbar
        public virtual void SagDeinenNamen()
        {
            Console.WriteLine($"Ich heiße {Vorname} {Nachname} und bin {Alter} Jahre alt");
        }

        //Die Person, deren Werte kopiert werden sollen,
        //ruft diese Methode auf.
        //Als Rückgabewert erhält man ein neues Personen-Objekt mit denselben Werten
        //MemberwiseClone() kopiert alle Properties
        public object Clone()
        {
            Person clonedPerson = (Person)this.MemberwiseClone();
            return clonedPerson;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Peter = new Person("Peter", "Schmidt", 53);
            Person Max = new Person("Max", "Mustermann", 24);

            Student student = new Student("Hans", 19, "Hanssen", 12345);
            Dozent dozent = new Dozent("Klaus", "Klaussen");

            Peter.SagDeinenNamen();
            Max.SagDeinenNamen();
            student.SagDeinenNamen();
            dozent.Vorstellen();

            Console.ReadKey();
        }
    }
}

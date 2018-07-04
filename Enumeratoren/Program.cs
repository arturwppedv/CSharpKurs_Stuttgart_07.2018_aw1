using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeratoren
{
    class Program
    {
        enum Operatoren { Addition, Subtraktion, Division, Multiplikation}

        static void Main(string[] args)
        {
            int zahl1 = 0, zahl2 = 0;
            int operation = 2;

            Operatoren op = new Operatoren();
            op = Operatoren.Addition;

            if(operation == (int)Operatoren.Division)
            {
                //int erg = zahl1 / zahl2;
            }

            if(op == Operatoren.Multiplikation)
            {

            }

            Console.WriteLine(Operatoren.Addition);

            switch (op)
            {
                case Operatoren.Addition:
                    break;
                case Operatoren.Subtraktion:
                    break;
                case Operatoren.Division:
                    break;
                case Operatoren.Multiplikation:
                    break;
                default:
                    break;
            }

            Console.ReadKey();
        }
    }
}

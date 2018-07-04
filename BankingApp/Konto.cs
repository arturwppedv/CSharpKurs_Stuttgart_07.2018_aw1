using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Konto
    {
        public int Kontonummer { get; set; }
        public double Guthaben { get; set; }
        public Person Inhaber { get; set; }

        public bool IsDisposition { get; protected set; }

        public Konto(int kto, double guthaben, Person inhaber)
        {
            Kontonummer = kto;
            Guthaben = guthaben;
            Inhaber = inhaber;
        }

        public void Einzahlen(double summe)
        {
            Guthaben += summe;
        }



        public override string ToString()
        {
            return $"Kto: {Kontonummer} | Guthaben: {Guthaben}";
        }
    }
}

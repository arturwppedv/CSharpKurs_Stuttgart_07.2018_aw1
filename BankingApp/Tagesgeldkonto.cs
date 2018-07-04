using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Tagesgeldkonto : Konto
    {
        const double ZINS = 1.02;
        public Tagesgeldkonto(int kto, double guthaben, Person inhaber) 
            : base(kto, guthaben, inhaber)
        {
            IsDisposition = false;
        }

        public void Umbuchen(Konto empfänger, double summe)
        {
            if (empfänger.Inhaber == Inhaber)
            {
                empfänger.Guthaben += summe;
                Guthaben -= summe;
            }
        }

        public void Verzinsen()
        {
            Guthaben *= ZINS;
        }

        public override string ToString()
        {
            return $"Kto: {Kontonummer} | Guthaben: {Guthaben} | Zins: {(ZINS * 100) - 100}%";
        }
    }
}

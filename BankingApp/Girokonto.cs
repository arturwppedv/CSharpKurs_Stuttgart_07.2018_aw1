using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public class Girokonto : Konto
    {
        public Girokonto(int kto, double guthaben, Person inhaber) 
            : base(kto, guthaben, inhaber)
        {
            IsDisposition = true;
        }

        public void Überweisen(Konto empfänger, double summe)
        {
            empfänger.Guthaben += summe;
            Guthaben -= summe;           
        }
    }
}

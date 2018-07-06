using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mitarbeiterverwaltung.Konstanten
{
    public static class Werte
    {
        public const double GRUNDGEHALT_AZUBI = 500;

        public const double GRUNDGEHALT_ENTWICKLER = 1500;

        public const double GRUNDGEHALT_PROJEKTLEITER = 2500;

        public const double GEHALT_ERHOEHUNG_MULTIPLIKATOR = 1.05;        

        public enum MitarbeiterTyp
        {
            Azubi,
            Entwickler,
            Projektleiter
        }
    }
}

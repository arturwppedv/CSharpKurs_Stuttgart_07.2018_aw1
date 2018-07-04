using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klassen
{
    public abstract class Mensch
    {
        public abstract string Vorname { get; set; }
        public abstract string Nachname { get; set; }

        public abstract void Vorstellen();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    public interface IMutter
    {
        bool Weiblich { get; set; }
        string Maedchenname { get; set; }

        void Gebaehren();
    }
}

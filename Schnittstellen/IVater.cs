using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schnittstellen
{
    public interface IVater
    {
        bool Zeugungsfaehig { get; set; }
        bool Maennlich { get; set; }

        void Jagen();
    }
}

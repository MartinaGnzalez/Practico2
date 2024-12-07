using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Impresora : IImprimible
    {
        public void Imprimir(IImprimible documento)
        {
            documento.Imprimir();
        }

    }
}

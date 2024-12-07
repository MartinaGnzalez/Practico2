using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Impuesto : IImprimible
    {
        private int Importe;

        public int getImporte() 
        { 
            return Importe; 
        }

        public void setImporte(int importe) 
        { 
            Importe = importe;
        }

        public abstract void Imprimir();

    }
}

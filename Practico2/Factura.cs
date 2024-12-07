using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Factura : DocumentoContable, IImprimible
    {
        
        public Factura() { }

       
        public Factura(DateTime fecha, int importe, int numero) : base (fecha, importe, numero)
        {
            Numero = numero;
            Fecha = fecha;
            Importe = importe;
        }

        
        public int Total()
        {
            
            return Importe;
        }

        
        
    }
}


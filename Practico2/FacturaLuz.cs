using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class FacturaLuz : Impuesto
    {
        private int CodigoPago;
        private int Importe;

        public int getCodigoPago() 
        {  
            return CodigoPago; 
        }
        public int getImporte()
        { 
            return Importe;
        }
        public void setCodigoPago(int codigoPago)
        {
            CodigoPago = codigoPago;
        }
        public void setImporte(int importe) 
        {
            Importe = importe;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Factura de Luz: Código Pago {CodigoPago}, Importe: {Importe}");
        }



    }
}

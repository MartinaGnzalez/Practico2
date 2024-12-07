using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class NotaCredito : DocumentoContable
    {
        public void Total()
        {

        }
        public override void Imprimir()
        {
            Console.WriteLine($"Nota de Crédito N°{Numero}, Fecha: {Fecha}, Importe: {Importe}");
        }
    }
}

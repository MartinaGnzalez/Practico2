using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var factura = new Factura(1, DateTime.Now, 1000);
            Console.WriteLine($"El total de la factura es: {factura.Total()}");
            var notaCredito = new NotaCredito { Numero = 2, Fecha = DateTime.Now, Importe = 500 };
            var facturaLuz = new FacturaLuz { CodigoPago = 123, Importe = 300 };
            var impuestoMunicipal = new Municipal { Partida = 456, Importe = 700 };
            var reciboSueldo = new ReciboSueldo { Legajo = 789, Total = 5000 };
            var remito = new Remito { Numero = 3, Fecha = DateTime.Now, CantBultos = 10 };

           
            Impresora impresora = new Impresora();

            
            impresora.Imprimir(factura);
            impresora.Imprimir(notaCredito);
            impresora.Imprimir(facturaLuz);
            impresora.Imprimir(impuestoMunicipal);
            impresora.Imprimir(reciboSueldo);
            impresora.Imprimir(remito);
        
        }
    }
}

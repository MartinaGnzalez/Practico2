using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class ReciboSueldo : IImprimible
    {
        private int Legajo;
        private int Total;

        public int getLegajo() 
        { 
            return Legajo; 
        }
        public int getTotal() 
        {
            return Total;
        }

        public void setLegajo(int legajo)
        {
            Legajo = legajo;
        }
        public void setTotal(int total) 
        { 
            Total = total;
        }
        public void Imprimir()
        {
            Console.WriteLine($"Recibo de Sueldo: Legajo {Legajo}, Total: {Total}");
        }
    }
}

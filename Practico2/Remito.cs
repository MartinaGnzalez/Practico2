using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class  Remito : IImprimible
    {
        private int CantBultos;
        private DateTime Fecha;
        private int Numero;

        public int getCantBultos() 
        { 
            return CantBultos;
        }
        public DateTime getFecha() 
        { 
            return Fecha; 
        }
        public int getNumero()
        {
            return Numero;
        }
        public void setFceha(DateTime fecha) 
        {
            Fecha = fecha;
        }
        public void setNumero(int numero) 
        { 
            Numero = numero;
        }

        public void Imprimir()
        {
            Console.WriteLine($"Remito N°{Numero}, Fecha: {Fecha}, Cantidad de Bultos: {CantBultos}");
        }
    }
}

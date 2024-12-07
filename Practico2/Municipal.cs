using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class Municipal : Impuesto
    {
        private int Partida;

  
        public int getPartida() 
        {
            return Partida;
        }

        public void setPartida(int partida)
        {
            Partida = partida;
        }

        public override void Imprimir()
        {
            Console.WriteLine($"Impuesto Municipal: Partida {Partida}, Importe: {Importe}");
        }

    }
}

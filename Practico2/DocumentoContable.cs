using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Practico2
{
    internal class DocumentoContable : IImprimible
    {
        private DateTime Fecha;
        private int Importe;
        private int Numero;
        private int Sigla;

        public DocumentoContable(DateTime fecha, int importe, int numero, int sigla)
        {
            Fecha = fecha;
            Importe = importe;
            Numero = numero;
            Sigla = sigla;
        }
        public DateTime getFecha()
        {
            return Fecha;
        }
        public int getImporte()
        { 
            return Importe;
        }

        public int getNumero()
        {
            return Numero;
        }
        public int getSigla()
        {
            return Sigla;
        }

        public void setFecha(DateTime fecha)
        {
            Fecha = fecha;
        }
        public void setImporte(int importe)
        {
            Importe = importe;
        }
        public void setNumero(int numero) 
        { 
            Numero = numero;
        }
        public void setSigla(int sigla)
        {
            Sigla = sigla;
        }

        public abstract void Imprimir();
        public void Total()
        {
            
        }
    }
}
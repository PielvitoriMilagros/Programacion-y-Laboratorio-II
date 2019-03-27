using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;


        public int GetCantSumas()
        {
            return this.cantidadSumas;

        }

        public Sumador(int cant)
        {
            this.cantidadSumas = cant;
        }

        public Sumador() : this(0)
        {

        }

        public long Sumar(long a, long b)
        {
            long result;
            this.cantidadSumas += 1;
            result = a + b;
            return result;
        }

        public string Sumar(string a,string b)
        {
            string result;
            this.cantidadSumas += 1;
            result = a + b;
            return result;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio39
{
    public abstract class Sobreescrito
    {
        protected string miAtributo;

        public Sobreescrito()
        {
            this.miAtributo = "Probar Abstractos";
        }

        public abstract string MiPropiedad { get; }

        public abstract string MiMetodo();



        public override string ToString()
        {
            return "¡Este es mi método ToString sobreescrito!";
            //            return base.ToString();
        }

        public override bool Equals(object obj)
        {
            if (obj is Sobreescrito)
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            return 1142510187;
        }

    }
}

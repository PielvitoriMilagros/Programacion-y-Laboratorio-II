using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio38
{
    public class Sobreescrito
    {
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio31
{
    public class PuestoAtencion
    {
        private static int numeroActual;
        private Puesto puesto;

        #region Constructores

        private PuestoAtencion()
        {
            numeroActual = 0;
        }

        public PuestoAtencion (Puesto puesto):this()
        {
            this.puesto = puesto;
        }

        #endregion

        #region Propiedad

        public static int NumeroActual
        {
            get { return numeroActual += 1; }
        }

        #endregion


        public bool Atender (Cliente cli)
        {
            Thread.Sleep(2000);
            return true;
        }



        #region Enumerado

        public enum Puesto
        {
            Caja1,
            Caja2
        }

        #endregion
    }
}

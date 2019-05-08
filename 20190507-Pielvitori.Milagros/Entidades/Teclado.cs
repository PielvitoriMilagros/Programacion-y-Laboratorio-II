using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Teclado : Periferico
    {
        public enum EDistribucion
        {
            Dvorak,
            QWERTY,
            QWERTZ,
            AZERTY
        }

        public EDistribucion distribucion;
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca">marca a asignar</param>
        /// <param name="modelo">modelo a asignar</param>
        /// <param name="conector">conector a asignar</param>
        public Teclado(string marca, string modelo, EConector conector) : base(marca, modelo, conector)
        {
            this.distribucion = EDistribucion.Dvorak;
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca">marca a asignar</param>
        /// <param name="modelo">modelo a asignar</param>
        /// <param name="conector">conector a asignar</param>
        /// <param name="region">distribución a asignar</param>
        public Teclado(string marca, string modelo, EConector conector, EDistribucion region) : base(marca, modelo, conector)
        {
            this.distribucion = region;
        }
        /// <summary>
        /// Mostrar los datos del Teclado
        /// </summary>
        /// <returns>Información del Teclado</returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("TECLADO " + (string)this);
            sb.AppendLine("Distribución " + this.distribucion);

            return sb.ToString();

        }


    }
}

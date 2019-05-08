using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Periferico
    {
        private EConector conector;
        private string marca;
        private string modelo;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="marca">marca a asignar al periferico</param>
        /// <param name="modelo">modelo a asignar al periferico</param>
        /// <param name="conector">conector a asignar al periferico</param>
        public Periferico(string marca, string modelo, EConector conector)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.conector = conector;
        }

        /// <summary>
        /// Conversion explicita para operador string
        /// </summary>
        /// <param name="p">objeto del tipo periferico</param>
        /// <returns>Información del periférico</returns>
        public static explicit operator string(Periferico p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat(p.marca + " ");
            sb.AppendFormat(p.modelo + " ");

            return string.Format(sb + " (Puerto: {0})", p.conector);

        }
        /// <summary>
        /// Sobrecarga para igualar dos perifericos
        /// </summary>
        /// <param name="p1">Objeto primer periferico a igualar</param>
        /// <param name="p2">Objeto segundo periferico a igualar</param>
        /// <returns>Condicion si son iguales o no</returns>
        public static bool operator ==(Periferico p1, Periferico p2)
        {
            if (p1.marca != null && p2.marca != null && p1.modelo != null && p2.modelo != null)
            {
                if (p1.marca == p2.marca && p1.modelo == p2.modelo)
                    return true;
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga para diferenciar dos perifericos
        /// </summary>
        /// <param name="p1">Objeto primer periferico a diferenciar</param>
        /// <param name="p2">Objeto segundo periferico a diferenciar</param>
        /// <returns>Condicion si son diferentes o no</returns>
        public static bool operator !=(Periferico p1, Periferico p2)
        {
            return !(p1 == p2);
        }


        public abstract string ExponerDatos();

    }
}

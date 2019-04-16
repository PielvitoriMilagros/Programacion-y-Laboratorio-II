using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        #region Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Numero
        {
            get { return numero; }
        }

        #endregion

        #region Constructores

        Cliente (int numero)
        {
            this.numero = numero;
        }

        Cliente(int numero, string nombre):this(numero)
        {
            this.nombre = nombre;
        }

        #endregion

        #region Sobrecarga de operadores
        public static bool operator ==(Cliente c1,Cliente c2)
        {
            if (c1.numero == c2.numero)
                return true;
            return false;
        }

        public static bool operator !=(Cliente c1,Cliente c2)
        {
            return !(c1 == c2);
        }

        #endregion
    }
}

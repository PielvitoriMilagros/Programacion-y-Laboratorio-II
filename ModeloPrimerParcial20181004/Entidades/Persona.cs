using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;


        public Persona(string nombre,string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.dni = dni;
        }

        #region Propiedades

        public string Apellido
        {
            get { return this.apellido; }
        }

        public int Dni
        {
            get { return this.dni; }
        }

        public int Edad
        {
            get { return this.edad; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        #endregion

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Apellido: " + Apellido);
            sb.AppendLine("Nombre: " + Nombre);
            sb.AppendLine("Dni: " + Dni);
            sb.AppendLine("Edad: " + Edad);

            return sb.ToString();
            
        }

        public abstract bool ValidarAptitud();


    }
}

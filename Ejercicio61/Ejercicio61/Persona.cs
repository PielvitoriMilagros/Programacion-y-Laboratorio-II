using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    public class Persona
    {

        private int id;
        private string nombre;
        private string apellido;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }


        public Persona(int id, string nom, string ape)
        {
            this.id = id;
            this.nombre = nom;
            this.apellido = ape;
        }

        public Persona(string nom, string ape)
        {
            this.nombre = nom;
            this.apellido = ape;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Persona: ");
            sb.AppendLine(this.Nombre + " " + this.Apellido);

            return sb.ToString();
        }
    }
}

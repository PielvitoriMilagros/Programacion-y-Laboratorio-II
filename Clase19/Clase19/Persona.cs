using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase19
{
    [Serializable]
    public class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;
        private int nroTarjeta;


        #region Propiedades

        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }

        public int Dni
        {
            get { return this.dni; }
            set { this.dni = value; }
        }
        #endregion


        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.dni = 0;
            this.nroTarjeta = 0;
        }

        public Persona(string nom, string ape, int dni,int nro)
        {
            this.Nombre = nom;
            this.Apellido = ape;
            this.Dni = dni;
            this.nroTarjeta = nro;
        }


        public override string  ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre+"  ");
            sb.AppendLine(this.Apellido + "  ");
            sb.AppendLine(this.Dni + "  ");
            sb.AppendLine(this.nroTarjeta + "  ");
            sb.AppendLine();
            
            return sb.ToString();
        }



    }
}

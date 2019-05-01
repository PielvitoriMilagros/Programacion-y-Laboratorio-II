using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador : Persona
    {
        private float altura;
        private float peso;
        private Posicion posicion;

        #region Propiedades
        public float Altura
        {
            get { return this.altura; }
        }
        public float Peso
        {
            get { return this.peso; }
        }
        public Posicion Posicion
        {
            get { return this.posicion; }
        }
        #endregion

        public Jugador(string nombre, string apellido, int edad, int dni, float peso, float altura, Posicion posicion) : base(nombre, apellido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }

        public override bool ValidarAptitud()
        {
            if (this.Edad < 40 && this.ValidarEstadoFisico()==true)
                return true;
            return false;
        }

        public bool ValidarEstadoFisico()
        {
            double IMC;
            double pow;
            pow = Math.Pow(this.Altura, 2);
            IMC = this.Peso / pow;
            if (IMC >= 18.5 && IMC <= 25)
                return true;
            return false;
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JUGADOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Altura: " + this.Altura);
            sb.AppendLine("Peso: " + this.Peso);
            sb.AppendLine("Posicion: " + this.posicion);

            return sb.ToString();

        }

    }
}

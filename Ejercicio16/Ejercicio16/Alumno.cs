using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    public class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public static string colegio;
        static Random rnd;

        // Constructor con parámetros
        public Alumno(string apellido, string nombre)
        {
            this.nombre = nombre;
            this.apellido = apellido;
        }

        // Constructor para los atributos static
        static Alumno()
        {
            colegio = "UTN";
            rnd = new Random();
        }



        public void CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2>=4)
            {
                this.notaFinal = rnd.Next();
            } else
            {
                this.notaFinal = -1;
            }
        }

        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public string Mostrar()
        {
//            CONDICION? VERDADERO:FALSO

            return this.legajo.ToString() + "-" + this.apellido + " " +
                this.nombre + " " + colegio + " " +
                (this.notaFinal == -1 ? "DESAPROBADO" : this.notaFinal.ToString());

            /*            if(this.notaFinal == -1)
                        {
                            return this.nombre + " " + this.apellido + " " + this.nota1 + " " + this.nota2 + " " + "DESAPROBADO"+" "+colegio;
                        }
                        else
                        {
                            return this.nombre + " " + this.apellido + " " + this.nota1 + " " + this.nota2+" "+this.notaFinal+" "+colegio;
                        }
            */

        }
    }
}

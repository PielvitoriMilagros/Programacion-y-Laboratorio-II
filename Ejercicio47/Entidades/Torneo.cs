using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Torneo<T> where T : Equipo
    {
        private List<T> equipos;
        private string nombre;
        Random rnd = new Random();

        private Torneo()
        {
            this.equipos = new List<T>();
        }

        public Torneo(string nombre):this()
        {
            this.nombre = nombre;
        }



        /*
         * Si no tengo constructor, en vez de los () le paso una propiedad así:
                public List<T> Equipos
                {
                    set { this.equipos = value; }
                }*/

        public string JugarPartido
        {
            get
            {
                T equipo1, equipo2;
                equipo1 = this.equipos.ElementAt(rnd.Next(this.equipos.Count));
                equipo2 = this.equipos.ElementAt(rnd.Next(this.equipos.Count));

                return CalcularPartido(equipo1, equipo2);
            }
        }


        public static bool operator ==(T equipo, Torneo<T> t)
        {
            if (t.equipos != null)
            {
                foreach (T auxEquipo in t.equipos)
                {
                    if (auxEquipo == equipo)
                        return true;
                }
            }
            return false;
        }

        public static bool operator !=(T equipo, Torneo<T> t)
        {
            return !(equipo == t);
        }

        public static Torneo<T> operator +(T equipo, Torneo<T> t)
        {
            if (t.equipos != null)
            {
                if (equipo != t)
                {
                    t.equipos.Add(equipo);
                }
            }
            return t;
        }


        public string Mostrar()
        {
            if (this.equipos != null)
            {
                StringBuilder sb = new StringBuilder();

                sb.AppendLine("Torneo: " + this.nombre);
                foreach (T e in this.equipos)
                {
                    sb.AppendLine(e.Ficha());
                }

                return sb.ToString();
            }
            else
            {
                return "Estaba vacio";
            }
        }

        private string CalcularPartido(T e1, T e2)
        {
            int resultado1 = rnd.Next(10);
            int resultado2 = rnd.Next(10);

            StringBuilder sb = new StringBuilder();

            sb.Append(e1.nombre + " ");
            sb.Append(resultado1 + " - " + resultado2);
            sb.Append(" " + e2.nombre);

            return sb.ToString();
        }
    }
}

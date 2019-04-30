using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        List<Jugador> jugadores;
        private string nombre;

        public DirectorTecnico DirectorTecnico
        {
            set
            {
                if (value.ValidarAptitud())
                    this.directorTecnico = value;
            }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }


        private Equipo()
        {
             this.jugadores = new List<Jugador>();
        }

        public Equipo (string nombre):this()
        {
            this.nombre = nombre;
        }

        public static explicit operator string(Equipo e)
        {

            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Equipo: " + e.nombre);

            if (e.directorTecnico == null)
                sb.AppendLine("Sin DT asignado");
            else
                sb.AppendLine(e.directorTecnico.Mostrar());

            foreach(Jugador varJugadores in e.jugadores)
            {
                sb.AppendLine(varJugadores.Mostrar());
            }

            return sb.ToString();

        }

        public static bool ValidarEquipo(Equipo e)
        {
            int arquero = 0;
            int defensor = 0;
            int central = 0;
            int delantero = 0;
            if (e.directorTecnico != null && e.jugadores.Count() == cantidadMaximaJugadores)
            {
                foreach(Jugador varJugadores in e.jugadores)
                {
                    if (varJugadores.Posicion == Posicion.Arquero)
                        arquero++;
                    if (varJugadores.Posicion == Posicion.Defensor)
                        defensor++;
                    if (varJugadores.Posicion == Posicion.Central)
                        central++;
                    if (varJugadores.Posicion == Posicion.Delantero)
                        delantero++;
                }
                if (arquero != 1)
                    return false;
                if (defensor < 1 || central < 1 || delantero < 1)
                    return false;
                return true;
            }
                return false;
        }
        

        #region Sobrecargas

        public static bool operator ==(Equipo e,Jugador j)
        {
            if (e.jugadores != null)
            {
                foreach (Jugador varJugadores in e.jugadores)
                {
                    if (varJugadores == j)
                        return true;
                }
            }
            return false;
        }

        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            if (e != j && e.jugadores.Count() < cantidadMaximaJugadores && j.ValidarAptitud() == true)
                e.jugadores.Add(j);
            return e;
        }

        #endregion



    }

}

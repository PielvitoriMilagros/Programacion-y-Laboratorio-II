using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Maquina
    {
        private int cantidadMaxPerifericos;
        private string nombre;
        List<Periferico> perifericos;
        /// <summary>
        /// Constructor privado que inicializa la lista y la cantidad máxima
        /// </summary>
        private Maquina()
        {
            this.cantidadMaxPerifericos = 3;
            this.perifericos = new List<Periferico>();
        }
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="nombre">nombre a asignar</param>
        public Maquina(string nombre) : this()
        {
            this.nombre = nombre;
        }
        /// <summary>
        /// Propiedad para leer o asignar la cantidad máxima de periféricos
        /// </summary>
        public int CantidadMaximaPerifericos
        {
            get { return this.cantidadMaxPerifericos; }

            set
            {
                if (value < 1)
                    this.cantidadMaxPerifericos = 1;
                if (value > 4)
                    this.cantidadMaxPerifericos = 4;
                if (value >= 1 && value <= 4)
                    this.cantidadMaxPerifericos = value;
            }
        }
        /// <summary>
        /// Propiedad para leer o asignar el nombre
        /// </summary>
        public string Nombre
        {
            get { return this.nombre; }
            set { this.nombre = value; }
        }

        /// <summary>
        /// Propiedad para leer los datos de la máquina junto con sus periféricos
        /// </summary>
        public string SystemInfo
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(this.nombre + ":");

                foreach (Periferico p in this.perifericos)
                {
                    sb.AppendLine(p.ExponerDatos());
                    sb.AppendLine();
                }

                return sb.ToString();
            }
        }

        /// <summary>
        /// Sobrecarga para determinar si un periferico ya existe en la maquina
        /// </summary>
        /// <param name="m">Objeto maquina a igualar</param>
        /// <param name="p">Objeto periferico a igualar</param>
        /// <returns>Condicion si ya existia en la maquina o no</returns>
        public static bool operator ==(Maquina m, Periferico p)
        {
            if (m.perifericos != null)
            {
                foreach (Periferico auxPer in m.perifericos)
                {
                    if (auxPer == p)
                        return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga para determinar si un periferico ya existe en la maquina
        /// </summary>
        /// <param name="m">Objeto maquina a diferenciar</param>
        /// <param name="p">Objeto periferico a diferenciar</param>
        /// <returns>Condicion si ya existia en la maquina o no</returns>
        public static bool operator !=(Maquina m, Periferico p)
        {
            return !(m == p);
        }
        /// <summary>
        /// Agregar periferico a una maquina
        /// </summary>
        /// <param name="m">Objeto maquina</param>
        /// <param name="p">Objeto periferico a agregar</param>
        /// <returns>Mensaje correspondiente si pudo agregarse o no</returns>
        public static string operator +(Maquina m, Periferico p)
        {
            if (m != p && m.perifericos.Count < m.CantidadMaximaPerifericos)
            {
                m.perifericos.Add(p);
                return "Periferico conectado!";
            }
            return "No se puede conectar el dispositivo";
        }

        /// <summary>
        /// Quitar periferico de una maquina
        /// </summary>
        /// <param name="m">Objeto maquina</param>
        /// <param name="p">Objeto periferico a quitar</param>
        /// <returns>Mensaje correspondiente si pudo quitarse o no</returns>
        public static string operator -(Maquina m, Periferico p)
        {
            if (m == p)
            {
                foreach (Periferico auxP in m.perifericos)
                {
                    if (auxP == p)
                    {
                        m.perifericos.Remove(auxP);
                        break;
                    }
                }
                return "Periferico desconectado!";
            }
            return "No se puede desconectar el dipositivo";
        }

    }
}

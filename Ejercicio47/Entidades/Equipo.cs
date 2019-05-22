using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaCreacion;

        public Equipo(string nom, DateTime fec)
        {
            this.nombre = nom;
            this.fechaCreacion = fec;
        }

        public string Ficha()
        {
            return this.nombre + " fundado el " + this.fechaCreacion;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            if (e1.nombre == e2.nombre && e1.fechaCreacion == e2.fechaCreacion)
                return true;
            return false;
        }


        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }

    }
}

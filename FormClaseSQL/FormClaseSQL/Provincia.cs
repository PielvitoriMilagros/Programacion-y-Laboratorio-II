using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormClaseSQL
{
    public class Provincia
    {
        private int id;
        private string nombre;

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


        public Provincia(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }


        public override string ToString()
        {
            return this.Nombre;
        }

    }
}

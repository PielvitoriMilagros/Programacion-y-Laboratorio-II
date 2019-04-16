using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
    public class Negocio
    {
        private string nombre;
        private Queue<Cliente> clientes;
        private PuestoAtencion caja;

        #region Constructores

        private Negocio()
        {
            //En un constructor esta bien, "creo" los objetos para inicializar
            Queue clientes = new Queue();
            caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre) : this()
        {
            this.nombre = nombre;
        }

        #endregion


        public Cliente Clientes
        {
            get { return clientes.Dequeue(); }
            set
            {
                bool auxiliar;
                if(this!=value)
                {
                    auxiliar = this + value;
                }
            }
        }


        public int ClientesPendientes
        {
            get { return clientes.Count; }
        }


        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente aux in n.clientes)
            {
                if (c == aux)
                    return false;
            }
            return true;
        }

        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        public static bool operator +(Negocio n,Cliente c)
        {
            if(n!=c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }


        public static bool operator ~(Negocio n)
        {
            return n.caja.Atender(n.Clientes);
        }


    }
}

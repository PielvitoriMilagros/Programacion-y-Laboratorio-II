using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryRepaso
{
    public class Producto
    {
        //Atributos
        private string codigoDeBarra;
        private string marca;
        private float precio;

        //Constructor de instancia
        public Producto(string marca, string codigo, float precio)
        {
            this.marca = marca;
            this.codigoDeBarra = codigo;
            this.precio = precio;
        }

        //Propiedades
        public string GetMarca()
        {
            return this.marca;
        }
        public float GetPrecio()
        {
            return this.precio;
        }

        //Métodos
        public static string MostrarProducto(Producto p)
        {
            //            return p.marca + " " + p.codigoDeBarra + " " + p.precio.ToString();
            return "Codigo de barra: " + (string)p + " Marca: " + p.GetMarca() + " Precio: " + p.GetPrecio() + "\n";
        }

        //Sobrecarga explicita
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        //Sobrecarga con dos objetos
        public static bool operator ==(Producto p1, Producto p2)
        {
            /*            if (p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra)
                            return true;
                        return false;
             */
            //No se necesita el IF porque está implicito en la condición. Si se cumple eso, y a me va a devolver true
            return ((string)p1 == (string)p2 && p1.GetMarca() == p2.GetMarca());
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        //Sobrecarga con objeto y string
        public static bool operator ==(Producto p1, string marca)
        {
            /*            if (p1.marca == marca)
                            return true;
                        return false;
             */
            return p1.marca == marca;
    }

        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1.marca == marca);
        }



    }
}

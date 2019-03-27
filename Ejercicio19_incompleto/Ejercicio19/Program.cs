using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador sumador = new Sumador();

            Console.WriteLine("Suma int");
            Console.WriteLine(sumador.Sumar(15, 32) +" "+ sumador.GetCantSumas());

            Console.WriteLine("Suma string");
            Console.WriteLine(sumador.Sumar("Hola", "Mundito")+" "+sumador.GetCantSumas());

            Console.ReadKey();


        }
    }
}

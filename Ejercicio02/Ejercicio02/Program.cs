using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio_02
    {
        static double numero;
        static double cuadrado;
        static double cubo;
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero: ");
            while (double.TryParse(Console.ReadLine(), out numero) != true || numero <= 0)
            {
                Console.WriteLine("ERROR ¡Reingresar numero! ");
            }
            cuadrado=Math.Pow(numero, 2);
            cubo=Math.Pow(numero, 3);
            Console.WriteLine("El cuadrado de {0} es {1}",numero,cuadrado);
            Console.WriteLine("El cubo de {0} es {1}", numero, cubo);

            Console.ReadKey();

        }
    }
}

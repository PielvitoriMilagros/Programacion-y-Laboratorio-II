using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        public static int numero;
        public static int min;
        public static int max;
        public static int cont = 0;
        static void Main(string[] args)
        {
            for (int x = 1; x < 5; x++)
            {
                Console.WriteLine("Ingrese un numero entre -100 y 100");
                //            while(!int.TryParse(Console.ReadLine(),out numero))
                numero = int.Parse(Console.ReadLine());
                while (!Validacion.Validar(numero, -100, 100))
                {
                    Console.WriteLine("ERROR reingrese numero");
                }
                cont++;
                if (cont == 1)
                {
                    min = numero;
                    max = numero;
                }
                else
                {
                    if (numero < min)
                        min = numero;
                    if (numero > max)
                        max = numero;
                }
            }
            Console.WriteLine("El mayor fue " + max);
            Console.WriteLine("El menor fue " + min);
            Console.ReadKey();
        }
    }

}

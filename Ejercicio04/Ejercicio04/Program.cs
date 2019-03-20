using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Ejercicio_04
    {
        static int cont;
        static int divisor;
        static int numero;
        static int suma;

        static void Main(string[] args)
        {
            Console.WriteLine("Los primeros cuatro numeros perfectos son ");

            //            for (numero = 1; numero < 1000; numero++)
            numero = 1;
            while (cont != 4)
            {
                suma = 0;
                for (divisor = numero - 1; divisor > 0; divisor--)
                {
                    if (numero % divisor == 0)
                    {
                        suma += divisor;
                    }
                }
                if (suma == numero)
                {
                    Console.WriteLine(numero);
                    cont++;
                }
                numero++;
            }
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Ejercicio_03
    {
        static int numero;
        static int x;
        static int y;
        static int flag = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            while (int.TryParse(Console.ReadLine(), out numero) != true || numero < 0)
            {
                Console.WriteLine("ERROR reingrese numero");
            }
            for (y = 3; y < numero; y++)
            {
                flag = 0;
                for (x = 2; x < y; x++)
                {
                    if (y % x == 0)
                    {
                        flag = 1;
                        break;
                    }
                }
                if (flag == 0)
                {
                    Console.WriteLine("ES PRIMO "+y);
                }

            }
            Console.ReadKey();
        }
    }
}

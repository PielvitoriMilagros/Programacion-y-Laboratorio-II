using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    class Ejercicio01
    {
        static int num;
        static int min;
        static int max;
        static int acum;
        static int promedio;

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            for(int i=0;i<=5;i++)
            {
                do
                {
                    Console.Write("Ingrese un numero ");
                } while (int.TryParse(Console.ReadLine(), out num)!= true);

                if(i==1)
                {
                    max = num;
                    min = num;
                }
                else
                {
                    if (num > max)
                        max = num;
                    if (num < min)
                        min = num;
                }
                acum += num;
            }
            promedio = acum / 5;
            Console.WriteLine("El numero maximo fue "+max);
            Console.WriteLine("El numero minimo fue "+min);
            Console.WriteLine("El promedio fue "+promedio);
            Console.ReadKey();        }
    }
}

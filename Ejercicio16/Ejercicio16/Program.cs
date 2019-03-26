using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno("Perez", "Juancito");
            Alumno alumno2 = new Alumno("Garcia", "Pedrito");
            Alumno alumno3 = new Alumno("Juarez", "Taquito");


            /* Sin constructor
             * Alumno.colegio = "UTN";

             * Una vez que se crea el constructor, no es necesario ponerlo siquiera aca
             */


            // Sin constructor
            //            Alumno alumno1 = new Alumno();
            //          alumno1.nombre = "Juancito";
            //          alumno1.apellido = "Perez";
            alumno1.legajo = 123456;
            alumno1.Estudiar(8, 7);
            alumno1.CalcularFinal();
            Console.WriteLine(alumno1.Mostrar());

            // Sin constructor
            //            Alumno alumno2 = new Alumno();
            //            alumno2.nombre = "Pedrito";
            //            alumno2.apellido = "Garcia";
            alumno2.legajo = 654321;
            alumno2.Estudiar(7, 5);
            alumno2.CalcularFinal();
            Console.WriteLine(alumno2.Mostrar());

            // Sin constructor
            //           Alumno alumno3 = new Alumno();
            //           alumno3.nombre = "Taquito";
            //           alumno3.apellido = "Juarez";
            alumno3.legajo = 789456;
            alumno3.Estudiar(2, 3);
            alumno3.CalcularFinal();
            Console.WriteLine(alumno3.Mostrar());


            Console.ReadKey();
        }
    }
}

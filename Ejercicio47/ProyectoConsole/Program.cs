using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace ProyectoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo los dos torneos
            Torneo<EquipoFutbol> tFutbol = new Torneo<EquipoFutbol>("Futbolin");
            /*
             * Si no tengo constructor, en vez de los () le paso una propiedad así:
             *          {
                            Equipos = new List<EquipoFutbol>()
                        };
            */
            Torneo<EquipoBasquet> tBasquet = new Torneo<EquipoBasquet>("Basquetbolito");

            //Creo equipos de futbol
            EquipoFutbol eFutbol1 = new EquipoFutbol("Argentinos", System.DateTime.Parse("25/05/2018"));
            EquipoFutbol eFutbol2 = new EquipoFutbol("Gallinas", System.DateTime.Parse("25/06/2018"));
            EquipoFutbol eFutbol3 = new EquipoFutbol("Bosteros", System.DateTime.Parse("28/07/2018"));

            //Creo equipos de basquet
            EquipoBasquet eBasquet1 = new EquipoBasquet("SanAntonio", System.DateTime.Parse("01/01/2018"));
            EquipoBasquet eBasquet2 = new EquipoBasquet("Spurs", System.DateTime.Parse("25/02/2018"));
            EquipoBasquet eBasquet3 = new EquipoBasquet("OtroEquipo", System.DateTime.Parse("05/09/2018"));

            //Asigno los equipos a sus correspondientes torneos
            tFutbol = eFutbol1 + tFutbol;
            tFutbol = eFutbol2 + tFutbol;
            tFutbol = eFutbol3 + tFutbol;
            tBasquet = eBasquet1 + tBasquet;
            tBasquet = eBasquet2 + tBasquet;
            tBasquet = eBasquet3 + tBasquet;

            //Muestro información de los equipos
            Console.WriteLine(tFutbol.Mostrar());
            Console.WriteLine(tBasquet.Mostrar());

            Console.WriteLine(tFutbol.JugarPartido);
            Console.WriteLine(tFutbol.JugarPartido);
            Console.WriteLine(tFutbol.JugarPartido);
            Console.WriteLine();
            Console.WriteLine(tBasquet.JugarPartido);
            Console.WriteLine(tBasquet.JugarPartido);
            Console.WriteLine(tBasquet.JugarPartido);

            Console.ReadKey();
        }
    }
}

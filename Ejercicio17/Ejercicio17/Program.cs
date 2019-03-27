using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio17Boligrafo;

namespace Ejercicio17
{
    class Program
    {
        static void Main(string[] args)
        {
            string dibujoM;
            int opcion;
            string valor;
            bool sigue = true;

            Boligrafo boligrafo1 = new Boligrafo(100, ConsoleColor.Blue);
            Boligrafo boligrafo2 = new Boligrafo(50, ConsoleColor.Red);


            //Menu
            while (sigue == true)
            {
                Console.WriteLine("1. Ver boligrafos");
                Console.WriteLine("2. Pintar azul");
                Console.WriteLine("3. Recargar azul");
                Console.WriteLine("4. Pintar rojo");
                Console.WriteLine("5. Recargar rojo");
                Console.WriteLine("6. Salir");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.ForegroundColor = boligrafo1.GetColor();
                            Console.WriteLine("BoligrafoAzul");
                            Console.WriteLine(boligrafo1.GetTinta() + " " + boligrafo1.GetColor());
                            Console.ForegroundColor = boligrafo2.GetColor();
                            Console.WriteLine("BoligrafoRojo");
                            Console.WriteLine(boligrafo2.GetTinta() + " " + boligrafo2.GetColor());
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("Cuanto va a pintar");
                            valor = Console.ReadLine();
                            if (boligrafo1.Pintar(int.Parse(valor), out dibujoM) == true)
                            {
                                Console.ForegroundColor = boligrafo1.GetColor();
                                Console.WriteLine(dibujoM);
                            }
                            else
                            {
                                Console.WriteLine("No se puede pintar tanto");
                                Console.ForegroundColor = boligrafo1.GetColor();
                                Console.WriteLine(dibujoM);
                            }
                            break;
                        }
                    case 3:
                        {
                            boligrafo1.Recargar();
                            Console.ForegroundColor = boligrafo1.GetColor();
                            Console.WriteLine("BoligrafoAzul");
                            Console.WriteLine(boligrafo1.GetTinta() + " " + boligrafo1.GetColor());
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Cuanto va a pintar");
                            valor = Console.ReadLine();
                            if (boligrafo2.Pintar(int.Parse(valor), out dibujoM) == true)
                            {
                                Console.ForegroundColor = boligrafo2.GetColor();
                                Console.WriteLine(dibujoM);
                            }
                            else
                            {
                                Console.WriteLine("No se puede pintar tanto");
                                Console.ForegroundColor = boligrafo2.GetColor();
                                Console.WriteLine(dibujoM);
                            }
                            break;

                        }
                    case 5:
                        {
                            boligrafo2.Recargar();
                            Console.ForegroundColor = boligrafo2.GetColor();
                            Console.WriteLine("BoligrafoRojo");
                            Console.WriteLine(boligrafo2.GetTinta() + " " + boligrafo2.GetColor());
                            break;
                        }
                    default:
                        {
                            sigue = false;
                            break;
                        }
                }
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.ReadKey();
                Console.Clear();
            }
            /*
            Console.WriteLine("Pinto 5");
            if (boligrafo1.Pintar(5, out dibujoM) == true)
            {
                Console.ForegroundColor = boligrafo1.GetColor();
                Console.WriteLine(dibujoM);
            }
            Console.ReadKey();
            */
        }
    }
}

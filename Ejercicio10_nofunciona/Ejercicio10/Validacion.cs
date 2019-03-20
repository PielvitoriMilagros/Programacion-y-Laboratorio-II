using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class Validacion
    {
        public static bool retorno;
        public static int cont = 0;
        public static bool Validar(int valor, int min, int max)
        {
            retorno = true;
            if (int.TryParse(Console.ReadLine(), out valor) != true)
                retorno = false;
            else
            {
                if (valor > max || valor < min)
                {
                    /*                    cont++;
                                        if(cont==1)
                                        {
                                            min = valor;
                                            max = valor;
                                        }
                                        else
                                        {
                                            if (valor < min)
                                                min = valor;
                                            if (valor > max)
                                                max = valor;
                    */
                    //                } else
                    //                {
                    retorno = false;
                }
            }
            return retorno;
        }
    }
}

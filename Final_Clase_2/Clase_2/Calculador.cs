using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_2
{
  public class Calculador
  {
    private int acumulador;

    public Calculador()
    {
      this.acumulador = 0;
    }

    public void acumular (string binario)
    {
      this.acumulador += int.Parse(binario);
    }

    public string getResultadoBinario()
    {

      return "";
    }

    public int getResultadoEntero()
    {
      return this.acumulador;
    }
  }
}

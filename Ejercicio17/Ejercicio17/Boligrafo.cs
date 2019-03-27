using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17Boligrafo
{
    public class Boligrafo
    {
        const int cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private int tinta;

        public Boligrafo(short tintaConstructor, ConsoleColor colorConstructor)
        {
            this.tinta = tintaConstructor;
            this.color = colorConstructor;
        }

        public ConsoleColor GetColor()
        {
            return this.color;
        }

        public int GetTinta()
        {
            return this.tinta;
        }

        private void SetTinta(int tintaVar)
        {
            int auxTinta = this.tinta;
//            if (tintaVar >= 0)
//            {
                auxTinta += tintaVar;
 /*           }
            else
            {
              auxTinta -= tintaVar;
            }
*/            if (auxTinta >= 0 && auxTinta <= cantidadTintaMaxima)
                this.tinta = auxTinta;
        }

        public void Recargar()
        {
            this.tinta = cantidadTintaMaxima;
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            bool retorno;
            int auxPinta;
            int auxgasto;
            dibujo = "";
            if (gasto >= this.tinta)
            {
                auxPinta = this.tinta;
            }
            else
            { auxPinta = gasto; }

            for(int i=auxPinta; i>0; i--)
            {
                dibujo = dibujo + "*";
            }
            if (gasto <= this.tinta)
            {
                retorno = true;
                auxgasto = 0 - gasto;
                SetTinta(auxgasto);
            }
            else { retorno = false; }


            return retorno;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial:Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        protected Franja franjaHoraria;

        public Provincial(string origen, Franja miFranja, float duracion,string destino):base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(Franja miFranja,Llamada llamada):base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.franjaHoraria = miFranja;
        }
        
        public float CostoLlamada
        {
            get { return this.CalcularCosto(); }
        }

        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.Mostrar());
            sb.AppendLine("Costo: " + this.CostoLlamada);
            sb.AppendLine("Franja: " + this.franjaHoraria);

            return sb.ToString();
        }

        private float CalcularCosto()
        {
            float costo=0;
            switch(this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = (float)(this.Duracion * 0.99);
                    break;
                case Franja.Franja_2:
                    costo = (float)(this.Duracion * 1.25);
                    break;
                case Franja.Franja_3:
                    costo = (float)(this.Duracion * 0.66);
                    break;
            }
            return costo;
        }


    }
}

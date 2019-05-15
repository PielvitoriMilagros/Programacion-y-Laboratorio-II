using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;


        public float GananciasPorLocal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Local); }
        }

        public float GananciasPorProvincial
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Provincial); }
        }

        public float GananciasPorTotal
        {
            get { return this.CalcularGanancia(Llamada.TipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }



        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string nombreEmpresa):this()
        {
            this.razonSocial = nombreEmpresa;
        }

        private float CalcularGanancia(Llamada.TipoLlamada tipo)
        {
            float costoLocal = 0, costoProv = 0, costoTot = 0, retorno = 0;

            foreach(Llamada aux in this.listaDeLlamadas)
            {
                if (aux is Local)
                    costoLocal += ((Local)aux).CostoLlamada;
                if (aux is Provincial)
                    costoProv += ((Provincial)aux).CostoLlamada;
            }
            costoTot = costoLocal + costoProv;

            switch(tipo)
            {
                case Llamada.TipoLlamada.Local:
                    retorno = costoLocal;
                    break;
                case Llamada.TipoLlamada.Provincial:
                    retorno = costoProv;
                    break;
                case Llamada.TipoLlamada.Todas:
                    retorno = costoTot;
                    break;
            }
            
            return retorno;
        }


        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Empresa " + this.razonSocial);
            sb.AppendLine("Gcia total: "+this.GananciasPorTotal);
            sb.AppendLine("Gcia local: "+this.GananciasPorLocal);
            sb.AppendLine("Gcia provincial: "+this.GananciasPorProvincial);

            foreach(Llamada aux in listaDeLlamadas)
            {
                sb.AppendLine(aux.Mostrar());
            }

            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

    }
}

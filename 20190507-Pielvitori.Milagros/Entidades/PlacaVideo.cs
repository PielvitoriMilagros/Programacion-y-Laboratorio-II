using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class PlacaVideo:Periferico
    {
        private int ramMB;
/// <summary>
/// Constructor
/// </summary>
/// <param name="marca">marca a asignar</param>
/// <param name="modelo">modelo a asignar</param>
/// <param name="ramMB">memoria a asignar</param>
        public PlacaVideo(string marca,string modelo,int ramMB):base(marca,modelo,EConector.PCIExpress)
        {
            this.ramMB = ramMB;
        }
/// <summary>
/// Mostrar los datos de la Placa de Video
/// </summary>
/// <returns>Información de la placa de video</returns>
        public override string ExponerDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("PLACA DE VIDEO " + (string)this);
            sb.AppendLine("Memoria " + this.ramMB + "MB");

            return sb.ToString();
        }
    }
}

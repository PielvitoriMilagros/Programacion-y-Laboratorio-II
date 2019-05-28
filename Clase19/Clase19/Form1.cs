using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Clase19
{
    public partial class Form1 : Form
    {
        public List<Persona> listaPersonas;
        Form2 formPersona = new Form2();

        XmlTextWriter writer;
        XmlSerializer ser;
//        XmlTextReader reader;

        FileStream fileStream;
        BinaryFormatter serBinario;


        public Form1()
        {
            InitializeComponent();
            listaPersonas = new List<Persona>();

            /*  Esta es la forma de leer un archivo xml.
             *  Lo comento para leer un binario
                        reader = new XmlTextReader(@"D:\VisualStudio\Mili\Clase19.xml");
                        ser = new XmlSerializer(typeof(List<Persona>));
                        this.listaPersonas = (List<Persona>)ser.Deserialize(reader);
                        reader.Close();
            */
            if (System.IO.File.Exists(@"D:\VisualStudio\Mili\Clase19Bin"))
            {
                fileStream = new FileStream(@"D:\VisualStudio\Mili\Clase19Bin", FileMode.Open);
                serBinario = new BinaryFormatter();
                this.listaPersonas = (List<Persona>)serBinario.Deserialize(fileStream);
                fileStream.Close();
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (formPersona.ShowDialog() == DialogResult.OK)
            {
                this.listaPersonas.Add(formPersona.persona);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.lsvPersona.Clear();
            foreach (Persona p1 in listaPersonas)
            {
                this.lsvPersona.Items.Add(p1.ToString());
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            writer = new XmlTextWriter(@"D:\VisualStudio\Mili\Clase19.xml", Encoding.UTF8);
            ser = new XmlSerializer(typeof(List<Persona>));
            ser.Serialize(writer, this.listaPersonas);
            writer.Close();

            fileStream = new FileStream(@"D:\VisualStudio\Mili\Clase19Bin", FileMode.Create);
            serBinario = new BinaryFormatter();
            serBinario.Serialize(fileStream, this.listaPersonas);
            fileStream.Close();

            MessageBox.Show("Registros guardados con éxito");

        }
    }
}

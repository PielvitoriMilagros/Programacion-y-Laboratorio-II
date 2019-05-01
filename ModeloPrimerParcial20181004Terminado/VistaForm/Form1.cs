using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Windows.Forms;

namespace VistaForm
{
    public partial class Form1 : Form
    {
        private DirectorTecnico dt;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            int edad;
            int dni;
            int anios;
            if (!(int.TryParse(this.nudEdad.Text, out edad)))
                edad = 0;
            if (!(int.TryParse(this.nudDNI.Text, out dni)))
                dni = 0;
            if (!(int.TryParse(this.nudExperiencia.Text, out anios)))
                anios = 0;

            this.dt= new DirectorTecnico(this.txtNombre.Text, this.txtApellido.Text, edad, dni, anios);

            MessageBox.Show("Se ha creado el DT!");

        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string mensaje;
            if (this.dt == null)
                MessageBox.Show("Aún no se ha creado el DT del formulario");
            else
            {
                if (this.dt.ValidarAptitud())
                    mensaje = "El DT es apto";
                else
                    mensaje = "El DT no es apto";

                MessageBox.Show(mensaje);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio61
{
    public partial class Form1 : Form
    {
        PersonaDAO DAO = new PersonaDAO();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (this.txtNombre.Text != "" && this.txtApellido.Text != "")
            {
                if (DAO.Guardar(new Persona(this.txtNombre.Text, this.txtApellido.Text)))
                {
                    MessageBox.Show("Se agregó la persona");
                }
            }
            else
            {
                MessageBox.Show("No se pudo agregar");
            }
        }

        private void btnLKeer_Click(object sender, EventArgs e)
        {
            this.listBox1.Items.Clear();
            foreach(Persona auxPersona in DAO.Leer())
            {
                this.listBox1.Items.Add(auxPersona.ToString());
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase19
{
    public partial class Form2 : Form
    {
        public Persona persona;

        public Form2()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int auxDni = 0;
            int auxTarj = 0;

            int.TryParse(this.txtDni.Text, out auxDni);
            int.TryParse(this.txtTarjeta.Text, out auxTarj);


            persona = new Persona(this.txtName.Text, this.txtApellido.Text, auxDni, auxTarj);
            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

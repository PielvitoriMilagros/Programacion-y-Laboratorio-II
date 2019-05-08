using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace GUI
{
    public partial class FrmPC : Form
    {
        Maquina m = new Maquina("LAB01PC03");
        public FrmPC()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int memoria;
            if (!(int.TryParse(this.nUDMemoria.Text, out memoria)))
                memoria = 0;
            PlacaVideo p = new PlacaVideo(this.txtMarca.Text, this.txtModelo.Text, memoria);
            MessageBox.Show(m + p);

        }

        private void btnSacar_Click(object sender, EventArgs e)
        {
            int memoria;
            if (!(int.TryParse(this.nUDMemoria.Text, out memoria)))
                memoria = 0;
            PlacaVideo p = new PlacaVideo(this.txtMarca.Text, this.txtModelo.Text, memoria);

            MessageBox.Show(m - p);
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            this.rtxtSystemInfo.Text = m.SystemInfo;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

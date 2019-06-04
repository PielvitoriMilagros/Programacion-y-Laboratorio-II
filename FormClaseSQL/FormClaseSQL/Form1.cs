using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace FormClaseSQL
{
    public partial class Form1 : Form
    {
        public List<Provincia> provincias;

        public Form1()
        {
            InitializeComponent();
            this.provincias = new List<Provincia>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection cn = new SqlConnection(Properties.Settings.Default.CadenaSQL);

            SqlCommand cm = new SqlCommand("SELECT id, nombre FROM Provincias", cn);
            // Si uso el constructor de arriba vacío, se carga así
            //            cm.Connection = cn;
            //            cm.CommandText = "SELECT id, nombre FROM Provincias";

            cn.Open();
            SqlDataReader dr = cm.ExecuteReader();

            while (dr.Read())
            {
                this.provincias.Add(new Provincia((int)((decimal)dr["id"]),
                                 dr["nombre"].ToString()));
            }

            cn.Close();

            this.cmbProvincia.DataSource = provincias;

            //            MessageBox.Show(Properties.Settings.Default.CadenaSQL);
        }
    }
}

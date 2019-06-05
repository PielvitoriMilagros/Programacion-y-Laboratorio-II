using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio61
{
    public class PersonaDAO
    {
        public List<Persona> personas;

        SqlConnection conec;
        SqlCommand comando;


        public PersonaDAO()
        {
            conec = new SqlConnection(Properties.Settings.Default.cadenaSQL);
            comando = new SqlCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conec;
        }

        public bool Guardar(Persona persona)
        {
            bool retorno = false;
            try
            {
                this.conec.Open();
                string consulta = $"INSERT INTO Persona (nombre, apellido) values ('{persona.Nombre}','{persona.Apellido}')";
                comando.CommandText = consulta;
                if (comando.ExecuteNonQuery() > 0)
                    retorno = true;
            }
            catch (SqlException ex)
            {
                var exception = ex.Message;

                // Hacer algo
            }
            finally
            {
                if(conec.State == System.Data.ConnectionState.Open)
                {
                    conec.Close();
                }
            }

            return retorno;
        }

        public List<Persona> Leer()
        {
            try
            {
                this.conec.Open();
                this.personas = new List<Persona>();
                string consulta = "SELECT nombre,apellido FROM Persona";
                comando.CommandText = consulta;
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    this.personas.Add(new Persona(dr["nombre"].ToString(), dr["apellido"].ToString()));
                }
            }
            catch (Exception)
            {

                //throw;
            }
            finally
            {
                if (conec.State == System.Data.ConnectionState.Open)
                {
                    conec.Close();
                }
            }
            return this.personas;
        }

        public bool LeerPorID(int id)
        {
            string consulta = $"SELECT * FROM Persona WHERE id={id}";
            comando.CommandText = consulta;
            bool retorno = false;
            this.personas = new List<Persona>();
            try
            {
                this.conec.Open();
                SqlDataReader dr = comando.ExecuteReader();
                while (dr.Read())
                {
                    this.personas.Add(new Persona(dr["nombre"].ToString(), dr["apellido"].ToString()));
                    retorno = true;
                }

            }
            catch (Exception)
            {

            //    throw;
            }
            finally
            {
                if (conec.State == System.Data.ConnectionState.Open)
                {
                    conec.Close();
                }
            }

            return retorno;
        }




    }
}

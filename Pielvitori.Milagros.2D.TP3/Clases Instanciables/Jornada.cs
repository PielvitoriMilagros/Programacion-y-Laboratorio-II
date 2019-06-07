using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Instanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private Universidad.EClases clase;
        private Profesor instructor;

        #region Propiedades
        public List<Alumno> Alumnos

        {
            get { return alumnos; }
            set { alumnos= value; }
        }

        public Universidad.EClases Clase
        {
            get { return clase; }
            set { clase = value; }
        }

        public Profesor Instructor
        {
            get { return instructor; }
            set { instructor = value; }
        }

        #endregion
        public bool Guardar(Jornada jornada)
        { }


        #region Constructores
        private Jornada()
        {
            this.alumnos = new List<Alumno>();
        }

        public Jornada(Universidad.EClases clase, Profesor instructor):this()
        {
            this.clase = clase;
            this.instructor = instructor;
        }

        #endregion

        public string Leer()
        { }


        #region Operadores
        public static bool operator ==(Jornada j, Alumno a)
        {
            foreach(Alumno auxAlumno in j.alumnos)
            {
                if (auxAlumno == a)
                    return true;
            }
            return false;
        }


        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }


        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j != a)
                j.alumnos.Add(a);
            return j;
        }

#endregion

        public override string ToString()
        {
            return base.ToString();
        }


    }
}

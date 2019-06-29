using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Abstractas;
using Clases_Instanciables;

namespace TestUnitarios
{
    [TestClass]
    public class TestExcepciones
    {
        [TestMethod]
        public void AlumnoRepetidoException()
        {
            try
            {
                Universidad univ = new Universidad();
                Alumno a1 = new Alumno(1, "Juan", "Perez", "45698", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
                univ += a1;
                univ += a1;

            }
            catch (Exception e)
            {

                Assert.IsInstanceOfType(e, typeof(AlumnoRepetidoException));
            }
        }


        [TestMethod]
        public void DniInvalidoException()
        {
            try
            {
                Alumno a1 = new Alumno(1, "Juan", "Perez", "aaa", Persona.ENacionalidad.Argentino, Universidad.EClases.Programacion);

            }
            catch (Exception e)
            {
                Assert.IsInstanceOfType(e, typeof(DniInvalidoException));
            }
        
        }
    }
}

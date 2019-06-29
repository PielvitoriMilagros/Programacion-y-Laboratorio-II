using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Abstractas;
using Clases_Instanciables;
using System.IO;
using System.Xml;
using System.Xml.Serialization;


namespace UnitTestProject1
{
    [TestClass]
    public class TestExcepciones
    {
        [TestMethod]
        public void ExcepcionAlumnoRepetido()
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
    }
}

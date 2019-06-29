using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Abstractas;
using Clases_Instanciables;

namespace TestUnitarios
{
    [TestClass]
    public class TestValoresNulos
    {
        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void ValidaAlumnoNulo()
        {
            Universidad univ = new Universidad();
            Alumno a1 = null;
            univ += a1;
        }
    }
}

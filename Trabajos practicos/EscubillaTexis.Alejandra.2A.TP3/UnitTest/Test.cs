using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClasesInstanciables;
using Excepciones;
using EntidadesAbstractas;

namespace UnitTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        [ExpectedException(typeof(AlumnoRepetidoException))]
        public void TestAlumnoRepetidoException()
        {
            Alumno alumnoTest = new Alumno(1, "NombreTest", "ApellidoTest", "42123456",
                Persona.ENacionalidad.Argentino, Universidad.EClases.Legislacion);
            
            Universidad universidadTest = new Universidad();
            universidadTest += alumnoTest;
            universidadTest += alumnoTest;
            Assert.Fail();
        }
        
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void TestDniInvalidoException()
        {
            Alumno alumnoTest = new Alumno(2, "NombreTest", "ApellidoTest", "DNITest",
                Persona.ENacionalidad.Extranjero, Universidad.EClases.Programacion);
            Assert.Fail();
        }

        [TestMethod]
        [ExpectedException(typeof(NacionalidadInvalidaException))]
        public void TestNacionalidadInvalidaException()
        {
            Alumno alumnoTest = new Alumno(3, "NombreTest", "ApellidoTest", "90000000",
                Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
            Assert.Fail();
        }

        [TestMethod]
        public void TestDniInt()
        {
            Profesor profesorTest = new Profesor(4, "NombreTest", "ApellidoTest", "42123456", Persona.ENacionalidad.Argentino);
            Assert.IsInstanceOfType(profesorTest.DNI, typeof(int));
        }

        [TestMethod]
        public void TestInstructoresNull()
        {
            Universidad universidadTest = new Universidad();
            Profesor profesorTest = new Profesor(5, "NombreTest", "ApellidoTest", "42123456", Persona.ENacionalidad.Argentino);

            Assert.IsNotNull(universidadTest.Instructores);
        }
    }
}

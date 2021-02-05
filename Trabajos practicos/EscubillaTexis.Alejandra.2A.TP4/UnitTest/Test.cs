using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;

namespace UnitTest
{
    [TestClass]
    public class Test
    {
        [TestMethod]
        [ExpectedException(typeof(ProductoRepetidoException))]
        public void TestProductoRepetidoException()
        {
            Artistica artisticaTest = new Artistica();
            Bastidor bastidorTest = new Bastidor(1, "BastidorTest", "MarcaTest", 2, 1500, ETamaño.Mediano);

            artisticaTest += bastidorTest;
            artisticaTest += bastidorTest;
            Assert.Fail();
        }

        [TestMethod]
        public void TestPrecioFloat()
        {
            Pincel pincelTest = new Pincel(1, "PincelTest", "MarcaTest", 2, (float)20.5, ETipoPincel.Redondo);
            Assert.IsInstanceOfType(pincelTest.Precio, typeof(float));
        }
    }
}

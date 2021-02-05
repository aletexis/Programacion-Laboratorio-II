using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
using Excepciones;
using Archivos;

namespace UnitTest
{
    [TestClass]
    public class Test
    {
        /// <summary>
        /// Método de testeo que espera una excepción al ingresar un producto que ya existe.
        /// </summary>
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

        /// <summary>
        /// Método de testeo que espera una excepción al abrir un archivo que no existe.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ArchivosException))]
        public void TestArchivos()
        {
            Texto archivoTest = new Texto();
            string path = AppDomain.CurrentDomain.BaseDirectory + "abc.txt";
            archivoTest.Leer(path, out string datosLeidos);
        }

        /// <summary>
        /// Método de testeo que serializa la artística.
        /// </summary>
        [TestMethod]
        public void TestSerializarXml()
        {
            Artistica artistica = new Artistica();

            Assert.IsTrue(Artistica.Guardar("Artistica.xml", artistica));
        }

        /// <summary>
        /// Método de testeo que verifica que un atributo del producto pincel sea de tipo float.
        /// </summary>
        [TestMethod]
        public void TestPrecioFloat()
        {
            Pincel pincelTest = new Pincel(1, "PincelTest", "MarcaTest", 2, (float)20.5, ETipoPincel.Redondo);
            Assert.IsInstanceOfType(pincelTest.Precio, typeof(float));
        }
    }
}

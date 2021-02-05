using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ProductoRepetidoException : Exception
    {
        /// <summary>
        /// Constructor de la excepcion de producto repetido.
        /// </summary>
        public ProductoRepetidoException()
            : base("\nProducto repetido.")
        {
        }
    }
}

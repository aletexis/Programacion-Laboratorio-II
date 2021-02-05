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
        /// Constructor por defecto.
        /// </summary>
        public ProductoRepetidoException()
            : base("El producto ya esta en el deposito de la Artistica.")
        {
        }
        /// <summary>
        /// Constructor parametrizado que inicializa un atributo.
        /// <param name="mensaje">El mensaje a mostrar</param>
        /// </summary>
        public ProductoRepetidoException(string mensaje)
            : base(mensaje)
        {
        }

        /// <summary>
        /// Constructor parametrizado que inicializa un atributo.
        /// <param name="innerException"></param>
        /// </summary>
        public ProductoRepetidoException(Exception innerException)
            : base("El producto ya esta en el deposito de la Artistica.", innerException)
        {
        }
    }
}

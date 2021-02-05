using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class NacionalidadInvalidaException : Exception
    {
        /// <summary>
        /// Excepcion de nacionalidad invalida.
        /// </summary>
        public NacionalidadInvalidaException()
            : this("La nacionalidad no se condice con el numero de DNI.")
        {
        }

        /// <summary>
        /// Excepcion de nacionalidad invalida con mensaje especificado.
        /// </summary>
        /// <param name="message">El mensaje a mostrar.</param>
        public NacionalidadInvalidaException(string message)
            : base(message)
        {
        }
    }
}

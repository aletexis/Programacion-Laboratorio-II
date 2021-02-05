using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DniInvalidoException : Exception
    {
        /// <summary>
        /// Excepcion de DNI invalida.
        /// </summary>
        public DniInvalidoException()
            : this("DNI invalido.")
        {
        }

        /// <summary>
        /// Excepcion de DNI invalida,
        /// </summary>
        /// <param name="e"></param>
        public DniInvalidoException(Exception e)
            : this(e.Message)
        {
        }

        /// <summary>
        /// Excepcion de DNI invalida con mensaje especificado.
        /// </summary>
        /// <param name="message">El mensaje a mostrar.</param>
        public DniInvalidoException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Excepcion de DNI invalida con mensaje especificado.
        /// </summary>
        /// <param name="message">El mensaje a mostrar.</param>
        /// <param name="e"></param>
        public DniInvalidoException(string message, Exception e)
            : base(message, e)
        {
        }
    }
}

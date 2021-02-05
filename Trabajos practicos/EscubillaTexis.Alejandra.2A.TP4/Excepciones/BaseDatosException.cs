using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class BaseDatosException : Exception
    {
        /// <summary>
        /// Constructor de la excepcion de base de datos.
        /// </summary>
        public BaseDatosException(Exception innerException)
            : base(innerException.Message)
        {
        }
    }
}

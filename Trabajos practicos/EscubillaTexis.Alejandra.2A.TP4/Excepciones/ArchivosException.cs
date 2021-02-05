using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class ArchivosException : Exception
    {
        /// <summary>
        /// Constructor de la excepcion de archivos.
        /// </summary>
        /// <param name="innerException"></param>
        public ArchivosException(Exception innerException)
            : base(innerException.Message)
        {
        }
    }
}

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
        /// Constructor por defecto.
        /// </summary>
        public ArchivosException()
            : base("Archivo inexistente.")
        {
        }

        /// <summary>
        /// Constructor parametrizado que inicializa un atributo.
        /// <param name="mensaje">El mensaje a mostrar</param>
        /// </summary>
        public ArchivosException(string mensaje)
            : base(mensaje)
        {
        }

        /// <summary>
        /// Constructor parametrizado que inicializa un atributo.
        /// <param name="innerException">Excepcion</param>
        /// </summary>
        public ArchivosException(Exception innerException)
            : base("Archivo Inexistente", innerException)
        {
        }
    }
}

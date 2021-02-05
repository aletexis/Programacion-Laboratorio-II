using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Archivos
{
    public interface IArchivo<T>
    {
        /// <summary>
        /// Guarda datos en un archivo.
        /// </summary>
        /// <param name="archivo">La ruta del archivo.</param>
        /// <param name="datos">La entrada de datos.</param>
        /// <returns>Retorna True si la ruta es valida.</returns>
        bool Guardar(string archivo, T datos);

        /// <summary>
        /// Lee los datos de un archivo
        /// </summary>
        /// <param name="archivo">La ruta del archivo.</param>
        /// <param name="datos">La salida de datos.</param>
        /// <returns>Retorna True si la ruta es valida.</returns>
        bool Leer(string archivo, out T datos);
    }
}

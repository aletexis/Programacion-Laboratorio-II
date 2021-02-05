using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using Archivos;
using Excepciones;

namespace Archivos
{
    public class Texto : IArchivo<string>
    {
        /// <summary>
        /// Guarda los datos en un archivo de texto.
        /// </summary>
        /// <param name="archivo">La ruta del archivo.</param>
        /// <param name="datos">La entrada de datos.</param>
        /// <returns>Retorna True si la ruta es valida. Caso contrario, lanza una excepcion.</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool retorno = false;

            try
            {
                using (StreamWriter sw = new StreamWriter(archivo))
                {
                    sw.WriteLine(datos);
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo guardar el archivo de texto.");
                throw new ArchivosException(e);
            }

            return retorno;
        }

        /// <summary>
        /// Lee datos de un archivo de texto y los devuelve como string.
        /// </summary>
        /// <param name="archivo">La ruta del archivo.</param>
        /// <param name="datos">La salida de datos.</param>
        /// <returns>Retorna True si la ruta es valida. Caso contrario, lanza una excepcion.</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool retorno = false;

            try
            {
                using (StreamReader sr = new StreamReader(archivo))
                {
                    datos = sr.ReadToEnd();
                    retorno = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("No se pudo leer el archivo de texto.");
                throw new ArchivosException(e);
            }

            return retorno;
        }
    }
}

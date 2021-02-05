using Excepciones;
using System;
using System.IO;
using System.Text;

namespace Archivos
{
    public class Texto : IArchivos<string>
    {
        /// <summary>
        /// Guarda los datos en un archivo de texto.
        /// </summary>
        /// <param name="archivo">La ruta del archivo.</param>
        /// <param name="datos">La entrada de datos.</param>
        /// <returns>Retorna True si la ruta es valida. Caso contrario, lanza una excepcion.</returns>
        public bool Guardar(string archivo, string datos)
        {
            bool ret = false;
            try
            {
                using (StreamWriter sw = new StreamWriter(archivo, true, Encoding.UTF8))
                {
                    sw.WriteLine(datos);
                    ret = true;
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("El archivo no se pudo crear.");
            }
            return ret;
        }

        /// <summary>
        /// Lee datos de un archivo de texto y los devuelve como string.
        /// </summary>
        /// <param name="archivo">La ruta del archivo.</param>
        /// <param name="datos">La salida de datos.</param>
        /// <returns>Retorna True si la ruta es valida. Caso contrario, lanza una excepcion.</returns>
        public bool Leer(string archivo, out string datos)
        {
            bool ret = false;
            try
            {
                using (StreamReader sr = new StreamReader(archivo, Encoding.UTF8))
                {
                    datos = sr.ReadToEnd();
                    ret = true;
                }
            }
            catch (Exception)
            {
                throw new ArchivosException("No se pudo abrir el archivo.");
            }
            return ret;
        }
    }
}


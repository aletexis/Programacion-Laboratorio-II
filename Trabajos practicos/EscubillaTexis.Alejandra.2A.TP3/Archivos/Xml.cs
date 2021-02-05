using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Xml<T> : IArchivo<T> where T : class
    {

        /// <summary>
        /// Guarda datos de tipo T en un archivo .xml.
        /// </summary>
        /// <param name="archivo">La ruta del archivo.</param>
        /// <param name="datos">El objeto a guardar.</param>
        /// <returns>Retorna True si la ruta es valida. Caso contrario, False y lanza una excepcion.</returns>
        public bool Guardar(string archivo, T datos)
        {
            bool retorno;
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(T));
                TextWriter tw = new StreamWriter(archivo);
                xmls.Serialize(tw, datos);
                retorno = true;
                tw.Close();
            }
            catch (Exception e)
            {
                retorno = false;
                Console.WriteLine("No se pudo guardar el archivo xml.");
                throw new ArchivosException(e);
            }
            return retorno;
        }

        /// <summary>
        /// Lee datos tipo T de un archivo .xml y los guarda en un objeto tipo T. 
        /// </summary>
        /// <param name="archivo">La ruta del archivo.</param>
        /// <param name="datos">La salida de datos.</param>
        /// <returns>Retorna True si la ruta es valida. Caso contrario, False y lanza una excepcion.</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool retorno;
            datos = default(T);
            try
            {
                XmlSerializer xmls = new XmlSerializer(typeof(T));
                StreamReader sr = new StreamReader(archivo);
                datos = (T)xmls.Deserialize(sr);
                retorno = true;
                sr.Close();
            }
            catch (Exception e)
            {
                retorno = false;
                Console.WriteLine("No se pudo leer el archivo xml.");
                throw new ArchivosException(e);
            }

            return retorno;
        }
    }
}

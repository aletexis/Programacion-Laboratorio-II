using Excepciones;
using System;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Archivos
{
    public class Xml<T> : IArchivos<T>
    {
        /// <summary>
        /// Guarda datos de tipo T en un archivo .xml.
        /// </summary>
        /// <param name="archivo">La ruta del archivo.</param>
        /// <param name="datos">El objeto a guardar.</param>
        /// <returns>Retorna True si la ruta es valida. Caso contrario, False y lanza una excepcion.</returns>
        public bool Guardar(string archivo, T datos)
        {
            bool ret = false;
            try
            {
                using (XmlTextWriter tw = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    ser.Serialize(tw, datos);
                    ret = true;
                }
            }

            catch (Exception)
            {
                throw new ArchivosException("Archivo no generado");
            }
            return ret;
        }

        /// <summary>
        /// Lee datos tipo T de un archivo .xml y los guarda en un objeto tipo T. 
        /// </summary>
        /// <param name="archivo">La ruta del archivo.</param>
        /// <param name="datos">La salida de datos.</param>
        /// <returns>Retorna True si la ruta es valida. Caso contrario, False y lanza una excepcion.</returns>
        public bool Leer(string archivo, out T datos)
        {
            bool ret = false;
            try
            {
                using (XmlTextReader tr = new XmlTextReader(archivo))
                {
                    XmlSerializer ser = new XmlSerializer(typeof(T));
                    datos = (T)ser.Deserialize(tr);
                    ret = true;
                }
            }
            catch (Exception)
            {
                throw new ArchivosException();
            }
            return ret;
        }
    }
}
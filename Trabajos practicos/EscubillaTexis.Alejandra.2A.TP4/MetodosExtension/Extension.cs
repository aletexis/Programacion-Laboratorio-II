using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace MetodosExtension
{
    
    public static class Extension
    {
        public static string MensajeErrorArchivo(this ArchivosException e)
        {
            return "No se pudo abrir el archivo.";
        }
    }
}

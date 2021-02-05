using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eventos.Entidades;

namespace Test.Extension
{
    using Entidades;

    public static class Extensora
    {

        #region Para clases propias

        public static string ObtenerInfoExtension(this Persona p)
        {
            return p.Nombre + " - " + p.Edad;
        }

        #endregion

        #region Para clases de terceros

        public static string ObtenerInfoExtension(this Empleado e)
        {
            return e.Nombre + " - " + e.Sueldo.ToString();
        }

        #endregion

        #region Para object

        public static bool EsNulo(this object o)
        {
            return o == null;
        }

        #endregion

        #region Para string

        public static int CantidadDePalabras(this string str)
        {
            return str.Split(new char[] { ' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
        }

        #endregion

        #region Para clases de terceros, con parámetros

        public static void EstablecerNombreExtensionParam(this EmpleadoMejorado e, string nombre)
        {
            e.Nombre = nombre;
        }

        #endregion

    }
}

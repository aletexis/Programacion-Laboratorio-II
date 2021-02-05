/*En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
opciones.
El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó
cualquier otro valor.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidacionRespuesta
    {
        public static bool ValidarS_N(char c)
        {
            bool validated = true;

            if (c != 'S' && c != 's' && c != 'N' && c != 'n')
            {
                validated = false;
            }

            return validated;
        }
    }
}

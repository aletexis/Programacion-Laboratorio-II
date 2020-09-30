using System;

namespace Ejercicio11
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool validated = true;

            if(valor < min || valor > max)
            {
                validated = false;
            }

            return validated;
        }
    }
}

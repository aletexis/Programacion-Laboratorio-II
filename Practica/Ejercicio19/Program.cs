/*Realizar una aplicación de consola. Agregar la clase Sumador.
 * 
 * SUMADOR
 * Campos:
 * private cantidadSumas : int
 * 
 * Metodos: 
 * public explicit operator int(Sumador s) : int
 * public operator |(Sumador s1, Sumador s2) : bool
 * public operator +(Sumador s1 ,Sumador s2) : long
 * public Suamdor()
 * public Sumador(int cantidadSumas)
 * public Sumar(long a, long b) : long
 * public Sumar(string a, string b) : string
 * 
 * 
 * a. Crear dos constructores:
            i. Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
            ii. Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
   
   b. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la
      siguiente lógica:
            i. En el caso de Sumar(long, long) sumará los valores numéricos
            ii. En el de Sumar(string, string) concatenará las cadenas de texto.

Antes de continuar, agregar un objeto del tipo Sumador en el Main y probar el código.

   c. Generar una conversión explícita que retorne cantidadSumas.

   d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long
      con dicho valor.

   e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual
      cantidadSumas.

Agregar un segundo objeto del tipo Sumador en el Main y probar el código.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            long num1long = 2;
            long num2long = 6;
            string num1str = "1";
            string num2str = "2";

            Sumador sumador = new Sumador(4);
            Sumador sumador2 = new Sumador();

            sumador.Sumar(num1long, num2long);
            sumador.Sumar(num1str, num2str);
            
            sumador2.Sumar(num1long, num2long);
            sumador2.Sumar(num1str, num2str);


        }
    }
}

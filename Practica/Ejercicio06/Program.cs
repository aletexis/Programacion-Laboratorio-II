/*Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 06";

            int firstYear;
            int lastYear;
            int year;
            int leapYear;

            Console.Write("Ingrese año de inicio: ");
            firstYear = int.Parse(Console.ReadLine());
            Console.Write("Ingrese año de fin: ");
            lastYear = int.Parse(Console.ReadLine());

            Console.WriteLine("{2}Los años bisiestos entre {0} y {1} son: ", firstYear, lastYear, Environment.NewLine);

            for (year = firstYear; year <= lastYear; year++)
            {
                if ((year % 4 == 0) && ((year % 100 != 0) || (year % 400 == 0)))
                {
                    leapYear = year;
                    Console.Write("{0} ", leapYear);
                    //si es multiplo de 4 y (no es multiplo de 100 o es multiplo de 400)
                }
            }

            Console.ReadKey(true);
        }

    }
}

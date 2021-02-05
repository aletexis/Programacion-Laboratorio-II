/*Realizar un programa que sume números enteros hasta que el usuario lo determine, por medio de
un mensaje "¿Continuar? (S/N)".
En el método estático ValidaS_N(char c) de la clase ValidarRespuesta, se validará el ingreso de
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
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio12";
            int number;
            int sum = 0;
            char answer;
            char cont = 's';

            do
            {
                Console.Write("\nIngrese un numero: ");
                number = int.Parse(Console.ReadLine());
                sum += number;

                Console.Write("\n¿Continuar? (S/N): ");
                answer = char.Parse(Console.ReadLine());

                while (ValidacionRespuesta.ValidarS_N(answer) == false)
                {
                    Console.Write("\n\t(!) Error. Respuesta invalida.\n\n¿Continuar? (S/N): ");
                    answer = char.Parse(Console.ReadLine());
                }

                cont = answer;

            } while (cont == 's' || cont == 'S');

            Console.WriteLine("\nLa suma de los numeros ingresados es: {0}", sum);
            Console.ReadKey(true);
        }
    }
}

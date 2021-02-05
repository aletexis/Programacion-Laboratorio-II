/*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas y selectivas.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";

            int numero;
            int divisor;
            int perfecto;
            int contador = 0;
            int acumulador = 0;

            Console.WriteLine("Numeros perfectos: ");

            for (numero = 0; numero < 10000; numero++)//recorro los numeros
            {
                acumulador = 0; //reinicio el acumulador para el proximo numero

                for (divisor = 1; divisor < numero; divisor++)//recorro los divisores
                {

                    if (numero % divisor == 0)//si el resto da 0
                    {
                        acumulador = acumulador + divisor; //acumulo los divisores del numero
                    }
                    else
                    {
                        acumulador = acumulador + 0; // le sumo 0 para que cubra todos los divisores y no se quede con el primer y falso numero perfecto que encuentre (Ej: el 24 es un falso numero perfecto)

                        if (acumulador == numero && divisor == acumulador - 1)//establezco el numero perfecto cuando ya recorri todos los divisores y el acumulador es igual al numero
                        {
                            perfecto = numero;
                            Console.Write(" {0}  ", perfecto);

                            while (contador < 5)//para que solo muestre los primeros 4
                            {
                                contador++;
                            }
                        }
                    }
                }
            }

            Console.ReadLine();
        }
    }
}

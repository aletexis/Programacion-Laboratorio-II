/*Un número perfecto es un entero positivo, que es igual a la suma de todos los enteros positivos
(excluido el mismo) que son divisores del número.
El primer número perfecto es 6, ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6.
Escribir una aplicación que encuentre los 4 primeros números perfectos.
Nota: Utilizar estructuras repetitivas y selectivas.*/


using System;

namespace Ejercicio04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio 04";

            int number;
            int divisor;
            int perfect;
            int counter = 0;
            int accumulator = 0;

            Console.WriteLine("Numeros perfectos: ");

            for (number = 0; number < 10000; number++)//recorro los numeros
            {
                accumulator = 0; //reinicio el acumulador para el proximo numero

                for(divisor = 1; divisor < number; divisor++)//recorro los divisores
                {

                    if (number % divisor == 0)//si el resto da 0
                    {
                        accumulator = accumulator + divisor; //acumulo los divisores del numero
                    }
                    else
                    {
                        accumulator = accumulator + 0; // le sumo 0 para que cubra todos los divisores y no se quede con el primer y falso numero perfecto que encuentre (Ej: el 24 es un falso numero perfecto)

                        if (accumulator == number && divisor == accumulator - 1)//establezco el numero perfecto cuando ya recorri todos los divisores y el acumulador es igual al numero
                        {
                            perfect = number;
                            Console.Write(" {0}  ", perfect);

                            while (counter < 5)//para que solo muestre los primeros 4
                            {
                                counter++;
                            }
                        }
                    }
                }
            }

            Console.ReadLine();         
        }
    }
}

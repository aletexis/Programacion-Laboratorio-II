/*. Mostrar por pantalla todos los números primos que haya hasta el número que ingrese el usuario
por consola.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/

using System;

namespace Ejercicio03
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio 03";
            int enteredNumber;
            int primo;
            int number;
            int divisor;
            int accumulator = 0;

            Console.Write("Ingrese un numero: ");
            enteredNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("{1}Los numeros primos hasta {0} son: ", enteredNumber, Environment.NewLine);
            for (number = 1; number <= enteredNumber; number++)
            {
                accumulator = 0;
                for (divisor=1; divisor<= number; divisor++)
                {
                    if (number % divisor == 0)
                    {
                        accumulator = accumulator + divisor;
                    }
                    else
                    {
                        accumulator = accumulator + 0;
                    }
                }
                if (accumulator == number + 1)
                {
                    primo = number;
                    Console.Write(" {0} ",primo);
                }

            }
        }
    }
}

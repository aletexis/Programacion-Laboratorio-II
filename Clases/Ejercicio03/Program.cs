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
            int numeroIngresado;
            int primo;
            int numero;
            int divisor;
            int acumulador = 0;

            Console.Write("Ingrese un numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());

            Console.WriteLine("{1}Los numeros primos hasta {0} son: ", numeroIngresado, Environment.NewLine);
            for (numero=1; numero<=numeroIngresado; numero++)
            {
                acumulador = 0;
                for (divisor=1; divisor<=numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        acumulador = acumulador + divisor;
                    }
                    else
                    {
                        acumulador = acumulador + 0;
                    }
                }
                if (acumulador == numero + 1)
                {
                    primo = numero;
                    Console.Write(" {0} ",primo);
                }

            }
        }
    }
}

/* Consigna: Ingresar 5 números por consola, guardándolos en una variable escalar.
 * Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.*/

using System;

namespace Ejercicio01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio01";
            int number;
            int max = 0;
            int min = 999999999;
            int sum = 0;
            float average;


            for (int i=0; i<5; i++)
            {
                Console.Write("Ingrese un numero: ");
                number = int.Parse(Console.ReadLine());
                sum += number;

                if(number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }
                
            }
            average = (sum / 5);

            Console.WriteLine("El valor maximo es {0}, el valor minimo es {1} y el promedio es {2}", max, min, average);


            Console.ReadKey(true);
        }
    }
}

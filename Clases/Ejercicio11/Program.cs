/*Realizar una clase llamada Validacion que posea un método estático llamado Validar, que posea la
siguiente firma: bool Validar(int valor, int min, int max):
a. valor: dato a validar
b. min y max: rango en el cual deberá estar la variable valor.
Pedir al usuario que ingrese 10 números enteros. Validar con el método desarrollado
anteriormente que esten dentro del rango -100 y 100.
Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
Nota: Utilizar variables escalares, NO utilizar vectores.*/

using System;

namespace Ejercicio11
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio11";
            int number;
            int min = 0;
            int max = 0;
            int sum = 0;
            float average;

            for(int i=0; i<10; i++)
            {
                Console.Write("\nIngrese el numero entero Nº{0}: ", i+1);
                number = int.Parse(Console.ReadLine());


                while (Validacion.Validar(number, -100, 100) == false)
                {
                    Console.Write("\n\t(!) Error, numero fuera de rango.\n\tIngrese el numero entero Nº{0}: ", i+1);
                    number = int.Parse(Console.ReadLine());
                }

               sum += number;
            
                if (number > max)
                {
                    max = number;
                }
                if (number < min)
                {
                    min = number;
                }     
            }

            average = (sum / 10);

            Console.WriteLine("\nValor minimo: {0}\nValor maximo: {1} \nPromedio: {2: 0.00}\n", min, max, average);
        }
    }
}

/*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar que el número sea
mayor que cero, caso contrario, mostrar el mensaje: "ERROR. ¡Reingresar número!".
Nota: Utilizar el metodo ‘Pow’ de la clase Math para realizar la operación.*/

using System;

namespace Ejercicio02
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio02";
            int number;

            Console.Write("Ingrese un numero: ");
            number = int.Parse(Console.ReadLine());

            while(number <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                Console.Write("Ingrese un numero: ");
                number = int.Parse(Console.ReadLine());
            }

            double cuadrado = Math.Pow(number, 2);
            double cubo = Math.Pow(number, 3);

            Console.WriteLine("{1} al cuadrado es: {2}{0}{1} al cubo es: {3}", Environment.NewLine, number, cuadrado, cubo);
        }
    }
}

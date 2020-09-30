/*Partiendo de la base del ejercicio anterior, se pide realizar un programa que imprima por pantalla
una pirámide como la siguiente:
      *
     ***
    *****
   *******
  *********
Nota: Utilizar estructuras repetitivas y selectivas.*/

using System;

namespace Ejercicio10
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio10";

            Console.Write("Ingrese el alto de la piramide: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++) 
            {
                for (int space = 0; space < (height - i); space++)
                {
                    Console.Write(" ");
                }

                for (int asterisk = 0; asterisk < (i * 2) - 1; asterisk++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /* Si el usuario ingresa height 5
             * i vale 1
             * la variable space va desde 0 hasta 4 (5-1). Muestra 4 espacios dejando espacio para 1 asterisco.
             * la variable asterik va desde 0 hasta 1 ((1*2)-1). Muestra 1 asterisco
             * se hace un Console.WriteLine para que pase al siguiente escalon
             * i vale 2
             * la variable space va desde 0 hasta 3 (5-2). Muestra 3 espacios dejando espacio para 3 asteriscos.
             * la variable asterik va desde 0 hasta 3 ((2*2)-1). Muestra 3 asteriscos.
             * se hace un Console.WriteLine para que pase al siguiente escalon            
            */
        }
    }
}

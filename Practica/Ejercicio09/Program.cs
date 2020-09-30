/*Escribir un programa que imprima por pantalla una pirámide como
la siguiente:
*
***  --> 3
***** --> 5
******* --> 7
********* --> 9
El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo. Para el
ejemplo anterior la altura ingresada fue de 5.
Nota: Utilizar estructuras repetitivas y selectivas.*/

using System;

namespace Ejercicio09
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio09";

            Console.Write("Ingrese la altura de la piramide: ");
            int height = int.Parse(Console.ReadLine());


            for(int i = 1; i <= height; i++) 
            {
                for (int asterisk = 0; asterisk < (i * 2) - 1; asterisk++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            /* Si el usuario ingresa height 5
             * i vale 1
             * la variable asterik va desde 0 hasta 1 ((1*2)-1). Muestra 1 asterisco
             * se hace un Console.WriteLine para que pase al siguiente escalon
             * i vale 2
             * la variable asterik va desde 0 hasta 3 ((2*2)-1). Muestra 3 asteriscos.
             * se hace un Console.WriteLine para que pase al siguiente escalon            
            */


            //Otra forma de hacerlo///////////////////////////////////////////////////

            /*string length = "";

            for (int i=0; i<height * 2; i++)
            {
                length += "*";

                if (i % 2 == 0)
                {
                    Console.WriteLine(length);

                }
            }*/

            /* Si height es 5 i llega hasta 9
             * cargo un asterisco. Acumulador: *
             * 0 dividido 2 no da resto cero. No entra al if. Itero
             * cargo un asterisco. Acumulador: **
             * 1 divido 2 no da resto cero. No entra al if. Itero
             * cargo un asterisco. Acumulador: ***
             * 2 dividido 2 da resto cero. Muestro ***            
            */
        }
    }
}

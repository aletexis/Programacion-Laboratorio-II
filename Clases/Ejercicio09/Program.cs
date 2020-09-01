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

            /*for(int i=0; i<=height; i++)
            {
                Console.Write("{0}", Environment.NewLine);

                for (int j=height; j>i; j--)
                {
                    Console.Write("*");
                }

            }*/

            for (int i=0; i<=height; i++)//termina valiendo 5
            {
                Console.Write("{0}", Environment.NewLine);
               
                for (int j=0; j<i; j++)//termina valiendo 4
                {
                    Console.Write("*");

                }
            }


        }
    }
}

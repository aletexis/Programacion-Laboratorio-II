/*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
usuario ingrese por consola.
Nota: Utilizar estructuras repetitivas y selectivas.*/

using System;

namespace Ejercicio05
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05"; 

            int numeroIngresado;
            int numero;
            int centro;
            int acumuladorGrupo1 = 0;
            int acumuladorGrupo2 = 0;

            Console.WriteLine("Ingrese un numero: ");
            numeroIngresado = int.Parse(Console.ReadLine());


            Console.WriteLine("Centros numericos: ");

            for (numero=1; numero<numeroIngresado; numero++)//recorro los numeros
            {
                acumuladorGrupo1 = 0;



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
}

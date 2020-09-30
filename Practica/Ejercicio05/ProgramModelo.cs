using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Ejercicio_5
    {
       

        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 05";


            Int32 contador = 1;
            Int32 numero;
            Int32 i, j;
            Int32 sumaAntes;
            Int32 sumaDespues;

            Console.Write("Ingrese un numero: ");
            numero = int.Parse(Console.ReadLine());

            while (contador < numero) //Mientras el contador sea menor al numero ingresado por usuario.
            {
                contador++; // Paso a dos porque antes del 1 esta el 0.
                sumaAntes = 0;
                sumaDespues = 0;

                for (i = 1; i < contador; i++)
                {
                    //Voy sumando los numeros anteriores al del centro, desde el 1 hacia delante
                    //Como contador vale 2 en la primer iteracion, solamente sumo el 1.
                    //SumaAntes valdra 1
                    sumaAntes += i;
                }
               
                // Ahora hacia delante del centro, como contador en la primera iteracion es 2, J valdra 3 y tiene que iterar hasta que sea <= sumaAntes
                // Como en esta ocasion, sumaAntes = 1, no entra al for.
                // Pero cuando el centro (contador) pase a ser 6 (CENTRO NUMERICO). J=7 y SumaAntes = 15, ahi si entra.
                for (j = contador + 1; j <= sumaAntes; j++)
                {
                    // Hagamos que contador = 6
                    //Como SumaDespues = 0 y SumaAntes = 15 NO ENTRA. a este IF
                    if ((sumaDespues == sumaAntes) || (sumaDespues > sumaAntes))
                    {
                       
                        break;
                    }
                       
                    sumaDespues += j;
                    //Aca SumaDespues = 7 e itera una vez mas y sera 7 + 8 = 15 y entrara al IF de arriba.
                }

                // Se hara el BREAK y se confirma este IF y se vuelve a repetir el while ahora contador pasando a ser 7
                if (sumaAntes == sumaDespues)
                    Console.WriteLine("Es centro numerico: {0}", contador);
            }

            Console.ReadLine();
        }
    }
}

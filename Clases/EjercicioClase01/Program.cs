using System;

namespace EjercicioClase01
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "EjercicioClase01";

            Sello.mensaje = "asdasdas"; //asigno un mensaje

            Console.WriteLine(Sello.Imprimir()); //lo muestro

            Sello.Borrar(); //lo borro

            Console.WriteLine(Sello.Imprimir()); //no muestra nada porque lo borre

            Sello.mensaje = "hola mundo"; //asigno otro mensaje
            Sello.color = ConsoleColor.Blue; //le asigno un color

            Sello.ImprimirEnColor(); //lo imprimo en color

            Console.WriteLine(Sello.Imprimir()); //lo muestro con el color original
        }
    }
}

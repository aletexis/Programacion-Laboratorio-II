using System;

namespace EjercicioClase04
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Cosa a = new Cosa();
            Cosa b = new Cosa("hola");
            Cosa c = new Cosa(4, "chau");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("------------------------------");
            Console.WriteLine("Despues de los constructores  ");
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;

            a.Mostrar();
            Console.WriteLine("\n------------------------------");
            b.Mostrar();
            Console.WriteLine("\n------------------------------");
            c.Mostrar();

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n------------------------------");
            Console.WriteLine("Despues de establecer valores ");
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Gray;

            a.EstablecerValor(1);
            a.EstablecerValor("cosita");
            a.EstablecerValor(new DateTime(2020, 09, 02));
            a.Mostrar();
        }
    }
}

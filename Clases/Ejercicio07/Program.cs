/*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.*/

using System;

namespace Ejercicio07
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int day;
            int month;
            int year;
            int daysLived = 0;
            DateTime actualDate;
            DateTime date;

            /*
            Console.Write("Ingrese el dia de su nacimiento: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el mes de su nacimiento: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el año de su nacimiento: ");
            year = int.Parse(Console.ReadLine());
            */           


            //Console.Write("Ingrese la fecha de nacimiento: ");
            //date = DateTime.Parse(Console.ReadLine());

            //actualDate = DateTime.Now;
            Console.WriteLine("Hoy es: {0:dd-MM-yyyy}", DateTime.Now);

            //Console.WriteLine("Dias vividos: {0}", daysLived);

        }
    }
}

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
            Console.Title = "Ejercicio07";
            int day;
            int month;
            int year;
            int daysLived = 0;
            DateTime actualDate = DateTime.Now;
            DateTime birthDate;


            Console.Write("Ingrese el dia de su nacimiento: ");
            day = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el mes de su nacimiento: ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el año de su nacimiento: ");
            year = int.Parse(Console.ReadLine());
                       
            birthDate = new DateTime(year, month, day);

            TimeSpan difference = actualDate - birthDate;// TimeSpan represents the difference between two dates
            daysLived = (int)difference.TotalDays;

            
            Console.WriteLine("\nFecha nacimiento: {0}/{1}/{2}", day, month, year);
            Console.WriteLine("Fecha actual: " + DateTime.Now.ToString("dd/MM/yyyy")); //DateTime.Now.ToString Converts the value of the current DateTime object to its equivalent string representation.
            Console.WriteLine("{0:#,###} dias vividos", daysLived);

        }
    }
}

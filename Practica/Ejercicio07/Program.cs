/*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) y
calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema
con DateTime.Now).
Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 07";

            int day;
            int month;
            int year;
            int daysLived;
            DateTime birthday;
            DateTime actualDate = DateTime.Today;


            Console.Write("Ingrese dia de nacimiento: ");
            day = int.Parse(Console.ReadLine());
            while (day < 0 || day > 31)
            {
                Console.Write("Ingrese dia de nacimiento: ");
                day = int.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese mes de nacimiento: ");
            month = int.Parse(Console.ReadLine());
            while (month < 0 || month > 12)
            {
                Console.Write("Ingrese mes de nacimiento: ");
                month = int.Parse(Console.ReadLine());
            }

            Console.Write("Ingrese año de nacimiento: ");
            year = int.Parse(Console.ReadLine());
            while (year > DateTime.Now.Year)
            {
                Console.Write("Ingrese año de nacimiento: ");
                year = int.Parse(Console.ReadLine());
            }


            birthday = new DateTime(year, month, day);
            daysLived = actualDate.Subtract(birthday).Days;


            Console.Write("\nFecha nacimiento: " + day + "/" + month + "/" + year);
            Console.Write("\nFecha actual: " + DateTime.Now.ToString("dd/MM/yyyy"));
            Console.Write("\nDias vividos: {0:#,###}", daysLived);

            Console.ReadLine();
        }
    }
}

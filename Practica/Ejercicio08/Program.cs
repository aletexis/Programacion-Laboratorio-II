/*. Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
trabajadas en el mes de N empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
Nota: Utilizar estructuras repetitivas y selectivas.*/

using System;

namespace Ejercicio08
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio08";
            int hour;
            string name;
            int antiquity;
            int hoursWorked;
            float total;
            float discount;
            float net;
            float gross;
            char cont = 's';
            string dataAccumulator = "";

            do
            {
                Console.Write("{0}Ingrese el valor por hora: ", Environment.NewLine);
                hour = int.Parse(Console.ReadLine());
                Console.Write("{0}Ingrese el nombre: ", Environment.NewLine);
                name = Console.ReadLine();
                Console.Write("{0}Ingrese la amtiguedad: ", Environment.NewLine);
                antiquity = int.Parse(Console.ReadLine());
                Console.Write("{0}Ingrese las horas trabajadas: ", Environment.NewLine);
                hoursWorked = int.Parse(Console.ReadLine());
                

                Console.Write("{0}¿Desea seguir ingresando empleados? s/n: ", Environment.NewLine);
                cont = char.Parse(Console.ReadLine());

                Console.Write("{0}-----------------------------------------{0}", Environment.NewLine);


                total = hour * hoursWorked;
                gross = total + antiquity * 150;
                discount = (float)(gross * 0.13);
                net = gross - discount;


                dataAccumulator = dataAccumulator + (
                "\nNombre: " + name +
                "\nAntiguedad: " + antiquity +
                "\nValor hora: " + hour +
                "\nTotal a cobrar en bruto: " + gross +
                "\nTotal de descuentos: " + discount +
                "\nValor neto a cobrar: " + net + "\n\n");
                    
                hour = 0;
                name = "";
                antiquity = 0;
                hoursWorked = 0;
                total = 0;
                discount = 0;
                net = 0;
                gross = 0;

            } while (cont == 's');

            Console.WriteLine(dataAccumulator);
        }
    } 
}

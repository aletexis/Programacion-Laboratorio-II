/*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
string DecimalBinario(double). Convierte un número de entero a binario.
double BinarioDecimal(string). Convierte un número binario a entero.*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio13";
            string bin;
            double dec;
            string binResult;
            double decResult;

            
            Console.Write("\nIngrese un numero decimal para convertir a binario: ");
            dec = double.Parse(Console.ReadLine());
            binResult = Conversor.DecimalBinario(dec);
            Console.WriteLine("Resultado de la conversion: {0}", binResult);
            
            Console.Write("\n---------------------------------------------------\n");

            Console.Write("\nIngrese un numero binario para convertir a decimal: ");
            bin = Console.ReadLine();
            decResult = Conversor.BinarioDecimal(bin);
            Console.WriteLine("Resultado de la conversion: {0}", decResult);

            Console.ReadKey(true);
        }
    }
}

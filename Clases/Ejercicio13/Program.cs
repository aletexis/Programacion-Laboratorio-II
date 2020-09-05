/*Desarrollar una clase llamada Conversor, que posea dos métodos de clase (estáticos):
string DecimalBinario(double). Convierte un número de entero a binario.
double BinarioDecimal(string). Convierte un número binario a entero.*/

using System;

namespace Ejercicio13
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio13";
            string bin;
            //double dec;
            //string binResult;
            double decResult;

            /*
            Console.Write("\nIngrese un numero decimal para convertir a binario: ");
            dec = double.Parse(Console.ReadLine());
            binResult = Conversor.DecimalBinario(dec);
            Console.Write("\nResultado de la conversion: {0}", binResult);

            */


            Console.Write("\nIngrese un numero binario para convertir a decimal: ");
            bin = Console.ReadLine();
            decResult = Conversor.BinarioDecimal(bin);
            Console.Write("\nResultado de la conversion: {0}", decResult);



        }
    }
}

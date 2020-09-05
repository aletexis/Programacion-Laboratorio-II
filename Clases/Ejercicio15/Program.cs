/*Realizar un programa que permita realizar operaciones matemáticas simples (suma, resta,
multiplicación y división). Para ello se le debe pedir al usuario que ingrese dos números y la
operación que desea realizar (pulsando el caracter +, -, * ó /).
El usuario decidirá cuándo finalizar el programa.
Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):
a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
operación matemática. El método devolverá el resultado de la operación.
b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
TRUE si el número es distinto de CERO.*/

using System;

namespace Ejercicio15
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio15";
            double firstNumber;
            double secondNumber;
            double result;
            char operation;
            char cont = 's';


            do
            {
                Console.Write("\nIngrese el primer numero: ");
                firstNumber = double.Parse(Console.ReadLine());
                Console.Write("\nIngrese el segundo numero: ");
                secondNumber = double.Parse(Console.ReadLine());
                Console.Write("\nIngrese la operacion a realizar (+, -, *, /): ");
                operation = char.Parse(Console.ReadLine());

                result = Calculadora.Calcular(firstNumber, secondNumber, operation);

                Console.Write("\n>>> El resultado de la operacion es: {0} <<<", result);

                Console.Write("\n\n¿Desea seguir realizando operaciones? (s/n): ");
                cont = char.Parse(Console.ReadLine());

            } while (cont != 'n');
        }
    }
}

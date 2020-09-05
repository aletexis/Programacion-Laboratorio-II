/*Crear una clase llamada Calculadora que posea dos métodos estáticos (de clase):

a. Calcular (público): Recibirá tres parámetros, el primer número, el segundo número y la
operación matemática. El método devolverá el resultado de la operación.

b. Validar (privado): Recibirá como parámetro el segundo número. Este método se debe
utilizar sólo cuando la operación elegida sea la DIVISIÓN. Este método devolverá
TRUE si el número es distinto de CERO*/

using System;
namespace Ejercicio15
{
    public class Calculadora
    {
        public static double Calcular(double firstNumber, double secondNumber, char operation)
        {
            double result = 0;

            switch (operation)
            {
                case '+':
                    result = firstNumber + secondNumber;
                    break;
                case '-':
                    result = firstNumber - secondNumber;
                    break;
                case '*':
                    result = firstNumber * secondNumber;
                    break;
                case '/':
                    if (Calculadora.Validar(secondNumber) == true)
                    {
                        result = firstNumber / secondNumber;
                    }
                    else
                    {
                        Console.WriteLine("\n(!) No se puede dividir por 0");
                    }
                    break;
            }
            return result;
        }

        private static bool Validar(double secondNumber)
        {
            bool validated = false;

            if(secondNumber != 0)
            {
                validated = true;
            }

            return validated;
        }
    }
}

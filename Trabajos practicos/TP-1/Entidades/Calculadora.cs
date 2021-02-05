using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Comprueba que el operador seleccionado sea valido.
        /// </summary>
        /// <param name="operador">El operador a validar.</param>
        /// <returns>Si es valido devuelve el operador seleccionado. Caso contrario, retorna  el operador '+'.</returns>
        private static string ValidarOperador(char operador)
        {
            string operadorToReturn = "+";
            
            if (operador == '-' || operador == '*' || operador == '/')
            {
                operadorToReturn = char.ToString(operador);
            }
            
            return operadorToReturn;
        }

        /// <summary>
        /// Realiza la operacion indicada con los numeros ingresados.
        /// </summary>
        /// <param name="num1">El primer numero operar.</param>
        /// <param name="num2">El segundo numero a operar.</param>
        /// <param name="operador">La operacion a realizar.</param>
        /// <returns>Si se pudo operar correctamente, devuelve el resultado. Caso contrario, devuelve 0.</returns>
        public static double Operar(Numero num1, Numero num2, string operador)
        {
            double result = 0;
	
	        if(!(string.IsNullOrEmpty(operador)))
            {
		        switch (ValidarOperador(char.Parse(operador)))
                {
                    case "+":
                       result = num1 + num2;
                       break;
                    case "-":
                       result = num1 - num2;
                       break;
                    case "*":
                       result = num1 * num2;
                       break;
                    case "/":
                       result = num1 / num2;
                       break;
                }
	        }
            
            return result;
        }
    }
}

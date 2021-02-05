using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Numero
    {
        private double numero;

        #region Constructores

        /// <summary>
        /// Constructor de la clase Numero por defecto, inicializa el atributo en 0.
        /// </summary>
        public Numero() : this(0)
        {

        }

        /// <summary>
        /// Constructor de la clase Numero.
        /// </summary>
        /// <param name="numero">El numero con el que se va a inicializar el atributo de la clase</param>
        public Numero(double numero)
        {
            this.numero = numero;
        }

        /// <summary>
        /// Constructor de la clase Numero.
        /// </summary>
        /// <param name="strNumero">El numero en formato string con el que se va a inicializar el atributo de la clase</param>
        public Numero(string strNumero) //: this(double.Parse(strNumero))
        {
            this.SetNumero = strNumero;
        }

        #endregion

        #region Propiedades

        /// <summary>
        /// Setea un valor al atributo de la clase Numero.
        /// </summary>
        public string SetNumero
        {
            set
            {
                this.numero = Numero.ValidarNumero(value);
            }
        }
        #endregion

        #region Validadores

        /// <summary>
        /// Valida un numero en string y lo comvierte a double.
        /// </summary>
        /// <param name="strNumero">El numero en string a validar</param>
        /// <returns>Devuelve el numero validado en double. Caso contrario, devuelve 0.</returns>
        private static double ValidarNumero(string strNumero)
        {
            double retNumber = 0;
            double aux;

            if (double.TryParse(strNumero, out aux))
            {
                retNumber = aux;
            }

            return retNumber;
        }

        /// <summary>
        /// Valida una cadena de numeros binarios.
        /// </summary>
        /// <param name="binario">La cadena a validar</param>
        /// <returns>Devuelve True si la cadena es binaria, False si no lo es.</returns>
        private bool EsBinario(string binario)
        {
            bool esBinario = false;

            foreach(char item in binario)
            {
                if (item == '1' || item == '0')
                {
                    esBinario = true;
                }
            }

            return esBinario;
        }
        #endregion

        #region Convertidores
        
        /// <summary>
        /// Convierte una cadena binaria a decimal.
        /// </summary>
        /// <param name="binario">La cadena a convertir.</param>
        /// <returns>Devuelve el resultado de la conversion si se realizo. Caso contrario, devuelve "Valor invalido".</returns>
        public string BinarioDecimal(string binario)
        {
            int ascii;
            double multResult = 0;
            double sumResult = 0;
            string retBinario = "Valor inválido.";

            if(EsBinario(binario))
            {
                for (int i = 0; i < binario.Length; i++)
                {
                    ascii = Convert.ToInt32(binario[i]);

                    if (ascii == 48)
                    {
                        ascii = 0;
                    }
                    else if (ascii == 49)
                    {
                        ascii = 1;
                    }

                    sumResult = multResult + ascii;
                    multResult = sumResult * 2;

                }
                retBinario = sumResult.ToString();
            }
            return retBinario;
        }

        /// <summary>
        /// Convierte un numero decimal a binario.
        /// </summary>
        /// <param name="numero">El numero a convertir.</param>
        /// <returns>Devuelve el resultado de la conversion si se realizo. Caso contrario, devuelve "Valor invalido".</returns>
        public string DecimalBinario(double numero)
        {
            string binResult = "";
            int rest;
            int result;
            string accumulator = "";
            string restStr;
            string resultStr;
            int auxNumero;


            if (int.TryParse(numero.ToString(), out auxNumero))
            {

                if (auxNumero == 0)
                {
                    binResult += "0";
                }
                else if (auxNumero == 1)
                {
                    binResult = "1";
                }

                do
                {
                    result = (auxNumero / 2); 
                    rest = auxNumero % 2; 
                    auxNumero = result; 
                    resultStr = result.ToString(); 
                    restStr = rest.ToString(); 
                    accumulator += restStr; 

                } while (result != 1);

                accumulator += resultStr; 

            
                foreach (char character in accumulator)
                {
                    binResult = character + binResult;

                }
            }
            else
            {
                binResult = "Valor inválido.";
            }

            return binResult;
        }

        /// <summary>
        /// Convierte un numero decimal a binario.
        /// </summary>
        /// <param name="numero">La cadena a convertir.</param>
        /// <returns>Devuelve el resultado de la conversion si se realizo. Caso contrario, devuelve "Valor invalido".</returns>
        public string DecimalBinario(string numero)
        {
            double auxNumero;
            string binResult = "Valor inválido.";

            if (double.TryParse(numero, out auxNumero))
            {
                binResult = DecimalBinario(auxNumero); 
            }
            return binResult;
        }

        #endregion

        #region Sobrecarga de operadores

        /// <summary>
        /// Sobrecarga del operador "+".
        /// </summary>
        /// <param name="n1">Primer numero a operar.</param>
        /// <param name="n2">Segundo numero a operar.</param>
        /// <returns>Devuelve el resultado de la suma entre los dos atributos de la clase Numero.</returns>
        public static double operator +(Numero n1, Numero n2)
        {
            double retorno = -1;

            if (!object.Equals(n1, null) && !object.Equals(n2, null))
            {
                retorno = n1.numero + n2.numero;
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador "-".
        /// </summary>
        /// <param name="n1">Primer numero a operar.</param>
        /// <param name="n2">Segundo numero a operar.</param>
        /// <returns>Devuelve el resultado de la resta entre los dos atributos de la clase Numero.</returns>
        public static double operator -(Numero n1, Numero n2)
        {
            double retorno = -1;

            if (!object.Equals(n1, null) && !object.Equals(n2, null))
            {
                retorno = n1.numero - n2.numero;
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador "*".
        /// </summary>
        /// <param name="n1">Primer numero a operar.</param>
        /// <param name="n2">Segundo numero a operar.</param>
        /// <returns>Devuelve el resultado de la multiplicacion entre los dos atributos de la clase Numero.</returns>
        public static double operator *(Numero n1, Numero n2)
        {
            double retorno = -1;

            if (!object.Equals(n1, null) && !object.Equals(n2, null))
            {
                retorno = n1.numero * n2.numero;
            }
            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador "/".
        /// </summary>
        /// <param name="n1">Primer numero a operar.</param>
        /// <param name="n2">Segundo numero a operar.</param>
        /// <returns>Devuelve el resultado de la division entre los dos atributos de la clase Numero.</returns>
        public static double operator /(Numero n1, Numero n2)
        {
            double retorno = -1;

            if (!object.Equals(n1, null) && !object.Equals(n2, null))
            {
                if (n2.numero == 0)
                {
                    retorno = double.MinValue;
                }
                else
                {
                    retorno = n1.numero / n2.numero;
                }
            }
            return retorno;
        }

        #endregion

    }
}

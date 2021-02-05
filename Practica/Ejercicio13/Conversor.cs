using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double dec) //Convierte un número de entero a binario.
        {
            string binResult = "";
            int rest;
            int result;
            string accumulator = "";
            string restStr;
            string resultStr;

            if ((int)dec == 0)
            {
                binResult += "0";
                //Console.Write("\nbin result en class conversor {0}", binResult);

            }
            else if ((int)dec == 1)
            {
                binResult = "1";
                //Console.Write("\nbin result en class conversor {0}", binResult);
            }

            do
            {
                result = (int)(dec / 2); //divido el decimal

                rest = (int)dec % 2; //guardo el resto

                dec = result; //actualizo el decimal con el resultado de la division

                resultStr = result.ToString(); //paso el resultado a string (se sobreescribe con la iteracion hasta que = 1)

                restStr = rest.ToString(); //paso el resto a string

                accumulator += restStr; //acumulo los restos en una cadena

            } while (result != 1); //divido hasta que el resultado de la division de 1

            accumulator += resultStr; //agrego el 1 del resultado de la ultima operacion

            //como el acumulador me cargo el binario al reves lo tengo que invertir
            foreach (char character in accumulator)
            {
                binResult = character + binResult;

            }

            return binResult;
        }

        public static double BinarioDecimal(string bin) //Convierte un número binario a entero
        {
            int dec;
            double multResult = 0;
            double sumResult = 0;

            for (int i = 0; i < bin.Length; i++) //recorro la cadena
            {
                dec = Convert.ToInt32(bin[i]); //en dec se guarda la representacion en ASCII del caracter

                if (dec == 48) //48 es 0 en ASCII
                {
                    dec = 0;
                }
                else if (dec == 49) //49 es 1 en ASCII
                {
                    dec = 1;
                }

                sumResult = multResult + dec;
                multResult = sumResult * 2;

            }

            return sumResult;
        }
    }
}

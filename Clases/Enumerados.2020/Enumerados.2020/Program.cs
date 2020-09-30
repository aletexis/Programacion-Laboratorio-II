using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerados._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            EColor unColor;
            String nombreDeColor;
            int cantidad;
            int numeroDeColor;


            #region Recorrer un Enumerado

            /// recorrer un enumerado con ForEach
            ///**********************************
            ///**********************************


            /// sacar los nombres de los items del enumerado con el método 
            /// estático "GetNames" de la clase "Enum"
            foreach (String NombresDelEnumerado in Enum.GetNames(typeof(EColor)))
            {
                Console.WriteLine(NombresDelEnumerado);
            }

            /// sacar los items del enumerado con el método 
            /// estático "GetValues" de la clase "Enum"
            foreach (EColor ValoresDelEnumerado in Enum.GetValues(typeof(EColor)))
            {
                Console.WriteLine(ValoresDelEnumerado);
            }

            /// sacar los items del enumerado con el método 
            /// estático "GetValues" de la clase "Enum", luego de
            /// extraerlos los casteo a entero para obtener su valor numérico 
            foreach (EColor ValoresDelEnumerado in Enum.GetValues(typeof(EColor)))
            {
                Console.WriteLine((int)ValoresDelEnumerado);
            }


            /// recorrer un enumerado con For
            ///******************************
            ///******************************

            cantidad = Enum.GetValues(typeof(EColor)).GetLength(0);

            // esto solo se puede hacer si el enumerado comienza 
            // en 0 e incrementa de una unidad sus valores
            for (int i = 0; i < cantidad; i++)
            {
                unColor = (EColor)i;

                Console.WriteLine((int)unColor);
            }

            #endregion


            #region Asignación de valores


            ///DESDE UN "STRING"
            ///*****************
            ///Asignación de valores a un enumerado
            ///desde un "STRING", con el metodo estático "Parse" de la clase "Enum" y 
            ///luego aplicando el casteo explícito.
            ///Recordar que debemos manejar los posibles errores de casteo que ocurran
            ///try - Catch

            nombreDeColor = "rojo";
            unColor = (EColor)Enum.Parse(typeof(EColor), nombreDeColor, true);
            nombreDeColor = "verde";
            unColor = (EColor)Enum.Parse(typeof(EColor), nombreDeColor, true);

            nombreDeColor = "amardfasdfasf";
            //unColor = (EColor)Enum.Parse(typeof(EColor), nombreDeColor, true);


            ///DESDE UN "INT"
            ///*****************
            ///Asignación de valores a un enumerado
            ///desde un "INT", el casteo explícito  "(EColor)"
            ///Recordar que debemos manejar los posibles errores de casteo que ocurran
            ///try - Catch

            numeroDeColor = 3;
            unColor = (EColor)numeroDeColor;

            numeroDeColor = 0;
            unColor = (EColor)numeroDeColor;


            numeroDeColor = 100;
            unColor = (EColor)numeroDeColor;


            #endregion


            #region Utilización del Switch

            ///facilita el uso de todos sus items en una estrutura "switch",
            ///colocando dentro del parametro un objeto de tipo enumerado y 
            ///generando los casos automáticamente gracias a su codeSnippet



            #endregion


            #region Pasaje de Datos

            /// PASEJE DE DATOS
            /// 
            /// Valores literales:

            Bicicleta bicicletaUno = new Bicicleta("Camila", EColor.Rojo);

            /// con una variable del tipo enumerado
            Bicicleta bicicletaDos = new Bicicleta("Victoria", unColor);

            /// parseando un string
            Bicicleta bicicletaTres = new Bicicleta("Agustina", (EColor)Enum.Parse(typeof(EColor), "azul", true));

            /// casteando un entero 
            Bicicleta bicicletaCuatro = new Bicicleta("Juan", (EColor)1);

            #endregion


            #region Posibles errores en tiempo de compilación 

            ///MAL

            //Bicicleta bicicletaCuatro1 = new Bicicleta("Carmen",(EColor)"AZul");


            //Bicicleta bicicletaTres1 = new Bicicleta("Agustina",(EColor) Enum.Parse((EColor, "azul", true));


            //Bicicleta bicicletaTres2 = new Bicicleta("Agustina", Enum.Parse(typeof(EColor), "azul", true));

            //foreach (Color ValoresDelEnumerado in Enum.GetValues(EColor))
            //{
            //    Console.WriteLine((int)ValoresDelEnumerado);
            //}

            #endregion

        }
    }
}

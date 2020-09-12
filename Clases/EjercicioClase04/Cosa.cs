/*
 clase Cosa
 (+) es public
 (-) es private
*-*-*-*-*-*-

(-) entero:int
(-) cadena:string
(-) fecha:DateTime
*-*-*-*-*-*-*-*-*-*-*

(+) Mostrar():void

*-*-*-*-*-*-*-*-*-

(+) EstablecerValor(int):void
(+) EstablecerValor(string):void
(+) EstablecerValor(DateTime):void

*-*-*-*-*-*-*-*-*-*


---> en todos los casos la fecha por defecto debe ser la actual

(+) Cosa(int, string)
(+) Cosa(string)
(+) Cosa()

*/

using System;
namespace EjercicioClase04
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;


        #region Constructores
        /* lo del : solo valido para constructores
         * solo en donde una sobrecarga de un constructor de instancia 
         * invoque a otra sobrecarga de un constructor de instancia.
         * NO es valido para ninguna otra cosa*/
        public Cosa()
        {
            this.entero = 0;
            this.cadena = "";
            this.fecha = DateTime.Now;
        }

        public Cosa(string valorStr):this()
        {
            this.cadena = valorStr;
        }

        public Cosa(int valorInt, string valorStr):this(valorStr)
        {
            this.entero = valorInt;
        }
        #endregion

        #region Metodos
        public void EstablecerValor(int valor)
        {
            this.entero = valor;
        }

        public void EstablecerValor(string valor)
        {
            this.cadena = valor;
        }

        public void EstablecerValor(DateTime valor)
        {
            this.fecha = valor;
        }

        public void Mostrar()
        {
            Console.WriteLine("\nEntero: {0}", this.entero);
            Console.WriteLine("\nCadena: {0}", this.cadena);
            Console.WriteLine("\nFecha: {0}", this.fecha);
        }
        #endregion
    }
}

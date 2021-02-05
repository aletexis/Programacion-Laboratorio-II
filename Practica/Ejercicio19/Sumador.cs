using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace Ejercicio19
{
    class Sumador
    {
        private int cantidadSumas;

        #region Constructores
        public Sumador() : this(0)
        {
        }

        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }
        #endregion

        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return (long)a + b;
        }

        public string Sumar(string a, string b)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0}{1}", a, b);
            this.cantidadSumas++;
            return sb.ToString();
        }

        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        public static bool operator |(Sumador s1, Sumador s2)
        {
            bool retorno = false;

            if(s1.cantidadSumas == s2.cantidadSumas)
            {
                retorno = true;
            }
            return retorno;

        }

        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
    }
}

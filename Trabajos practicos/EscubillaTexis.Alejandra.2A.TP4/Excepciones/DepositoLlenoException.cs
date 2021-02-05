using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class DepositoLlenoException : Exception
    {
        /// <summary>
        /// Constructor de la excepcion de deposito lleno.
        /// </summary>
        public DepositoLlenoException()
           : base("\nEl deposito está lleno.")
        {
        }
    }
}

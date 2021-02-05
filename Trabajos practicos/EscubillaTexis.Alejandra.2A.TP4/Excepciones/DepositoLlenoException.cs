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
        /// Constructor por defecto.
        /// </summary>
        public DepositoLlenoException()
           : base("Deposito lleno")
        {
        }

        /// <summary>
        /// Constructor parametrizado que inicializa un atributo.
        /// <param name="mensaje">El mensaje a mostrar</param>
        /// </summary>
        public DepositoLlenoException(string mensaje)
           : base(mensaje)
        {
        }
    }
}

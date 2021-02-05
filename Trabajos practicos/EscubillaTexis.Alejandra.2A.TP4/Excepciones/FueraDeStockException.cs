using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepciones
{
    public class FueraDeStockException : Exception
    {
        /// <summary>
        /// Constructor de la excepcion de producto fuera de stock.
        /// </summary>
        public FueraDeStockException()
            : base("\nEl producto esta fuera de stock.")
        {
        }
    }
}

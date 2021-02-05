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
        /// Constructor por defecto.
        /// </summary>
        public FueraDeStockException()
            : base("No hay stock del producto seleccionado.")
        {
        }

        /// <summary>
        /// Constructor parametrizado que inicializa un atributo.
        /// <param name="mensaje">El mensaje a mostrar</param>
        /// </summary>
        public FueraDeStockException(string mensaje)
            : base(mensaje)
        {
        }

    }
}


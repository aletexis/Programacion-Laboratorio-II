using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class CajaLlenaException : Exception
    {
        public CajaLlenaException()
            : base("La caja está llena. Se superó la cantidad máxima.")
        {

        }
    }
}
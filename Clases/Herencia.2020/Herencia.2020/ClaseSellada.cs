using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herencia
{
    sealed class ClaseSellada : ClaseDerivada
    {
        public ClaseSellada()
            : base(8)
        {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerados
{
    class Bicicleta
    {
        public EColor color;
        public string dueño;

        public Bicicleta(string dueño)
        {
            this.dueño = dueño;
        }

        public Bicicleta(string dueño, EColor colorDeLaBici):this(dueño)
        {
            this.color = colorDeLaBici;
        }
    }
}

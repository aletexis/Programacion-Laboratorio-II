using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometría
{
    class Punto
    {
        private int x;
        private int y;

        #region Propiedades
        public int GetX()
        {
            return this.x;
        }
        public int GetY()
        {
            return this.y;
        }

        #endregion

        #region Constructores
        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        #endregion

    }
}

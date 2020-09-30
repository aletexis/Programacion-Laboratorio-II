using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class ClaseError : ClaseBase
    {

        #region Constructor

        public ClaseError()
            : base(1)
        { }

        #endregion

        #region Métodos

        public void Falla(ClaseBase t)
        {
            //Console.WriteLine("{0} - {1} - {2}", t.Id, t.nombre, t.edad);
        }
        public void Compila()
        {
            Console.WriteLine("{0} - {1} - {2}", base.Id, base.nombre, base.edad);
        }

        #endregion

    }
}

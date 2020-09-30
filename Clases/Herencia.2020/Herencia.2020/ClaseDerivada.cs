using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class ClaseDerivada : ClaseBase
    {
        #region Atributos

        public string algo;

        #endregion

        #region Constructor

        public ClaseDerivada(long id)
            : base(id)
        {
            base.edad = 1;
            this.algo = "algo";
        }

        #endregion

        #region Métodos

        public void Compila()
        {
            Console.WriteLine("{0} - {1} - {2}", base.Id, base.nombre, base.edad);
        }

        #endregion

    }
}

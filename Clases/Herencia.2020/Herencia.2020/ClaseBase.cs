using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Herencia
{
    class ClaseBase
    {

        #region Atributos

        private long id;

        protected int edad; 
        
        public string nombre;       

        #endregion

        #region Propiedades

        public long Id 
        {
            get { return this.id; }
        }

        #endregion

        #region Constructor

        public ClaseBase(long id)
        {
            this.id = id;
        }

        #endregion

    }
}

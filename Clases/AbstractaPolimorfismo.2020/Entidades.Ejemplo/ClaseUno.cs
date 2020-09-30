using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ejemplo
{
    public class ClaseUno
    {
        protected string nombre;

        public string TipoClaseUno
        {
            get { return "ClaseUno"; }
        }

        public ClaseUno(string nombre) { this.nombre = nombre; }

        public string MostrarClaseUno()
        {
            return this.nombre;
        }





        #region Con Polimorfismo
        //public virtual string Tipo
        //{
        //    get { return "ClaseUno"; }
        //}

        //public virtual string Mostrar()
        //{
        //    return this.nombre;
        //}
        #endregion
    }
}

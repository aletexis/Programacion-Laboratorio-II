using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Ejemplo
{
    public class ClaseDos : ClaseUno
    {
        protected string atributoClaseDos;

        public string TipoClaseDos
        {
            get 
            {
                return "ClaseDos " + "Hereda de: " + base.TipoClaseUno; 
            }
        }

        public ClaseDos(string nombre, string propio)
            :base(nombre)
        { 
            this.atributoClaseDos = propio; 
        }

        public string MostrarClaseDos()
        {
            return base.MostrarClaseUno() + " " + this.atributoClaseDos;
        }





        #region Con Polimorfismo
        //public override string Tipo
        //{
        //    get { return "ClaseDos " + "Hereda de: " + base.Tipo; }
        //}

        //public override string Mostrar()
        //{
        //    return base.Mostrar() + " " + this.atributoClaseDos;
        //}
        #endregion

    }
}

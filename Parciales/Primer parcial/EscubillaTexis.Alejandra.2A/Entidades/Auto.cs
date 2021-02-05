using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Auto : Vehiculo
    {
        #region Atributos
        
        public ETipo tipo;
        
        #endregion

        #region Constructor
        public Auto(string modelo, float precio, Fabricante fabri, ETipo tipo)
            : base(precio, modelo, fabri)
        {
            this.tipo = tipo;
        }
        
        #endregion

        #region Sobrecargas

        public static bool operator ==(Auto a, Auto b)
        {
            return ((Vehiculo)a == (Vehiculo)b && a.tipo == b.tipo);
        }

        public static bool operator !=(Auto a, Auto b)
        {
            return !(a == b);
        }

        public static explicit operator Single(Auto a)
        {
            return a.precio;
        }

        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Auto)
            {
                retorno = this == (Auto)obj;
            }

            return retorno;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append((string)(Vehiculo)this);
            sb.AppendFormat("TIPO: {0}", this.tipo);

            return sb.ToString();
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Moto : Vehiculo
    {
        #region Atributo

        public ECilindrada cilindrada;

        #endregion

        #region Constructor
        public Moto(string marca, EPais pais, string modelo, float precio, ECilindrada cilindrada)
            : base(marca, pais, modelo, precio)
        {
            this.cilindrada = cilindrada;
        }
        #endregion


        #region Sobrecargas

        public static bool operator ==(Moto a, Moto b)
        {
            return ((Vehiculo)a == (Vehiculo)b && a.cilindrada == b.cilindrada);
        }
        public static bool operator !=(Moto a, Moto b)
        {
            return !(a == b);
        }

        public static implicit operator Single(Moto m)
        {
            return m.precio;
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
            sb.AppendFormat("CILINDRADA: {0}", this.cilindrada);

            return sb.ToString();
        }

        #endregion
    }
}

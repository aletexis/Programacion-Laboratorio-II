using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTintaPluma
{
    class Pluma
    {
        private string marca;
        private Tinta tinta;
        private int cantidad;

        public Pluma()
        {
            this.marca = "Sin marca";
            this.tinta = null;
            this.cantidad = 1;
        }

        public Pluma(string marca)
            : this()
        {
            this.marca = marca;
        }

        public Pluma(string marca, Tinta tinta)
            : this(marca)
        {
            this.tinta = tinta;
        }

        public Pluma(string marca, Tinta tinta, int cantidad)
            : this(marca, tinta)
        {
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nMarca: {0}", this.marca);
            sb.AppendFormat("Tinta: {0}", this.tinta);
            sb.AppendFormat("Cantidad: {0}\n", this.cantidad);
            return sb.ToString();
        }

        public static bool operator ==(Pluma pluma, Tinta tinta)
        {
            return pluma.tinta == tinta;
        }

        public static bool operator !=(Pluma pluma, Tinta tinta)
        {
            return !(pluma.tinta == tinta);
        }

        //        +(Pluma, Tinta):Pluma // agrega solo si las tintas son iguales. (incrementar cantidad)
        public static Pluma operator +(Pluma pluma, Tinta tinta)
        {
            if(pluma == tinta)
            {
                pluma.cantidad++;
            }
            return pluma;
        }

        //       - (Pluma, Tinta):Pluma // agrega solo si las tintas son iguales. (decrementar cantidad)
        public static Pluma operator -(Pluma pluma, Tinta tinta)
        {
            if (pluma == tinta)
            {
                pluma.cantidad--;
            }
            return pluma;
        }
        
        //       implicit (Pluma):string //se relaciona con mostrar
        public static implicit operator string (Pluma pluma)
        {
            return pluma.Mostrar();
        }
    }








}

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTintaPluma
{
    class Tinta
    {
        private ConsoleColor color;
        private ETipoTinta tipo;


        public Tinta()
        {
            this.color = ConsoleColor.Black;
            this.tipo = ETipoTinta.Comun;
        }

        public Tinta(ConsoleColor color)
            : this()
        {
            this.color = color;
        }

        public Tinta(ConsoleColor color, ETipoTinta tipo)
            : this(color)
        {
            this.tipo = tipo;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("\nColor: {0}", this.color);
            sb.AppendFormat("Tipo: {0}\n", this.tipo);
            return sb.ToString();
        }

        public static string Mostrar(Tinta tinta)
        {
            return tinta.Mostrar();
        }

        public static bool operator ==(Tinta tinta1, Tinta tinta2)
        {
            return (tinta1.color == tinta2.color && tinta1.tipo == tinta2.tipo);
        }

        public static bool operator !=(Tinta tinta1, Tinta tinta2)
        {
            return !(tinta1 == tinta2);
        }

        public static explicit operator string(Tinta tinta)
        {
            return tinta.Mostrar();
        }

    }

}

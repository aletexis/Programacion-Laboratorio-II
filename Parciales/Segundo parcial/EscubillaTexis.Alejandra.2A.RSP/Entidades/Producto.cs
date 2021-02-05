using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Producto
    {
        #region Atributos
        public string tipo;
        public string marca;
        public float precio;
        #endregion

        #region Propiedades
        public float Precio
        {
            get
            {
                return precio;
            }
        }
        #endregion

        #region Constructores
        public Producto()
        {

        }

        public Producto(string tipo, string marca, float precio)
        {
            this.tipo = tipo;
            this.marca = marca;
            this.precio = precio;
        }
        #endregion

        #region Metodos
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine();
            sb.AppendFormat("Tipo: {0}\n", this.tipo);
            sb.AppendFormat("Marca: {0}\n", this.marca);
            sb.AppendFormat("Precio: ${0}\n", this.precio);

            return sb.ToString();
        }
        #endregion
    }
}

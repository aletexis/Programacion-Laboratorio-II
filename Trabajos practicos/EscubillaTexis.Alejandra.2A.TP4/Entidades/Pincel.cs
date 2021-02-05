using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pincel : Producto
    {
        #region Atributo
        private ETipoPincel tipo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que permite obtener un tipo de pincel.
        /// </summary>
        public ETipoPincel Tipo
        {
            get
            {
                return this.tipo;
            }
        }

        /// <summary>
        /// Propiedad que permite obtener una marca.
        /// </summary>
        public override string Marca
        {
            get
            {
                return this.marca;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto del Pincel.
        /// </summary>
        public Pincel()
            : base()
        { }

        /// <summary>
        /// Constructor que inicializa el codigo, nombre, marca, stock, precio y tipo de un pincel.
        /// </summary>
        /// <param name="codigo">El codigo del pincel.</param>
        /// <param name="nombre">El nombre del pincel.</param>
        /// <param name="marca">La marca del pincel.</param>
        /// <param name="stock">El stock del pincel.</param>
        /// <param name="precio">El precio del pincel.</param>
        /// <param name="tipo">El tipo del pincel.</param>
        public Pincel(int codigo, string nombre, string marca, int stock, float precio, ETipoPincel tipo)
            : base(codigo, nombre, marca, stock, precio)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra la informacion del pincel.
        /// </summary>
        /// <returns>Devuelve la informacion en string.</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("\tTipo: " + this.tipo);

            return sb.ToString();
        }
        /// <summary>
        /// Hace publica la informacion del pincel.
        /// </summary>
        /// <returns>Devuelve la informacion en string.</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        /// <summary>
        /// Verifica si un objeto es de tipo pincel.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>Devuelve True si son iguales. Caso contrario devuelve False.</returns>
        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Pincel)
            {
                ret = this == (Pincel)obj;
            }

            return ret;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        #endregion

        #region Sobrecargas
        /// <summary>
        /// Verifica que dos pinceles sean iguales.
        /// </summary>
        /// <param name="pincel1">Primer pincel a comparar.</param>
        /// <param name="pincel2">Segundo pincel a comparar.</param>
        /// <returns>Devuelve true si son iguales. Caso contrario, devuelve False.</returns>
        public static bool operator ==(Pincel pincel1, Pincel pincel2)
        {
            return (Producto)pincel1 == (Producto)pincel2;
        }

        /// <summary>
        /// Verifica que dos pinceles sean distintos.
        /// </summary>
        /// <param name="pincel1">Primer pincel a comparar.</param>
        /// <param name="pincel2">Segundo pincel a comparar.</param>
        /// <returns>Devuelve true si son distintos. Caso contrario, devuelve False.</returns>
        public static bool operator !=(Pincel pincel1, Pincel pincel2)
        {
            return !(pincel1 == pincel2);
        }
        #endregion
    }
}

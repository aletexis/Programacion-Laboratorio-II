using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pintura : Producto
    {
        #region Atributos
        private ETipoPintura tipo;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que permite obtener un tipo de pintura.
        /// </summary>
        public ETipoPintura Tipo
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
        /// Constructor por defecto.
        /// </summary>
        public Pintura()
            : base()
        {
        }
        /// <summary>
        /// Constructor que inicializa el codigo, nombre, marca, stock, precio y tipo de una pintura.
        /// </summary>
        /// <param name="codigo">El codigo de la pintura.</param>
        /// <param name="nombre">El nombre de la pintura.</param>
        /// <param name="marca">La marca de la pintura.</param>
        /// <param name="stock">El stock de la pintura.</param>
        /// <param name="precio">El precio de la pintura.</param>
        /// <param name="tipo">El tipo de la pintura.</param>
        public Pintura(int codigo, string nombre, string marca, int stock, float precio, ETipoPintura tipo)
            : base(codigo, nombre, marca, stock, precio)
        {
            this.tipo = tipo;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Muestra la informacion de la pintura.
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
        /// Hace publica la informacion de la pintura.
        /// </summary>
        /// <returns>Devuelve la informacion en string.</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Verifica si un objeto es de tipo pintura.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>Devuelve True si son iguales. Caso contrario devuelve False.</returns>
        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Pintura)
            {
                ret = this == (Pintura)obj;
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
        /// Verifica que dos pinturas sean iguales.
        /// </summary>
        /// <param name="pintura1">Primer pintura a comparar.</param>
        /// <param name="pintura2">Segunda pintura a comparar.</param>
        /// <returns>Devuelve True si son iguales. Caso contrario, decuelve False.</returns>
        public static bool operator ==(Pintura pintura1, Pintura pintura2)
        {
            return (Producto)pintura1 == (Producto)pintura2;
        }

        /// <summary>
        /// Verifica que dos pinturas sean distintas.
        /// </summary>
        /// <param name="pintura1">Primer pintura a comparar.</param>
        /// <param name="pintura2">Segunda pintura a comparar.</param>
        /// <returns>Devuelve True si son distintas. Caso contrario, decuelve False.</returns>
        public static bool operator !=(Pintura pintura1, Pintura pintura2)
        {
            return !(pintura1 == pintura2);
        }
        #endregion
    }
}

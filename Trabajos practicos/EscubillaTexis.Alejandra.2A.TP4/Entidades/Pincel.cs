using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pincel : Producto
    {
        #region Atributos
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
        /// Constructor por defecto.
        /// </summary>
        public Pincel()
        {
        }
        /// <summary>
        /// Constructor que inicializa el codigo, nombre, marca, stock, precio y tipo de un pincel.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="tipo"></param>
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
        /// <returns></returns>
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
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}

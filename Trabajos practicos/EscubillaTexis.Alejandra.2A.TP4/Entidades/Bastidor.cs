using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Bastidor : Producto
    {
        #region Atributos
        private ETamaño tamaño;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que permite obtener un tipo de pintura.
        /// </summary>
        public ETamaño Tamaño
        {
            get
            {
                return this.tamaño;
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
        public Bastidor()
        {
        }
        /// <summary>
        /// Constructor que inicializa el codigo, nombre, marca, stock, precio y tipo de un bastidor.
        /// </summary>
        /// <param name="codigo"></param>
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="tamaño"></param>
        public Bastidor(int codigo, string nombre, string marca, int stock, float precio, ETamaño tamaño)
            : base(codigo, nombre, marca, stock, precio)
        {
            this.tamaño = tamaño;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra la informacion del bastidor.
        /// </summary>
        /// <returns></returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("\tTamaño: " + this.tamaño);

            return sb.ToString();
        }
        
        /// <summary>
        /// Hace publica la informacion del bastidor
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        #endregion
    }
}

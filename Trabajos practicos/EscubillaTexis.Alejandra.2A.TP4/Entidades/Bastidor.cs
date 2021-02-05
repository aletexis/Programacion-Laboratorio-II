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
            : base()
        {
        }
        /// <summary>
        /// Constructor que inicializa el codigo, nombre, marca, stock, precio y tipo de un bastidor.
        /// </summary>
        /// <param name="codigo">El codigo del bastidor.</param>
        /// <param name="nombre">El nombre del bastidor.</param>
        /// <param name="marca">La marca del bastidor.</param>
        /// <param name="stock">El stock del bastidor.</param>
        /// <param name="precio">El precio del bastidor.</param>
        /// <param name="tamaño">El tamaño del bastidor.</param>
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
        /// <returns>Devuelve la informacion en string.</returns>
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.Mostrar());
            sb.AppendLine("\tTamaño: " + this.tamaño);

            return sb.ToString();
        }

        /// <summary>
        /// Hace publica la informacion del bastidor.
        /// </summary>
        /// <returns>Devuelve la informacion en string.</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Verifica si un objeto es de tipo bastidor.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>Devuelve True si son iguales. Caso contrario devuelve False.</returns>
        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Bastidor)
            {
                ret = this == (Bastidor)obj;
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
        /// Verifica que dos bastidores sean iguales.
        /// </summary>
        /// <param name="bastidor1">Primer bastidor a comparar.</param>
        /// <param name="bastidor2">Segundo bastidor a comparar.</param>
        /// <returns>Devuelve True si son iguales. Caso contrario, devuelve False.</returns>
        public static bool operator ==(Bastidor bastidor1, Bastidor bastidor2)
        {
            return (Producto)bastidor1 == (Producto)bastidor2;
        }

        /// <summary>
        /// Verifica que dos bastidores sean distintos.
        /// </summary>
        /// <param name="bastidor1">Primer bastidor a comparar.</param>
        /// <param name="bastidor2">Segundo bastidor a comparar.</param>
        /// <returns>Devuelve True si son distintos. Caso contrario, devuelve False.</returns>
        public static bool operator !=(Bastidor bastidor1, Bastidor bastidor2)
        {
            return !(bastidor1 == bastidor2);
        }
        #endregion
    }
}

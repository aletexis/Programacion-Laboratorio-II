using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    [XmlInclude(typeof(Pincel))]
    [XmlInclude(typeof(Pintura))]
    [XmlInclude(typeof(Bastidor))]
    public class Producto
    {
        #region Atributos
        private int codigo;
        private string nombre;
        public string marca;
        private int stock;
        private float precio;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que permite obtener un codigo.
        /// </summary>
        public int Codigo
        {
            get
            {
                return this.codigo;
            }
        }

        /// <summary>
        /// Propiedad que permite obtener un nombre.
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        /// <summary>
        /// Propiedad que permite obtener una marca.
        /// </summary>
        public virtual string Marca
        {
            get;
        }
        /// <summary>
        /// Propiedad que permite obtener un stock.
        /// </summary>
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (value >= 0)
                {
                    this.stock = value;
                }
            }
        }
        /// <summary>
        /// Propiedad que permite obtener un precio.
        /// </summary>
        public float Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                if (value >= 1)
                {
                    this.precio = value;
                }
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public Producto()
        {
        }
        /// <summary>
        /// Constructor que inicializa el nombre, marca, stock y precio del producto.
        /// </summary>
        /// <param name="nombre">El nombre del producto.</param>
        /// <param name="marca">La marca del producto.</param>
        /// <param name="stock">El stock del producto.</param>
        /// <param name="precio">El precio del producto.</param>
        public Producto(string nombre, string marca, int stock, float precio)
            : this()
        {
            this.Nombre = nombre;
            this.marca = marca;
            this.Stock = stock;
            this.Precio = precio;
        }
        /// <summary>
        /// Constructor que inicializa el codigo, nombre, marca, stock y precio del producto.
        /// </summary>
        /// <param name="codigo">El codigo del producto.</param>
        /// <param name="nombre">El nombre del producto.</param>
        /// <param name="marca">La marca del producto.</param>
        /// <param name="stock">El stock del producto.</param>
        /// <param name="precio">El precio del producto.</param>
        public Producto(int codigo, string nombre, string marca, int stock, float precio)
            : this(nombre, marca, stock, precio)
        {
            this.codigo = codigo;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Muestra la informacion del producto.
        /// </summary>
        /// <returns>Devuelve la informacion en string.</returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\tCodigo: " + this.codigo);
            //sb.AppendLine("\tStock: " + this.stock);
            sb.AppendLine("\tPrecio: $" + this.precio);
            sb.AppendLine("\tNombre: " + this.nombre);
            sb.AppendLine("\tMarca: " + this.marca);

            return sb.ToString();
        }

        /// <summary>
        /// Hace publica la informacion del producto.
        /// </summary>
        /// <returns>Devuelve la informacion en string.</returns>
        public override string ToString()
        {
            return this.Mostrar();
        }

        /// <summary>
        /// Verifica que un objeto sea de tipo producto.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>Devuelve True si es. Caso contrario, devuelve false.</returns>
        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Producto)
            {
                ret = this == (Producto)obj;
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
        /// Dos productos son iguales si tienen el mismo codigo.
        /// </summary>
        /// <param name="producto1">El primer producto a comparar.</param>
        /// <param name="producto2">El segundo producto a comparar.</param>
        /// <returns>Devuelve True si son iguales, false si no lo son.</returns>
        public static bool operator ==(Producto producto1, Producto producto2)
        {
            bool ret = false;
            if ((object)producto1 != null && (object)producto2 != null)
            {
                if (producto1.codigo == producto2.codigo)
                {
                    ret = true;
                }
            }
            return ret;
        }

        /// <summary>
        /// Dos productos son distintos si tienen el mismo codigo.
        /// </summary>
        /// <param name="producto1">El primer producto a comparar.</param>
        /// <param name="producto2">El segundo producto a comparar.</param>
        /// <returns>Devuelve True si son distintos, false si no lo son.</returns>
        public static bool operator !=(Producto producto1, Producto producto2)
        {
            return !(producto1 == producto2);
        }
        #endregion
    }
}

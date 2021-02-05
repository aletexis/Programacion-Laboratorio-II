using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
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
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
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
        /// <param name="nombre"></param>
        /// <param name="marca"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
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
        /// <returns></returns>
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\tCodigo: " + this.codigo);
            sb.AppendLine("\tStock: " + this.stock);
            sb.AppendLine("\tPrecio: " + this.precio);
            sb.AppendLine("\tNombre: " + this.nombre);
            sb.AppendLine("\tMarca: " + this.marca);
           
            return sb.ToString();
        }

        /// <summary>
        /// Hace publica la informacion del producto.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}

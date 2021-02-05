using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivos;
using Excepciones;

namespace Entidades
{
    public class Artistica
    {
        #region Atributos
        private int capacidadDeposito;
        public List<Producto> productos;
        public List<Venta> ventas;
        #endregion

        #region Propiedades
        /// <summary>
        /// Propiedad que permite obtener o asignar la capacidad del deposito.
        /// </summary>
        public int CapacidadDeposito
        {
            get
            {
                return this.capacidadDeposito;
            }
            set
            {
                this.capacidadDeposito = value;
            }
        }

        /// <summary>
        /// Propiedad que permite obtener o asignar productos.
        /// </summary>
        public List<Producto> Productos
        {
            get
            {
                return this.productos;
            }
            set
            {
                this.productos = value;
            }
        }

        /// <summary>
        /// Propiedad que permite obtener o asignar ventas.
        /// </summary>
        public List<Venta> Ventas
        {
            get
            {
                return this.ventas;
            }
            set
            {
                this.ventas = value;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto. Inicializa la lista de productos y ventas
        /// y establece la capacidad del deposito en 30.
        /// </summary>
        public Artistica()
        {
            this.capacidadDeposito = 30;
            this.productos = new List<Producto>();
            this.ventas = new List<Venta>();
        }

        /// <summary>
        /// Constructor que inicializa una capacidad de deposito determinada.
        /// </summary>
        /// <param name="capacidadDeposito">La capacidad del deposito recibida.</param>
        public Artistica(int capacidadDeposito)
            : this()
        {
            this.capacidadDeposito = capacidadDeposito;
        }
        #endregion

        #region Metodos

        /// <summary>
        /// Muestra un listado de ventas realizadas.
        /// </summary>
        /// <returns>Devuelve el listado de ventas en string.</returns>
        public string MostrarVentas()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\t**************************************\n");
            sb.Append("\t*** VENTAS ***************************\n");
            sb.Append("\t**************************************\n");
            foreach (Venta v in Ventas)
            {
                sb.AppendLine(v.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Muestra un listado de productos.
        /// </summary>
        /// <returns>Devuelve el listado de productos en string.</returns>
        private string MostrarProductos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\t**************************************\n");
            sb.Append("\t*** PRODUCTOS ************************\n");
            sb.Append("\t**************************************\n");
            foreach (Producto p in Productos)
            {
                sb.AppendLine(p.ToString());
            }

            return sb.ToString();
        }
 
        /// <summary>
        /// Hace publicos los datos de la artistica, detallando los productos,
        /// ventas y la capacidad del deposito.
        /// </summary>
        /// <returns>Devuelve los datos en formato string.</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("\n\t=======================================\n");
            sb.Append("\t============== ARTISTICA ==============\n");
            sb.Append("\t=======================================\n");
            sb.AppendFormat("\n\tCapacidad del deposito: {0}\n\n", this.capacidadDeposito);
            sb.AppendLine(MostrarProductos());
            return sb.ToString();
        }

        /// <summary>
        /// Vende un producto de la artistica.
        /// </summary>
        /// <param name="artistica">La artistica de la cual se va a vender el producto.</param>
        /// <param name="producto">El producto a vender.</param>
        public void Vender(Artistica artistica, Producto producto)
        {
            artistica -= producto;
            Console.WriteLine("Se realizo la venta exitosamente.");
        }

        /// <summary>
        /// Guarda la informacion del negocio en un archivo xml.
        /// </summary>
        /// <param name="path">La ruta del archivo.</param>
        /// <param name="artistica">El negocio a guardar.</param>
        /// <returns>Devuelve True si se pudo guardar exitosamente, False si no se pudo.</returns>
        public static bool Guardar(string path, Artistica artistica)
        {
            bool retorno = false;
            Xml<Artistica> xml = new Xml<Artistica>();
            retorno = xml.Guardar(path, artistica);
            return retorno;
        }

        /// <summary>
        /// Permite leer la informacion del negocio desde un archivo xml.
        /// </summary>
        /// <returns>Devuelve el negocio con los datos cargados si se pudo leer exitosamente. 
        /// Caso contrario se devuelve el negocio vacio.</returns>
        public static string Leer()
        {
            Artistica artistica = new Artistica();
            Xml<Artistica> xml = new Xml<Artistica>();
            try
            {
                xml.Leer("Artistica.xml", out artistica);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }
            return artistica.ToString();
        }

        /// <summary>
        /// Verifica si un objeto es de tipo artistica.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>Devuelve True si son iguales. Caso contrario devuelve False.</returns>
        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Artistica)
            {
                ret = this == (Artistica)obj;
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
        /// Una artistica es igual a un producto si el producto esta en la lista de
        /// productos de la artistica.
        /// </summary>
        /// <param name="artistica">La artistica a comparar.</param>
        /// <param name="producto">El producto a comparar.</param>
        /// <returns>Devuelve True si son iguales. Caso contrario devuelve False.</returns>
        public static bool operator ==(Artistica artistica, Producto producto)
        {
            bool retorno = false;
            if ((object)artistica != null && (object)producto != null)
            {
                if (artistica.productos.Contains(producto))
                {
                    retorno = true;
                }
            }
            return retorno;
        }

        /// <summary>
        /// Una artistica es distinta a un producto si el producto no esta en la lista de
        /// productos de la artistica.
        /// </summary>
        /// <param name="artistica">La artistica a comparar.</param>
        /// <param name="producto">El producto a comparar.</param>
        /// <returns>Devuelve True si son distintos. Caso contrario devuelve False.</returns>
        public static bool operator !=(Artistica artistica, Producto producto)
        {
            return !(artistica == producto);
        }

        /// <summary>
        /// Sobrecarga del operador +. Se agrega un producto al negocio si no esta repetido
        /// y si hay espacio disponible. Caso contrario se lanzan las excepciones correspondientes.
        /// </summary>
        /// <param name="artistica">El negocio al cual se va a agregar el producto.</param>
        /// <param name="producto">El producto a agregar.</param>
        /// <returns>Devuelve la artistica con el producto agregado. Caso contrario, no se hacen cambios.</returns>
        public static Artistica operator +(Artistica artistica, Producto producto)
        {
            if (artistica != producto)
            {
                if (artistica.capacidadDeposito > artistica.Productos.Count)
                {
                    artistica.productos.Add(producto);
                }
                else
                {
                    throw new DepositoLlenoException();
                }
            }
            else
            {
                throw new ProductoRepetidoException();
            }
            return artistica;
        }

        /// <summary>
        /// Sobrecarga del operador -. Se quita un producto del negocio si se encuentra en él.
        /// Caso contrario, se lanza la excepcion correspondiente.
        /// </summary>
        /// <param name="artistica">El negocio al cual se le va a quitar el producto.</param>
        /// <param name="producto">El producto a quitar.</param>
        /// <returns>Devuelve la artistica con el producto quitado. Caso contrario, no se hacen cambios.</returns>
        public static Artistica operator -(Artistica artistica, Producto producto)
        {
            if (artistica == producto)
            {
                artistica.productos.Remove(producto);
            }
            else
            {
                throw new FueraDeStockException();
            }
            return artistica;
        }
        #endregion
    }
}

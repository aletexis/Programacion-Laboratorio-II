using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;
using Archivos;

namespace Entidades
{
    public class Artistica
    {
        private List<Producto> productos;
        private List<Venta> ventas;
        private int capacidadDeposito;

        #region Propiedades
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
        /// <param name="capacidadDeposito"></param>
        public Artistica(int capacidadDeposito)
            : this()
        {
            this.capacidadDeposito = capacidadDeposito;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Realiza la venta de un producto agregandolo a la lista de ventas.
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="cantidad"></param>
        public void Vender(Producto producto, int cantidad)
        {
            Venta nuevaVenta = new Venta(producto, cantidad);
            this.ventas.Add(nuevaVenta);
        }

        /// <summary>
        /// Muestra un listado de ventas realizadas.
        /// </summary>
        /// <returns></returns>
        public string MostrarVentas()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\t*** VENTAS ***************************\n");
            foreach (Venta v in Ventas)
            {
                sb.AppendLine(v.ToString());
            }
            sb.AppendLine("\t**************************************");

            return sb.ToString();
        }

        /// <summary>
        /// Muestra un listado de productos.
        /// </summary>
        /// <returns></returns>
        public string MostrarProductos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\t--- PRODUCTOS ------------------------\n");
            foreach (Producto p in Productos)
            {
                sb.AppendLine(p.ToString());
            }
            sb.AppendLine("\t------------------------------------");

            return sb.ToString();
        }

        /// <summary>
        /// Guarda la informacion del negocio en un archivo xml.
        /// </summary>
        /// <param name="artistica"></param>
        /// <returns></returns>
        public static bool Guardar(Artistica artistica)
        {
            try
            {
                string path = System.IO.Directory.GetCurrentDirectory()
                    + @"\ArchivosGuardados";
                System.IO.Directory.CreateDirectory(path);
                Xml<Artistica> archivo = new Xml<Artistica>();
                return archivo.Guardar((path + @"\Artistica.xml"), artistica);
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }
        /// <summary>
        /// Permite leer la informacion del negocio desde un archivo xml.
        /// </summary>
        /// <returns></returns>
        public static Artistica Leer()
        {
            try
            {
                Artistica artistica = new Artistica();
                Xml<Artistica> archivo = new Xml<Artistica>();
                archivo.Leer((System.IO.Directory.GetCurrentDirectory()
                    + @"\ArchivosGuardados\Artistica.xml"), out artistica);
                return artistica;
            }
            catch (Exception e)
            {
                throw new ArchivosException(e);
            }
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga del operador ==. Dos productos son iguales si tienen el mismo codigo.
        /// </summary>
        /// <param name="artistica"></param>
        /// <param name="producto"></param>
        /// <returns>Retorna true si son iguales, false si no lo son.</returns>
        public static bool operator ==(Artistica artistica, Producto producto)
        {
            foreach (Producto p in artistica.productos)
            {
                if (p.Codigo == producto.Codigo)
                {
                    return true;
                }
            }
            return false;
        }
        /// <summary>
        /// Sobrecarga del operador !=. Dos productos son distintos si no tienen el mismo codigo.
        /// </summary>
        /// <param name="artistica"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static bool operator !=(Artistica artistica, Producto producto)
        {
            return !(artistica == producto);
        }
        #endregion

        /// <summary>
        /// Sobrecarga del operador +. Se agrega un producto al negocio si no esta repetido
        /// y si hay espacio disponible.
        /// </summary>
        /// <param name="artistica"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
        public static Artistica operator +(Artistica artistica, Producto producto)
        {
            if (artistica != producto)
            {
                if (artistica.capacidadDeposito > artistica.productos.Count)
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
        /// Sobrecarga del operador -. Se saca un producto del negocio si se encuentra en él.
        /// </summary>
        /// <param name="artistica"></param>
        /// <param name="producto"></param>
        /// <returns></returns>
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
    }
}

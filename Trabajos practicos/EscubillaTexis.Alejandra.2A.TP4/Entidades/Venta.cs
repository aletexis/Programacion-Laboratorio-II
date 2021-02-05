using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;
using Archivos;
using System.IO;

namespace Entidades
{
    public class Venta
    {
        #region Atributos
        public List<Producto> listaProductos;
        public int capacidad;
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto. Inicializa la lista de productos.
        /// </summary>
        public Venta()
        {
            this.listaProductos = new List<Producto>();
        }
        /// <summary>
        /// Constructor que inicializa la capacidad maxima de productos que se venden.
        /// </summary>
        /// <param name="capacidad"></param>
        public Venta(int capacidad) : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Muestra el listado de productos (carrito) de una venta determinada.
        /// </summary>
        /// <param name="venta">Venta a la que pertenecen los productos.</param>
        /// <returns>Devuelve la lista de productos de una venta.</returns>
        private static string MostrarVentas(Venta venta)
        {
            StringBuilder sb = new StringBuilder();

            if (venta.listaProductos != null)
            {
                foreach (Producto item in venta.listaProductos)
                {
                    sb.Append(item.ToString());
                    sb.AppendLine("\n*************************************************\n");
                }
            }

            return sb.ToString();
        }

        /// <summary>
        /// Hace publicas las ventas efectuadas.
        /// </summary>
        /// <returns>Devuelve las ventas en formato string.</returns>
        public override string ToString()
        {
            return MostrarVentas(this);
        }

        /// <summary>
        /// Calcula el precio final de un producto multiplicando el precio unitario
        /// por la cantidad seleccionada.
        /// </summary>
        /// <param name="precioUnidad">El precio unitario del producto.</param>
        /// <param name="cantidad">La cantidad seleccionada del producto.</param>
        /// <returns>Devuelve el precio final del producto.</returns>
        public static float CalcularPrecioFinal(float precioUnidad, int cantidad)
        {
            return precioUnidad * cantidad;
        }

        /// <summary>
        /// Imprime en un archivo de texto el ticket de la venta.
        /// </summary>
        /// <param name="producto">El producto del cual se va a imprimir el ticket.</param>
        /// <returns>Devuelve True si se pudo imprimir el ticket. Caso contrario, devuelve False.</returns>
        public static bool ImprimirTicket(Producto producto)
        {
            bool retorno = false;

            StringBuilder sb = new StringBuilder();
            sb.AppendLine("********************************************");
            sb.AppendLine($"Fecha y Hora: {DateTime.Now}");
            sb.AppendLine(producto.ToString());
            sb.AppendLine($"Total: ${producto.Precio}");
            sb.AppendLine("********************************************");

            try
            {
                using (StreamWriter sw = new StreamWriter("Tickets.log", true))
                {
                    sw.WriteLine(sb.ToString());
                }

                retorno = true;
            }
            catch (Exception)
            {
                throw new ArchivosException();
            }

            return retorno;
        }

        /// <summary>
        /// Guarda en un archivo de texto una venta.
        /// </summary>
        /// <param name="venta">La venta a guardar.</param>
        /// <returns>Devuelve True si se pudo guardar. Caso contrario, devuelve false.</returns>
        public static bool Guardar(Venta venta)
        {
            Texto texto = new Texto();
            return texto.Guardar("Ventas.log", venta.ToString());
        }

        /// <summary>
        /// Lee un archivo de texto de ventas. 
        /// </summary>
        /// <returns>Devuelve el contenido del archivo en string.</returns>
        public static string Leer()
        {
            string datos = "";
            try 
            {
                Texto texto = new Texto();
                texto.Leer("Ventas.log", out datos);
            }
            catch(Exception e)
            {

                Console.WriteLine("No se pudo leer el archivo.");
            }

            return datos;
        }

        /// <summary>
        /// Verifica si un objeto es de tipo Venta.
        /// </summary>
        /// <param name="obj">El objeto a comparar.</param>
        /// <returns>Devuelve True si son iguales. Caso contario, devuelve False.</returns>
        public override bool Equals(object obj)
        {
            bool ret = false;
            if (obj is Venta)
            {
                ret = this == (Venta)obj;
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
        /// Sobrecarga del operador ==.Una venta y un producto son iguales si este pertenece a la misma.
        /// </summary>
        /// <param name="venta">La venta a comparar.</param>
        /// <param name="producto">El producto a comparar.</param>
        /// <returns>Devuelve True si son iguales. Caso contrario, devuelve False.</returns>
        public static bool operator ==(Venta venta, Producto producto)
        {
            bool retorno = false;

            if ((object)venta != null)
            {
                foreach (Producto item in venta.listaProductos)
                {
                    if (item == producto)
                    {
                        retorno = true;
                        break;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador !=.Una venta y un producto son distintos si este no pertenece a la misma.
        /// </summary>
        /// <param name="venta">La venta a comparar.</param>
        /// <param name="producto">El producto a comparar.</param>
        /// <returns>Devuelve True si son distintos. Caso contrario, devuelve False.</returns>
        public static bool operator !=(Venta venta, Producto producto)
        {
            return !(venta == producto);
        }

       /// <summary>
       /// Sobrecarga del operador +. Agrega un producto a la venta si este no se encuentra en la misma.
       /// </summary>
       /// <param name="venta">La venta a la que se va a agregar el producto.</param>
       /// <param name="producto">El producto a agregar.</param>
       /// <returns>La venta con el producto cargado. Caso contrario, la venta sin cambios.</returns>
       public static Venta operator +(Venta venta, Producto producto)
       {
           try
           {
               if (venta.capacidad > venta.listaProductos.Count)
               {
                   if (venta != producto)
                   {
                       venta.listaProductos.Add(producto);
                   }
                   else
                   {
                       Console.WriteLine("El producto ya se encuentra en el carrito.");
                   }
               }
               else
               {
                   Console.WriteLine("No hay mas espacio disponible.");
               }
           }
           catch (Exception e)
           {
               throw new Exception("Error al agregar el producto al carrito.", e);
           }

           return venta;
       }

        /// <summary>
        /// Sobrecarga del operador -. Quita un elemento de la lista de ventas (carrito) al ser vendido.
        /// </summary>
        /// <param name="venta">La venta a la que se va a quitar el producto.</param>
        /// <param name="producto">El producto a quitar.</param>
        /// <returns>La venta con el producto quitado. Caso contrario, la venta sin cambios.</returns>
        public static Venta operator -(Venta venta, Producto producto)
        {
           try
           {
               if (venta.capacidad > 0)
               {
                   if (venta == producto)
                   {
                        venta.listaProductos.Remove(producto);
                        Venta.ImprimirTicket(producto);
                        Console.WriteLine($"{producto} vendido/a.\n");
                   }
                   else
                   {
                       Console.WriteLine("El producto no se encuentra en el deposito.");
                   }
               }
               else
               {
                    Console.WriteLine("No hay productos para vender.");
               }
           }
           catch (Exception)
           {
               Console.Write("Error al vender el producto.");
           }
           return venta;    
        }
        #endregion      
    }
}


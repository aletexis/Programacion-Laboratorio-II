using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public sealed class Venta
    {
        #region Atributos
        private DateTime fecha;
        private int cantidad;
        private Producto producto;
        private double precioFinal;
        #endregion

        #region Propiedades
        internal DateTime Fecha
        {
            get
            {
                return this.fecha;
            }
            set
            {
                this.fecha = value;
            }
        }
        private int Cantidad
        {
            get
            {
                return this.cantidad;
            }
            set
            {
                this.cantidad = value;
            }
        }
        public Producto Producto
        {
            get
            {
                return this.producto;
            }
            set
            {
                this.producto = value;
            }
        }
        public double PrecioFinal
        {
            get
            {
                return this.precioFinal;
            }
            set
            {
                this.precioFinal = value;
            }
        }
        #endregion

        #region Constructores
        public Venta()
        { 
        }
        public Venta(Producto producto, int cantidad)
        {
            this.cantidad = cantidad;
            this.producto = producto;
            this.Vender(cantidad);
        }
        #endregion

        #region Metodos
        private void Vender(int cantidad)
        {
            producto.Stock -= cantidad;
            this.fecha = DateTime.Now;
            this.precioFinal = Venta.CalcularPrecioFinal(producto.Precio, cantidad);
        }

        public static double CalcularPrecioFinal(float precioUnidad, int cantidad)
        {
            return precioUnidad * cantidad;
        }
                
        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("\tFecha: " + this.fecha);
            sb.AppendLine("\tCantidad: " + this.cantidad);
            sb.AppendLine("\tProducto: " + this.producto.Nombre);
            sb.AppendLine("\tPrecio: " + this.precioFinal);

            return sb.ToString();
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
        #endregion
    }
}

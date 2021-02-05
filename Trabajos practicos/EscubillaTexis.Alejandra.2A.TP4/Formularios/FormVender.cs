using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Formularios
{
    public partial class FormVender : Form
    {
        private Artistica artistica = new Artistica();
        private Venta venta = new Venta(10);
        protected Producto producto;

        /// <summary>
        /// Propiedad que permite obtener un producto.
        /// </summary>
        public Producto Producto
        {
            get
            {
                return this.producto;
            }
        }
        /// <summary>
        /// Constructor que inicializa un producto.
        /// </summary>
        /// <param name="producto"></param>
        public FormVender(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            this.lblMostrarProducto.Text = this.producto.Nombre;
        }

        /// <summary>
        /// Actualiza el precio de un producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVender_Load(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        /// <summary>
        /// A medida que se cambia la cantidad se va actualizando el
        /// precio acorde con la misma.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCantidadChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }

        /// <summary>
        /// Calcula el precio de un producto segun la cantidad seleccionada.
        /// </summary>
        private void ActualizarPrecio()
        {
            int cantidadSeleccionada = (int)this.numericUpDownCantidad.Value;
            float precioFinal = Venta.CalcularPrecioFinal(this.producto.Precio, cantidadSeleccionada);
            this.lblPrecio.Text = String.Format("Precio Final:       $");
            this.lblPrecioFinal.Text = String.Format("{0:0.00}", precioFinal);
        }

        /// <summary>
        /// VEnde un producto.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVender_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionada = (int)this.numericUpDownCantidad.Value;
            float precioFinal = float.Parse(this.lblPrecioFinal.Text);

            if (producto.Stock >= cantidadSeleccionada)
            {
                producto.Precio = precioFinal;
                venta += producto;
                Venta.Guardar(venta);
                artistica.Ventas.Add(venta);
                producto.Stock -= cantidadSeleccionada;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay stock para la cantidad seleccionada.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Cancela los cambios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

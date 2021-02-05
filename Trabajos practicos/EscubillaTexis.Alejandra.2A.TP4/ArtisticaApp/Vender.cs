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

namespace ArtisticaApp
{
    public partial class Vender : Form
    {
        protected Producto producto;
        private Artistica artistica = new Artistica();

        public Vender(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
        }


        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.lblMostrarProducto.Text = this.producto.Nombre;
            ActualizarPrecio();
        }


        private void OnCantidadChanged(object sender, EventArgs e)
        {
            ActualizarPrecio();
        }


        private void ActualizarPrecio()
        {
            int cantidadSeleccionada = (int)this.numericUpDownCantidad.Value;
            double nuevoPrecioFinal = Venta.CalcularPrecioFinal(this.producto.Precio, cantidadSeleccionada);
            this.lblPrecioFinal.Text = String.Format("Precio Final: ${0:0.00}", nuevoPrecioFinal);
        }


        private void btnVender_Click(object sender, EventArgs e)
        {
            int cantidadSeleccionada = (int)this.numericUpDownCantidad.Value;

            if (producto.Stock >= cantidadSeleccionada)
            {
                this.artistica.Vender(this.producto, cantidadSeleccionada);
                this.DialogResult = DialogResult.OK;
                MessageBox.Show("Venta realizada!");
                this.Close();
            }
            else
            {
                MessageBox.Show("No hay stock para la cantidad seleccionada.", "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}

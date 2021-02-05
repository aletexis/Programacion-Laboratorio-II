using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArtisticaApp
{
    public partial class Principal : Form
    {
        #region Constructor
        public Principal()
        {
            InitializeComponent();
        }
        #endregion

        #region Manejadores de eventos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            Productos formProductos = new Productos();
            formProductos.Show();

        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            Ventas formVentas = new Ventas();
            formVentas.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}

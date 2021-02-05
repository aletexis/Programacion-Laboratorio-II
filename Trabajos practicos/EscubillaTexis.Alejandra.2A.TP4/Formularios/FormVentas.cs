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
    public partial class FormVentas : Form
    {
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FormVentas()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga un archivo con las ventas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.richTextBoxVentas.Text = Venta.Leer();
        }
    }
}

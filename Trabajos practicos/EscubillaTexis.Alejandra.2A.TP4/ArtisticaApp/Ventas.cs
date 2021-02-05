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
    public partial class Ventas : Form
    {
        private Artistica artistica = new Artistica();
       
        public Ventas()
        {
            InitializeComponent();
        }

        private void VentasForm_Load(object sender, EventArgs e)
        {
            this.listBoxVentas.Text = this.artistica.MostrarVentas();
        }

    }
}

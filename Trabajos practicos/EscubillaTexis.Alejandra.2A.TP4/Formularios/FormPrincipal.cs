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
using System.Threading;

namespace Formularios
{
    public partial class formPrincipal : Form
    {
        Thread hilo;
        public delegate void DelegadoFechaHora();
        public event DelegadoFechaHora Evento;

        #region Constructor
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public formPrincipal()
        {
            InitializeComponent();
            this.hilo = new Thread(Actualizar);
            this.Evento += ActualizarFechaHora;
            this.hilo.Start();
        }
        #endregion

        #region Manejadores de eventos
        /// <summary>
        /// Inicia el form de productos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnProductos_Click(object sender, EventArgs e)
        {
            FormProductos formProductos = new FormProductos();
            formProductos.Show();

        }

        /// <summary>
        /// Inicia el form de ventas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVentas_Click(object sender, EventArgs e)
        {
            FormVentas formVentas = new FormVentas();
            formVentas.Show();
        }

        /// <summary>
        /// Cierra el programa.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Pregunta si se desea salir y mata el hilo si esta vivo.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void formPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.Yes)
            {
                e.Cancel = false;
                if (this.hilo.IsAlive)
                {
                    this.hilo.Abort();
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Actualiza la fecha del form principal.
        /// </summary>
        public void ActualizarFechaHora()
        {
            if (this.lblFechaHora.InvokeRequired)
            {
                DelegadoFechaHora delegadoFechaHora = new DelegadoFechaHora(ActualizarFechaHora);
                this.Invoke(delegadoFechaHora);
            }
            else
            {
                this.lblFechaHora.Text = DateTime.Now.ToString();
            }
        }

        /// <summary>
        /// Actualiza la hora cada 1 segundo.
        /// </summary>
        public void Actualizar()
        {
            do
            {
                Thread.Sleep(100);
                this.Evento();
            } while (true);
        }
        #endregion

    }
}

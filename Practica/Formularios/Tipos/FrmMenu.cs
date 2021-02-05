using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tipos
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();

            //INDICO QUE VA A SER UN FORM CONTENEDOR
            this.IsMdiContainer = true;
            //MUESTRO EL FORM MAXIMIZADO
            this.WindowState = FormWindowState.Maximized;
        }
        private void NormalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForm frmNormal = new FrmForm();

            frmNormal.StartPosition = FormStartPosition.CenterScreen;

            //LO MUESTRO EN FORMA 'NORMAL'
            frmNormal.Show();

            //MUESTRO EL MENSAJE OBTENIDO DEL FORM, SOLO SI SE PULSO 'ACEPTAR'
            if (frmNormal.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(frmNormal.ObtenerMensaje());
            }
            
        }

        private void ContenidoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForm frmContenido = new FrmForm();

            frmContenido.StartPosition = FormStartPosition.CenterScreen;

            //INDICO QUIEN SERA EL FORMULARIO PADRE
            frmContenido.MdiParent = this;

            //MUESTRO EL FORMULARIO
            frmContenido.Show();
        }

        private void PropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForm frmPropietario = new FrmForm();

            frmPropietario.StartPosition = FormStartPosition.CenterScreen;

            //MUESTRO EL FORMULARIO CON SU 'DUEÑO'
            frmPropietario.Show(this);
        }

        private void DialogoOModalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmForm frmDialogo = new FrmForm();

            frmDialogo.StartPosition = FormStartPosition.CenterScreen;

            //LO MUESTRO EN FORMA 'MODAL'
            frmDialogo.ShowDialog();

            //MUESTRO EL MENSAJE OBTENIDO DEL FORM, SOLO SI SE PULSO 'ACEPTAR'
            if (frmDialogo.DialogResult == DialogResult.OK)
            {
                MessageBox.Show(frmDialogo.ObtenerMensaje());
            }

        }

        private void SalirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

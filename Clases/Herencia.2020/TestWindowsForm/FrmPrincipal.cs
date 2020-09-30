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

namespace HerenciaWindowsForm
{
    public partial class FrmPrincipal : Form
    {
        private Empresa miEmpresa;

        public FrmPrincipal()
        {
            InitializeComponent();

            this.IsMdiContainer = true;
            this.WindowState = FormWindowState.Maximized;
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult rta = MessageBox.Show("¿Está seguro de salir?", "ATENCION", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rta == DialogResult.OK)
            {
                MessageBox.Show("¡Quedate en casa!");
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEmpresa frm = new FrmEmpresa();

            frm.MdiParent = this;

            frm.Show();
        }
    }
}

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

namespace FormularioVinoVinoteca
{
    public partial class FrmVinoteca : Form
    {
        private Vinoteca miVinoteca;

        public FrmVinoteca()
        {
            InitializeComponent();

            this.miVinoteca = new Vinoteca(5);

            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmVinoteca_Load(object sender, EventArgs e)
        {           
            this.txtVisor.Text = this.miVinoteca.Mostrar();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            FrmVino frm = new FrmVino();

            frm.StartPosition = FormStartPosition.CenterScreen;

            DialogResult rta = frm.ShowDialog();

            if (rta == DialogResult.OK)
            {
                this.miVinoteca += frm.ObtenerVino();

                this.txtVisor.Clear();
                this.txtVisor.Text = this.miVinoteca.Mostrar();
            }
        }
    }
}

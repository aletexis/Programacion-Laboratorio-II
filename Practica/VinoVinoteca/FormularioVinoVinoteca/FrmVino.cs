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
    public partial class FrmVino : Form
    {
        private Vino miVino;

        public FrmVino()
        {
            InitializeComponent();
        }

        public Vino ObtenerVino()
        {
            return this.miVino; 
        }

        private void Vino_Load(object sender, EventArgs e)
        {
            foreach (ETipoVino item in Enum.GetValues(typeof(ETipoVino)))
            {
                this.cboTipoVino.Items.Add(item);
            }

            foreach (EBodega item in Enum.GetValues(typeof(EBodega)))
            {
                this.cboBodega.Items.Add(item);
            }

            this.cboBodega.SelectedItem = EBodega.Zuccardi;
            this.cboTipoVino.SelectedItem = ETipoVino.Merlot;

            this.cboTipoVino.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cboBodega.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ETipoVino tipo = (ETipoVino)this.cboTipoVino.SelectedItem;
            EBodega bodega = (EBodega)this.cboBodega.SelectedItem;

            this.miVino = new Vino(tipo, bodega);

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

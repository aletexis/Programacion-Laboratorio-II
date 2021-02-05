using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    public partial class FrmCheckBox : Form
    {
        private string cadenaOriginal;

        public FrmCheckBox()
        {
            // Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent();

            this.cadenaOriginal = "Estamos visualizando una cadena";
            this.lblMuestra.Text = cadenaOriginal;

            //COLOCO EL ESTADO EN 'IDETERMINADO'
            this.chkMostrar.CheckState = CheckState.Indeterminate;
        }

        //ESTE EVENTO SE PRODUCE CUANDO SE HACE CLICK EN EL CHECKBOX Y 
        //CAMBIA EL CONTENIDO DE LA CASILLA
        private void chkColor_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkColor.CheckState == CheckState.Checked)
                this.BackColor = Color.LightBlue;
            else
                this.ResetBackColor();
        }

        //ESTE EVENTO SE PRODUCE CUANDO CAMBIA EL ESTADO DE LA CASILLA
        private void chkMostrar_CheckedChanged(object sender, EventArgs e)
        {
            switch (this.chkMostrar.CheckState)
            {
                case CheckState.Checked:
                    this.lblMuestra.Text = this.cadenaOriginal;
                    break;
                case CheckState.Indeterminate:
                    this.lblMuestra.Text = "";
                    break;
                case CheckState.Unchecked:
                    this.lblMuestra.Text = this.cadenaOriginal.Substring(0, (this.cadenaOriginal.Length / 2));
                    break;
                default:
                    break;
            }

        }
    }
}

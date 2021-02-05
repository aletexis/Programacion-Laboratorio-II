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
    public partial class FrmInicio : Form
    {
        //DECLARO ATRIBUTO
        private Ejemplo seleccion;

        //DECLARO GETTER
        public Ejemplo ObtenerSeleccion()
        {
            return this.seleccion;
        }

        public FrmInicio()
        {
            // Llamada necesaria para el Diseñador de Windows Forms.
            InitializeComponent();

            //NECESITO UTILIZAR EL METODO GETVALUES PARA OBTENER UN ARRAY
            //Y ASI PODER RECORRERLO CON UN FOREACH
            foreach (Ejemplo elementoEnumerado in Enum.GetValues(typeof(Ejemplo)))
            {
                this.cboEjemplos.Items.Add(elementoEnumerado);
            }

            //ELIGO EL ESTILO DEL COMBO
            this.cboEjemplos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void cboEjemplos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Ejemplo miEjemplo;

            miEjemplo = (Ejemplo)this.cboEjemplos.SelectedItem;

            this.seleccion = miEjemplo;

            //CIERRO EL FORMULARIO DE INICIO
            this.Close();
        }
    }
}

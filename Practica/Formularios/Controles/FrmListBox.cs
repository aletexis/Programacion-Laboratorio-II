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
    public partial class FrmListBox : Form
    {
        //CONSTANTE UTILIZADA EN EL TITULO DEL FORMULARIO, JUNTO AL 
        //ELEMENTO SELECCIONADO
        public const string TITULO = "Elemento seleccionado: ";

        public FrmListBox()
        {
            InitializeComponent();
        }

        //ESTE EVENTO SE PRODUCE CADA VEZ QUE CAMBIA EL INDICE SELECCIONADO
        private void lstValores_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MUESTRO EL VALOR SELECCIONADO DEL LISTBOX
            this.Text = TITULO + this.lstValores.SelectedItem;
        }

        private void rdoUno_CheckedChanged(object sender, EventArgs e)
        {
            //SELECCIONO EL TIPO DE SELECCION DEL LISTBOX A "UNO"
            this.lstValores.SelectionMode = SelectionMode.One;
        }

        private void rdoMultiple_CheckedChanged(object sender, EventArgs e)
        {
            //SELECCIONO EL TIPO DE SELECCION DEL LISTBOX A "MULTIPLES"
            this.lstValores.SelectionMode = SelectionMode.MultiSimple;
        }

        private void rdoExtendida_CheckedChanged(object sender, EventArgs e)
        {
            //SELECCIONO EL TIPO DE SELECCION DEL LISTBOX A "MULTIPLES DE MODO EXTENDIDO"
            this.lstValores.SelectionMode = SelectionMode.MultiExtended;
        }

        private void chkOrdenar_CheckedChanged(object sender, EventArgs e)
        {
            //SEGUN EL VALOR DEL CHECKBOX, ORDENO O NO
            this.lstValores.Sorted = this.chkOrdenar.Checked;
        }

        private void chkColumnas_CheckedChanged(object sender, EventArgs e)
        {
            //SEGUN EL VALOR DEL CHECKBOX, MUESTRO EN UNA O VARIAS COLUMNAS
            this.lstValores.MultiColumn = this.chkColumnas.Checked;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //AGREGO EL CONTENIDO DEL TEXTBOX COMO ELEMENTO DE LA LISTA
            this.lstValores.Items.Add(this.txtValor.Text);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int posicion = 0;

            //EL METODO 'FINDSTRING' BUSCA UN VALOR EN LA LISTA
            posicion = this.lstValores.FindString(this.txtValor.Text);

            //EL CAMPO 'NOMATCHES' INDICA SI NO EXISTE EL VALOR BUSCADO
            if (posicion == ListBox.NoMatches)
                MessageBox.Show("No existe el valor");
            else
                this.lstValores.SelectedIndex = posicion;

        }

        private void btnSeleccinarCod_Click(object sender, EventArgs e)
        {
            //SI ES CORRECTO EL VALOR DEL INDICE, LO SELECCIONO
            if (this.EsIndiceCorrecto())
            {
                this.rdoUno.Checked = true;
                int indice = int.Parse(this.txtCodigo.Text);

                //PARA SELECCIONAR ELEMENTOS POR CODIGO, SE PUEDE 
                //UTILIZAR EL METODO 'SETSELECTED'
                this.lstValores.SetSelected(indice, true);
            }
        }

        private void btnTraspasar_Click(object sender, EventArgs e)
        {
            //DECLARO VARIABLE DE TIPO 'SELECTEDOBJECTCOLLECTION'
            ListBox.SelectedObjectCollection seleccion;

            //OBTENGO LOS ELEMENTOS SELECCIONADOS
            seleccion = this.lstValores.SelectedItems;

            if (seleccion.Count > 0)
            {
                System.Collections.IEnumerator enumerador;

                enumerador = seleccion.GetEnumerator();

                while (enumerador.MoveNext())
                {
                    this.lstTraspaso.Items.Add(enumerador.Current);
                }
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //LIMPIO EL LISTBOX
            this.lstTraspaso.Items.Clear();
        }

        #region Función Privada
        private Boolean EsIndiceCorrecto()
        {

            if (String.IsNullOrEmpty(this.txtCodigo.Text) || !EsNumero(this.txtCodigo.Text))
            {
                MessageBox.Show("Debe ingresar un valor numérico");
                return false;
            }

            int indice = int.Parse(this.txtCodigo.Text);

            if (indice > this.lstValores.Items.Count - 1 || indice < 0)
            {
                MessageBox.Show("Debe ingresar un valor numérico entre 0 y " + (this.lstValores.Items.Count - 1).ToString());
                return false;
            }

            return true;

        }

        private Boolean EsNumero(string valor)
        {
            bool resultado = true;

            foreach (char item in valor.ToCharArray())
            {
                if (!Char.IsDigit(item))
                {
                    resultado = false;
                    break;
                }
            }

            return resultado;
        }
        #endregion
    }
}

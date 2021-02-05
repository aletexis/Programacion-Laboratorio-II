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
    public partial class Agregar : Form
    {
        protected Entidades.Producto p;

        #region Propiedad
        public Entidades.Producto Producto
        {
            get
            {
                return this.p;
            }
        }
        #endregion

        #region Constructor
        public Agregar()
        {
            InitializeComponent();
            this.lblDescripcion.Hide();
            this.cmbDescripcion.Hide();
        }
        public Agregar(Entidades.Producto p) 
            : this()
        {
            this.p = p;

            this.txtId.Text = p.Codigo.ToString();
            //producto
            //descripcion
            this.txtMarca.Text = p.Marca;
            this.numericUpDownStock.Value = p.Stock;
            this.txtPrecio.Text = p.Precio.ToString();
        }
        #endregion

        #region Metodos

        #endregion

        #region Manejadores de eventos
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbProducto.SelectedIndex)
            {
                case 0:
                    this.cmbDescripcion.Items.Remove("Acuarela");
                    this.cmbDescripcion.Items.Remove("Tempera");
                    this.cmbDescripcion.Items.Remove("Acrilico");
                    this.cmbDescripcion.Items.Remove("Pastel");
                    this.cmbDescripcion.Items.Remove("Chico");
                    this.cmbDescripcion.Items.Remove("Mediano");
                    this.cmbDescripcion.Items.Remove("Grande");
                    this.cmbDescripcion.Items.Add("Redondo");
                    this.cmbDescripcion.Items.Add("Plano");
                    this.cmbDescripcion.Items.Add("Abanico");
                    this.lblDescripcion.Text = "Tipo";
                    this.lblDescripcion.Show();
                    this.cmbDescripcion.Show();
                    break;
                case 1:
                    this.cmbDescripcion.Items.Remove("Redondo");
                    this.cmbDescripcion.Items.Remove("Plano");
                    this.cmbDescripcion.Items.Remove("Abanico");
                    this.cmbDescripcion.Items.Remove("Chico");
                    this.cmbDescripcion.Items.Remove("Mediano");
                    this.cmbDescripcion.Items.Remove("Grande");
                    this.cmbDescripcion.Items.Add("Acuarela");
                    this.cmbDescripcion.Items.Add("Tempera");
                    this.cmbDescripcion.Items.Add("Acrilico");
                    this.cmbDescripcion.Items.Add("Pastel");
                    this.lblDescripcion.Text = "Tipo";
                    this.lblDescripcion.Show();
                    this.cmbDescripcion.Show();
                    break;
                case 2:
                    this.cmbDescripcion.Items.Remove("Acuarela");
                    this.cmbDescripcion.Items.Remove("Tempera");
                    this.cmbDescripcion.Items.Remove("Acrilico");
                    this.cmbDescripcion.Items.Remove("Pastel");
                    this.cmbDescripcion.Items.Remove("Redondo");
                    this.cmbDescripcion.Items.Remove("Plano");
                    this.cmbDescripcion.Items.Remove("Abanico");
                    this.cmbDescripcion.Items.Add("Chico");
                    this.cmbDescripcion.Items.Add("Mediano");
                    this.cmbDescripcion.Items.Add("Grande");
                    this.lblDescripcion.Text = "Tamaño";
                    this.lblDescripcion.Show();
                    this.cmbDescripcion.Show();
                    break;
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.txtId.Text;
                id = id == "" ? "0" : id;


                switch (this.cmbProducto.SelectedIndex)
                {
                    case 0:
                        this.p = new Pincel(int.Parse(id), "Pincel", this.txtMarca.Text,
                              (int)numericUpDownStock.Value, float.Parse(this.txtPrecio.Text),
                              (ETipoPincel)Enum.Parse(typeof(ETipoPincel), this.cmbDescripcion.Text.ToString()));

                        this.DialogResult = DialogResult.OK;
                        break;

                    case 1:
                        this.p = new Pintura(int.Parse(id), "Pintura", this.txtMarca.Text,
                            (int)numericUpDownStock.Value, float.Parse(this.txtPrecio.Text),
                            (ETipoPintura)Enum.Parse(typeof(ETipoPintura), this.cmbDescripcion.Text.ToString()));

                        this.DialogResult = DialogResult.OK;
                        break;

                    case 2:
                        this.p = new Bastidor(int.Parse(id), "Bastidor", this.txtMarca.Text,
                            (int)numericUpDownStock.Value, float.Parse(this.txtPrecio.Text),
                            (ETamaño)Enum.Parse(typeof(ETamaño), this.cmbDescripcion.Text.ToString()));

                        this.DialogResult = DialogResult.OK;
                        break;

                    default:
                        MessageBox.Show("No se seleccionó un producto.");
                        break;
                }
                if (Validar())
                {
                    int nuevaCodigo = int.Parse(this.txtId.Text);
                    string nuevaMarca = this.txtMarca.Text;
                    int nuevoStock = (int)this.numericUpDownStock.Value;
                    float nuevoPrecio = float.Parse(this.txtPrecio.Text);

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        #endregion

         private bool Validar()
         {
             if (String.IsNullOrWhiteSpace(this.txtMarca.Text) 
                || String.IsNullOrWhiteSpace(this.txtId.Text)
                || String.IsNullOrWhiteSpace(this.txtPrecio.Text)
                || String.IsNullOrWhiteSpace(this.cmbProducto.Text)
                || String.IsNullOrWhiteSpace(this.cmbDescripcion.Text))
             {
                MessageBox.Show("Debe completar todos los campos.");
                return false;
             }

             float nuevoPrecio;
             if (!float.TryParse(this.txtPrecio.Text, out nuevoPrecio))
             {
                MessageBox.Show("Debe ingresar un precio válido.");
                return false;
             }

            return true;
         }
     
  
    }
}

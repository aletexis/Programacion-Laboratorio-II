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

namespace Formularios
{
    public partial class FormAgregar : Form
    {
        protected Producto p;

        #region Propiedad
        /// <summary>
        /// Propiedad que permite obtener un producto.
        /// </summary>
        public Producto Producto
        {
            get
            {
                return this.p;
            }
        }
        #endregion

        #region Constructores
        /// <summary>
        /// Constructor por defecto.
        /// </summary>
        public FormAgregar()
        {
            InitializeComponent();
            this.lblDescripcion.Hide();
            this.cmbDescripcion.Hide();
        }
        /// <summary>
        /// Constructor que inicializa el codigo, la marca, el stock y
        /// el precio de un producto.
        /// </summary>
        /// <param name="p"></param>
        public FormAgregar(Producto p)
            : this()
        {
            this.p = p;

            this.txtId.Text = p.Codigo.ToString();
            this.txtMarca.Text = p.Marca;
            this.numericUpDownStock.Value = p.Stock;
            this.txtPrecio.Text = p.Precio.ToString();
        }
        #endregion

        #region Manejadores de eventos
        /// <summary>
        /// Dependiendo de que producto se seleccione permite seleccionar
        /// sus caracteristicas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (this.cmbProducto.SelectedIndex)
            {
                case 0:
                    foreach (Enum item in Enum.GetValues(typeof(ETipoPintura)))
                    {
                        this.cmbDescripcion.Items.Remove(item);
                    }
                    foreach (Enum item in Enum.GetValues(typeof(ETamaño)))
                    {
                        this.cmbDescripcion.Items.Remove(item);
                    }
                    foreach (Enum item in Enum.GetValues(typeof(ETipoPincel)))
                    {
                        this.cmbDescripcion.Items.Add(item);
                    }

                    this.lblDescripcion.Text = "Tipo";
                    this.lblDescripcion.Show();
                    this.cmbDescripcion.Show();
                    break;
                case 1:
                    foreach (Enum item in Enum.GetValues(typeof(ETipoPincel)))
                    {
                        this.cmbDescripcion.Items.Remove(item);
                    }
                    foreach (Enum item in Enum.GetValues(typeof(ETamaño)))
                    {
                        this.cmbDescripcion.Items.Remove(item);
                    }
                    foreach (Enum item in Enum.GetValues(typeof(ETipoPintura)))
                    {
                        this.cmbDescripcion.Items.Add(item);
                    }
                    this.lblDescripcion.Text = "Tipo";
                    this.lblDescripcion.Show();
                    this.cmbDescripcion.Show();
                    break;
                case 2:
                    foreach (Enum item in Enum.GetValues(typeof(ETipoPintura)))
                    {
                        this.cmbDescripcion.Items.Remove(item);
                    }
                    foreach (Enum item in Enum.GetValues(typeof(ETipoPincel)))
                    {
                        this.cmbDescripcion.Items.Remove(item);
                    }
                    foreach (Enum item in Enum.GetValues(typeof(ETamaño)))
                    {
                        this.cmbDescripcion.Items.Add(item);
                    }
                    this.lblDescripcion.Text = "Tamaño";
                    this.lblDescripcion.Show();
                    this.cmbDescripcion.Show();
                    break;
            }
        }

        /// <summary>
        /// Valida los datos ingresados y los guarda en la lista.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                }
                if (Validar())
                {
                    int nuevoCodigo = int.Parse(this.txtId.Text);
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

        /// <summary>
        /// Cancela los cambios.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
        #endregion

        /// <summary>
        /// Valida que los campos tengan los datos correctos.
        /// </summary>
        /// <returns></returns>
        private bool Validar()
        {
            bool retorno = true;

            if(ValidarEspaciosVacios() && ValidarPrecio() && ValidarCodigo() && ValidarStock())
            {
                retorno = false;
            }

            return retorno;
        }
        /// <summary>
        /// Valida que los campos no esten vacios.
        /// </summary>
        /// <returns></returns>
        private bool ValidarEspaciosVacios()
        {
            bool retorno = true;

            if (String.IsNullOrWhiteSpace(this.txtMarca.Text)
               || String.IsNullOrWhiteSpace(this.txtId.Text)
               || String.IsNullOrWhiteSpace(this.txtPrecio.Text)
               || String.IsNullOrWhiteSpace(this.cmbProducto.Text)
               || String.IsNullOrWhiteSpace(this.cmbDescripcion.Text))
            {
                lblMensaje.Text = "Debe completar todos los campos.";
                retorno = false;
            }

            return retorno;
        }
        /// <summary>
        /// Valida que el precio sea de tipo float.
        /// </summary>
        /// <returns></returns>
        private bool ValidarPrecio()
        {
            bool retorno = true;
            float nuevoPrecio;

            if (!float.TryParse(this.txtPrecio.Text, out nuevoPrecio))
            {
                lblMensaje.Text = "Debe ingresar un precio válido.";
                retorno = false;
            }

            return retorno;
        }
        /// <summary>
        /// Valida que el codigo sea de tipo int.
        /// </summary>
        /// <returns></returns>
        private bool ValidarCodigo()
        {
            bool retorno = true;
            int nuevoId;
            
            if (!int.TryParse(this.txtPrecio.Text, out nuevoId))
            {
                lblMensaje.Text = "Debe ingresar un código válido.";
                retorno = false;
            }

            return retorno;
        }
        /// <summary>
        /// Valida que el stock sea correcto.
        /// </summary>
        /// <returns></returns>
        private bool ValidarStock()
        {
            bool retorno = true;
            if ((int)numericUpDownStock.Value < 1)
            {
                lblMensaje.Text = "Debe haber al menos un producto en stock.";
                retorno = false;
            }

            return retorno;
        }

    }
}

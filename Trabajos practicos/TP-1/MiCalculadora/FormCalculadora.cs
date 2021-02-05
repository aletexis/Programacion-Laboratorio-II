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

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// El constructor del formulario.
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = false;
        }

        /// <summary>
        /// Vacia los campos de la calculadora.
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text = "0";
            this.cmbOperador.SelectedIndex = -1;
            this.btnConvertirADecimal.Enabled = false;
            this.btnConvertirABinario.Enabled = false;
        }

        /// <summary>
        /// Realiza una operacion determinada con los numeros ingresados.
        /// </summary>
        /// <param name="numero1">El primer numero ingresado.</param>
        /// <param name="numero2">El segundo numero ingresado.</param>
        /// <param name="operador">El operador seleccionado.</param>
        /// <returns>Devuelve el resultado de la operacion.</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            Numero num1 = new Numero(numero1);
            Numero num2 = new Numero(numero2);
            double ret = -1;

            if (numero1.Length > 0 && numero2.Length > 0)
            {
                ret = Calculadora.Operar(num1, num2, operador);
            }
            return ret;
        }

        #region Eventos

        /// <summary>
        /// El evento que muestra el resultado de la operacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.cmbOperador.Text))
            {
                this.cmbOperador.Text = "+";
            }

            this.lblResultado.Text = Convert.ToString(Operar(this.txtNumero1.Text, this.txtNumero2.Text, this.cmbOperador.Text));

            if (this.lblResultado.Text == "-1")
            {
                this.lblResultado.Text = "Error";
                btnConvertirABinario.Enabled = false;
            }
            else
            {
                btnConvertirABinario.Enabled = true;
            }
        }

        /// <summary>
        /// El evento que limpia los campos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        /// <summary>
        /// El evento que cierra la calculadora.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// El evento que convierte a binario un resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            Numero number = new Numero();

            if (!string.IsNullOrEmpty(lblResultado.Text))
            {
                this.lblResultado.Text = number.DecimalBinario(this.lblResultado.Text);
                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = true;
            }

            if(this.lblResultado.Text == "Valor inválido." || this.lblResultado.Text == "Error")
            {
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = false;
            }
        }

        /// <summary>
        /// El evento que convierte a decimal un resultado.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            Numero number = new Numero();

            if (!string.IsNullOrEmpty(lblResultado.Text))
            {
                this.lblResultado.Text = number.BinarioDecimal(this.lblResultado.Text);
                btnConvertirABinario.Enabled = true;
                btnConvertirADecimal.Enabled = true;
            }
            
            if (this.lblResultado.Text == "Valor inválido." || this.lblResultado.Text == "Error")
            {
                btnConvertirABinario.Enabled = false;
                btnConvertirADecimal.Enabled = false;
            }
        }

        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Seguro de querer salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        #endregion
    }
}

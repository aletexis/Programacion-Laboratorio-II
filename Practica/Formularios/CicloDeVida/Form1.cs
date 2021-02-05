using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CicloDeVida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Text = "Ciclo de vida";
            this.StartPosition = FormStartPosition.CenterScreen;

            MessageBox.Show("Se crea la instancia del formulario... en el CONSTRUCTOR");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario está en memoria, pero invisible... en el evento LOAD");
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            Console.WriteLine("El formulario recibe el foco... en el evento ACTIVATED");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Console.WriteLine("Se 'pinta' el formulario y sus controles... en el evento PAINT");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sale con DISPOSE...");
            this.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Permite cancelar el cierre... en el evento FORMCLOSING");

            DialogResult rta = MessageBox.Show("¿Está seguro de salir pulsando la 'X'?", "Atención",
                                                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                                                MessageBoxDefaultButton.Button2);

            if (rta == DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
                MessageBox.Show("Sigue en la aplicación");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("El formulario se cerrará... en el evento FORMCLOSED");
        }
    }
}

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
    public partial class FrmEmpresa : Form
    {
        private Empresa miEmpresa;

        public Empresa MiEmpresa
        {
            get { return  this.miEmpresa; }
        }

        public FrmEmpresa()
        {
            InitializeComponent();

            this.miEmpresa = new Empresa("Accentuna");

            this.Text = this.miEmpresa.nombre;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void FrmEmpresa_Load(object sender, EventArgs e)
        {
            this.cboOrdenamiento.SelectedIndex = 0;
            this.cboOrdenamiento.DropDownStyle = ComboBoxStyle.DropDownList;         
        }

        private void cboOrdenamiento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Comparison<Empleado> comparador = null;

            switch (this.cboOrdenamiento.SelectedIndex)
            {
                case 0:
                    comparador = Empleado.OrdernarPorLegajoAsc;
                    break;
                case 1:
                    comparador = Empleado.OrdernarPorLegajoDesc;
                    break;
                case 2:
                    comparador = Empleado.OrdernarPorSueldoAsc;
                    break;
                case 3:
                    comparador = Empleado.OrdernarPorSueldoDesc;
                    break;
                case 4:
                    comparador = Empleado.OrdernarPorApellidoAsc;
                    break;
                case 5:
                    comparador = Empleado.OrdernarPorApellidoDesc;
                    break;

                default:
                    break;
            }

            this.miEmpresa.Empleados.Sort(comparador);

            this.MostrarEnVisor();
        }

        private void MostrarEnVisor()
        {
            this.lstVisor.Items.Clear();

            foreach (Empleado item in this.miEmpresa.Empleados)
            {
                //CAMBIO EL METODO MOSTRAR POR EL TOSTRING
                this.lstVisor.Items.Add(item.ToString());
            }
        }

        private void btnAgregarAdmin_Click(object sender, EventArgs e)
        {
            //FrmAdministrativo frm = new FrmAdministrativo();

            //frm.StartPosition = FormStartPosition.CenterScreen;

            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    this.miEmpresa += frm.AdministrativoDelForm;

            //    this.MostrarEnVisor();
            //}

            this.AgregarEmpleados(sender, e);

        }

        private void btnAgregarCadete_Click(object sender, EventArgs e)
        {
            //FrmCadete frm = new FrmCadete();

            //frm.StartPosition = FormStartPosition.CenterScreen;

            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    this.miEmpresa += frm.CadeteDelForm;

            //    this.MostrarEnVisor();
            //}

            this.AgregarEmpleados(sender, e);

        }

        private void btnAgregarProg_Click(object sender, EventArgs e)
        {
            //FrmProgramador frm = new FrmProgramador();

            //frm.StartPosition = FormStartPosition.CenterScreen;

            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    this.miEmpresa += frm.ProgramadorDelForm;

            //    this.MostrarEnVisor();
            //}

            this.AgregarEmpleados(sender, e);

        }

        //AGREGO METODO CENTRALIZADO PARA MANEJAR LOS EVENTOS CLICKS DE LOS AGREGAR
        private void AgregarEmpleados(object sender, EventArgs e)
        {
            //DECLARO VARIABLE 'PADRE'
            FrmEmpleado frm = null;

            //IDENTIFICO QUE BOTON FUE PULSADO (CON EL 'SENDER')
            Button btn = (Button)sender;

            if (btn.Name == "btnAgregarAdmin")
            {
                frm = new FrmAdministrativo();
            }

            if (btn.Name == "btnAgregarCadete")
            {
                frm = new FrmCadete();
            }

            if (btn.Name == "btnAgregarProg")
            {
                frm = new FrmProgramador();
            }

            frm.StartPosition = FormStartPosition.CenterScreen;

            if (frm.ShowDialog() == DialogResult.OK)
            {
                this.miEmpresa += frm.EmpleadoDelForm;

                this.MostrarEnVisor();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int i = this.lstVisor.SelectedIndex;

            if (i > -1)
            {
                bool rta = this.miEmpresa - this.miEmpresa.Empleados[i];

                if (! rta)
                {
                    MessageBox.Show("No se pudo eliminar");
                    return;
                }

                this.MostrarEnVisor();
            }
        }

    }
}

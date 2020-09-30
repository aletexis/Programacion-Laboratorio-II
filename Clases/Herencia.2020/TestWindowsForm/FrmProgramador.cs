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
    public partial class FrmProgramador : FrmEmpleado
    {
        private Programador programador;

        public Programador ProgramadorDelForm
        {
            get { return this.programador; }
        }

        //IMPLEMENTO LA PROPIEDAD ABSTRACTA EMPLEADODELFORM
        public override Empleado EmpleadoDelForm
        {
            get { return this.programador; }
        }

        public FrmProgramador()
        {
            InitializeComponent();

            this.cboCategoria.DataSource = Enum.GetValues(typeof(ECategoria));

            this.cboCategoria.SelectedItem = ECategoria.SemiSenior;
            this.cboCategoria.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //SE SOBRESCRIBE EL MANEJADOR DE EVENTOS
        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            this.programador = new Entidades.Programador(base.txtNombre.Text, base.txtApellido.Text,
                    int.Parse(base.txtLegajo.Text), double.Parse(base.txtSueldo.Text), (ECategoria)this.cboCategoria.SelectedItem);

            base.btnAceptar_Click(sender, e);
        }

    }
}

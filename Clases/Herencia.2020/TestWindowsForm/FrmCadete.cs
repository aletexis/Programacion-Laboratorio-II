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
    public partial class FrmCadete : FrmEmpleado
    {
        private Cadete cadete;

        public Cadete CadeteDelForm
        {
            get { return this.cadete; }
        }

        //IMPLEMENTO LA PROPIEDAD ABSTRACTA EMPLEADODELFORM
        public override Empleado EmpleadoDelForm
        {
            get { return this.cadete; }
        }

        public FrmCadete()
        {
            InitializeComponent();
        }

        //SE SOBRESCRIBE EL MANEJADOR DE EVENTOS
        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            this.cadete = new Cadete(base.txtNombre.Text, base.txtApellido.Text,
                    int.Parse(base.txtLegajo.Text), double.Parse(base.txtSueldo.Text), this.txtSobrenombre.Text);

            base.btnAceptar_Click(sender, e);
        }

    }
}

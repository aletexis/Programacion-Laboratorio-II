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
    public abstract partial class FrmEmpleado : Form
    {
        //AL SER ABSTRACTA, NO SE PUEDE GENERAR UN OBJETO
        //private Empleado empleadoDelForm;

        //GENERO UNA PROPIEDAD ABSTRACTA, PARA QUE CADA CLASE DERIVADA LA IMPEMENTE
        public abstract Empleado EmpleadoDelForm
        {
            get;
        }

        public FrmEmpleado()
        {
            InitializeComponent();
        }

        //SE HACE PROTEGIDO Y VIRTUAL
        protected virtual void btnAceptar_Click(object sender, EventArgs e)
        {
            //ERROR!
            //this.empleadoDelForm = new Empleado(this.txtNombre.Text, this.txtApellido.Text, 
            //                    int.Parse(this.txtLegajo.Text), double.Parse(this.txtSueldo.Text));

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

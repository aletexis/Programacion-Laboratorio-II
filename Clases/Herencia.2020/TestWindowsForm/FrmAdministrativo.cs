using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HerenciaWindowsForm
{
    public partial class FrmAdministrativo : FrmEmpleado
    {
        private Entidades.Administrativo administrativo;

        public Entidades.Administrativo AdministrativoDelForm
        {
            get { return this.administrativo; }
        }

        //IMPLEMENTO LA PROPIEDAD ABSTRACTA EMPLEADODELFORM
        public override Entidades.Empleado EmpleadoDelForm
        {
            get { return this.administrativo; }
        }

        public FrmAdministrativo()
        {
            InitializeComponent();

            foreach (ESimpatia item in Enum.GetValues(typeof(ESimpatia)))
            {
                this.cboSimpatia.Items.Add(item);
            }

            this.cboSimpatia.SelectedItem = ESimpatia.MuyPoca;
            this.cboSimpatia.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        //SE SOBRESCRIBE EL MANEJADOR DE EVENTOS
        protected override void btnAceptar_Click(object sender, EventArgs e)
        {
            this.administrativo = new Entidades.Administrativo(base.txtNombre.Text, base.txtApellido.Text,
                    int.Parse(base.txtLegajo.Text), double.Parse(base.txtSueldo.Text), (ESimpatia)this.cboSimpatia.SelectedItem);

            base.btnAceptar_Click(sender, e);
        }
    }
}

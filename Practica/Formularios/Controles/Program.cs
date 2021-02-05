using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controles
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //CREO UNA INSTANCIA DEL FORMULARIO DE INICIO
            FrmInicio frm = new FrmInicio();

            //CREO UNA VARIABLE DE TIPO ENUMERACION
            Ejemplo queEjemplo;

            //INDICO LA POSICION EN LA PANTALLA
            frm.StartPosition = FormStartPosition.CenterScreen;

            try
            {
                //INICIO LA APLICACION
                frm.ShowDialog();

                //OBTENGO LA PROPIEDAD
                queEjemplo = frm.ObtenerSeleccion();

                Form frmAplicacion = null;

                //ELIJO EL FORMULARIO DE INICIO DE LA APLICACION
                switch (queEjemplo)
                {
                    case Ejemplo.CheckBox:
                        frmAplicacion = new FrmCheckBox();
                        break;
                    case Ejemplo.RadioButton:
                        frmAplicacion = new FrmRadioButton();
                        break;
                    case Ejemplo.ListBox:
                        frmAplicacion = new FrmListBox();
                        break;
                    case Ejemplo.ComboBox:
                        frmAplicacion = new FrmComboBox();
                        break;
                    default:
                        frmAplicacion = null;
                        break;
                }

                //INDICO LA POSICION EN LA PANTALLA
                frmAplicacion.StartPosition = FormStartPosition.CenterScreen;

                //INICIO LA APLICACION
                Application.Run(frmAplicacion);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                MessageBox.Show("La aplicación terminó.", "FIN DEL EJEMPLO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

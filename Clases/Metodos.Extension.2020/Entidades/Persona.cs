using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected ESexo sexo;

        #region #1.- Propiedades
        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int Edad { get { return this.edad; } }
        public ESexo Sexo { get { return this.sexo; } }
        #endregion

        public Persona(string nombre, string apellido, int edad, ESexo sexo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.sexo = sexo;
        }

        #region #2.- Método
        public string ObtenerInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(this.nombre);
            sb.Append("Apellido: ");
            sb.AppendLine(this.apellido);
            sb.Append("Edad: ");
            sb.AppendLine(this.edad.ToString());
            sb.Append("Sexo: ");
            sb.AppendLine(this.sexo.ToString());

            return sb.ToString();
        }
        #endregion

    }
}

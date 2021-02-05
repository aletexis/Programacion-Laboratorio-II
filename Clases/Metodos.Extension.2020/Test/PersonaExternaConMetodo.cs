using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{

    #region #3.- Derivar de la Dll externa
    class PersonaExternaConMetodo : Entidades.Externa.PersonaExterna
    {
        public PersonaExternaConMetodo(string nombre, string apellido, int edad, Entidades.Externa.ESexo sexo)
            : base(nombre, apellido, edad, sexo) { }

        public string ObtenerInfo()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.AppendLine(base.nombre);
            sb.Append("Apellido: ");
            sb.AppendLine(base.apellido);
            sb.Append("Edad: ");
            sb.AppendLine(base.edad.ToString());
            sb.Append("Sexo: ");
            sb.AppendLine(base.sexo.ToString());

            return sb.ToString();
        }

    }
    #endregion

}

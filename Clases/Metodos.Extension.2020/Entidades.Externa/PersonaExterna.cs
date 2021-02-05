using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Externa
{
    public class PersonaExterna
    {
        protected string nombre;
        protected string apellido;
        protected int edad;
        protected ESexo sexo;

        public PersonaExterna(string nombre, string apellido, int edad, ESexo sexo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.sexo = sexo;
        }
    }
}

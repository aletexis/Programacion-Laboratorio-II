using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Externa.Sellada
{
    public sealed class PersonaExternaSellada
    {
        private string nombre;
        private string apellido;
        private int edad;
        private ESexo sexo;

        public PersonaExternaSellada(string nombre, string apellido, int edad, ESexo sexo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.sexo = sexo;
        }

        public string Nombre { get { return this.nombre; } }
        public string Apellido { get { return this.apellido; } }
        public int Edad { get { return this.edad; } }
        public ESexo Sexo { get { return this.sexo; } }

    }
}

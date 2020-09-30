using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cadete : Empleado
    {
		#region Atributos

		private string sobrenombre;

		#endregion

		#region Propiedades

		public String Sobrenombre
		{
			get { return this.sobrenombre; }
			set { this.sobrenombre = value; }
		}

		#endregion

		#region Constructor

		public Cadete(string nombre, string apellido, int legajo,
							double sueldo, string sobrenombre)
			: base(nombre, apellido, legajo, sueldo)
		{
			this.sobrenombre = sobrenombre;
		}

		#endregion

		#region Métodos

		//SE CAMBIA EL NIVEL DE ACCESIBILIDAD DE PUBLICO A PROTEGIDO
		protected override string Mostrar()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(base.Mostrar());
			sb.Append(" - Sobrenomobre: ");
			sb.Append(this.sobrenombre);

			return sb.ToString();
		}

		#endregion

		#region Polimorfismo

		public override string ToString()
		{
			return this.Mostrar();
		}

		#endregion

	}
}

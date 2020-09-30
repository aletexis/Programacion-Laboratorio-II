using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
	public class Administrativo : Empleado
	{
		#region Atributos

		private ESimpatia simpatia;

		#endregion

		#region Propiedades

		public ESimpatia Simpatia
		{
			get { return this.simpatia; }
			set { this.simpatia = value; }
		}

		#endregion

		#region Constructor

		public Administrativo(string nombre, string apellido, int legajo,
							double sueldo, ESimpatia simpatia)
			: base(nombre, apellido, legajo, sueldo)
		{
			this.simpatia = simpatia;
		}

		#endregion

		#region Métodos

		//SE CAMBIA EL NIVEL DE ACCESIBILIDAD DE PUBLICO A PROTEGIDO
		protected override string Mostrar()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(base.Mostrar());
			sb.Append(" - Simpatía: ");
			sb.Append(this.simpatia.ToString());

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

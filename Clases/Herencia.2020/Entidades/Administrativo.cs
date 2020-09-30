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

		public string MostrarAdministrativo()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(base.MostrarEmpleado());
			sb.Append(" - Simpatía: ");
			sb.Append(this.simpatia.ToString());

			return sb.ToString();
		}

		#endregion

	}
}

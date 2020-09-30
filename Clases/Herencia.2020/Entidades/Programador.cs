using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Programador : Empleado
    {
		#region Atributos

		private ECategoria categoria;

		#endregion

		#region Propiedades

		public ECategoria Categoria
		{
			get { return this.categoria; }
			set { this.categoria = value; }
		}

		#endregion

		#region Constructor

		public Programador(string nombre, string apellido, int legajo, double sueldo)
			:base(nombre, apellido, legajo, sueldo)
		{
		}

		public Programador(string nombre, string apellido, int legajo, 
							double sueldo, ECategoria categoria)
			:this(nombre, apellido, legajo, sueldo)
		{
			this.categoria = categoria;
		}

		#endregion

		#region Métodos

		public string MostrarProgramador()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append(base.MostrarEmpleado());
			sb.Append(" - Categoría: ");
			sb.Append(this.categoria.ToString());
			
			return sb.ToString();
		}

        #endregion

    }
}

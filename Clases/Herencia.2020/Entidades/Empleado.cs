using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        #region Atributos

        protected string nombre;
        protected string apellido;
        protected int legajo;
        protected double sueldo;

        #endregion

        #region Propiedades

        public string Nombre 
        {
            get { return this.nombre; } 
        }

        public string Apellido
        {
            get { return this.apellido; }
        }

        public int Legajo
        {
            get { return this.legajo; }
        }

        public double Sueldo
        {
            get { return this.sueldo; }
        }

        #endregion

        #region Constructor

        public Empleado(string nombre, string apellido, int legajo, double sueldo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.sueldo = sueldo;
        }

        #endregion

        #region Métodos

        public string MostrarEmpleado()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Nombre: ");
            sb.Append(this.nombre);
            sb.Append(" - Apellido: ");
            sb.Append(this.apellido);
            sb.Append(" - Legajo: ");
            sb.Append(this.legajo.ToString());
            sb.Append(" - Sueldo: ");
            sb.Append(this.sueldo.ToString());

            return sb.ToString();
        }

        #region Para ordenamiento

        public static int OrdernarPorLegajoAsc(Empleado e1, Empleado e2)
        {
            return String.Compare(e1.legajo.ToString(), e2.legajo.ToString());
        }

        public static int OrdernarPorLegajoDesc(Empleado e1, Empleado e2)
        {
            return (-1) * Empleado.OrdernarPorLegajoAsc(e1, e2);
        }

        public static int OrdernarPorSueldoAsc(Empleado e1, Empleado e2)
        {
            return String.Compare(e1.sueldo.ToString(), e2.sueldo.ToString());
        }

        public static int OrdernarPorSueldoDesc(Empleado e1, Empleado e2)
        {
            return (-1) * Empleado.OrdernarPorSueldoAsc(e1, e2);
        }

        public static int OrdernarPorApellidoAsc(Empleado e1, Empleado e2)
        {
            return String.Compare(e1.apellido, e2.apellido);
        }

        public static int OrdernarPorApellidoDesc(Empleado e1, Empleado e2)
        {
            return (-1) * Empleado.OrdernarPorApellidoAsc(e1, e2);
        }

        #endregion

        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Empleado e1, Empleado e2)
        {
            return e1.legajo == e2.legajo;
        }

        public static bool operator !=(Empleado e1, Empleado e2)
        {
            return ! (e1 == e2);
        }

        #endregion

    }
}

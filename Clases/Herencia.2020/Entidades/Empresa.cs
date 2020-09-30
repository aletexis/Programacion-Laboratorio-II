using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empresa
    {
        #region Atributos

        public string nombre;
        private List<Empleado> empleados;

        #endregion

        #region Propiedades

        public List<Empleado> Empleados
        {
            get { return this.empleados; }
        }

        public double TotalSueldos 
        {
            get { return this.ObtenerTotalSueldos(ETipoEmpleado.Todos); } 
        }
        public double TotalSueldosProgramadores
        {
            get { return this.ObtenerTotalSueldos(ETipoEmpleado.Programador); }
        }
        public double TotalSueldosAdministrativos
        {
            get { return this.ObtenerTotalSueldos(ETipoEmpleado.Administrativo); }
        }
        public double TotalSueldosCadetes
        {
            get { return this.ObtenerTotalSueldos(ETipoEmpleado.Cadete); }
        }

        #endregion

        #region Constructor

        private Empresa()
        {
            this.empleados = new List<Empleado>();
        }

        public Empresa(string nombre) : this()
        {
            this.nombre = nombre;
        }

        #endregion

        #region Métodos

        public double ObtenerTotalSueldos(ETipoEmpleado tipo)
        {
            double total = 0;
            double total_prog = 0;
            double total_admin = 0;
            double total_cadete = 0;

            foreach (Empleado item in this.empleados)
            {
                if (item is Programador)
                {
                    total_prog += item.Sueldo;
                }

                if (item is Administrativo)
                {
                    total_admin += item.Sueldo;
                }

                if (item is Cadete)
                {
                    total_cadete += item.Sueldo;
                }
            }

            switch (tipo)
            {
                case ETipoEmpleado.Programador:
                    total = total_prog;
                    break;
                case ETipoEmpleado.Administrativo:
                    total = total_admin;
                    break;
                case ETipoEmpleado.Cadete:
                    total = total_cadete;
                    break;
                case ETipoEmpleado.Todos:
                    total = total_admin + total_cadete + total_prog;
                    break;
                default:
                    break;
            }

            return total;
        }

        //SE CAMBIA EL NIVEL DE ACCESIBILIDAD DE PUBLICO A PROTEGIDO
        protected string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("Empresa: ");
            sb.AppendLine(this.nombre);
            sb.AppendFormat("Listado de empleados ({0})", this.empleados.Count.ToString());
            sb.AppendLine();

            foreach (Empleado item in this.empleados)
            {
                //CAMBIO EL METODO MOSTRAR POR EL TOSTRING
                sb.AppendLine(item.ToString());

            }

            return sb.ToString();
        }

        #endregion

        #region Sobrecarga de Operadores

        public static bool operator ==(Empresa e, Empleado emple)
        {
            bool rta = false;

            foreach (Empleado item in e.empleados)
            {
                if (item == emple)
                {
                    rta = true;
                    break;
                }
            }

            return rta;
        }

        public static bool operator !=(Empresa e, Empleado emple)
        {
            return !(e == emple);
        }

        public static Empresa operator +(Empresa e, Empleado emple)
        {
            if (e != emple)
            {
                e.empleados.Add(emple);
            }

            return e;
        }

        public static int operator |(Empresa e, Empleado emple)
        {
            int indice = -1;
            int cont = -1;

            foreach (Empleado item in e.empleados)
            {
                cont++;

                if (item == emple)
                {
                    indice = cont;
                    break;
                }
            }

            return indice;
        }

        public static bool operator -(Empresa e, Empleado emple)
        {
            int indice = e | emple;
            bool rta = false;

            if (indice > -1)
            {
                e.empleados.RemoveAt(indice);
                rta = true;
            }

            return rta;
        }

        #endregion

        #region Polimorfismo

        public override string ToString()
        {
            return this.Mostrar();
        }

        public override bool Equals(object obj)
        {
            bool rta = false;

            if (obj is Empleado)
            {
                rta = this == (Empleado)obj;
            }

            return rta;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    }
}

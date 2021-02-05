using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Alumno : Universitario
    {
        #region Atributos

        private Universidad.EClases claseQueToma;
        private EEstadoCuenta estadoCuenta;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto de Alumno.
        /// </summary>
        public Alumno()
            : base()
        {
        }

        /// <summary>
        /// Constructor que inicializa el id, nombre, apellido, DNI (string), 
        /// nacionalidad y clase que toma un alumno.
        /// </summary>
        /// <param name="id">El id de un alumno.</param>
        /// <param name="nombre">El nombre de un alumno.</param>
        /// <param name="apellido">El apellido de un alumno.</param>
        /// <param name="dni">El DNI de un alumno.</param>
        /// <param name="nacionalidad">La nacionalidad de un alumno.</param>
        /// <param name="claseQueToma">La clase que toma un alumno.</param>
        public Alumno(int id, string nombre, string apellido, string dni,
            ENacionalidad nacionalidad, Universidad.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad)
        {
            this.claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Constructor que inicializa el id, nombre, apellido, DNI (string), 
        /// nacionalidad y clase que toma  y estado de cuenta de un alumno.
        /// </summary>
        /// <param name="id">El id de un alumno.</param>
        /// <param name="nombre">El nombre de un alumno.</param>
        /// <param name="apellido">El apellido de un alumno.</param>
        /// <param name="dni">El DNI de un alumno.</param>
        /// <param name="nacionalidad">La nacionalidad de un alumno.</param>
        /// <param name="claseQueToma">La clase que toma un alumno.</param>
        /// <param name="estadoCuenta">El estado de cuenta de un alumno.</param>
        public Alumno(int id, string nombre, string apellido, string dni, 
            ENacionalidad nacionalidad, Universidad.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this.estadoCuenta = estadoCuenta;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los datos del alumno en string.
        /// </summary>
        /// <returns>Retorna los datos del alumno.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder alumno = new StringBuilder();
            alumno.AppendFormat("{0}", base.MostrarDatos());
            alumno.Append("\nESTADO DE CUENTA: ");

            switch (this.estadoCuenta)
            {
                case EEstadoCuenta.AlDia:
                    alumno.Append("Cuota al dia\n");
                    break;
                case EEstadoCuenta.Deudor:
                    alumno.Append("Deudor\n");
                    break;
                case EEstadoCuenta.Becado:
                    alumno.Append("Becado\n");
                    break;
            }
            return alumno.ToString() + this.ParticiparEnClase();
        }

        /// <summary>
        /// Hace publicos los datos del alumno.
        /// </summary>
        /// <returns>Los datos del alumno.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Muestra la clase que toma un alumno.
        /// </summary>
        /// <returns>La clase que toma el alumno.</returns>
        protected override string ParticiparEnClase()
        {
            return "TOMA CLASES DE " + this.claseQueToma.ToString();
        }

        #endregion

        #region Sobrecargas
        /// <summary>
        /// Sobrecarga del operador ==. Un Alumno será igual a un EClase
        /// si toma esa clase y su estado de cuenta no es Deudor.
        /// </summary>
        /// <param name="a">El alumno a comparar.</param>
        /// <param name="clase">La clase a comparar.</param>
        /// <returns>Retorna True si toma la clase, False si no la toma.</returns>
        public static bool operator ==(Alumno a, Universidad.EClases clase)
        {
            return (a.claseQueToma == clase && a.estadoCuenta != EEstadoCuenta.Deudor);
        }

        /// <summary>
        /// Sobrecarga del operador !=. Un Alumno será distinto a un EClase
        /// si no toma esa clase y su estado de cuenta es Deudor.
        /// </summary>
        /// <param name="a">El alumno a comparar.</param>
        /// <param name="clase">La clase a comparar.</param>
        /// <returns>Retorna True si no toma la clase, False si la toma.</returns>
        public static bool operator !=(Alumno a, Universidad.EClases clase)
        {
            return !(a == clase);
        }

        #endregion

        #region Enumerados
        
        /// <summary>
        /// Enumerados del estado de cuenta del alumno.
        /// </summary>
        public enum EEstadoCuenta
        {
            AlDia,
            Deudor,
            Becado
        }

        #endregion
    }

}

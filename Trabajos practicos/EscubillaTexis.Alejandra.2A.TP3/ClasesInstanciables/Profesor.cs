using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace ClasesInstanciables
{
    public sealed class Profesor : Universitario
    {
        #region Atributos

        private Queue<Universidad.EClases> clasesDelDia;
        private static Random random;

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor estatico de un profesor. Inicializa el atributo Random.
        /// </summary>
        static Profesor()
        {
            Profesor.random = new Random();
        }

        /// <summary>
        /// Constructor por defecto de un profesor. Inicializa la lista de clases.
        /// </summary>
        public Profesor()
            : base()
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
        }

        /// <summary>
        /// Constructor que inicializa el id, nombre, apellido, dni (string) y
        /// nacionalidad de un profesor.
        /// </summary>
        /// <param name="id">El id del profesor.</param>
        /// <param name="nombre">El nombre del profesor.</param>
        /// <param name="apellido">El apellido del profesor.</param>
        /// <param name="dni">El DNI del profesor.</param>
        /// <param name="nacionalidad">La nacionalidad del profesor.</param>
        public Profesor(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base (id, nombre, apellido, dni, nacionalidad)
        {
            this.clasesDelDia = new Queue<Universidad.EClases>();
            this._randomClases();
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los datos del profesor en string.
        /// </summary>
        /// <returns>Retorna los datos del profesor.</returns>
        protected override string MostrarDatos()
        {
            StringBuilder profesor = new StringBuilder();
            profesor.AppendFormat("{0}", base.MostrarDatos());
            profesor.AppendLine(this.ParticiparEnClase());
            return profesor.ToString();
        }

        /// <summary>
        /// Hace publicos los datos del profesor.
        /// </summary>
        /// <returns>Retorna los datos del profesor.</returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }

        /// <summary>
        /// Muestra las clases que toma el profesor.
        /// </summary>
        /// <returns>Retorna las clases que toma.</returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder clases = new StringBuilder();
            clases.AppendLine("CLASES DEL DIA: ");
            foreach (Universidad.EClases item in this.clasesDelDia)
            {
                clases.AppendLine(item.ToString());
            }
            return clases.ToString();
        }

        /// <summary>
        /// Agrega dos clases random a un profesor, pueden ser iguales o no.
        /// </summary>
        private void _randomClases()
        {
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(1, 4));
            this.clasesDelDia.Enqueue((Universidad.EClases)random.Next(1, 4));
        }

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga del operador ==. Un Profesor será igual a un EClase si da esa clase.
        /// </summary>
        /// <param name="i">El profesor a comparar.</param>
        /// <param name="clase">La clase a comparar.</param>
        /// <returns>Retorna True si da esa clase, False si no la da.</returns>
        public static bool operator ==(Profesor i, Universidad.EClases clase)
        {
            bool retorno = false;

            foreach (Universidad.EClases item in i.clasesDelDia)
            {
                if (item == clase)
                {
                    retorno = true;
                    break;
                }
            }

            return retorno;
        }

        /// <summary>
        /// Sobrecarga del operador !=. Un Profesor será distinto a un EClase si no da esa clase.
        /// </summary>
        /// <param name="i">El profesor a comparar.</param>
        /// <param name="clase">La clase a comparar.</param>
        /// <returns>Retorna True si no da esa clase, False si la da.</returns>
        public static bool operator !=(Profesor i, Universidad.EClases clase)
        {
            return !(i == clase);
        }

        #endregion
    }
}

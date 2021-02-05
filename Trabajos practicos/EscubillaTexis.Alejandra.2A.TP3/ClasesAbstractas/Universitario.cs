using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Universitario : Persona
    {
        #region Atributos

        private int legajo;

        #endregion

        #region Constructores

        /// <summary>
        /// Constructor por defecto de universitario.
        /// </summary>
        public Universitario()
            : base()
        {
        }

        /// <summary>
        /// Constructor que inicializa el legajo, nombre, apellido,
        /// DNI (string), nacionalidad de un universitario.
        /// </summary>
        /// <param name="legajo">El legajo del universitario.</param>
        /// <param name="nombre">El nombre del universitario.</param>
        /// <param name="apellido">El apellido del universitario.</param>
        /// <param name="dni">El DNI del universitario.</param>
        /// <param name="nacionalidad">La nacionalidad del universitario.</param>
        public Universitario(int legajo, string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : base(nombre, apellido, dni, nacionalidad)
        {
            this.legajo = legajo;
        }

        #endregion

        #region Metodos

        /// <summary>
        /// Muestra los datos del universitario.
        /// </summary>
        /// <returns>Los datos del universitario en string.</returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder universitario = new StringBuilder();
            universitario.AppendLine(base.ToString());
            universitario.AppendFormat("LEGAJO NUMERO: {0}\n", this.legajo);
            return universitario.ToString();
        }

        /// <summary>
        /// Muestra la clase que toma un universitario.
        /// </summary>
        /// <returns>La clase que toma un universitario.</returns>
        protected abstract string ParticiparEnClase();

        #endregion

        #region Sobrecargas

        /// <summary>
        /// Sobrecarga del operador ==. Dos universitarios son iguales 
        /// si y sólo si son del mismo Tipo y su Legajo o DNI son iguales.
        /// </summary>
        /// <param name="pg1">Primer universitario a comparar.</param>
        /// <param name="pg2">Segundo universitario a comparar.</param>
        /// <returns>Retorna True si son iguales, False si no lo son.</returns>
        public static bool operator ==(Universitario pg1, Universitario pg2)
        {
            return (pg1.DNI == pg2.DNI || pg1.legajo == pg2.legajo);
        }

        /// <summary>
        /// Sobrecarga del operador !=. Dos universitarios son distintos 
        /// si no son del mismo Tipo y su Legajo o DNI son diferentes.
        /// </summary>
        /// <param name="pg1">Primer universitario a comparar.</param>
        /// <param name="pg2">Segundo universitario a comparar.</param>
        /// <returns>Retorna True si son distintos, False si no lo son.</returns>
        public static bool operator !=(Universitario pg1, Universitario pg2)
        {
            return !(pg1 == pg2);
        }

        /// <summary>
        /// Verifica que un objeto sea de tipo universitario.
        /// Teniendo en cuenta tambien su DNI y legajo.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;
            
            if (obj is Universitario)
            {
                retorno = this == (Universitario)obj;
            }
            return retorno;
        }

        #endregion
    }
}

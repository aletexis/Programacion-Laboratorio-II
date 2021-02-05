using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace Entidades
{
    public class Sedan : Vehiculo
    {
        #region "Enumerados"
       
        public enum ETipo
        {
            CuatroPuertas,
            CincoPuertas 
        }

        #endregion

        #region "Atributos"

        private ETipo tipo;

        #endregion

        #region "Propiedades"
        /// <summary>
        /// Sedan son 'Mediano'
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Mediano;
            }
        }
        #endregion
        
        #region "Constructores"

        /// <summary>
        /// Constructo que inicializa la marca, el chasis y el color del sedan. Por defecto, TIPO será CuatroPuertas.
        /// </summary>
        /// <param name="marca">La marca del sedan.</param>
        /// <param name="chasis">El chasis del sedan.</param>
        /// <param name="color">El color del sedan.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
            tipo = ETipo.CuatroPuertas;
        }

        /// <summary>
        /// Constructo que inicializa la marca, chasis, color y tipo del sedan. 
        /// </summary>
        /// <param name="marca">La marca del sedan.</param>
        /// <param name="chasis">El chasis del sedan.</param>
        /// <param name="color">El color del sedan.</param>
        /// <param name="tipo">El tipo del sedan.</param>
        public Sedan(EMarca marca, string chasis, ConsoleColor color, ETipo tipo)
            : base(chasis, marca, color)
        {
            this.tipo = tipo;
        }
        
        #endregion

        #region "Metodos"

        /// <summary>
        /// Muestra los datos del sedan.
        /// </summary>
        /// <returns>Devuelve un string con los datos del sedan.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("SEDAN");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("\nTIPO : " + this.tipo);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }

        #endregion
    }
}

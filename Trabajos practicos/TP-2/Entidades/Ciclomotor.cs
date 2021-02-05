using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Ciclomotor : Vehiculo
    {
        #region "Propiedades"
        
        /// <summary>
        /// Devuelve el tamaño de los ciclomotores. Los Ciclomotores son 'Chico'.
        /// </summary>
        protected override ETamanio Tamanio
        {
            get
            {
                return ETamanio.Chico;
            }
        }

        #endregion
        
        #region "Constructores"
        
        /// <summary>
        /// Constructor que inicializa chasis, marca, color del ciclomotor.
        /// </summary>
        /// <param name="marca">Marca del ciclomotor.</param>
        /// <param name="chasis">Chasis del ciclomotor.</param>
        /// <param name="color">Color del ciclomotor.</param>
        public Ciclomotor(EMarca marca, string chasis, ConsoleColor color)
            : base(chasis, marca, color)
        {
        }

        #endregion

        #region "Metodos"
        
        /// <summary>
        /// Muestra los datos del ciclomotor.
        /// </summary>
        /// <returns>Devuelve un string con datos del ciclomotor.</returns>
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CICLOMOTOR");
            sb.AppendLine(base.Mostrar());
            sb.AppendFormat("TAMAÑO : {0}", this.Tamanio);
            sb.AppendLine("");
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        
        #endregion
    }
}

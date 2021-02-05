using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// La clase Vehiculo no deberá permitir que se instancien elementos de este tipo.
    /// </summary>
    public abstract class Vehiculo
    {
        #region "Enumerados"
      
        public enum EMarca
        {
            Chevrolet,
            Ford,
            Renault,
            Toyota,
            BMW,
            Honda,
            HarleyDavidson
        }

        public enum ETamanio
        {
            Chico,
            Mediano,
            Grande
        }
       
        #endregion

        #region "Atributos"
       
        private EMarca marca;
        private string chasis;
        private ConsoleColor color;
        
        #endregion

        #region "Propiedades"
        
        /// <summary>
        /// ReadOnly: Retornará el tamaño
        /// </summary>
        protected abstract ETamanio Tamanio 
        {
            get;
        }

        #endregion

        #region "Constructores"
        
        /// <summary>
        /// Constructor que inicializa chasis, marca y color del vehiculo.
        /// </summary>
        /// <param name="chasis">Chasis del vehiculo.</param>
        /// <param name="marca">Marca del vehiculo.</param>
        /// <param name="color">Color de vehiculo.</param>
        public Vehiculo(string chasis, EMarca marca, ConsoleColor color)
        {
            this.chasis = chasis;
            this.marca = marca;
            this.color = color;
        }

        #endregion
        
        #region "Metodos"
        
        /// <summary>
        /// Publica todos los datos del Vehiculo.
        /// </summary>
        /// <returns>Devuelve los datos del vehiculo.</returns>
        public virtual string Mostrar()
        {
            return (string)this;
        }

        #endregion

        #region "Sobrecarga de operadores"

        /// <summary>
        /// Muestra los datos de un vehículo.
        /// </summary>
        /// <param name="p">El vehículo que se mostrará.</param>
        public static explicit operator string(Vehiculo p)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("CHASIS: {0}\n", p.chasis);
            sb.AppendFormat("MARCA : {0}\n", p.marca.ToString());
            sb.AppendFormat("COLOR : {0}\n", p.color.ToString());
            sb.AppendLine("---------------------");

            return sb.ToString();
        }
        /// <summary>
        /// Dos vehiculos son iguales si comparten el mismo chasis.
        /// </summary>
        /// <param name="v1">El primer vehiculo a comparar.</param>
        /// <param name="v2">El segundo vehiculo a comparar.</param>
        /// <returns>Devuelve true si son iguales, false si no lo son.</returns>
        public static bool operator ==(Vehiculo v1, Vehiculo v2)
        {
            bool retorno = false;

            if (((object)v1) == null && ((object)v2) == null)
            {
                retorno = true;
            }
            else
            {
                if (((object)v1) != null && ((object)v2) != null)
                {
                    if (v1.chasis == v2.chasis)
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        /// <summary>
        /// Dos vehiculos son distintos si su chasis es distinto
        /// </summary>
        /// <param name="v1">El primer vehiculo a comparar.</param>
        /// <param name="v2">El segundo vehiculo a comparar.</param>
        /// <returns>Devuelve true si son distintos, false si no lo son.</returns>
        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }

        /// <summary>
        /// Compara un objeto con un objeto de tipo vehiculo.
        /// </summary>
        /// <param name="obj">EL objeto a comparar.</param>
        /// <returns>Devuelve true si son iguales, false si no lo son.</returns>
        public override bool Equals(object obj)
        {
            bool retorno = false;

            if (obj is Vehiculo)
            {
                retorno = this == (Vehiculo)obj;
            }

            return retorno;
        }

        /// <summary>
        /// Retorna el hash code de la clase base.
        /// </summary>
        /// <returns>Devuelve el hash code.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion

    }
}

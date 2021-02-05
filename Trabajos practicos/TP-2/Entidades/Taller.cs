using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        #region "Enumerados"
        
        public enum ETipo
        {
            Ciclomotor,
            Sedan,
            Suv,
            Todos
        }

        #endregion
        
        #region "Atributos"
        
        private List<Vehiculo> vehiculos;
        private int espacioDisponible;
        
        #endregion

        #region "Constructores"
        
        /// <summary>
        /// Constructor que inicializa la lista de vehículos.
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }

        /// <summary>
        /// Constructor que inicializa la lista de vehiculos y el espacio disponible.
        /// </summary>
        /// <param name="espacioDisponible">Espacio disponible.</param>
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }

        #endregion

        #region "Métodos"

        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="taller">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns>Devuelve los datos del elemento.</returns>
        public static string Listar(Taller taller, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles", taller.vehiculos.Count, taller.espacioDisponible);
            sb.AppendLine("");
            
            foreach (Vehiculo v in taller.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Ciclomotor:
                        if (v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if (v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Suv:
                        if (v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        
        #endregion

        #region "Sobrecargas"
       
        /// <summary>
        /// Muestra el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns>Devuelve los datos del estacionamiento y los vehiculos.</returns>
        public override string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        
        #endregion
        
        #region "Operadores"
        
        /// <summary>
        /// Agregará un elemento a la lista
        /// </summary>
        /// <param name="taller">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns>Devuelve el objeto con los elementos actualizados si se pudo agregar.
        /// Caso contrario, el objeto tal y como se pasó.</returns>
        public static Taller operator +(Taller taller, Vehiculo vehiculo)
        {
            if (taller.vehiculos.Count < taller.espacioDisponible )
            {
                foreach (Vehiculo v in taller.vehiculos)
                {
                    if (v.Equals(vehiculo))
                    {
                        return taller;
                    }
                }
                
                taller.vehiculos.Add(vehiculo);
            }
            
            return taller;
        }

        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns>Devuelve el objeto con los elementos actualizados si se pudo quitar.
        /// Caso contrario, el objeto tal y como se pasó.</returns>
        public static Taller operator -(Taller taller, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in taller.vehiculos)
            {
                if (v == vehiculo)
                {
                    taller.vehiculos.Remove(v);
                    break;
                }
            }

            return taller;
        }

        #endregion

    }
}

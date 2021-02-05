using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Concesionaria
    {
        #region Atributos

        private int capacidad;
        private List<Vehiculo> vehiculos;
        
        #endregion

        #region Propiedades
        public double PrecioDeAutos 
        { 
            get 
            { 
                return this.ObtenerPrecio(EVehiculo.PrecioDeAutos); 
            } 
        }

        public double PrecioDeMotos 
        { 
            get 
            { 
                return this.ObtenerPrecio(EVehiculo.PrecioDeMotos); 
            } 
        }
        public double PrecioTotal 
        { 
            get 
            { 
                return this.ObtenerPrecio(EVehiculo.PrecipTotal); 
            } 
        }
        #endregion

        #region Constructores
        
        private Concesionaria()
        {
            vehiculos = new List<Vehiculo>();
        }
        private Concesionaria(int capacidad)
            : this()
        {
            this.capacidad = capacidad;
        }
        
        #endregion

        #region Metodos


        private double ObtenerPrecio(EVehiculo tipoVehiculo)
        {
            double retorno = 0;

            foreach (Vehiculo item in this.vehiculos)
            {
                switch (tipoVehiculo)
                {
                    case (EVehiculo.PrecioDeAutos):
                        if (item is Auto)
                        {
                            retorno += (Double)((Auto)item);
                        }
                        break;

                    case (EVehiculo.PrecioDeMotos):
                        if (item is Moto)
                        {
                            retorno += ((Moto)item);
                        }
                        break;

                    default:
                        if (item is Auto)
                            retorno += (Double)((Auto)item);
                        if (item is Moto)
                            retorno += ((Moto)item);
                        break;
                }

            }
            return retorno;
        }

        public static string Mostrar(Concesionaria c)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Capacidad: {0}\n", c.capacidad);
            sb.AppendFormat("Total de autos: {0}\n", c.PrecioDeAutos);
            sb.AppendFormat("Total de motos: {0}\n", c.PrecioDeMotos);
            sb.AppendFormat("Total: {0}\n", c.PrecioTotal);

            sb.AppendLine("************************************************");
            sb.AppendLine("\nListado de Vehiculos:");
            sb.AppendLine("************************************************");

            foreach (Vehiculo item in c.vehiculos)
            {
                sb.AppendLine(item.ToString());                    
            }

            return sb.ToString();
        }
        #endregion

        #region Sobrecargas

        public static bool operator ==(Concesionaria c, Vehiculo m)
        {
            bool retorno = false;

            if (c.vehiculos.Equals(m) == true)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Concesionaria c, Vehiculo v)
        {
            return !(c == v);
        }

        public static Concesionaria operator +(Concesionaria c, Vehiculo v)
        {
            if (c.capacidad > c.vehiculos.Count())
            {
                if (c != v)
                {
                    c.vehiculos.Add(v);
                    Console.WriteLine("\n El vehiculo ya esta en la concesionaria!!!!");
                }
                else
                {
                    Console.WriteLine("\n No hay mas lugar en la concesionaria!!!!");
                }
            }
            return c;
        }

        public static implicit operator Concesionaria(int capacidad)
        {
            return new Concesionaria(capacidad);
        }
        #endregion

    }
}

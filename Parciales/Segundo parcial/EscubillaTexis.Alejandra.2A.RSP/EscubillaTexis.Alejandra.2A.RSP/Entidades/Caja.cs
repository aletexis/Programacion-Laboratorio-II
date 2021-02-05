using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public delegate void EventoPrecio(object sender, EventArgs e);

    public class Caja<T> where T : Producto
    {
        #region Atributos

        //atributos: capacidad:int y elementos:List<T> (TODOS protegidos)  

        protected int capacidad;
        protected List<T> elementos;

        public EventoPrecio PrecioSuperado;

        #endregion

        #region Propiedades

        //Propiedades:
        //Elementos:(sólo lectura) expone al atributo de tipo List<T>.
        public List<T> Elementos
        {
            get
            {
                return this.elementos;
            }
        }

        //PrecioTotal:(sólo lectura) retorna el precio total de la caja (la suma de los precios de sus elementos).
        public float PrecioTotal
        {
            get
            {
                float suma = 0;

                foreach (T item in this.elementos)
                {
                    suma += item.Precio;
                }

                return suma;
            }
        }
        #endregion

        #region Constructores

        //Constructor
        //Caja(), Caja(int); 
        //El constructor por default es el único que se encargará de inicializar la lista.

        public Caja()
        {
            this.elementos = new List<T>();
        }

        public Caja(int capacidad)
            : this()
        {
            this.capacidad = capacidad;
        }
        #endregion

        #region Metodos

        //Métodos:
        //ToString: Mostrará en formato de tipo string: 
        //el tipo de caja, la capacidad, la cantidad actual de elementos, el precio total y el listado completo 
        //de todos los elementos contenidos en la misma. Reutilizar código.
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Caja de: {0}\n", typeof(T).Name);
            sb.AppendFormat("Capacidad: {0}\n", this.capacidad);
            sb.AppendFormat("Cantidad actual de elementos: {0}\n", this.elementos.Count);
            sb.AppendFormat("Precio total: ${0}\n", this.PrecioTotal);
            sb.AppendLine("Lista de productos:");

            foreach (Producto aux in this.elementos)
            {
                sb.Append(aux.ToString());
            }

            return sb.ToString();
        }

        #endregion

        #region Sobrecargas
        //Sobrecarga de operadores:
        //(+) Será el encargado de agregar elementos a la caja, 
        //siempre y cuando no supere la capacidad máxima de la misma.
        public static Caja<T> operator +(Caja<T> caja, T item)
        {
            double precio = caja.PrecioTotal;

            if ((object)caja != null && (object)item != null)
            {
                if (caja.elementos.Count < caja.capacidad)
                {
                    caja.elementos.Add(item);

                    if (caja.PrecioTotal > 120 && caja.PrecioSuperado != null)
                    {
                        caja.PrecioSuperado.Invoke(caja, EventArgs.Empty);
                    }
                }
                else
                {
                    throw new CajaLlenaException();
                }
            }

            return caja;
        }
        #endregion
    }
}

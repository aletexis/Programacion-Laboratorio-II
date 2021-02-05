using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        #region Atributos

        protected Fabricante fabricante;
        protected static Random generadorDeVelocidades;
        protected string modelo;
        protected float precio;
        protected int velocidadMaxima;

        #endregion

        #region Propiedades

        public int VelocidadMaxima
        {
            get
            {
                if (this.velocidadMaxima == 0)
                {
                    generadorDeVelocidades = new Random();
                    this.velocidadMaxima = generadorDeVelocidades.Next(100, 280);
                }
                return this.velocidadMaxima;
            }
        }

        #endregion

        #region Constructores

        static Vehiculo()
        {
            Vehiculo.generadorDeVelocidades = new Random();
        }
        public Vehiculo(float precio, string modelo, Fabricante fabri)
        {
            this.precio = precio;
            this.modelo = modelo;
            this.fabricante = fabri;
        }
        public Vehiculo(string marca, EPais pais, string modelo, float precio)
            : this(precio, modelo, new Fabricante(marca, pais))
        {
        }

        #endregion

        #region Metodos

        private static string Mostrar(Vehiculo v)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("-FABRICANTE: {0} \n", (String)v.fabricante);

            sb.AppendFormat("-MODELO: {0} \n", v.modelo);
            sb.AppendFormat("-VELOCIDAD MAXIMA: {0} \n", v.VelocidadMaxima);
            sb.AppendFormat("-PRECIO: ${0}", v.precio);

            return sb.ToString();
        }

        #endregion

        #region Sobrecargas

        public static bool operator ==(Vehiculo a, Vehiculo b)
        {
            return (a.modelo == b.modelo && a.fabricante == b.fabricante);
        }

        public static bool operator !=(Vehiculo a, Vehiculo b)
        {
            return !(a == b);
        }

        public static explicit operator String(Vehiculo v)
        {
            return Vehiculo.Mostrar(v);
        }

        #endregion
    }
}

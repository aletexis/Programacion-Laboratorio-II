using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Ejemplo2
{
   public abstract class Transporte
   {
       #region Atributos
       
       protected byte cantidadPasajeros;
       protected Velocidades velocidadMaxima;
       
       #endregion

       #region Constructor

       public Transporte(byte pasajeros, Velocidades velocidadMaxima)
       {
           this.cantidadPasajeros = pasajeros;
           this.velocidadMaxima = velocidadMaxima;
       }

       #endregion

       #region Métodos

        //MARCO EL METODO COMO VIRTUAL PARA QUE PUEDA SER SOBRESCRITO EN CLASES DERIVADAS
       public virtual void Avanzar()
       {
           Console.Write("Está avanzando ");
       }

        //MARCO EL METODO COMO ABSTRACTO PARA QUE DEBA SER SOBRESCRITO EN CLASES DERIVADAS
        public abstract void Frenar();

        #endregion

       #region Polimorfismo ToString

        //SOBRESCRIBO EL MÉTODO TOSTRING(), 
        //HEREDADO DE OBJECT
        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            sb.AppendLine("En la clase Transporte...");
            sb.Append("Cantidad de pasajeros: ");
            sb.AppendLine(this.cantidadPasajeros.ToString());
            sb.Append("Velocidad Máxima: ");
            sb.AppendLine(((Int32)this.velocidadMaxima).ToString());

            return sb.ToString();
        }

        #endregion

    }
}

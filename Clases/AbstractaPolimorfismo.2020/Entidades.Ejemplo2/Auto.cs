using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Ejemplo2
{
    public class Auto:Transporte
    {
        #region Atributos

        public int cantidadRuedas;

        #endregion

        #region Constructor

        public Auto(byte pasajeros, Velocidades velocidad, int ruedas)
            :base(pasajeros,velocidad)
        {
            this.cantidadRuedas = ruedas;
        }

        #endregion

        #region Métodos

        //SOBRESCRIBO AL METODO ABSTRACTO
        public override void Frenar()
        {
            Console.WriteLine("El Auto está frenando...");
        }

        //SOBRESCRIBO AL METODO VIRTUAL
        public override void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("el Auto.");
        }

        #endregion

        #region Polimorfismo ToString

        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            //INVOCO AL TOSTRING() DE LA CLASE BASE
            sb.AppendLine(base.ToString());

            sb.AppendLine("En la clase Auto...");
            sb.Append("Cantidad de ruedas: ");
            sb.AppendLine(this.cantidadRuedas.ToString());

            return sb.ToString();
        }

        #endregion

    }
}

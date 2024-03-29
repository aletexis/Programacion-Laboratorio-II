﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades.Ejemplo2
{
    public class Caballo:Transporte
    {
        #region Atributos

        public string raza;
        public Colores color;

        #endregion

        #region Constructor

        public Caballo(string raza, byte cantPasajeros, Velocidades miVelocidad, Colores miColor)
        :base(cantPasajeros,miVelocidad)
        {
            this.raza = raza;
            this.color = miColor ;
        }

        #endregion

        #region Métodos

        //SOBRESCRIBO AL METODO ABSTRACTO
        public override void Frenar()
        {
            Console.WriteLine("El Caballo está frenando...");
        }

        //SOBRESCRIBO AL METODO VIRTUAL
        public override void Avanzar()
        {
            base.Avanzar();
            Console.WriteLine("el Caballo.");
        }

        #endregion

        #region Polimorfismo ToString

        public override string ToString()
        {
            System.Text.StringBuilder sb = new StringBuilder();

            //INVOCO AL TOSTRING() DE LA CLASE BASE
            sb.AppendLine(base.ToString());

            sb.AppendLine("En la clase Caballo...");
            sb.Append("Raza: ");
            sb.AppendLine(this.raza);
            sb.Append("Color: ");
            sb.AppendLine(this.color.ToString());

            return sb.ToString();
        }

        #endregion

    }
}

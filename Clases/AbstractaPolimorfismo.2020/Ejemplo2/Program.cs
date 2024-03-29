﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ejemplo2;

namespace Ejemplo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //INSTANCIO DISTINTOS TRANSPORTES
            Auto autito = new Auto(4, Velocidades.Alta, 3);
            Caballo ico = new Caballo("poni", 1, Velocidades.Minima, Colores.Pinto);
            Cohete chalenger = new Cohete(8, Velocidades.Hiper, 4, "98 full");

            //ERROR NO SE PUEDE INSTANCIAR UNA CLASE ABSTRACTA!!!
            //Transporte miTransporte = new Transporte(2, Velocidades.Baja);

            //DECLARO UNA VARIABLE DE TIPO TRANSPORTE
            Transporte miTransporte;

            //PUEDO INICIALIZARLA CON OBJETOS DE CLASES DERIVADAS
            miTransporte = autito;

            //MUESTRO MÉTODOS GENÉRICOS
            miTransporte.Avanzar();
            miTransporte.Frenar();

            Console.ReadLine();

            //CASTEO PARA OBTENER ATRIBUTOS PROPIOS
            Console.WriteLine();
            Console.WriteLine("Atributos particulares según la clase...{0}",
                                ((Auto)miTransporte).cantidadRuedas);
            
            Console.ReadLine();

            //CREO UNA LISTA GENÉRICA DE TIPO TRANSPORTE
            List<Transporte> ListaDeTransporte = new List<Transporte>();

            //AGREGO LOS DISTINTOS TIPOS DE TRANSPORTE
            ListaDeTransporte.Add(autito);
            ListaDeTransporte.Add(ico);
            ListaDeTransporte.Add(chalenger);
            ListaDeTransporte.Add(miTransporte);

            //RECORRO LA LISTA CON UN FOREACH
            foreach (Transporte transporteAux in ListaDeTransporte)
            {
                //LA IMPLEMENTACIÓN SE RESUELVE EN TIEMPO DE EJECUCIÓN
                transporteAux.Avanzar();
                transporteAux.Frenar();

                Console.WriteLine("---------------------------------------");
            }

            Console.ReadLine();
            Console.Clear();

            foreach (Transporte item in ListaDeTransporte)
            {
                Console.WriteLine(item.ToString());

                Console.WriteLine("---------------------------------------");
            }

            Console.ReadLine();
        }
    }
}

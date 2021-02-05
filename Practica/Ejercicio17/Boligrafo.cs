using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17Boligrafo
{
    class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;


        public Boligrafo(short tinta, ConsoleColor color)
        {
            this.tinta = tinta;
            this.color = color;
        }
       
        public ConsoleColor GetColor()
        {
            return this.color;
        
        }

        public short GetTinta()
        {
            return this.tinta;
        }


        public bool Pintar(short gasto, out string dibujo)
        {
            bool esValido = false;
            short tintaDisponible = this.GetTinta();
            dibujo = "";
            short nivelTintaAux = tintaDisponible;

            
            if (tintaDisponible > 0 && gasto < 0)
            {
                this.SetTinta(gasto);
                Console.ForegroundColor = this.color;
                
                for (int i = gasto; i < 0; i++)
                {
                    if (nivelTintaAux > 0)
                    {
                        dibujo += "*";
                        nivelTintaAux--;
                    }

                }

                Console.WriteLine("\n" + dibujo);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Se escibieron {0} caracteres\nTinta disponible: {1}", dibujo.Length, this.tinta);
                esValido = true;

            }

            if (tintaDisponible == 0)
            {
                Console.WriteLine("\nSin tinta para escribir.");
            }

            return esValido;

        }

        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }


        private void SetTinta(short tinta)
        {
            if (tinta < 0)
            {
                this.tinta += tinta;
                if (this.tinta < 0)
                {
                    this.tinta = 0;
                }
            }
            else
            {
                this.tinta += tinta;
                if (this.tinta > cantidadTintaMaxima)
                {
                    this.tinta = cantidadTintaMaxima;
                }
            }
        }
    }
}

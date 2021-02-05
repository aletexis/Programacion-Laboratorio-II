using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTempera
{
    class Tempera
    {
        private ConsoleColor color;
        private string marca;
        private int cantidad;

        public Tempera(ConsoleColor color, string marca, int cantidad)
        {
            this.color = color;
            this.marca = marca;
            this.cantidad = cantidad;
        }

        private string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Color: " + color);
            sb.AppendLine("Marca: " + marca);
            sb.AppendLine("Cantidad: " + cantidad);
            return sb.ToString();
        }

        public static string Mostrar(Tempera tempera)
        {
            return tempera.Mostrar();
        }


        public static bool operator ==(Tempera tempera1, Tempera tempera2)
        {
            return (tempera1.marca == tempera2.marca && tempera1.color == tempera2.color);
        }

        public static bool operator !=(Tempera tempera1, Tempera tempera2)
        {
            return !(tempera1 == tempera2);
        }

        //implicit (tempera) : int // cantidad
        public static implicit operator int(Tempera tempera)
        {
            int cantidad = 0;
            if (tempera != null)
            {
                cantidad = tempera.cantidad;
            }

            return cantidad;
        }

        public static bool operator +(Tempera tempera1, Tempera tempera2)
        {
            bool retorno = false;

            //Crear instancia nueva de tempera.

            if (tempera1 != null && tempera2 != null)
            {
                retorno = tempera1 == tempera2;
                if (retorno)
                {
                    Tempera aux = new Tempera(tempera1.color, tempera1.marca, tempera1.cantidad += tempera2.cantidad);

                }

            }
            return retorno;
        }

        public static bool operator -(Tempera tempera1, Tempera tempera2)
        {
            bool retorno = tempera1 == tempera2;
            if (retorno)
                tempera1.cantidad -= tempera2.cantidad;

            return retorno;
        }

        public static Tempera operator +(Tempera tempera1, int cantidadTempera)
        {
            if (tempera1 != null)
            {
                tempera1.cantidad += cantidadTempera;
            }

            return tempera1;
        }
    }

    //+ (tempera, tempera) : tempera
    //-> si temperas iguales, acumula cantidad


    //+ (tempera, int) : tempera
    //-> acumula cantidad

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTempera
{
    class Paleta
    {
        private Tempera[] temperas;
        private int cantidadMaximaColores;


        private Paleta() : this(5)
        {

        }

        public Paleta(int cantidadMaxima)
        {
            this.cantidadMaximaColores = cantidadMaxima;
            this.temperas = new Tempera[this.cantidadMaximaColores];
        }

        public static implicit operator Paleta(int cantidad)
        {
            Paleta p = new Paleta(cantidad);
            return p;
        }



    }
    /*
     public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Listado de temperas: \n\n");
            foreach (Tempera t1 in this.temperas)
            {
                if (t1 != null)
                    sb.AppendFormat(Tempera.Mostrar(t1));
            }
            return sb.ToString();
        }

        public static explicit operator string(Paleta p)
        {
            return p.Mostrar();
        }

        public static bool operator ==(Paleta p, Tempera t1)
        {
            bool retorno = false;
            foreach (Tempera aux in p.temperas)
            {
                if (aux == t1)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }

        public static bool operator !=(Paleta p, Tempera t1)
        {
            return !(p == t1);
        }

        public int ObtenerIndice()
        {
            int indiceRetornado = -1;
            int contador = 0;
            foreach (Tempera t1 in this.temperas)
            {
                if (t1 == null)
                {
                    indiceRetornado = contador;
                    break;
                }


                else
                    contador++;
            }

            return indiceRetornado;
        }

        public int ObtenerIndice(Tempera t1)
        {
            int indice = -1;
            int contador = 0;

            foreach (Tempera aux in this.temperas)
            {
                if (aux == t1)
                {
                    indice = contador;
                    break;
                }

                else
                    contador++;
            }
            return indice;
        }

        public static Paleta operator +(Paleta p, Tempera t1)
        {
            int indice = p.ObtenerIndice(t1);
            int indiceVacio;
            bool sumaEfectuada;

            if (indice == -1)
            {
                indiceVacio = p.ObtenerIndice();
                //Mediante casteo implicito de cantidad de tempera.
                if (t1 > 0)
                    p.temperas[indiceVacio] = t1;
            }
            else
            {
                sumaEfectuada = p.temperas[indice] + t1;
            }

            return p;
        }

        public static Paleta operator -(Paleta p, Tempera t1)
        {
            int indice = p.ObtenerIndice(t1);
            int t1Cantidad = t1;
            bool restaEfectuada;
            int cantidadEnPosicion;
            if (indice != -1)
            {
                restaEfectuada = p.temperas[indice] - t1;
                cantidadEnPosicion = p.temperas[indice];
                if (cantidadEnPosicion <= 0)
                    p.temperas[indice] = null;
            }
            return p;
        }

        public static Paleta operator +(Paleta p1, Paleta p2)
        {
            Paleta nuevaPaleta = new Paleta(p2.cantidadMaximaColores);
            int i;
            int x;
            bool sumador;
            int cantidadSumada;
            int indice = 0;
            ////Cargo en la paleta resultante todo lo contenido en la primer paleta
            //for (i = 0; i < p1.cantidadMaximaColores; i++)
            //{
            //    if (p1.temperas[i] != null)
            //        nuevaPaleta += p1.temperas[i];
            //}

            ////Comparo la segunda paleta con la paleta resultante y si las temperas son iguales, las sumo.            
            //for (i = 0; i < p2.cantidadMaximaColores; i++)
            //{
            //    if (p2.temperas[i] != null)
            //    {
            //        for (x = 0; x < nuevaPaleta.cantidadMaximaColores; x++)
            //        {
            //            if (nuevaPaleta.temperas[x] != null)
            //            {
            //                //Obtengo la cantidad de tempera a sumar.
            //                cantidadSumada = p2.temperas[i];
            //                if (p2.temperas[i] == nuevaPaleta.temperas[x])
            //                {
            //                    nuevaPaleta.temperas[x] += cantidadSumada;
            //                }
            //                //Sino son iguales, la agrego
            //                else
            //                {
            //                    nuevaPaleta += p2.temperas[i];
            //                }
            //            }
            //        }
            //    }
            //}


            //Recorro la primer paleta y cargo todas sus temperas dentro de la nuevaPaleta.
            foreach (Tempera temperaP1 in p1.temperas)
            {
                if (temperaP1 != null)
                    nuevaPaleta += temperaP1;
            }
            //Recorro la segunda y compara cada tempera con las temperas que tenga la nuevaPaleta.
            //Si está, suma cantidades, sino la agrega.
            foreach (Tempera temperaP2 in p2.temperas)
            {
                if (temperaP2 != null)
                    nuevaPaleta += temperaP2;


            }

            return nuevaPaleta;
        }
     
     */

    //////////////////////////////////////////////
    //(-)Mostrar() :string


    //explicit (Paleta):string


    //==(paleta, tempera):bool
    //*->si tempera esta en paleta-->true

    ////obtenerIndice + 1overload
    //*)obtenerIndice() :int
    // *-> retorna el indice del primer lugar disponible(null) o valor neg.si no hay lugar
    //*)obtenerIndice(Tempera) :int
    // *->retorna el indice donde se encuentra la tempera o valor neg.si no la encuentra

    //+(paleta, tempera):paleta
    //*->si tempera esta en paleta-->incrementa cantidad en tempera
    //*->si no esta--> agrega la tempera en el primer lugar disponible


    //-(paleta, tempera):paleta
    //*->si tempera esta en paleta->decrementa cantidad
    //*)si cantidad menor o igual a cero, elimina la tempera(null)


    //+(paleta, paleta):paleta
    //*->genera una paleta con los colores de ambas paletas.
    //*)si temperas son iguales-->suma cantidades

}

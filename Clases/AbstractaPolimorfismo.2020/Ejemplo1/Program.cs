using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Ejemplo;

namespace TestEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseUno c1 = new ClaseUno("Primera Clase");
            ClaseDos c2 = new ClaseDos("Primera Clase", "Segunda Clase");
            ClaseTres c3 = new ClaseTres("Primera Clase", "Segunda Clase", "Tercera Clase");

            Console.WriteLine(c1.TipoClaseUno);
            Console.WriteLine(c2.TipoClaseDos);
            Console.WriteLine(c3.TipoClaseTres);

            Console.WriteLine(c1.MostrarClaseUno());
            Console.WriteLine(c2.MostrarClaseDos());
            Console.WriteLine(c3.MostrarClaseTres());


            Console.ReadLine();

            //CREO LISTA GENERICA DE TIPO CLASEUNO
            List<ClaseUno> listaUno = new List<ClaseUno>();

            listaUno.Add(c1);
            listaUno.Add(c2);
            listaUno.Add(c3);

            //CREO LISTA GENERICA DE TIPO CLASEDOS
            List<ClaseDos> listaDos = new List<ClaseDos>();

            //listaDos.Add(c1);//ERROR
            listaDos.Add(c2);
            listaDos.Add(c3);

            //CREO LISTA GENERICA DE TIPO CLASETRES
            List<ClaseTres> listaTres = new List<ClaseTres>();

            //listaTres.Add(c1);//ERROR
            //listaTres.Add(c2);//ERROR
            listaTres.Add(c3);

            Console.ReadLine();

            //RECORRO LA LISTA... CUANDO EL OBJETO SEA CLASEDOS O CLASETRES -> ERROR!
            foreach (ClaseUno item in listaUno)
            {

                Console.WriteLine(item.TipoClaseUno);
                Console.WriteLine(item.MostrarClaseUno());

            }

            Console.ReadLine();









            #region Con Polimorfismo

            //foreach (ClaseUno item in listaUno)
            //{
            //    Console.WriteLine(item.Tipo);
            //    Console.WriteLine(item.Mostrar());
            //}

            //Console.ReadLine();
            #endregion
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Herencia;

namespace Herencia._2020
{
    class Program
    {
        static void Main(string[] args)
        {

            ClaseBase cb = new ClaseBase(6);
            cb.nombre = "clase base";
            
            ClaseDerivada cd = new ClaseDerivada(1);

            cd.nombre = "clase derivada";            
            cd.Compila();

            Console.WriteLine(cd.Id);

            ClaseError error = new ClaseError();

            error.Compila();
            error.Falla(new ClaseBase(1));

            Console.ReadLine();

            
            ClaseSellada cs = new ClaseSellada();

            Console.WriteLine(cs.Id);

            Console.ReadLine();

        }
    }
}

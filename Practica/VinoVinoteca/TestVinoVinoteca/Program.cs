using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestVinoVinoteca
{
    class Program
    {
        static void Main(string[] args)
        {
            Vino v1 = new Vino(ETipoVino.Malbec, EBodega.Zuccardi);
            Vino v2 = new Vino(ETipoVino.Malbec, EBodega.Garzón);
            Vino v3 = new Vino(ETipoVino.Merlot, EBodega.Marquéz_de_Riscal);
            Vino v4 = new Vino(ETipoVino.Malbec, EBodega.Zuccardi);

            if (v1 == v2)
            {
                Console.WriteLine("El vino {0} es igual al vino {1}", v1.Mostrar(), v2.Mostrar());
            }

            if (v1 != v2)
            {
                Console.WriteLine("El vino {0} es distinto al vino {1}", v1.Mostrar(), v2.Mostrar());
            }

            if (v1 == v4)
            {
                Console.WriteLine("El vino {0} es igual al vino {1}", v1.Mostrar(), v4.Mostrar());
            }

            if (v2 != v3)
            {
                Console.WriteLine("El vino {0} es distinto al vino {1}", v2.Mostrar(), v3.Mostrar());
            }

            //comparo contra null
            if (v1 != null)
            {
                Console.WriteLine("El vino {0} es distinto a null", v1.Mostrar());
            }

            if (null != v2)
            {
                Console.WriteLine("El valor null es distinto al vino {0}", v2.Mostrar());
            }

            Vinoteca vinoteca = new Vinoteca(3);

            vinoteca += v1;

            //verifico el buen funcionamiento del Mostrar.
            Console.WriteLine(vinoteca.Mostrar());

            vinoteca += v2;
            vinoteca += v3;
            vinoteca += v4;

            Console.WriteLine(vinoteca.Mostrar());

            Console.ReadLine();
        }
    }
}

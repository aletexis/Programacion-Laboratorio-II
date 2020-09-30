using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace test.sobrecarga.operadores
{
    class Program
    {
        static void Main(string[] args)
        {
            //se reemplaza new Numero(5) por 5
            Numero n1 = 5;
            //se reemplaza new Numero(4) por 4
            Numero n2 = 4;

            if (n1 == n2)
            {
                Console.WriteLine("son iguales");
            }

            if (n1 != n2)
            {
                Console.WriteLine("son distintos");
            }

            if (n1 == 5)
            {
                Console.WriteLine("son iguales");
            }

            if (n1 != 8)
            {
                Console.WriteLine("son distintos");
            }

            Numero res = n1 + n2;

            //se reemplaza res.valor por (double)res --> se invoca a la conversión explícita
            Console.WriteLine("suma = {0}", (double)res);

            res = n1 - n2;

            //se reemplaza res.valor por (double)res --> se invoca a la conversión explícita
            Console.WriteLine("resta = {0}", (double)res);

            Numero inc_dec = res++;

            Console.WriteLine("incremento -> {0}", (double)inc_dec);

            Console.WriteLine("decremento -> {0}", (double)inc_dec--);

            Console.ReadLine();
        }
    }
}

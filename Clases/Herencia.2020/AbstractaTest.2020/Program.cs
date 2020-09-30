using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace AbstractaTest._2020
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa("Accentuna");

            //Empleado e = new Empleado("No se pude", "Instanciar", 0, 0); //ERROR!

            Administrativo a1 = new Administrativo("Juana", "Pérez", 123, 22000, ESimpatia.MuyPoca);
            Administrativo a2 = new Administrativo("Mariana", "Re", 124, 22500, ESimpatia.NiPreguntes);

            Cadete c = new Cadete("Pedro", "Alfonso", 210, 18000, "Peter");

            Programador p1 = new Programador("Álvaro", "Fernandez", 345, 32000, ECategoria.Junior);
            Programador p2 = new Programador("María", "Hernandez", 378, 42000, ECategoria.SemiSenior);

            Console.WriteLine(a1.ToString());
            Console.WriteLine(a2);// POR DEFECTO, SE INVOCA AL .TOSTRING()
            Console.WriteLine(c.ToString());
            Console.WriteLine(p1.ToString());
            Console.WriteLine(p2.ToString());

            Console.ReadLine();
            Console.Clear();

            empresa += a1;
            empresa += a2;

            empresa += c;

            empresa += p1;
            empresa += p2;

            Console.WriteLine(empresa);// POR DEFECTO, SE INVOCA AL .TOSTRING()

            Console.ReadLine();
            Console.Clear();

            if (a1.Equals(a2))
            {
                Console.WriteLine("Los 'administrativos' son iguales.");
            }
            else
            {
                Console.WriteLine("Los 'administrativos' NO son iguales.");
            }

            if (p1.Equals(new Programador("Nombre", "Apellido", 345, 0)))
            {
                Console.WriteLine("Los 'programadores' son iguales.");
            }
            else
            {
                Console.WriteLine("Los 'programadores' NO son iguales.");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace TestHerencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Empresa empresa = new Empresa("Accentuna");

            Administrativo a1 = new Administrativo("Juana", "Pérez", 123, 22000, ESimpatia.MuyPoca);
            Administrativo a2 = new Administrativo("Mariana", "Re", 124, 22500, ESimpatia.NiPreguntes);

            Cadete c = new Cadete("Pedro", "Alfonso", 210, 18000, "Peter");

            Programador p1 = new Programador("Álvaro", "Fernandez", 345, 32000, ECategoria.Junior);
            Programador p2 = new Programador("Julio", "Churches", 345, 52000);
            Programador p3 = new Programador("María", "Hernandez", 378, 42000, ECategoria.SemiSenior);
            Programador p4 = new Programador("Augusto", "Martinez", 389, 92000);

            p4.Categoria = ECategoria.MasterOfTheUniverse;

            empresa += a1;
            empresa += a2;

            empresa += c;

            empresa += p1;
            empresa += p2;
            empresa += p3;
            empresa += p4;

            Console.WriteLine(empresa.ToString());

            Console.ReadLine();


            //ordenamiento por SUELDO ascendente
            empresa.Empleados.Sort(Empleado.OrdernarPorSueldoAsc);

            Console.WriteLine(empresa.ToString());
            Console.ReadLine();

            //ordenamiento por SUELDO descendente
            empresa.Empleados.Sort(Empleado.OrdernarPorSueldoDesc);

            Console.WriteLine(empresa.ToString());
            Console.ReadLine();

            //ordenamiento por APELLIDO ascendente
            empresa.Empleados.Sort(Empleado.OrdernarPorApellidoAsc);

            Console.WriteLine(empresa.ToString());
            Console.ReadLine();

            //ordenamiento por APELLIDO descendente
            empresa.Empleados.Sort(Empleado.OrdernarPorApellidoDesc);

            Console.WriteLine(empresa);
            Console.ReadLine();

            Console.Clear();

            Console.WriteLine("Monto TOTAL de sueldos: {0}", empresa.TotalSueldos);
            Console.WriteLine("Monto de sueldos por ADMINISTRATIVOS: {0}", empresa.TotalSueldosAdministrativos);
            Console.WriteLine("Monto de sueldos por CADETES: {0}", empresa.TotalSueldosCadetes);
            Console.WriteLine("Monto de sueldos por PROGRAMADORES: {0}", empresa.TotalSueldosProgramadores);

            Console.ReadLine();

            Programador p = new Programador("nn", "nn", 666, 0);

            if (! (empresa - p))
            {
                Console.WriteLine("No se pudo eliminar al empleado {0}", p.ToString());
            }

            if (empresa - a2)
            {
                Console.WriteLine("Se pudo eliminar al empleado {0}", a2.ToString());
            }

            Console.WriteLine();

            Console.WriteLine(empresa.ToString());

            Console.ReadLine();
        }
    }
}

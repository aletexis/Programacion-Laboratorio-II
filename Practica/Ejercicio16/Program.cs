/*. Crear la clase Alumno de acuerdo al siguiente diagrama:
 * 
 * Campos:
 * private nota1 : byte
 * private nota2 : byte
 * private notaFinal : float
 * public apellido : string
 * public legajo : int
 * public nombre : string
 * 
 * Metodos:
 * CalcularFinal() : void
 * Estudiar(byte notaUno, byte notaDos) : void
 * Mostrar() : string
 * 
a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main. Colocarle
nombre, apellido y legajo a cada uno de ellos.
b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2 son mayores o
iguales a 4, caso contrario la inicializará con -1. Para darle un valor a la nota final utilice
el método de instancia Next de la clase Random.
d. El método Mostrar, expondrá en la consola todos los datos de los alumnos. La nota final se
mostrará sólo si es distinto de -1, caso contrario se mostrará la leyenda "Alumno
desaprobado".
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio16";

            Alumno primerAlumno = new Alumno("Bon", "Iver", 100);
            Alumno segundoAlumno = new Alumno("Sufjan", "Stevens", 101);
            Alumno tercerAlumno = new Alumno("Amber", "Run", 102);
            byte notaUno;
            byte notaDos;

            Console.Write("\nIngrese la primer nota de {0} {1}: ", primerAlumno.nombre, primerAlumno.apellido);
            notaUno = byte.Parse(Console.ReadLine());
            Console.Write("\nIngrese la segunda nota de {0} {1}: ", primerAlumno.nombre, primerAlumno.apellido);
            notaDos = byte.Parse(Console.ReadLine());
            primerAlumno.Estudiar(notaUno, notaDos);
            primerAlumno.CalcularFinal();
            Console.Write(primerAlumno.Mostrar());

            Console.Write("\n\n----------------------------------------------\n");

            Console.Write("\nIngrese la primer nota de {0} {1}: ", segundoAlumno.nombre, segundoAlumno.apellido);
            notaUno = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda nota de {0} {1}: ", segundoAlumno.nombre, segundoAlumno.apellido);
            notaDos = byte.Parse(Console.ReadLine());
            segundoAlumno.Estudiar(notaUno, notaDos);
            segundoAlumno.CalcularFinal();
            Console.Write(segundoAlumno.Mostrar());

            Console.Write("\n\n----------------------------------------------\n");

            Console.Write("\nIngrese la primer nota de {0} {1}: ", tercerAlumno.nombre, tercerAlumno.apellido);
            notaUno = byte.Parse(Console.ReadLine());
            Console.Write("Ingrese la segunda nota de {0} {1}: ", tercerAlumno.nombre, tercerAlumno.apellido);
            notaDos = byte.Parse(Console.ReadLine());
            tercerAlumno.Estudiar(notaUno, notaDos);
            tercerAlumno.CalcularFinal();
            Console.Write(tercerAlumno.Mostrar());

            Console.ReadKey(true);

        }
    }
}

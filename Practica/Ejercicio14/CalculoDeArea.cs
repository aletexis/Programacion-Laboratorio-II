using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio14
{
    class CalculoDeArea
    {
        public static double CalcularCuadrado(double side)
        {
            double area;

            area = (side * side);

            return area;
        }

        public static double CalcularTriangulo(double triangleBase, double triangleHeight)
        {
            double area;

            area = (triangleBase * triangleHeight) / 2;

            return area;
        }

        public static double CalcularCirculo(double radio)
        {
            double area;

            area = (3.14 * radio * radio);

            return area;
        }
    }
}

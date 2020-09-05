/*Realizar una clase llamada CalculoDeArea que posea 3 métodos de clase (estáticos) que realicen el
cálculo del área que corresponda:
a. double CalcularCuadrado(double)
b. double CalcularTriangulo(double, double)
c. double CalcularCirculo(double)
El ingreso de los datos como la visualización se deberán realizar desde el método Main().*/

using System;

namespace Ejercicio14
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Title = "Ejercicio14";
            double squareSide;
            double triangleBase;
            double triangleHeight;
            double circleRadius;

            double squareArea;
            double triangleArea;
            double circleArea;

            Console.Write("\nIngrese un lado del cuadrado: ");
            squareSide = double.Parse(Console.ReadLine());

            Console.Write("\n----------------------------------------\n");

            Console.Write("\nIngrese la base del triangulo: ");
            triangleBase = double.Parse(Console.ReadLine());

            Console.Write("\nIngrese la altura del triangulo: ");
            triangleHeight = double.Parse(Console.ReadLine());

            Console.Write("\n----------------------------------------\n");

            Console.Write("\nIngrese el radio del circulo: ");
            circleRadius = double.Parse(Console.ReadLine());

            Console.Write("\n----------------------------------------\n");

            squareArea = CalculoDeArea.CalcularCuadrado(squareSide);
            triangleArea = CalculoDeArea.CalcularTriangulo(triangleBase, triangleHeight);
            circleArea = CalculoDeArea.CalcularCirculo(circleRadius);


            Console.Write("\nEl area del cuadrado es: {0}", squareArea);
            Console.Write("\nEl area del triangulo es: {0}", triangleArea);
            Console.Write("\nEl area del circulo es: {0}", circleArea);

        }
    }
}

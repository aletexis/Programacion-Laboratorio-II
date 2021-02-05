using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometría
{
    class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;


        public float Area()
        {
            int flag = 0;
            
            if (flag == 0)
            {
                int baseRectangulo = this.Base();
                int alturaRectangulo = this.Altura(this.vertice2);

                this.area = baseRectangulo * alturaRectangulo;
                flag = 1;
            }

            return this.area;
        }

        public float Perimetro()
        {
            int flag = 0;
            
            if (flag == 0)
            {
                int baseRectangulo = this.Base();
                int alturaRectangulo = this.Altura(this.vertice2);

                this.perimetro = (baseRectangulo + alturaRectangulo) * 2;
                flag = 1;
            }

            return this.perimetro;
        }


        public Rectangulo(Punto vertice1, Punto vertice3)
        {
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
        }

        public int Altura(Punto dos)
        {
            int vertice2Y = Math.Abs(dos.GetY());
            int vertice1Y = Math.Abs(this.vertice1.GetY());
            return vertice2Y - vertice1Y;
        }
        public int Base()
        {
            int vertice1X = Math.Abs(this.vertice1.GetX());
            int vertice3X = Math.Abs(this.vertice3.GetX());
            return vertice3X - vertice1X;
        }

    }
}

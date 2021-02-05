using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Remedio : Producto
    {
        public Remedio(string tipo, string marca, float precio)
           : base(tipo, marca, precio)
        {

        }
    }
}
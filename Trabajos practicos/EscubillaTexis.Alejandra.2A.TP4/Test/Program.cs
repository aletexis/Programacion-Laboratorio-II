using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Excepciones;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Artistica artistica = new Artistica(8);
            
            Pincel pincel1 = new Pincel(1000, "Pincel", "Escoda", 1, 120, ETipoPincel.Abanico);
            Pincel pincel2 = new Pincel(1001, "Pincel", "Arteza", 2, 250, ETipoPincel.Redondo);
            Pincel pincel3 = new Pincel(1002, "Pincel", "DaVinci", 2, 300, ETipoPincel.Plano);
            
            Pintura pintura1 = new Pintura(1003, "Pintura", "Alba", 1, 400, ETipoPintura.Acrilico);
            Pintura pintura2 = new Pintura(1004, "Pintura", "Winsor&Newton", 1, 600, ETipoPintura.Acuarela);
            Pintura pintura3 = new Pintura(1005, "Pintura", "Caran d'Ache", 1, 570, ETipoPintura.Pastel);
            Pintura pintura4 = new Pintura(1006, "Pintura", "Faber-Castell", 1, 630, ETipoPintura.Tempera);
            
            Bastidor bastidor1 = new Bastidor(1007, "Bastidor", "Seurat", 1, 1200, ETamaño.Chico);
            Bastidor bastidor2 = new Bastidor(1008, "Bastidor", "Creart", 1, 1500, ETamaño.Grande);

            artistica += pincel1;
            artistica += pincel2;
            artistica += pincel3;

            artistica += pintura1;
            artistica += pintura2;
            artistica += pintura3;
            artistica += pintura4;
            
            artistica += bastidor1;
           

            try
            {
                artistica -= bastidor2;
            }
            catch (FueraDeStockException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                artistica += bastidor2;
            }
            catch (DepositoLlenoException ex)
            {
                Console.WriteLine(ex.Message);
            }

            artistica.Vender(pintura2, 2);
            artistica.Vender(bastidor1, 1);

            Console.WriteLine("");
            Console.WriteLine(artistica.MostrarVentas());

            artistica.Vender(pintura1, 3);

            Console.WriteLine("");
            Console.WriteLine(artistica.MostrarVentas());
            Console.WriteLine(artistica.MostrarProductos());

            try
            {
                Artistica.Guardar(artistica);
                Console.WriteLine("Archivo de Artistica guardado.");
            }
            catch (ArchivosException e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}

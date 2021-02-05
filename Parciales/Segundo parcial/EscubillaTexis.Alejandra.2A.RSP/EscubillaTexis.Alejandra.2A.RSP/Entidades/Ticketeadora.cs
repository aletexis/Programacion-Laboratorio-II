using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class Ticketeadora<T> where T : Producto
    {
        public static bool ImprimirTicket(Caja<T> caja)
        {
            bool retorno = true;

            string path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "tickets.log");

            try
            {
                using (StreamWriter sw = new StreamWriter(path, true))
                {
                    sw.Write("Fecha y hora: ");
                    sw.WriteLine(DateTime.Now);
                    sw.Write("Precio total de la caja: ");
                    sw.WriteLine(caja.PrecioTotal.ToString());
                }
            }
            catch (Exception)
            {
                retorno = false;
            }

            return retorno;
        }
    }
}

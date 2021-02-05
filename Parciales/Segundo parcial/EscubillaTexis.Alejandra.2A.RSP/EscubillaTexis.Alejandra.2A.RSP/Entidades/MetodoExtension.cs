using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class MetodoExtension
    {
        public static string InformarNovedad(this CajaLlenaException ex)
        {
            return ex.Message;
        }
    }
}

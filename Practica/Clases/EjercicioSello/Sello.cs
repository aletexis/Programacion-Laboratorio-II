using System;

namespace EjercicioSello
{
    public static class Sello
    {
        public static string mensaje;
        public static ConsoleColor color;

        public static string Imprimir()
        {
            return Sello.ArmarFormatoMensaje();
        }

        public static void Borrar()
        {
            Sello.mensaje = "";
        }

        public static void ImprimirEnColor()
        {
            Console.ForegroundColor = Sello.color; //cambio el color por el color predefinido en el main
            Console.WriteLine(Sello.Imprimir()); //lo muestro
            Console.ForegroundColor = ConsoleColor.Gray; //vuelvo al color original
        }

        private static string ArmarFormatoMensaje()
        {
            string formato = string.Empty;
            string mensajeFormateado;
            int len = Sello.mensaje.Length;

            for (int i = 0; i < len + 2; i++)
            {
                formato = formato + "*";
            }

            mensajeFormateado = $"\n{formato}\n*{Sello.mensaje}*\n{formato}";

            return mensajeFormateado;
        }
    }
}

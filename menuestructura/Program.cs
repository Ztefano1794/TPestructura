using System;

namespace TipoMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Seleccione una de las opciones:");
            Console.WriteLine("1) Invertir lo escrito");
            Console.WriteLine("2) Eliminar los espacios");
            Console.WriteLine("3) Salir del programa");
            Console.Write("\r\nSelecciones una de las opciones: ");

            switch (Console.ReadLine())
            {
                case "1":
                    ReverseString();
                    return true;
                case "2":
                    RemoveWhitespace();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

        private static string CaptureInput()
        {
            Console.Write("Ingrese la oracion: ");
            return Console.ReadLine();
        }

        private static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Invertir la oracion");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }

        private static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Elimine los espacios");

            DisplayResult(CaptureInput().Replace(" ", ""));
        }

        private static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nSu oracion modificada es: {message}");
            Console.Write("\r\nPresione enter para volver al menu");
            Console.ReadLine();
        }
    }
}


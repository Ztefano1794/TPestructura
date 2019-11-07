using System;
using System.Collections;
using System.Linq;

namespace Prueba
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
            Console.ReadLine();
        }

        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Seleccione una de las opciones:");
            Console.WriteLine("1) Invertir lo escrito");
            Console.WriteLine("2) Eliminar los espacios");
            Console.WriteLine("3) Averiguar si es palindromo");
            Console.WriteLine("4) Salir del programa");
            Console.Write("Seleccione una de las opciones: ");

            switch (Console.ReadLine())
            {
                case "1":
                    InvertirOracion();
                    return true;
                case "2":
                    EliminarEspacios();
                    return true;
                case "3":
                    EsPalindromo();
                    return true;
                case "4":
                    return false;
                default:
                    return true;
            }
        }

       

        private static void EliminarEspacios()
        {
            Console.Clear();
            Console.WriteLine("Elimine los espacios");

            MostrarResultado(CapturarOracion().Replace(" ", ""));
        }

        private static void MostrarResultado(string message)
        {
            Console.WriteLine();
            Console.WriteLine("Su oracion modificada es: {0}", message);
            Console.WriteLine();
            Console.WriteLine("Presione enter para volver al menu");
            Console.ReadLine();
        }

        private static string CapturarOracion()
        {
            Console.Write("Ingrese la oracion: ");
            return Console.ReadLine();
        }

        private static void InvertirOracion()
        {
            Console.Clear();
            Console.WriteLine("Invertir la oracion");

            char[] charArray = CapturarOracion().ToCharArray();
            Array.Reverse(charArray);
            MostrarResultado(String.Concat(charArray));
        }

        private static void EsPalindromo()
        {
            Console.Clear();
            Console.WriteLine("¿Es Palindromo?");

            string palabra = CapturarOracion();
            //string reverso = string.Empty;
            
            char[] charPalabra = palabra.ToCharArray();
            Array.Reverse(charPalabra);

            //Console.Write("{0}", String.Concat(charPalabra));

            if (palabra.Equals(String.Concat(charPalabra)))
            {
                Console.WriteLine();
                Console.WriteLine("Su oracion modificada es: {0}", String.Concat(charPalabra));
                Console.WriteLine();
                Console.WriteLine("Es palindromo");
                Console.WriteLine();
                Console.WriteLine("Presione enter para volver al menu");
                           
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Su oracion modificada es: {0}", String.Concat(charPalabra));
                Console.WriteLine();
                Console.WriteLine("No es palindromo");
                Console.WriteLine();
                Console.WriteLine("Presione enter para volver al menu");
                
            }                            
            Console.ReadLine();
        }
    }
}


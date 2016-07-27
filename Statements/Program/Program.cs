using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            bool proceed = true;
            while (proceed)
            {
                char selection = printmenu();
                switch (selection)
                {
                    case 'a':
                        addvalues();
                        break;
                    case 'b':
                        concatenateStrings();
                    case 'c':
                        loopANumber();
                        break;
                    case 'd':
                        proceed = false;
                        break;
                    default:
                        Console.WriteLine("opcion incorrecta");
                        break;
                }
                Console.WriteLine("Adios");
            }
        }

        private static void loopANumber()
        {
            throw new NotImplementedException();
        }

        private static void concatenateStrings()
        {
            throw new NotImplementedException();
        }

        private static void addvalues()
        {
            throw new NotImplementedException();
        }

        static char printmenu()
        {
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("a-Sumar dos valores.");
            Console.WriteLine("b-Concatenar dos strings.");
            Console.WriteLine("c-Iterar un numero.");
            Console.WriteLine("d-Salir.");
            char option = (char)Console.Read();
            Console.WriteLine();
            return option;


        }
    }
}

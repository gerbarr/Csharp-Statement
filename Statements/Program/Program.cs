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
                char selecction = printMenu();
                switch (selecction)
                {
                    case 'a':
                        addValues();
                        break;
                    case 'b':
                        concatenateStrings();
                        break;
                    case 'c':
                        loopANumber();
                        break;
                    case 'd':
                        proceed = false;
                        Console.WriteLine("Adios");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opción incorrecta.");
                        break;
                }
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

        private static void addValues()
        {
            throw new NotImplementedException();
        }

        static char printMenu()
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("a-Sumar dos valores.");
            Console.WriteLine("b-Concatenar dos strings.");
            Console.WriteLine("c-Iterar un número.");
            Console.WriteLine("d-Salir.");
            char option = (char)Console.Read();
            Console.WriteLine();
            return option;
        }
    }
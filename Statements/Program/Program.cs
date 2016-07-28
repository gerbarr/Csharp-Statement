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
               char selection = printMenu();
                switch (selection)
                {
                    case 'a':
                        addValues();
                        break;
                    case 'b':
                        concatenationStrings();
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
                        Console.WriteLine("Opcion Incorrecta");
                        break;
                }

                Console.ReadKey();

            } 
        }

        private static void loopANumber()
        {
            int value;

            Console.WriteLine("Por Favor ingrese un numero");
            Console.ReadLine();
            value = Convert.ToInt32(Console.ReadLine());


            for (int i = 0; i < value; i++)

            {

                Console.WriteLine("El resultado es:" + i);
            }


        }
               

        private static void concatenationStrings()
        {

            Console.WriteLine("Ingrese el primer texto: ");
            Console.ReadLine();
            string text1 = Convert.ToString(Console.ReadLine());
            

            Console.WriteLine("Ingrese el segundo texto: ");
            string text2 = Convert.ToString(Console.ReadLine());

            Console.WriteLine("El resultado es: " + text1 + text2);



        }

        private static void addValues()
        { 
            
            int v1, v2,r ;
            Console.WriteLine("Ingrese un numero:");
            Console.ReadLine();
            v1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese otro numero:");
            v2 = Convert.ToInt32(Console.ReadLine());
         
            r = v1 + v2;
            Console.WriteLine("El resultado es:" + r);
            Console.ReadLine();
            Console.ReadKey();

        }



        static char printMenu()
        {
            Console.WriteLine("Seleccione una opcion:");
            Console.WriteLine("a - Sumar dos valores.");
            Console.WriteLine("b - Concantenar dos Strings.");
            Console.WriteLine("c - Iterar un numero.");
            Console.WriteLine("d - Salir.");
            char option = (char)Console.Read();
            Console.WriteLine();
            return option;
        }
    }
}

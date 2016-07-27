using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("ingrese un caracter");
            char c = (char)Console.Read();

            // condicion tipo if 
            if (char.IsLetter(c)) {
                if (char.IsLower(c))
                {
                    Console.WriteLine("el caracter es minuscula.");
                }
                else
                {
                    Console.WriteLine("El caracter es mayuscula.");
                }
                Console.WriteLine("El caracter no es una letra.");
            }
            Console.ReadKey();
        }
    }
}

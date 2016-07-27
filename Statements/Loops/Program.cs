using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int value;

            Console.WriteLine("por favor ingrese un numero");
            value = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < value; i++)
            {
                Console.WriteLine("El valor de i es " + i);
            }

        }

        int u = 10;
        while (u >= 0)
        {
            Console.writeline  ("el valor de u es");
            u--;
            }


            Console.Read();

            




        }
    }
}

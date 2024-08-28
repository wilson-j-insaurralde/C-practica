using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Desarrollar un programa que muestre la tabla de multiplicar del 5 (del 5 al 50)

namespace ejercicio47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            for (int i = 1 ; i <= 10; i++)
            {
                x = i *5;
                Console.WriteLine(x);

            }
            Console.ReadKey();
        }
        
    }
}

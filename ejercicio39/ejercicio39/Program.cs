using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// 10 - Estructura repetitiva for
//Realizar un programa que imprima en pantalla los números del 1 al 100.

namespace ejercicio39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f;
            for (f = 1 ; f<=100; f++)
            {
                Console.Write(f);
                Console.Write("-");
            }
            Console.ReadKey();
        }
    }
}

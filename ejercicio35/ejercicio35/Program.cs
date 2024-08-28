using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. (No se ingresan valores por teclado)
namespace ejercicio35
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int x, y;
            x = 11;
            y = 1;
            while (y <= 25)
            {
                Console.Write(x);
                Console.Write("-");
                x = x + 11;
                y = y + 1;
            }
            Console.ReadKey();
        }
        
    }
}

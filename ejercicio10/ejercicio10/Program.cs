using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string linea;
            Console.WriteLine("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            if (num1 > num2) {
                Console.Write("el mayor es: ");
                Console.WriteLine(num1);
                   
                    }
            else
            {
                Console.Write("el mayor es: ");
                Console.WriteLine(num2);
            }
            Console.ReadKey();  
        }
    }
}

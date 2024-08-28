using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se cargan por teclado tres números distintos. Mostrar por pantalla el mayor de ellos
namespace ejercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            string linea;
            Console.WriteLine("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("ingrese el tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            if (num1 > num2 && num1>num3) {
                Console.WriteLine("el numero mayor es: " + num1);
            }
            else
            {
                if (num2 > num1 && num2 > num3)
                {
                    Console.WriteLine("el numero mayor es: " + num2);
                }
                else { Console.WriteLine("el numero mayor es: " + num3); }
            }
            Console.ReadKey();
        }
    }
}

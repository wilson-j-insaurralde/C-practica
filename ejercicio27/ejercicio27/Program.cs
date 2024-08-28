using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Escribir un programa en el cual:
// dada una lista de tres valores numéricos distintos se calcule e informe su rango de variación (debe mostrar el mayor y el menor de ellos)
namespace ejercicio27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int num1, num2, num3;
            Console.WriteLine("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingrese el segundo numero: ");
            linea =Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("ingrese el tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.Write("Rango de valores:");
            if (num1 < num2 && num1 < num3)
            {
                Console.Write(num1);
            }
            else
            {
                if (num2 < num3)
                {
                    Console.Write(num2);
                }
                else
                {
                    Console.Write(num3);
                }
            }
            Console.Write("-");
            if (num1 > num2 && num1 > num3)
            {
                Console.Write(num1);
            }
            else
            {
                if (num2 > num3)
                {
                    Console.Write(num2);
                }
                else
                {
                    Console.Write(num3);
                }
            }
            Console.ReadKey();

        }
    }
}

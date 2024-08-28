using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//  Escribir un programa en el cual se ingresen cuatro números,
//  calcular e informar la suma de los dos primeros y el producto del tercero y el cuarto. //
namespace ejercicio6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            int suma, producto;
            string linea;
            Console.WriteLine("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingrese el segundo numero:");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("ingrese el tercer numero:");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            Console.WriteLine("ingrese el cuarto numero: ");
            linea = Console.ReadLine();
            num4 = int.Parse(linea);
            suma = num1 + num2;
            producto = num3 * num4;
            Console.Write("la suma de los dos primeros es:");
            Console.WriteLine(suma);    
            Console.Write("el producto del tercero y el cuarto es:");
            Console.WriteLine(producto);
            Console.ReadKey();

        }
    }
}

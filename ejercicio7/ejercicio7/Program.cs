using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Realizar un programa que lea cuatro valores numéricos e informar su suma y promedio//
namespace ejercicio7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            int suma, promedio;
            string linea;
            Console.WriteLine("ingrese el primer valor: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingrese el segundo valor:");
            linea= Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("ingrese el tercer valor:");
            linea= Console.ReadLine();
            num3 = int.Parse(linea);
            Console.WriteLine("ingrese el cuarto valor:");
            linea= Console.ReadLine();
            num4 = int.Parse(linea);
            suma= num1 + num2 + num3 + num4;
            promedio = suma / 4 ;
            Console.Write("la suma de todos los numeros es: ");
            Console.WriteLine(suma);
            Console.Write("el promedio es: ");
            Console.WriteLine(promedio);
            Console.ReadLine(); 


        }
    }
}

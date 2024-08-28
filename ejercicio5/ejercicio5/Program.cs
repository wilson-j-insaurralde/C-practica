using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Realizar la carga del lado de un cuadrado, mostrar por pantalla el perímetro del mismo //
// (El perímetro de un cuadrado se calcula multiplicando el valor del lado por cuatro)  //
namespace ejercicio5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado, perimetro;
            string linea;
            Console.WriteLine("ingrese el valor del lado:");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            perimetro = lado * 4;
            Console.Write("el valor del perimetro es: ");
            Console.WriteLine(perimetro);
            Console.ReadKey();
        }
    }
}

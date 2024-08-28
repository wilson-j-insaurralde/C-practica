using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Hallar la superficie de un cuadrado conociendo el valor de un lado.//
namespace ejercicio3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lado, superficie;
            string linea;
            Console.WriteLine("ingrese valor del lado del cuadrado: ");
            linea = Console.ReadLine();
            lado = int.Parse(linea);
            superficie = lado*lado;
            Console.WriteLine("el valor de la superficie es: ");
            Console.WriteLine(superficie);
            Console.ReadLine(); 

        }
    }
}

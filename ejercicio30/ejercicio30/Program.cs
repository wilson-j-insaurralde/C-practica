using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre
//posteriormente la suma de los valores ingresados y su promedio.
namespace ejercicio30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int x, y, suma, promed;
            x = 1;
            suma = 0;
            while (x <= 10) {
                Console.WriteLine("ingrese el valor:");
                linea = Console.ReadLine();
                y = int.Parse(linea);
                x = x + 1;
                suma = suma + y;

                  }
            promed = suma / 10;
            Console.WriteLine("su suma es:" + suma);
            Console.Write("el promedio es: " + promed);
            Console.ReadKey();
        }
        
    }
}

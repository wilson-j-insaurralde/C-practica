using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Escribir un programa que solicite la carga de un valor positivo y nos muestre desde 1 hasta el valor ingresado de uno en uno.
//Ejemplo: Si ingresamos 30 se debe mostrar en pantalla los números del 1 al 30.
namespace ejercicio29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x, n;
            string linea;
            Console.WriteLine("ingrese el valor final:");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            x = 1;
            while (x <= n)
            {
                Console.Write(x);
                Console.Write("-");
                x= x + 1;


            }
            Console.ReadKey();  
        }
    }
}

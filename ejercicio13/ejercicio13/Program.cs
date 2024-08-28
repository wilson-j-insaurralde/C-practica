using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Se ingresa por teclado un número positivo de uno o dos dígitos (1..99) mostrar un mensaje indicando si el número tiene uno o dos dígitos.
// (Tener en cuenta que condición debe cumplirse para tener dos dígitos, un número entero)

namespace ejercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int num;
            Console.WriteLine("ingrese el numero: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            if (num >= 10) {
                Console.WriteLine("el numero pose dos digitos.");
            
            }
            else
            {

                Console.WriteLine("el numero es de un solo digio.");
            }
            Console.ReadKey();  

        }
    }
}

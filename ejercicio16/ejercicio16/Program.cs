using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Se ingresa por teclado un valor entero, mostrar una leyenda que indique si el número es positivo, nulo o negativo

namespace ejercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.WriteLine("ingrese el numero: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            if (num > 0) {
                Console.WriteLine("el numero es positivo.");
            }
            else
            {

                if (num == 0) { Console.WriteLine("el numero es nulo."); }
                else { Console.WriteLine("el numero es negativo."); }
            }
            Console.ReadKey();  
        }
        
    }
}

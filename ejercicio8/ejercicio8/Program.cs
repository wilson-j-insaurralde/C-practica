using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Se debe desarrollar un programa que pida el ingreso del precio de un artículo y la cantidad que lleva el cliente.
// Mostrar lo que debe abonar el comprador.  
//

namespace ejercicio8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int precio, cantidad;
            int abonar;
            string linea;
            Console.WriteLine("ingrese el precio de la unidad: ");
            linea = Console.ReadLine();
            precio = int.Parse(linea);
            Console.WriteLine("ingrese la cantidad:");
            linea = Console.ReadLine();
            cantidad = int.Parse(linea);
            abonar = cantidad * precio;
            Console.Write("el comprador debe abonar:");
            Console.WriteLine(abonar);  
            Console.ReadKey();
                

        }
    }
}

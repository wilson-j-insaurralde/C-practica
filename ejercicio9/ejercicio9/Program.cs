using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Estructuras condicionales simples y compuestas

namespace ejercicio9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sueldo;
            string linea;
            Console.WriteLine("ingrese sueldo: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            if (sueldo > 3000) {
                Console.WriteLine("esta  persona debe abonar impuestos. ");
            }
            else
            {
                Console.WriteLine("esta persona no debe abonar impuetos.");
            }
            Console.ReadKey();
        }
    }
}

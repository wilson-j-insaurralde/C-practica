using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Solicitar el ingreso del nombre y edad de dos personas. Mostrar el nombre de la persona con mayor edad.
namespace ejercicio58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre1, nombre2;
            int edad1, edad2;
            string linea;
            Console.Write("ingrese el nombre de la persona: ");
            nombre1 = Console.ReadLine();
            Console.Write("ingrese la edad de la persona: ");
            linea = Console.ReadLine();
            edad1 = int.Parse(linea);
            Console.Write("ingrese el nombre de la persona: ");
            nombre2 = Console.ReadLine();
            Console.WriteLine("ingrese la edad de la persona: ");
            linea = Console.ReadLine();
            edad2 = int.Parse(linea);
            if (edad1 > edad2) { Console.WriteLine(nombre1); }
            else { Console.WriteLine(nombre2); }    
            Console.ReadKey();

        }
    }
}

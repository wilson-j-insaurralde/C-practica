using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se ingresan un conjunto de n alturas de personas por teclado. Mostrar la altura promedio de las personas.

namespace ejercicio33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int   n, x;
            float altura, suma , promedio;
            x = 1;
            suma = 0;
            Console.WriteLine("ingrese la cantidad de personas: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x <= n)
            {
                Console.WriteLine("ingrese la altura: ");
                linea= Console.ReadLine();
                altura = float.Parse(linea);
                suma = suma + altura;
                x = x + 1;
            }
            promedio = suma / n;
            Console.WriteLine("la altura proedio de las personas es: " + promedio);
            Console.ReadKey();


        }
    }
}

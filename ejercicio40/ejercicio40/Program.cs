using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Desarrollar un programa que permita la carga de 10 valores por teclado y nos muestre posteriormente
// la suma de los valores ingresados y su promedio
namespace ejercicio40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int suma, promedio, f, valor;
            f = 1;
            suma=0; promedio=0;
            for(f=1; f<=10; f++)
            {
                Console.WriteLine("ingrese el valor: ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                suma = suma + valor;

            }
            promedio = (suma/10);
            Console.WriteLine("la suma es: "+ suma);
            Console.WriteLine("el promedio es: " + promedio);
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Realizar la carga de dos números enteros por teclado e imprimir su suma y su producto. //
namespace ejercicio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2, suma, producto;
            string linea;
            Console.WriteLine("ingrese el primer numero:");
            linea = Console.ReadLine();
            numero1 = int.Parse(linea);
            Console.WriteLine("ingrese el segundo numero: ");
            linea = Console.ReadLine();
            numero2 = int.Parse(linea);
            suma = numero1+numero2;
            producto = numero2*numero1;
            Console.WriteLine("la suma de los dos numeros es:");
            Console.WriteLine(suma);
            Console.WriteLine("el resultado del productos es: ");
            Console.WriteLine(producto);
            Console.ReadKey();


        }
    }
}

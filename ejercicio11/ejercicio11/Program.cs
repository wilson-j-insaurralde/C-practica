using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia,
//en caso contrario informar el producto y la división del primero respecto al segundo.
namespace ejercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            int suma, diferencia, producto, division;
            string linea;
            Console.WriteLine("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            if  (num1 > num2) {
                suma = num1 + num2;
                diferencia = num1 - num2;
                Console.Write("su suma es :");
                Console.WriteLine(suma);
                Console.Write("su diferencia es: ");
                Console.WriteLine(diferencia);
            
            }
            else
            {

                producto = num1 * num2;
                division = num1 / num2;
                Console.Write("su producto es: ");
                Console.WriteLine(producto);
                Console.Write("su division es: ");
                Console.WriteLine(division);
            }
            Console.ReadKey();
        }
    }
}

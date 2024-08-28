using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se ingresan por teclado tres números,
//si todos los valores ingresados son menores a 10, imprimir en pantalla la leyenda "Todos los números son menores a diez".
namespace ejercicio23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int num1, num2, num3;
            Console.WriteLine("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2= int.Parse(linea);
            Console.WriteLine("ingrese el tercer numero: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            if (num1 < 10 && num2 < 10 && num3 < 10)
            {
                Console.WriteLine("todos los numeros son menores a 10.");
            }
            Console.ReadLine();
        }
    }
}

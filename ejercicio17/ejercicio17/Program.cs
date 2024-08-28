using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Confeccionar un programa que permita cargar un número entero positivo de hasta tres cifras y muestre un mensaje indicando si tiene
//1, 2, o 3 cifras. Mostrar un mensaje de error si el número de cifras es mayor.
namespace ejercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            string linea;
            Console.WriteLine("ingrese el numero:");
            linea = Console.ReadLine();
            num = int.Parse(linea);
            if (num > 99) {
                Console.WriteLine("el numero posee 3 cifras");
            }
            else
            {

             if (num > 9)
                {
                    Console.WriteLine("el numero posee dos cifras ");
                }
             else { Console.WriteLine("el numero es de una cifra"); }

            }
            Console.ReadKey();  

        }
        
    }
}

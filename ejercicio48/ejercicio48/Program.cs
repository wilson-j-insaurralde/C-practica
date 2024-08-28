using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos muestre la tabla de multiplicar del mismo (los primeros 13 términos)
//Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.
namespace ejercicio48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int valor, x;
            x=0;
            Console.WriteLine("ingrese un valor del 1 al 10: ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);
            for (int i = 1; i <= 13; i++)
            {
                x = valor * i;
                Console.Write(x);
                Console.Write("-");

            }
            Console.ReadKey();

        }
    }
}

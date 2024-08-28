using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados.

namespace ejercicio46
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int numero, suma, x;
            suma = 0;
            x = 0;
            for (int i = 1; i <=10; i++)
            {
                Console.WriteLine("ingrese el numero: ");
                linea = Console.ReadLine();
                numero= int.Parse(linea);
                x = x+ 1;   
                if (x > 5)
                {
                    suma = x + suma ;

                }
            }
            Console.WriteLine("suma de los ultimos 5 valores: " + suma);
            Console.ReadKey();


        }
    }
}

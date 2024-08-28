using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Desarrollar un programa que permita cargar n números enteros y luego nos informe cuántos valores fueron pares y cuántos impares.
//Emplear el operador “%” en la condición de la estructura condicional:
//	if (valor % 2 == 0)         //Si el if da verdadero luego es par.
namespace ejercicio38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int num,n , x, pares, impares;
            x = 1;
            pares = 0;
            impares = 0;
            Console.WriteLine("ingrese la cantidad de numeros: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x <= n)
            {
                Console.WriteLine("ingrese el numero: ");
                linea= Console.ReadLine();
                num = int.Parse(linea);
                if (num%2 == 0)
                {
                    pares = pares + 1;
                }
                else
                {
                    impares = impares + 1;
                }

                x = x + 1;
            }
            Console.WriteLine("la cantidad de numeros pares son: " + pares);
            Console.WriteLine("la cantidad de numeros impares son: " + impares);
            Console.ReadKey();
        }
    }
}

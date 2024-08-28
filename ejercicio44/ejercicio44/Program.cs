using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Escribir un programa que lea n números enteros y calcule la cantidad de valores mayores o iguales a 1000.
//Este tipo de problemas también se puede resolver empleando la estructura repetitiva for.
//Lo primero que se hace es cargar una variable que indique la cantidad de valores a ingresar.
//Dicha variable se carga antes de entrar a la estructura repetitiva for.
//La estructura for permite que el valor inicial o final dependa de una variable cargada previamente por teclado.
namespace ejercicio44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int n, mayore, numero;
            mayore = 0;
            Console.WriteLine("ingrese la cantidad de valores: ");
            linea = Console.ReadLine();
            n= int.Parse(linea);

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("ingrese el numero: ");
                linea= Console.ReadLine();
                numero = int.Parse(linea);
                if (numero >=1000)
                {
                    mayore = mayore + 1;
                }



            }
            Console.WriteLine("la cantidad de numeros mayores son: "+ mayore);
            Console.ReadKey();

        }
    }
}

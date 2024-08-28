using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Escribir un programa que lea 10 números enteros y luego muestre cuántos valores ingresados fueron múltiplos de 3 y cuántos de 5.
//Debemos tener en cuenta que hay números que son múltiplos de 3 y de 5 a la vez.
namespace ejercicio42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int mul3, mult5, numero;
            mult5 = 0;
            mul3 = 0;
            
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("ingrese el numero: ");
                linea = Console.ReadLine();
                numero = int.Parse(linea);
                if (numero%5==0 || numero % 3 == 0)
                {
                    if (numero%5==0)
                    {
                        mult5 = mult5+1;
                    }
                    else
                    {
                        mul3 = mul3 + 1;
                    }
                }
            }
            Console.WriteLine("multiplos de 3: " + mul3);
            Console.WriteLine("multiplos de 5: " + mult5);
            Console.ReadKey();
        }
    }
}

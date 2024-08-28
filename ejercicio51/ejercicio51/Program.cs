using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
//a) La cantidad de valores ingresados negativos.
//b) La cantidad de valores ingresados positivos.
//c) La cantidad de múltiplos de 15.
//d) El valor acumulado de los números ingresados que son pares.
namespace ejercicio51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int negativos, positivos, mult15, pares, valor, acumulado;
            positivos = 0;
            negativos = 0;
            mult15 = 0;
            pares = 0;
            acumulado = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("ingrese el valor: ");
                linea = Console.ReadLine();
                valor = int.Parse(linea);
                if (valor >0)
                {
                    positivos++;

                }
                else
                {
                    negativos++;
                }
                if (valor % 15 == 0)
                {
                    mult15++;
                }
                if (valor%2 == 0)
                {
                    acumulado = acumulado + valor;
                    pares++;
                }
            }
            Console.WriteLine("numeros posivos: " + positivos);
            Console.WriteLine("numeros negativos: "+ negativos);
            Console.WriteLine("numeros pares: " + pares);
            Console.WriteLine("valor acumulado de numeros pares: "+ acumulado);
            Console.WriteLine("numeros multiplos de 15: "+ mult15);
            Console.ReadKey();
        }
    }
}

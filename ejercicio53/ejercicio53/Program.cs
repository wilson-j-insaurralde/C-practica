using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//11 - Estructura repetitiva do while
//Escribir un programa que solicite la carga de un número entre 0 y 999, y nos muestre un mensaje de cuántos dígitos tiene el mismo.
//Finalizar el programa cuando se cargue el valor 0.
namespace ejercicio53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int num;
            do {
                    Console.WriteLine("ingrese un valor del 0 al 999 (con 0 finaliza la ejecucion)");
                    linea = Console.ReadLine();
                    num = int.Parse(linea);
                    if (num > 99) {
                     Console.WriteLine("el numero posee 3 digitos");
                     }
                    else { if (num > 9) { Console.WriteLine("el numero posee 2 digitos"); }
                           else { Console.WriteLine("el numero posee 1  digito"); }
                }


                } while (num != 0) ;     
            Console.ReadKey();
        }
    }
}

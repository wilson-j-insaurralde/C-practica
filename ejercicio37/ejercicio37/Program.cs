using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Realizar un programa que permita cargar dos listas de 15 valores cada una.
// Informar con un mensaje cual de las dos listas tiene un valor acumulado mayor (mensajes "Lista 1 mayor",
// "Lista 2 mayor", "Listas iguales")
//vTener en cuenta que puede haber dos o más estructuras repetitivas en un algoritmo.
namespace ejercicio37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int list1, list2, suma1, suma2,x ;
            x = 1;
            suma1 = 0;
            suma2 = 0; 
            while (x <= 15)
            {
                Console.WriteLine("ingrese los valores de la primera lista: ");
                linea = Console.ReadLine();
                list1 = int.Parse(linea);
                suma1 = list1 + suma1;
                x = x+1;    
            }
            x = 1;
            while (x <= 15)
            {
                Console.WriteLine("ingrese los valores de la segunda lista: ");
                linea = Console.ReadLine();
                list2 = int.Parse(linea);
                suma2 = list2 + suma2;
                x = x + 1;
            }
            if (suma1 == suma2)
            {
                Console.WriteLine("Listas iguales");
            }
            else {

            if ( suma1>suma2 )
            {
                Console.WriteLine("Lista 1 mayor");
            }
            else { Console.WriteLine("Lista 2 mayor"); }
             }
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Solicitar el ingreso de dos apellidos. Mostrar un mensaje si son iguales o distintos.
namespace ejercicio59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string apellido1, apellido2;
            Console.WriteLine("ingrese el primer apellido: ");
            apellido1 = Console.ReadLine();
            Console.WriteLine("ingrese el segundo apellido: ");
            apellido2 = Console.ReadLine();
            if (apellido1 == apellido2)
            {
                Console.WriteLine("los apellidos son iguales");
            }
            else
            {
                Console.WriteLine("los apellidos son distintos.");
            }
            Console.ReadKey();
        }
    }
}

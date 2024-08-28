using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se ingresan tres valores por teclado,
//si todos son iguales se imprime la suma del primero con el segundo y a este resultado se lo multiplica por el tercero.

namespace ejercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int num1, num2, num3;
            int suma, multi;
            Console.WriteLine("ingrese el primer numero: ");
            linea = Console.ReadLine();
            num1= int.Parse(linea);
            Console.WriteLine("ingrese el segundo numero: ");
            linea= Console.ReadLine();
            num2= int.Parse(linea);
            Console.WriteLine("ingrese el tercernumero");
            linea= Console.ReadLine();
            num3= int.Parse(linea); 

            if ( num1 == num2 & num1 == num3 )
            {
                suma = num1 + num2;
                multi = suma * num3;
                Console.WriteLine("el resultado de la suma es: " + suma);
                Console.Write("el resultado del producto: " + multi);
                
            }
            Console.ReadKey();

        }
    }
}

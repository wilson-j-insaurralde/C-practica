using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la medida de la base y la altura de un triángulo.
//El programa deberá informar:
//a) De cada triángulo la medida de su base, su altura y su superficie.
//b) La cantidad de triángulos cuya superficie es mayor a 12.

namespace ejercicio45
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int Base, n, alt, supe, mayores;
            mayores = 0;
            Console.WriteLine("ingrese la cantidad de triangulos: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for (int i = 1;i <= n;i++)
            {
                Console.Write("ingrese la altura: ");
                linea = Console.ReadLine();
                alt=int.Parse(linea);
                Console.WriteLine("ingrese la base: ");
                linea= Console.ReadLine();
                Base = int.Parse(linea);
                supe = (Base * alt) / 2;
                Console.WriteLine("la superficie es: " + supe);
                if (supe >= 12)
                {
                    mayores = mayores + 1;
                }
            }
            Console.WriteLine("cantidad de triangulos con superficie mayor a 12: " + mayores);
            Console.ReadKey();  




        }
    }
}

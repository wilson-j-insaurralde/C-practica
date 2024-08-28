using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Realizar un programa que lea los lados de n triángulos, e informar:
//a) De cada uno de ellos, qué tipo de triángulo es: equilátero(tres lados iguales), isósceles(dos lados iguales), o escaleno(ningún lado igual)
//b) Cantidad de triángulos de cada tipo.
//c) Tipo de triángulo que posee menor cantidad.
namespace ejercicio49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int n, equi, iso, esc;
            int a, b, c;
            equi = 0; iso = 0; esc = 0;
            Console.WriteLine("ingrese la cantidad de triangulos: ");
            linea = Console.ReadLine();
            n=int.Parse(linea);
            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("ingrese el primer lado: ");
                linea = Console.ReadLine();
                a = int.Parse(linea);
                Console.WriteLine("ingrese el segundo lado: ");
                linea = Console.ReadLine();  
                b = int.Parse(linea);
                Console.WriteLine("ingrece el tercer lado: ");
                linea = Console.ReadLine();
                c = int.Parse(linea);
                if (a == b && a== c)
                {
                    esc++;
                    Console.WriteLine("este triangulo es escaleno");

                }
                else {
                    if (b == c  || a==b || a==c)
                    { iso++;
                        Console.WriteLine("este triangulo es isoceles");

                    }
                    else
                    {
                        Console.WriteLine("este triangulo es equilatero");
                        equi++;
                    }

                       }

                
                }
                Console.WriteLine("equilateros:" + equi);
                Console.WriteLine("escalenos: " + esc);
                Console.WriteLine("isoceles:" + iso);
                if (equi < esc && equi < iso)
                {
                    Console.WriteLine("menor cantidad de equilateros.");
                }
                else
                {
                    if (iso < esc)
                    {
                        Console.WriteLine("menor cantidad de sioceles.");
                    }
                    else
                    {
                        Console.WriteLine("menor cantidad de escalenos.");
                    }
                    Console.ReadKey();
            }
        }
    }
}

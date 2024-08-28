using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escribir un programa que pida ingresar la coordenada de un punto en el plano, es decir dos valores enteros x e y (distintos a cero).
//Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0, etc.)
namespace ejercicio25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int x, y;
            Console.WriteLine("ingrese el valor de x: ");
            linea = Console.ReadLine();
            x = int.Parse(linea);
            Console.WriteLine("ingrese el valor de y:");
            linea = Console.ReadLine();
            y = int.Parse(linea);
            if (x > 0 && y > 0)
            {
                Console.WriteLine("1° cuadrante");
            }
            else
            {
                if (x < 0 &&  y > 0) { 
                    Console.WriteLine("2° cuadrante");
                }
                else
                {
                    if (x < 0 && y <0) { Console.WriteLine("3° cuadrante"); }
                    else { Console.WriteLine("4° cuadrante"); }
                }
            }
            Console.ReadKey();  
        }
    }
}

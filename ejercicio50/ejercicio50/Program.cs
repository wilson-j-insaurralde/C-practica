using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Escribir un programa que pida ingresar coordenadas (x,y) que representan puntos en el plano.
//Informar cuántos puntos se han ingresado en el primer, segundo, tercer y cuarto cuadrante.
//Al comenzar el programa se pide que se ingrese la cantidad de puntos a procesar.
namespace ejercicio50
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int x, y, n;
            int primer, segund, tercer, cuarto;
            primer = 0;
            segund = 0;
            tercer = 0;
            cuarto = 0;
            Console.WriteLine("ingrese la cantidad de puntos:");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            for ( int i = 0; i <= n; i++ )
            {
                Console.WriteLine("ingrese cordenadas de x: ");
                linea= Console.ReadLine();
                x = int.Parse(linea);
                Console.WriteLine("ingrese cordenadas de y: ");
                linea=Console.ReadLine();
                y = int.Parse(linea);
                if (x>0 && y > 0)
                {
                    primer++;

                }
                else
                {
                    if (x < 0 && y > 0)
                    {
                        segund++;
                    }
                    else { if (x < 0 && y< 0) {
                            tercer++;
                              } 
                    else { cuarto++ ; }
                            }
                }
            } 
            Console.WriteLine("puntos en el primer cuadrante: " + primer);
            Console.WriteLine("puntos en el segundo cuadrante: " + segund);
            Console.WriteLine("puntos en el tercer cuadrante: "+ tercer);
            Console.WriteLine("puntos en el cuarto cuadrante: "+cuarto);
            Console.ReadKey();
        }
    }
}

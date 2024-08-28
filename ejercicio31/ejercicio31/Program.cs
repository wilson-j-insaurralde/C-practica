using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Una planta que fabrica perfiles de hierro posee un lote de n piezas.
//Confeccionar un programa que pida ingresar por teclado la cantidad de piezas a procesar y luego ingrese la longitud de cada perfil;
//sabiendo que la pieza cuya longitud esté comprendida en el rango de 1,20 y 1,30 son aptas.
//Imprimir por pantalla la cantidad de piezas aptas que hay en el lote.
namespace ejercicio31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int n, aptas, x;
            float longitud;
            x = 1;
            aptas = 0;
            Console.WriteLine("ingrese la cantidad de piezas a procesar: ");
            linea = Console.ReadLine();
            n = int.Parse(linea);
            while (x <= n)
            {
                Console.WriteLine("ingrese la longitud del perfil ");
                linea = Console.ReadLine() ;
                longitud = float.Parse(linea);
                if ( longitud >= 1.20 && longitud <= 1.30)
                {
                    aptas = aptas + 1;
                }
                x = x + 1;
            }
            Console.WriteLine("la cantidad aptas son: " + aptas);
            Console.ReadKey();

        }
    }
}

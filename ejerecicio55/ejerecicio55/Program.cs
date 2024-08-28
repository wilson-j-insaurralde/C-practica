using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Realizar un programa que permita ingresar el peso (en kilogramos) de piezas. El proceso termina cuando ingresamos el valor 0. Se debe informar:
//a) Cuántas piezas tienen un peso entre 9.8 Kg. y 10.2 Kg.?, cuántas con más de 10.2 Kg.? y cuántas con menos de 9.8 Kg.?
//b) La cantidad total de piezas procesadas.
namespace ejerecicio55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int x, y, z, suma;
            float piezas;
            x = 0;
            y = 0;
            z = 0;
            suma = 0;
            do
            {
                Console.WriteLine("ingrese el peso (en kilogramos) de la pieza: ");
                linea = Console.ReadLine();
                piezas = float.Parse(linea);
                suma++;
                if (piezas == 0)
                {
                    Console.WriteLine("no se ingreso ningun valor.");
                }
                else
                {
                    if (piezas > 10.2)
                    {
                        x++;
                    }
                    else
                    {
                        if (piezas <= 10.2 && piezas >= 9.8) { y++; }
                        else { z++; }
                    }

                }


            }
            while (piezas != 0);
            Console.WriteLine("mas de 10.2: " + x);
            Console.WriteLine("entre 9.8 y 10.2: "+ y);
            Console.WriteLine("menos de 9.8:" + z);
            Console.WriteLine("cantidad de piezas procesadas: "+ suma);
            Console.ReadKey();
        }
    }
}

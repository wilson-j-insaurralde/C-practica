using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//De un operario se conoce su sueldo y los años de antigüedad. Se pide confeccionar un programa que lea los datos de entrada e informe:
//a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
//b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
//c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.
namespace ejercicio26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            double sueldo, antiguedad, aument;
            Console.WriteLine("ingrese la antiguedad: ");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
            Console.WriteLine("ingrese el sueldo: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);

            if ( antiguedad >= 10 && sueldo < 500 ) {

                aument = sueldo * 1.20;
                Console.Write("el sueldo a pagar es: " + aument);

            }
            else { if ( antiguedad < 10 &&  sueldo < 500 )
                {
                    aument = sueldo * 1.05;
                    Console.Write("el sueldo a pagar es: " + aument);
                }
                else { Console.Write("el sueldo a pagar es: " + sueldo); }
           }
            Console.ReadKey();
        }
        
    }
}

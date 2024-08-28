using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Se ingresan tres notas de un alumno, si el promedio es mayor o igual a siete mostrar un mensaje "Promocionado"

namespace ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            int promedio;
            string linea;
            Console.WriteLine("ingrese la primera nota: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);
            Console.WriteLine("ingrese la segunda nota: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            Console.WriteLine("ingrese la tercera nota: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);
            promedio = (num1 + num2 + num3) / 3;
            if (promedio >= 7) {
                Console.WriteLine("el alumno promociono.");
            }
            else
            {
                Console.WriteLine("el alumno no promociono.");
            }
            Console.ReadKey();
        }
    }
}

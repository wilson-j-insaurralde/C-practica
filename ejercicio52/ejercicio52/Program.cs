using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Se cuenta con la siguiente información:
//Las edades de 50 estudiantes del turno mañana.
//Las edades de 60 estudiantes del turno tarde.
//Las edades de 110 estudiantes del turno noche.
//Las edades de cada estudiante deben ingresarse por teclado.
//a) Obtener el promedio de las edades de cada turno (tres promedios)
//b) Imprimir dichos promedios (promedio de cada turno)
//c) Mostrar por pantalla un mensaje que indique cual de los tres turnos tiene un promedio de edades menor.
namespace ejercicio52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int f, edad, suma1, suma2, suma3, pro1, pro2, pro3;
            string linea;
            suma1 = 0;
            suma2 = 0;
            suma3 = 0;
            for (f = 1; f <= 50; f++)
            {
                Console.Write("Ingrese edad:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                suma1 = suma1 + edad;
            }
            pro1 = suma1 / 50;
            Console.Write("Promedio de edades del turno mañana:");
            Console.WriteLine(pro1);
            for (f = 1; f <= 60; f++)
            {
                Console.Write("Ingrese edad:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                suma2 = suma2 + edad;
            }
            pro2 = suma2 / 60;
            Console.Write("Promedio de edades del turno tarde:");
            Console.WriteLine(pro2);
            for (f = 1; f <= 110; f++)
            {
                Console.Write("Ingrese edad:");
                linea = Console.ReadLine();
                edad = int.Parse(linea);
                suma3 = suma3 + edad;
            }
            pro3 = suma3 / 110;
            Console.Write("Promedio de edades del turno noche:");
            Console.WriteLine(pro3);
            if (pro1 < pro2 && pro1 < pro3)
            {
                Console.Write("El turno mañana tiene un promedio menor de edades.");
            }
            else
            {
                if (pro2 < pro3)
                {
                    Console.Write("El turno tarde tiene un promedio menor de edades.");
                }
                else
                {
                    Console.Write("El turno noche tiene un promedio menor de edades.");
                }
            }
            Console.ReadKey();

        }
    }
}

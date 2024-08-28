using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Confeccionar un programa que pida por teclado tres notas de un alumno, calcule el promedio e imprima alguno de estos mensajes:
//Si el promedio es >=7 mostrar "Promocionado".
//Si el promedio es >=4 y <7 mostrar "Regular".
//Si el promedio es <4 mostrar "Reprobado".
namespace ejercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int not1, not2, not3;
            string linea;
            int promedio;
            Console.WriteLine("ingrese la primera nota: ");
            linea = Console.ReadLine();
            not1= int.Parse(linea);
            Console.WriteLine("ingrese la segunda nota: ");
            linea = Console.ReadLine();
            not2= int.Parse(linea);
            Console.WriteLine("ingrese la tercera nota: ");
            linea = Console.ReadLine();
            not3= int.Parse(linea);
            promedio = (not1 + not2 + not3) / 3;
            if (promedio >= 7)
            {
                Console.WriteLine("promocionado");
            }
            else { 
                if (promedio >= 4 ) 
                { Console.WriteLine("aprobado"); }
                else { Console.WriteLine("desaproado"); }
            
                    }
            Console.ReadKey();  
        }
    }
}

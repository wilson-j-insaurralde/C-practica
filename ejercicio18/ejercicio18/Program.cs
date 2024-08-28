using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Un postulante a un empleo, realiza un test de capacitación, se obtuvo la siguiente información:
//cantidad total de preguntas que se le realizaron y la cantidad de preguntas que contestó correctamente.
//Se pide confeccionar un programa que ingrese los dos datos por teclado e informe el nivel del mismo según el porcentaje de
//respuestas correctas que ha obtenido, y sabiendo que:
//    Nivel máximo:	Porcentaje >= 90 %.
//    Nivel medio:	Porcentaje >= 75 % y < 90 %.
//   Nivel regular:	Porcentaje >= 50 % y < 75 %.
//  Fuera de nivel:	Porcentaje < 50 %.
namespace ejercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int porcentaje, preguntas, correctas;
            Console.WriteLine("ingrese la cantidad de preguntas: ");
            linea = Console.ReadLine();
            preguntas = int.Parse(linea);
            Console.WriteLine("ingrese la cantidad de respuestas corectas: ");
            linea= Console.ReadLine();
            correctas = int.Parse(linea);
            porcentaje = (correctas / preguntas) * 100;
            if (porcentaje >= 90)
            {
                Console.WriteLine("nivel maximo");

            } 
            else
            {
                if (porcentaje >= 75) { Console.WriteLine("nivel medio"); }
                else {
                    if (porcentaje >=50) { Console.WriteLine("nivel regular "); 
                    } 
                    else { Console.WriteLine("fuera de nivel"); }   
                }
            }
            Console.ReadKey();  
            
        }
    }
}

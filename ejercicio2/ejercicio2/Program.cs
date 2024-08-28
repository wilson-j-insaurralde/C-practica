using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int horasTrabajadas;
            float costoHora, sueldo;
            string linea;
            Console.WriteLine("ingrese horas trabajadas por el operario: ");
            linea = Console.ReadLine();
            horasTrabajadas= int.Parse(linea);
            Console.WriteLine("ingrese el pago por hora: ");
            linea = Console.ReadLine();
            costoHora = float.Parse(linea);   
            sueldo = horasTrabajadas * costoHora;
            Console.WriteLine("el sueldo total del operario es: ");
            Console.WriteLine(sueldo);
            Console.ReadKey();



        }
    }
}

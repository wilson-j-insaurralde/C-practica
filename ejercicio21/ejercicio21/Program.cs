using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Realizar un programa que pida cargar una fecha cualquiera, luego verificar si dicha fecha corresponde a Navidad.
namespace ejercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int dia, mes, año;
            Console.WriteLine("ingrese el dia: ");
            linea = Console.ReadLine();
            dia = int.Parse(linea);
            Console.WriteLine("ingrese el mes: ");
            linea= Console.ReadLine();
            mes = int.Parse(linea);
            Console.WriteLine("ingrese el año: ");
            linea= Console.ReadLine();
            año = int.Parse(linea);
            if (dia == 25 && mes == 12 )
            {
                Console.WriteLine("es navidad.");
                
            }
            Console.ReadKey();  

        }
    }
}

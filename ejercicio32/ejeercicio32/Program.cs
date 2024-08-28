using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Escribir un programa que solicite ingresar 10 notas de alumnos y nos informe cuántos tienen notas mayores o iguales a 7 y cuántos menores.
namespace ejeercicio32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int x, nota, mayores, menores;
            x = 1;
            mayores = 0;
            menores = 0;
            while (x<=10)
            {
                Console.WriteLine("ingrese la nota: ");
                linea = Console.ReadLine();
                nota = int.Parse(linea);
                if (nota >= 7)
                {
                    mayores = mayores + 1;
                }
                else
                {
                    menores = menores + 1;
                }
                x = x + 1;

            }
            Console.WriteLine("las notas mayores o iguales 7 son:" + mayores);
            Console.WriteLine("las notas menores a 7 son:" + menores);
            Console.ReadKey();
        }
    }
}

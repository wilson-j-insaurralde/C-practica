using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escribir un programa que lea 10 notas de alumnos y nos informe cuántos tienen notas mayores o iguales a 7 y cuántos menores.



namespace ejercicio41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int nota, mayores, menores;
            mayores = 0; 
            menores = 0;
            for (int i = 1; i <= 10 ; i++)
            {
                Console.WriteLine("ingrese la nota: ");
                linea = Console.ReadLine();
                nota = int.Parse(linea);
                if (nota >= 7 )
                {
                    mayores = mayores + 1;
                }
                else
                {
                    menores = menores + 1;
                }
            }
            Console.WriteLine("notas mayores o igual a 7: " + mayores);
            Console.WriteLine("notas menores a 7: " + menores);
            Console.ReadKey();
        }
    }
}

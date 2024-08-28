using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500,
//realizar un programa que lea los sueldos que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y
// cuántos cobran más de $300. Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.
namespace ejercicio34
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int n, importe, mas, entre, x;
            int sueldo;
            x = 1;
            entre = 0;
            mas = 0;
            importe = 0;
            Console.WriteLine("ingrese el numero de empleados:");
            linea = Console.ReadLine();
            n = int.Parse(linea);

            while (x <= n)
            {
                Console.WriteLine("ingrese el sueldo:");
                linea = Console.ReadLine();
                sueldo = int.Parse(linea);
                importe = importe + sueldo;
                if (sueldo >= 100 && sueldo <=300)
                {
                    entre = entre + 1;
                }
                else
                {
                    if (sueldo > 300)
                    {
                        mas = mas + 1;
                    }
                }

                x = x + 1;
            }
            Console.WriteLine("empleados que cobran entre $100 y $300: " + entre);
            Console.WriteLine("empleados que cobran mas de $300: " + mas);
            Console.WriteLine("importe total de sueldos de la empresa: " + importe);
            Console.ReadKey();

        }
    }
}

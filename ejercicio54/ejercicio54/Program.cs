using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escribir un programa que solicite la carga de números por teclado, obtener su promedio.
//Finalizar la carga de valores cuando se cargue el valor 0.
//Cuando la finalización depende de algún valor ingresado por el operador conviene el empleo de la estructura do while,
//por lo menos se cargará un valor (en el caso más extremo se carga 0, que indica la finalización de la carga de valores)
namespace ejercicio54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string linea;
            int numero,suma,promedio,x;
            x = 0;
            suma = 0;
            promedio = 0;
            do
            {
                Console.WriteLine("ingrese un numero (0 para finalizar ejecucion)");
                linea = Console.ReadLine();
                numero = int.Parse(linea);
                if (numero > 0)
                {
                    x++;
                    suma = suma + numero;
                }
               


            } while (numero != 0);
            if (x!=0)
            {
                promedio = suma / x;
                

            }
            else { Console.WriteLine("no se ingreso ningun numero."); }
            Console.WriteLine("el promedio es: " +promedio);
            Console.ReadKey();  


        }
    }
}

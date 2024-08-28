using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999 (no sumar dicho valor,
//indica que ha finalizado la carga). Imprimir el valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.
namespace ejercicio56
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string linea;
            int suma, valor;
            suma = 0;
            
            do {
                Console.WriteLine("ingrese el numero: ");
                linea = Console.ReadLine();
                valor= int.Parse(linea);
                if (valor == 999) { Console.WriteLine("se finalizo la carga de valores."); }
                else
                {
                    suma= suma + valor;

                }
            
                }

            while (valor != 999); 
            if (suma > 0) { Console.WriteLine("el valor acumulado es mayor a cero: "+ suma); }
            else {
                if (suma <0) { Console.WriteLine("el valor acumulado es menor a cero: "+suma); }
                else { Console.WriteLine("el valor a cumulado es cero: "+ suma);}
                 }
            Console.ReadKey();
        }
    }
}

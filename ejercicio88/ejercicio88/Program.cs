using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
//Crear una matriz de 2 filas y 5 columnas. Realizar la carga de componentes por columna (es decir primero ingresar toda la primer columna, luego la segunda columna y así sucesivamente)
//Imprimir luego la matriz.
namespace ejercicio88
{
    class Program
    {
        private int[,] matriz;
        public void Carga()
        {
            matriz = new int[2,5];
            for (int c = 0;c < 5; c++)
            {
                for (int f = 0;f < 2; f++)
                {
                    string linea;
                    Console.WriteLine("ingrese componentes: ");
                    linea = Console.ReadLine();
                    matriz[f,c]=int.Parse(linea);
                }
            }
            Console.WriteLine();
        }
        public void Imprimir()
        {
            for(int f = 0; f < 2; f++)
            {
                for (int c=0;c < 5; c++)
                {
                    Console.WriteLine(matriz[f,c] + "  ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program mat=new Program();
            mat.Carga();
            mat.Imprimir();
            Console.ReadKey();
        }
    }
}

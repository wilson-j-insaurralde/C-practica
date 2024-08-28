using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
//Crear una matriz de 3 filas por 5 columnas con elementos de tipo int, cargar sus componentes y luego imprimirlas.
namespace ejercicio85
{
    internal class Matriz
    {
        private int[,] mat;
        public void Carga()
        {
            mat = new int[3,5];
            for (int f = 0; f < 3; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    string linea;
                    Console.WriteLine("ingrese componente: ");
                    linea = Console.ReadLine();
                    mat[f,c]=int.Parse(linea);

                }
            }
         }
        public void Imprimir()
        {
            for(int f = 0;f < 3; f++)
            {
                for (int c =0;c < 5; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }




        static void Main(string[] args)
        {
            Matriz matriz = new Matriz();
            matriz.Carga();
            matriz.Imprimir();
            Console.ReadKey();
        }
    }
}

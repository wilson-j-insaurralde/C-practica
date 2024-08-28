using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
//Crear y cargar una matriz de 4 filas por 4 columnas. Imprimir la diagonal principal.
namespace ejercicio86
{
    internal class MatrizDiagonal
    { 
        private int[,] matriz;
        public void Carga()
        {
            matriz = new int[3, 5];
            for (int f = 0;f < 3;f++)
            {
                for (int c = 0;c < 5;c++)
                {
                    string linea;
                    Console.WriteLine("ingrese componente: ");
                    linea = Console.ReadLine();
                    matriz[f,c]=int.Parse(linea);
                }
            }

        }
        public void ImprimirDiagonal()
        {   for (int f = 0; f < 3; f++)
            {
                Console.Write(matriz[f, f] + " ");
            }

        }



        static void Main(string[] args)
        {
            MatrizDiagonal matriz = new MatrizDiagonal();
            matriz.Carga();
            matriz.ImprimirDiagonal();
            Console.ReadKey();
        }
    }
}

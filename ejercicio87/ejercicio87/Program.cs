using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
//Crear y cargar una matriz de 3 filas por 4 columnas. Imprimir la primer fila. Imprimir la última fila e imprimir la primer columna.
namespace ejercicio87
{
     class Matriz
    {
        private int[,] matriz;
        public void Carga()
        {
            matriz = new int[3, 4];
            for (int f = 0; f < 3; f++) { 
            for (int c = 0; c < 4; c++)
                {
                    string linea;
                    Console.WriteLine("ingrese componente: ");
                    linea = Console.ReadLine();
                    matriz[f,c]=int.Parse(linea);
                }
            }
        }
        
        public void ImprimirPrimerFila()
        {
            Console.WriteLine("primera fila: ");
            for (int f = 0;f < 4; f++)
            {
                Console.Write($"{matriz[0,f]} -- ");
                
            }
            Console.WriteLine();
        }
        public void ImprimirUltimaFila()
        {
            Console.WriteLine("ultima fila: ");
            for(int f = 0; f < 4; f++)
            {
                Console.Write($"{matriz[2, f]} -- ");
            }
            Console.WriteLine();
        }
        public void ImprimirPrimeraColumna()
        {
            Console.WriteLine("primera columna: ");
            for ( int f = 0; f < 3; f++)
            {
                Console.WriteLine($"{matriz[f, 0]} -- ");
            }

        }
        static void Main(string[] args)
        {
            Matriz matriz = new Matriz();
            matriz.Carga();
            matriz.ImprimirPrimerFila();
            matriz.ImprimirUltimaFila();
            matriz.ImprimirPrimeraColumna();
            Console.ReadKey();
        }
    }
}
